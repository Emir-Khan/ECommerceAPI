using ECommerceAPI.Application.Abstractions.Services;
using ECommerceAPI.Application.DTOs.Payments;
using Microsoft.Extensions.Logging;

namespace ECommerceAPI.Infrastructure.Services.Payments
{
    public class StripePaymentService : IPaymentService
    {
        private readonly ILogger<StripePaymentService> _logger;

        public StripePaymentService(ILogger<StripePaymentService> logger)
        {
            _logger = logger;
        }

        public Task<PaymentInitiationResponse> InitiateAsync(PaymentInitiationRequest request, CancellationToken cancellationToken = default)
        {
            if (request.Amount <= 0)
            {
                return Task.FromResult(new PaymentInitiationResponse
                {
                    Success = false,
                    ProviderName = request.ProviderName,
                    Status = "failed",
                    Amount = request.Amount,
                    Currency = request.Currency,
                    ExternalReference = string.Empty,
                    ErrorMessage = "Amount must be greater than zero."
                });
            }

            var reference = $"{request.ProviderName?.ToLowerInvariant() ?? "stripe"}_{Guid.NewGuid():N}";
            _logger.LogInformation("Initiating payment with provider {Provider} for amount {Amount} {Currency}.", request.ProviderName, request.Amount, request.Currency);

            return Task.FromResult(new PaymentInitiationResponse
            {
                Success = true,
                ProviderName = string.IsNullOrWhiteSpace(request.ProviderName) ? "Stripe" : request.ProviderName,
                Status = "pending",
                Amount = request.Amount,
                Currency = request.Currency,
                ExternalReference = reference
            });
        }

        public Task<PaymentConfirmationResponse> ConfirmAsync(PaymentConfirmationRequest request, CancellationToken cancellationToken = default)
        {
            var success = string.Equals(request.Status, "succeeded", StringComparison.OrdinalIgnoreCase) || string.Equals(request.Status, "paid", StringComparison.OrdinalIgnoreCase);
            _logger.LogInformation("Confirming payment {Reference} with status {Status} from provider {Provider}.", request.ExternalReference, request.Status, request.ProviderName);

            return Task.FromResult(new PaymentConfirmationResponse
            {
                Success = success,
                ProviderName = request.ProviderName,
                Status = request.Status,
                Amount = request.Amount,
                Currency = request.Currency,
                ExternalReference = request.ExternalReference,
                ErrorMessage = success ? null : "Payment not approved by provider."
            });
        }
    }
}
