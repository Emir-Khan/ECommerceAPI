namespace ECommerceAPI.Application.Abstractions.Services
{
    public interface IProductService
    {
        Task<byte[]> ProductQrCodeAsync(string productId);
        Task UpdateQrCodeProductStock(string productId, int stock);
    }
}
