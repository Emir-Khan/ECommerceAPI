namespace ECommerceAPI.Application.Features.Commands.Order.CreateOrder
{
    public class CreateOrderCommandResponse
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public string? PaymentStatus { get; set; }
        public string? PaymentReference { get; set; }
    }
}
