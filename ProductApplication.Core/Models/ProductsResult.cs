using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication.Core.Models
{
    public class ProductsResult
    {
        public List<ProductDto> Products { get; set; } = new List<ProductDto>();
        public int TotalProducts { get; set; }
    }
}
