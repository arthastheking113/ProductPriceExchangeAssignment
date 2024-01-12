using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductPriceExchange.Server.Services.Interface;

namespace ProductPriceExchange.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductOperation _productOperation;

        public ProductController(IProductOperation productOperation)
        {
            _productOperation = productOperation;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetProducts()
        {
            var result = await _productOperation.GetProducts();
            return Ok(result);
        }

    }
}
