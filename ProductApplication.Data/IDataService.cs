using ProductApplication.Data.Entities;

namespace ProductApplication.Data
{
    public interface IDataService
    {
        Product CreateProduct(Product product);
        IEnumerable<Product> GetAllProcucts(int index = 0, int limit = 100);
    }
}