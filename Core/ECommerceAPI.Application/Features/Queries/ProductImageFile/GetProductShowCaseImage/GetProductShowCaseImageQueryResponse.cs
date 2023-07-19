namespace ECommerceAPI.Application.Features.Queries.ProductImageFile.GetProductShowCaseImage
{
    public class GetProductShowCaseImageQueryResponse
    {
        public string Path { get; set; }
        public string FileName { get; set; }
        public Guid Id { get; set; }
        public bool ShowCase { get; set; }
    }
}