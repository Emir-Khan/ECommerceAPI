using ECommerceAPI.Application.Abstractions.Services;
using ECommerceAPI.Application.DTOs.Order;
using ECommerceAPI.Application.DTOs.Payments;
using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Persistence.Services
{
    public class OrderService : IOrderService
    {
        readonly IOrderWriteRepository _orderWriteRepository;
        readonly IOrderReadRepository _orderReadRepository;
        readonly ICompletedOrderWriteRepository _completedOrderWriteRepository;
        readonly ICompletedOrderReadRepository _completedOrderReadRepository;

        public OrderService(IOrderWriteRepository orderWriteRepository, IOrderReadRepository orderReadRepository, ICompletedOrderWriteRepository completedOrderWriteRepository, ICompletedOrderReadRepository completedOrderReadRepository)
        {
            _orderWriteRepository = orderWriteRepository;
            _orderReadRepository = orderReadRepository;
            _completedOrderWriteRepository = completedOrderWriteRepository;
            _completedOrderReadRepository = completedOrderReadRepository;
        }

        public async Task<(bool, CompletedOrderDTO?)> CompleteOrderAsync(string id)
        {
            Order? order = await _orderReadRepository.Table.Include(o => o.Basket).ThenInclude(b => b.User)
                .FirstOrDefaultAsync(o => o.Id == Guid.Parse(id));
            if (order != null)
            {
                await _completedOrderWriteRepository.AddAsync(new() { OrderId = Guid.Parse(id) });
                return (await _completedOrderWriteRepository.SaveAsync() > 0, new()
                {
                    NameSurname = order.Basket.User.NameSurname,
                    OrderCode = order.OrderCode,
                    OrderDate = order.CreatedDate,
                    Email = order.Basket.User.Email
                });
            }
            return (false, null);
        }

        public async Task CreateOrder(CreateOrder createOrder)
        {
            var orderCode = (new Random().NextDouble() * 10000).ToString();
            orderCode = orderCode.Substring(orderCode.IndexOf(",") + 1, orderCode.Length - orderCode.IndexOf(",") - 1);

            var orderId = Guid.Parse(createOrder.BasketId);
            var order = new Order
            {
                Id = orderId,
                Address = createOrder.Address,
                Description = createOrder.Description,
                OrderCode = orderCode,
                Payment = new Payment
                {
                    OrderId = orderId,
                    ProviderName = createOrder.ProviderName,
                    Status = createOrder.Status,
                    Amount = createOrder.Amount,
                    Currency = createOrder.Currency,
                    ExternalReference = createOrder.ExternalReference,
                    Transactions =
                    {
                        new PaymentTransaction
                        {
                            ProviderName = createOrder.ProviderName,
                            Status = createOrder.Status,
                            Amount = createOrder.Amount,
                            Currency = createOrder.Currency,
                            ExternalReference = createOrder.ExternalReference,
                            OccurredOn = DateTime.UtcNow
                        }
                    }
                }
            };

            await _orderWriteRepository.AddAsync(order);
            await _orderWriteRepository.SaveAsync();
        }

        public async Task UpdatePaymentAsync(PaymentConfirmationResponse confirmationResponse)
        {
            var order = await _orderReadRepository.Table
                .Include(o => o.Payment)
                .ThenInclude(p => p.Transactions)
                .FirstOrDefaultAsync(o => o.Payment != null && o.Payment.ExternalReference == confirmationResponse.ExternalReference);

            if (order?.Payment == null)
                return;

            order.Payment.Status = confirmationResponse.Status;
            order.Payment.Amount = confirmationResponse.Amount;
            order.Payment.Currency = confirmationResponse.Currency;

            order.Payment.Transactions.Add(new PaymentTransaction
            {
                ProviderName = confirmationResponse.ProviderName,
                Status = confirmationResponse.Status,
                Amount = confirmationResponse.Amount,
                Currency = confirmationResponse.Currency,
                ExternalReference = confirmationResponse.ExternalReference,
                OccurredOn = DateTime.UtcNow
            });

            await _orderWriteRepository.SaveAsync();
        }

        public async Task<ListOrder> GetAllOrdersAsync(int page, int size)
        {
            var query = _orderReadRepository.Table.Include(o => o.Basket).ThenInclude(b => b.User)
                .Include(u => u.Basket).ThenInclude(b => b.BasketItems).ThenInclude(bi => bi.Product)
                .Include(o => o.Payment);

            var paginatedData = query.Skip(page * size).Take(size);

            var data = from order in paginatedData
                       join completedOrder in _completedOrderReadRepository.Table
                               on order.Id equals completedOrder.OrderId into co
                       from _co in co.DefaultIfEmpty()
                       select new
                       {
                           order.Id,
                           order.CreatedDate,
                           order.OrderCode,
                           order.Basket,
                           order.Payment,
                           Completed = _co != null
                       };

            return new()
            {
                TotalOrderCount = await query.CountAsync(),
                Orders = await data.Select(o => new
                {
                    o.Id,
                    o.OrderCode,
                    o.Basket.User.UserName,
                    o.CreatedDate,
                    TotalPrice = o.Basket.BasketItems.Sum(bi => bi.Product.Price * bi.Quantity),
                    o.Completed,
                    PaymentStatus = o.Payment != null ? o.Payment.Status : null,
                    PaymentReference = o.Payment != null ? o.Payment.ExternalReference : null
                }).ToListAsync()
            };
        }

        public async Task<SingleOrder> GetOrderByIdAsync(string id)
        {
            var includedData = _orderReadRepository.Table
                .Include(o => o.Basket)
                .ThenInclude(b => b.BasketItems)
                .ThenInclude(bi => bi.Product)
                .Include(o => o.Payment);

            var data = await (from order in includedData
                              join completedOrder in _completedOrderReadRepository.Table
                                   on order.Id equals completedOrder.OrderId into co
                              from _co in co.DefaultIfEmpty()
                              select new
                              {
                                  order.Id,
                                  order.CreatedDate,
                                  order.OrderCode,
                                  order.Basket,
                                  order.Payment,
                                  Completed = _co != null,
                                  order.Address,
                                  order.Description
                              }).FirstOrDefaultAsync(o => o.Id == Guid.Parse(id));

            return new()
            {
                Id = data.Id.ToString(),
                BasketItems = data.Basket.BasketItems.Select(bi => new
                {
                    bi.Product.Name,
                    bi.Product.Price,
                    bi.Quantity,
                    bi.ProductId
                }),
                Address = data.Address,
                CreatedDate = data.CreatedDate,
                Description = data.Description,
                OrderCode = data.OrderCode,
                Completed = data.Completed
            };
        }
    }
}
