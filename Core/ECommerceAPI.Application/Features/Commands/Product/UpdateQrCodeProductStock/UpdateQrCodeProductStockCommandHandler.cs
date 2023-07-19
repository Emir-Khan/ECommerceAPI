using ECommerceAPI.Application.Abstractions.Services;
using MediatR;

namespace ECommerceAPI.Application.Features.Commands.Product.UpdateQrCodeProductStock
{
    public class UpdateQrCodeProductStockCommandHandler : IRequestHandler<UpdateQrCodeProductStockCommandRequest, UpdateQrCodeProductStockCommandResponse>
    {
        readonly IProductService _productService;

        public UpdateQrCodeProductStockCommandHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<UpdateQrCodeProductStockCommandResponse> Handle(UpdateQrCodeProductStockCommandRequest request, CancellationToken cancellationToken)
        {
            await _productService.UpdateQrCodeProductStock(request.ProductId, request.Stock);
            return new();
        }
    }
}
