using ECommerceAPI.Domain.Entities.Common;

namespace ECommerceAPI.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public Guid OrderId { get; set; }
        public string ProviderName { get; set; }
        public string Status { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string ExternalReference { get; set; }

        public Order Order { get; set; }
        public ICollection<PaymentTransaction> Transactions { get; set; } = new HashSet<PaymentTransaction>();
    }
}
