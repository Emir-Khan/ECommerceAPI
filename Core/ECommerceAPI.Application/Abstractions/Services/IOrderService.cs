using ECommerceAPI.Application.DTOs.Order;

namespace ECommerceAPI.Application.Abstractions.Services
{
    public interface IOrderService
    {
        Task CreateOrder(CreateOrder createOrder);
        Task<ListOrder> GetAllOrdersAsync(int page, int size);
        Task<SingleOrder> GetOrderByIdAsync(string id);
        Task<(bool,CompletedOrderDTO?)> CompleteOrderAsync(string id);
    }
}
