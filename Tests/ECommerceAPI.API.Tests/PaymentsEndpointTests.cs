using System.Net;
using System.Net.Http.Json;
using ECommerceAPI.Application.DTOs.Payments;
using Moq;
using Xunit;

namespace ECommerceAPI.API.Tests
{
    public class PaymentsEndpointTests : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly CustomWebApplicationFactory _factory;
        private readonly HttpClient _client;

        public PaymentsEndpointTests(CustomWebApplicationFactory factory)
        {
            _factory = factory;
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task InitiatePayment_ReturnsSuccessResponse()
        {
            var expectedResponse = new PaymentInitiationResponse
            {
                Success = true,
                ProviderName = "Stripe",
                Status = "pending",
                Amount = 42,
                Currency = "USD",
                ExternalReference = "test-ref"
            };

            _factory.PaymentServiceMock
                .Setup(p => p.InitiateAsync(It.IsAny<PaymentInitiationRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(expectedResponse);

            var request = new PaymentInitiationRequest
            {
                ProviderName = "Stripe",
                Amount = 42,
                Currency = "USD",
                Description = "Test order"
            };

            var response = await _client.PostAsJsonAsync("/api/payments/initiate", request);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            var content = await response.Content.ReadFromJsonAsync<PaymentInitiationResponse>();
            Assert.NotNull(content);
            Assert.True(content!.Success);
            Assert.Equal(expectedResponse.ExternalReference, content.ExternalReference);

            _factory.PaymentServiceMock.Verify(p => p.InitiateAsync(It.IsAny<PaymentInitiationRequest>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task ConfirmPayment_InvokesOrderUpdate()
        {
            var confirmationResponse = new PaymentConfirmationResponse
            {
                Success = true,
                ProviderName = "Stripe",
                Status = "succeeded",
                Amount = 10,
                Currency = "USD",
                ExternalReference = "ref-123"
            };

            _factory.PaymentServiceMock
                .Setup(p => p.ConfirmAsync(It.IsAny<PaymentConfirmationRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(confirmationResponse);

            var request = new PaymentConfirmationRequest
            {
                ProviderName = "Stripe",
                ExternalReference = "ref-123",
                Amount = 10,
                Currency = "USD",
                Status = "succeeded"
            };

            var response = await _client.PostAsJsonAsync("/api/payments/confirm", request);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            var content = await response.Content.ReadFromJsonAsync<PaymentConfirmationResponse>();
            Assert.NotNull(content);
            Assert.True(content!.Success);

            _factory.OrderServiceMock.Verify(o => o.UpdatePaymentAsync(It.Is<PaymentConfirmationResponse>(r => r.ExternalReference == "ref-123" && r.Success)), Times.Once);
            _factory.PaymentServiceMock.Verify(p => p.ConfirmAsync(It.IsAny<PaymentConfirmationRequest>(), It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}
