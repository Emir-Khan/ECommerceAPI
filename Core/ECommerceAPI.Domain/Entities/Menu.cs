using ECommerceAPI.Domain.Entities.Common;

namespace ECommerceAPI.Domain.Entities
{
    public class Menu : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Endpoint> Endpoints { get; set; }
    }
}
