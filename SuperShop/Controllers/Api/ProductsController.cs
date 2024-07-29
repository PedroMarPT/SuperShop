using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperShop.Data;

namespace SuperShop.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductRepository _producRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _producRepository = productRepository;
        }
        [HttpGet]
        public IActionResult GetProducts()
        { 
            return Ok(_producRepository.GetAllWithUser());
        }
    }
}
