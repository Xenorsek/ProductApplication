using ProductApplication.Common;
using ProductApplication.Data.Entities;

namespace ProductApplication.Data
{
    public class DataService : IDataService
    {
        private readonly List<Product> _products = [
            new Product { Id = 1, Code = "ME001", Name = "Konsola ARCADE1UP Pac-Man", Price = 3199.99 },
            new Product { Id = 2, Code = "ME002", Name = "Grill elektryczny CLATRONIC DVG 3686", Price = 328.99 }
        ];
        private int _nextId = 3;

        public (int, IEnumerable<Product>) GetAllProcucts(int skip = 0, int take = 100)
        {
            var total = _products.Count;

            return (total, _products.Skip(skip).Take(take).ToList());
        }

        public Product CreateProduct(Product product)
        {
            if(_products.Count > 500)
            {
                throw new DatabaseOverPopulatedException("Database has reach its limit");
            }

            product.Id = _nextId++;
            _products.Add(product);
            return product;
        }
    }
}
