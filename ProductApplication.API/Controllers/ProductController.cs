using Microsoft.AspNetCore.Mvc;
using ProductApplication.Core;
using ProductApplication.Core.Models;

namespace ProductApplication.API.Controllers
{
    [Route("api/[controller]/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService dataService)
        {
            _productService = dataService;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] PaginationParameters paginationParameters)
        {
            var products = _productService.GetAllProducts(paginationParameters);
            return Ok(products);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProductRequest model)
        {
            if (ModelState.IsValid)
            {
                var newProduct = _productService.CreateProduct(model);
                return Ok(newProduct);  
            }
            return BadRequest();
        }
    }
}
