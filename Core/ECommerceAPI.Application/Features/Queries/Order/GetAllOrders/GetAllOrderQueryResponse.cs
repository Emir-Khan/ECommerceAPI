namespace ECommerceAPI.Application.Features.Queries.Order.GetAllOrders
{
    public class GetAllOrderQueryResponse
    {
        public object Orders { get; set; }
        public int TotalOrderCount { get; set; }
    }
}
