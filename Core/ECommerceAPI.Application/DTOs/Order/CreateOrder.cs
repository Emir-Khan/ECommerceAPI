namespace ECommerceAPI.Application.DTOs.Order
{
    public class CreateOrder
    {
        public string? BasketId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string ProviderName { get; set; }
        public string Status { get; set; }
        public string ExternalReference { get; set; }
    }
}
