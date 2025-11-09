using System.Linq;
using ECommerceAPI.Application.Abstractions.Hubs;
using ECommerceAPI.Application.Abstractions.Services;
using ECommerceAPI.Application.DTOs.Payments;
using MediatR;

namespace ECommerceAPI.Application.Features.Commands.Order.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
    {
        private readonly IOrderService _orderService;
        private readonly IBasketService _basketService;
        private readonly IOrderHubService _orderHubService;
        private readonly IPaymentService _paymentService;

        public CreateOrderCommandHandler(IOrderService orderService, IBasketService basketService, IOrderHubService orderHubService, IPaymentService paymentService)
        {
            _orderService = orderService;
            _basketService = basketService;
            _orderHubService = orderHubService;
            _paymentService = paymentService;
        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var basket = _basketService.Basket;
            if (basket == null)
            {
                return new CreateOrderCommandResponse
                {
                    Success = false,
                    Message = "Basket could not be loaded for the current user."
                };
            }

            var basketItems = await _basketService.GetBasketItemsAsync();
            if (basketItems == null || !basketItems.Any())
            {
                return new CreateOrderCommandResponse
                {
                    Success = false,
                    Message = "Basket is empty."
                };
            }

            var totalAmount = basketItems.Sum(bi => (decimal)bi.Product.Price * bi.Quantity);

            var paymentRequest = new PaymentInitiationRequest
            {
                ProviderName = request.ProviderName,
                Amount = totalAmount,
                Currency = request.Currency,
                Description = request.Description
            };

            var paymentResult = await _paymentService.InitiateAsync(paymentRequest, cancellationToken);
            if (!paymentResult.Success)
            {
                return new CreateOrderCommandResponse
                {
                    Success = false,
                    Message = paymentResult.ErrorMessage ?? "Payment initiation failed.",
                    PaymentStatus = paymentResult.Status,
                    PaymentReference = paymentResult.ExternalReference
                };
            }

            await _orderService.CreateOrder(new()
            {
                BasketId = basket.Id.ToString(),
                Address = request.Address,
                Description = request.Description,
                Amount = paymentResult.Amount,
                Currency = paymentResult.Currency,
                ProviderName = paymentResult.ProviderName,
                Status = paymentResult.Status,
                ExternalReference = paymentResult.ExternalReference
            });

            await _orderHubService.OrderAddedMessageAsync("An order has been created");

            return new CreateOrderCommandResponse
            {
                Success = true,
                Message = "Order created successfully.",
                PaymentStatus = paymentResult.Status,
                PaymentReference = paymentResult.ExternalReference
            };
        }
    }
}
