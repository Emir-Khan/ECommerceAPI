namespace ECommerceAPI.Application.DTOs.Payments
{
    public class PaymentConfirmationResponse
    {
        public bool Success { get; set; }
        public string ProviderName { get; set; }
        public string Status { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string ExternalReference { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
