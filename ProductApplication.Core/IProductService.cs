using ProductApplication.Core.Models;

namespace ProductApplication.Core
{
    public interface IProductService
    {
        ProductDto CreateProduct(CreateProductRequest model);
        ProductsResult GetAllProducts(PaginationParameters paginationParameters);
    }
}