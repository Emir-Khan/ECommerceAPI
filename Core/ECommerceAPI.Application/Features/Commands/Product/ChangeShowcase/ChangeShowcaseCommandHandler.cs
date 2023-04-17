using ECommerceAPI.Application.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Application.Features.Commands.Product.ChangeShowcase
{
    public class ChangeShowcaseCommandHandler : IRequestHandler<ChangeShowcaseCommandRequest, ChangeShowcaseCommandResponse>
    {
        readonly IProductImageFileWriteRepository _productImageFileWriteRepository;

        public ChangeShowcaseCommandHandler(IProductImageFileWriteRepository productImageFileWriteRepository)
        {
            _productImageFileWriteRepository = productImageFileWriteRepository;
        }

        public async Task<ChangeShowcaseCommandResponse> Handle(ChangeShowcaseCommandRequest request, CancellationToken cancellationToken)
        {
            var productImageFile = await _productImageFileWriteRepository.Table
                .Include(pif => pif.Products)
                .FirstOrDefaultAsync(pif => pif.ShowCase && pif.Products.Any(p => p.Id == Guid.Parse(request.ProductId)));

            if (productImageFile != null)
                productImageFile.ShowCase = false;

            var showcaseImage = await _productImageFileWriteRepository.Table
                .FirstOrDefaultAsync(pif => pif.Id == Guid.Parse(request.ImageId));

            if (showcaseImage != null)
                showcaseImage.ShowCase = true;

            await _productImageFileWriteRepository.SaveAsync();

            return new();
        }
    }
}
