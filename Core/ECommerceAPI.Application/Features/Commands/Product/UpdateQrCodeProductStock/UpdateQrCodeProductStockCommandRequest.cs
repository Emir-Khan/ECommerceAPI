using MediatR;

namespace ECommerceAPI.Application.Features.Commands.Product.UpdateQrCodeProductStock
{
    public class UpdateQrCodeProductStockCommandRequest : IRequest<UpdateQrCodeProductStockCommandResponse>
    {
        public string ProductId { get; set; }
        public int Stock { get; set; }
    }
}