using ECommerceAPI.Application.Abstractions.Hubs;
using ECommerceAPI.Application.Abstractions.Services;
using ECommerceAPI.Application.DTOs.Payments;
using ECommerceAPI.Application.Features.Commands.Order.CreateOrder;
using ECommerceAPI.Domain.Entities;
using Moq;
using Xunit;

namespace ECommerceAPI.Application.Tests
{
    public class CreateOrderCommandHandlerTests
    {
        private readonly Mock<IOrderService> _orderServiceMock = new();
        private readonly Mock<IBasketService> _basketServiceMock = new();
        private readonly Mock<IOrderHubService> _orderHubServiceMock = new();
        private readonly Mock<IPaymentService> _paymentServiceMock = new();

        private CreateOrderCommandHandler CreateHandler()
            => new(_orderServiceMock.Object, _basketServiceMock.Object, _orderHubServiceMock.Object, _paymentServiceMock.Object);

        [Fact]
        public async Task Handle_ShouldReturnFailure_WhenBasketIsEmpty()
        {
            var basketId = Guid.NewGuid();
            _basketServiceMock.SetupGet(b => b.Basket).Returns(new Basket { Id = basketId });
            _basketServiceMock.Setup(b => b.GetBasketItemsAsync()).ReturnsAsync(new List<BasketItem>());

            var handler = CreateHandler();
            var result = await handler.Handle(new CreateOrderCommandRequest { Address = "addr", Description = "desc" }, CancellationToken.None);

            Assert.False(result.Success);
            Assert.Equal("Basket is empty.", result.Message);
            _orderServiceMock.Verify(o => o.CreateOrder(It.IsAny<ECommerceAPI.Application.DTOs.Order.CreateOrder>()), Times.Never);
            _paymentServiceMock.Verify(p => p.InitiateAsync(It.IsAny<PaymentInitiationRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        }

        [Fact]
        public async Task Handle_ShouldReturnFailure_WhenPaymentFails()
        {
            var basketId = Guid.NewGuid();
            var product = new Product { Id = Guid.NewGuid(), Name = "Test", Price = 10f, Stock = 10 };
            _basketServiceMock.SetupGet(b => b.Basket).Returns(new Basket { Id = basketId });
            _basketServiceMock.Setup(b => b.GetBasketItemsAsync()).ReturnsAsync(new List<BasketItem>
            {
                new()
                {
                    Product = product,
                    Quantity = 2
                }
            });

            _paymentServiceMock.Setup(p => p.InitiateAsync(It.IsAny<PaymentInitiationRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new PaymentInitiationResponse
                {
                    Success = false,
                    ProviderName = "Stripe",
                    Status = "failed",
                    Amount = 20,
                    Currency = "USD",
                    ExternalReference = string.Empty,
                    ErrorMessage = "error"
                });

            var handler = CreateHandler();
            var result = await handler.Handle(new CreateOrderCommandRequest { Address = "addr", Description = "desc" }, CancellationToken.None);

            Assert.False(result.Success);
            Assert.Equal("error", result.Message);
            _orderServiceMock.Verify(o => o.CreateOrder(It.IsAny<ECommerceAPI.Application.DTOs.Order.CreateOrder>()), Times.Never);
        }

        [Fact]
        public async Task Handle_ShouldCreateOrder_WhenPaymentSucceeds()
        {
            var basketId = Guid.NewGuid();
            var product = new Product { Id = Guid.NewGuid(), Name = "Test", Price = 5f, Stock = 10 };
            _basketServiceMock.SetupGet(b => b.Basket).Returns(new Basket { Id = basketId });
            _basketServiceMock.Setup(b => b.GetBasketItemsAsync()).ReturnsAsync(new List<BasketItem>
            {
                new()
                {
                    Product = product,
                    Quantity = 3
                }
            });

            _paymentServiceMock.Setup(p => p.InitiateAsync(It.IsAny<PaymentInitiationRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new PaymentInitiationResponse
                {
                    Success = true,
                    ProviderName = "Stripe",
                    Status = "pending",
                    Amount = 15,
                    Currency = "USD",
                    ExternalReference = "ref123"
                });

            var handler = CreateHandler();
            var result = await handler.Handle(new CreateOrderCommandRequest { Address = "addr", Description = "desc" }, CancellationToken.None);

            Assert.True(result.Success);
            Assert.Equal("ref123", result.PaymentReference);
            _orderServiceMock.Verify(o => o.CreateOrder(It.Is<ECommerceAPI.Application.DTOs.Order.CreateOrder>(dto => dto.Amount == 15 && dto.Currency == "USD" && dto.ExternalReference == "ref123")), Times.Once);
            _orderHubServiceMock.Verify(h => h.OrderAddedMessageAsync(It.IsAny<string>()), Times.Once);
        }
    }
}
