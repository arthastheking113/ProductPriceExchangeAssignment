using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductPriceExchange.Server.Services.Interface;

namespace ProductPriceExchange.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryOperation _countryOperation;

        public CountryController(ICountryOperation countryOperation)
        {
            _countryOperation = countryOperation;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetExchangeRates()
        {
            var result = await _countryOperation.GetCountries();
            return Ok(result);
        }
    }
}
