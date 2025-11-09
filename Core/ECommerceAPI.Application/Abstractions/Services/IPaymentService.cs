using System.Threading;
using System.Threading.Tasks;
using ECommerceAPI.Application.DTOs.Payments;

namespace ECommerceAPI.Application.Abstractions.Services
{
    public interface IPaymentService
    {
        Task<PaymentInitiationResponse> InitiateAsync(PaymentInitiationRequest request, CancellationToken cancellationToken = default);
        Task<PaymentConfirmationResponse> ConfirmAsync(PaymentConfirmationRequest request, CancellationToken cancellationToken = default);
    }
}
