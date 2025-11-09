namespace ECommerceAPI.Application.DTOs.Payments
{
    public class PaymentConfirmationRequest
    {
        public string ProviderName { get; set; }
        public string ExternalReference { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; }
        public string? Payload { get; set; }
    }
}
