using ProductPriceExchange.ClientService.Services.Interface;
using ProductPriceExchange.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ProductPriceExchange.ClientService.Services.Implementation
{
    public class CountryCodeService : ICountryCodeService
    {
        private readonly IHttpClientService _httpClientService;

        public CountryCodeService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public async Task<List<CountryResult>> GetCountryCodes()
        {
            var client = _httpClientService.Create();

            var result = await client.GetFromJsonAsync<List<CountryResult>>("api/country");

            return result;
        }
    }
}
