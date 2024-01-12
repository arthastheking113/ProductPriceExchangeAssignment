using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductPriceExchange.Server.Services.Interface;

namespace ProductPriceExchange.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeRateController : ControllerBase
    {
        private readonly IExchangeRateOperation _exchangeRateOperation;

        public ExchangeRateController(IExchangeRateOperation exchangeRateOperation)
        {
            _exchangeRateOperation = exchangeRateOperation;
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> GetExchangeRates(string code)
        {
            var result = await _exchangeRateOperation.GetExchangeRates(code);
            return Ok(result);
        }
    }
}
