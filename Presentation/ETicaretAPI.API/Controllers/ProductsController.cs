
using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Application.RequestParameters;
using ETicaretAPI.Application.ViewModels.Products;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;
        readonly private IWebHostEnvironment _webHostEnvironment;
        readonly IFileWriteRepository _fileWriteRepository;
        readonly IFileReadRepository _fileReadRepository;
        readonly IProductImageFileReadRepository _productImageFileReadRepository;
        readonly IProductImageFileWriteRepository _productImageFileWriteRepository;
        readonly IInvoiceFileReadRepository _invoiceFileReadRepository;
        readonly IInvoiceFileWriteRepository _invoiceFileWriteRepository;
        readonly IStorageService _storageService;

        public ProductsController(
            IProductWriteRepository productWriteRepository,
            IProductReadRepository productReadRepository,
            IWebHostEnvironment webHostEnvironment,
            IFileWriteRepository fileWriteRepository,
            IFileReadRepository fileReadRepository,
            IProductImageFileReadRepository productImageFileReadRepository,
            IProductImageFileWriteRepository productImageFileWriteRepository,
            IInvoiceFileReadRepository invoiceFileReadRepository,
            IInvoiceFileWriteRepository invoiceFileWriteRepository,
            IStorageService storageService)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _webHostEnvironment = webHostEnvironment;
            _fileWriteRepository = fileWriteRepository;
            _fileReadRepository = fileReadRepository;
            _productImageFileReadRepository = productImageFileReadRepository;
            _productImageFileWriteRepository = productImageFileWriteRepository;
            _invoiceFileReadRepository = invoiceFileReadRepository;
            _invoiceFileWriteRepository = invoiceFileWriteRepository;
            _storageService = storageService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] Pagination pagination)
        {
            return Ok(new { totalCount = _productReadRepository.GetAll(false).Count(), products = _productReadRepository.GetAll(false).Skip(pagination.Page * pagination.Size).Take(pagination.Size) });
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _productReadRepository.GetByIdAsync(id, false));
        }

        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_Product model)
        {
            await _productWriteRepository.AddAsync(new()
            {
                Name = model.Name,
                Price = model.Price,
                Stock = model.Stock
            });
            await _productWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }
        [HttpPut]
        public async Task<IActionResult> Put(VM_Update_Product model)
        {
            Product product = await _productReadRepository.GetByIdAsync(model.Id);
            product.Price = model.Price;
            product.Stock = model.Stock;
            product.Name = model.Name;
            await _productWriteRepository.SaveAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _productWriteRepository.RemoveAsync(id);
            await _productWriteRepository.SaveAsync();
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Upload(string id)
        {
            var result = await _storageService.UploadAsync("photo-images", Request.Form.Files);

            Product product = await _productReadRepository.GetByIdAsync(id);

            await _productImageFileWriteRepository.AddRangeAsync(result.Select(r => new ProductImageFile
            {
                FileName = r.fileName,
                Path = r.pathOrContainerName,
                Storage = _storageService.StorageName,
                Products = new List<Product> { product }
            }).ToList());

            await _productImageFileWriteRepository.SaveAsync();

            return Ok();
        }
    }
}
