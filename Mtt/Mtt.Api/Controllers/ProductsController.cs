using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mtt.Api.Services;

namespace Mtt.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var products = await _productService.GetByCategory(id);

            if (products != null && !products.Any())
            {
                return NotFound("No products were found in the Database");
            }

            return Ok(products);
        }
    }
}
