namespace ECommerceAPI.Application.DTOs.Payments
{
    public class PaymentInitiationRequest
    {
        public string ProviderName { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
    }
}
