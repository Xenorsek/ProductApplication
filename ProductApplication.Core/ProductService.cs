using ProductApplication.Core.Models;
using ProductApplication.Data;
using ProductApplication.Data.Entities;

namespace ProductApplication.Core
{
    public class ProductService : IProductService
    {
        private readonly IDataService _dataService;

        public ProductService(IDataService dataService)
        {
            _dataService = dataService;
        }

        public IEnumerable<ProductDto> GetAllProducts(PaginationParameters paginationParameters)
        {
            var skip = (paginationParameters.PageNumber - 1) * paginationParameters.PageSize;
            var take = paginationParameters.PageSize;

            var products = _dataService.GetAllProcucts(skip, take);
            var productsDto = products.Select(x => new ProductDto
            {
                Name = x.Name,
                Code = x.Code,
                Price = x.Price
            }).ToList();

            return productsDto;
        }

        public ProductDto CreateProduct(CreateProductRequest model)
        {
            Product newProduct = new()
            {
                Code = model.Code,
                Name = model.Name,
                Price = model.Price
            };
            var product = _dataService.CreateProduct(newProduct);

            return new ProductDto
            {
                Name = product.Name,
                Code = product.Code,
                Price = product.Price
            };
        }
    }
}
