using System.ComponentModel.DataAnnotations;

namespace ProductApplication.Core.Models
{
    public class CreateProductRequest
    {
        [Required]
        [MaxLength(150)]
        public required string Code { get; set; }
        [Required]
        [MaxLength(150)]
        public required string Name { get; set; }
        [Required]
        [Range(0.0, double.MaxValue)]
        public double Price { get; set; }
    }
}  