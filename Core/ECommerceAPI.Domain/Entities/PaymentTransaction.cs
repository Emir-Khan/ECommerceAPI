using ECommerceAPI.Domain.Entities.Common;

namespace ECommerceAPI.Domain.Entities
{
    public class PaymentTransaction : BaseEntity
    {
        public Guid PaymentId { get; set; }
        public string ProviderName { get; set; }
        public string Status { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string ExternalReference { get; set; }
        public DateTime OccurredOn { get; set; }

        public Payment Payment { get; set; }
    }
}
