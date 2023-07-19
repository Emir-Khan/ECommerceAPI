using ECommerceAPI.Application.Abstractions.Services;
using ECommerceAPI.Application.Repositories;
using System.Text.Json;

namespace ECommerceAPI.Persistence.Services
{
    public class ProductService : IProductService
    {
        readonly IProductReadRepository _productReadRepository;
        readonly IProductWriteRepository _productWriteRepository;
        readonly IQRCodeService _qrCodeService;
        public ProductService(IProductReadRepository productReadRepository, IQRCodeService qrCodeService, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _qrCodeService = qrCodeService;
            _productWriteRepository = productWriteRepository;
        }

        public async Task<byte[]> ProductQrCodeAsync(string productId)
        {
            var product = await _productReadRepository.GetByIdAsync(productId);
            if (product == null)
                throw new Exception("Product not found");

            var plainObject = new
            {
                product.Id,
                product.Name,
                product.Price,
                product.Stock,
                product.CreatedDate
            };
            string plainText = JsonSerializer.Serialize(plainObject);

            return _qrCodeService.GenerateQRCode(plainText);
        }

        public async Task UpdateQrCodeProductStock(string productId, int stock)
        {
            var product = await _productReadRepository.GetByIdAsync(productId) ?? throw new Exception("Product not found");
            product.Stock = stock;

            await _productWriteRepository.SaveAsync();
        }
    }
}
