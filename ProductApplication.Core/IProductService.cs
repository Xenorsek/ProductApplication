using ProductApplication.Core.Models;

namespace ProductApplication.Core
{
    public interface IProductService
    {
        ProductDto CreateProduct(CreateProductRequest model);
        IEnumerable<ProductDto> GetAllProducts(PaginationParameters paginationParameters);
    }
}