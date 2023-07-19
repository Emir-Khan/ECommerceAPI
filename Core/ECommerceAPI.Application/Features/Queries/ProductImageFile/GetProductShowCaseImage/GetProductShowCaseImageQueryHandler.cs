using ECommerceAPI.Application.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ECommerceAPI.Application.Features.Queries.ProductImageFile.GetProductShowCaseImage
{
    public class GetProductShowCaseImageQueryHandler : IRequestHandler<GetProductShowCaseImageQueryRequest, GetProductShowCaseImageQueryResponse>
    {
        readonly IProductReadRepository _productReadRepository;
        readonly IConfiguration configuration;

        public GetProductShowCaseImageQueryHandler(IProductReadRepository productReadRepository, IConfiguration configuration)
        {
            _productReadRepository = productReadRepository;
            this.configuration = configuration;
        }

        public async Task<GetProductShowCaseImageQueryResponse> Handle(GetProductShowCaseImageQueryRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Product? product = await _productReadRepository.Table.Include(p => p.ProductImageFiles)
                   .FirstOrDefaultAsync(p => p.Id == Guid.Parse(request.Id));


            return product?.ProductImageFiles?.Select(p => new GetProductShowCaseImageQueryResponse
            {
                Path = $"{configuration["BaseStorageUrl"]}/{p.Path}",
                FileName = p.FileName,
                Id = p.Id,
                ShowCase = p.ShowCase
            }).FirstOrDefault(pf => pf.ShowCase);
        }
    }
}
