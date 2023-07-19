using MediatR;

namespace ECommerceAPI.Application.Features.Queries.ProductImageFile.GetProductShowCaseImage
{
    public class GetProductShowCaseImageQueryRequest : IRequest<GetProductShowCaseImageQueryResponse>
    {
        public string Id { get; set; }
    }
}