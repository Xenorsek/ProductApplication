using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication.Core.Models
{
    public class ProductDto
    {
        public required string Name { get; set; }
        public required string Code { get; set; }
        public double Price { get; set; }
    }
}
