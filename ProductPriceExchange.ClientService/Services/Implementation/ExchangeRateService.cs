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
    public class ExchangeRateService : IExchangeRateService
    {
        private readonly IHttpClientService _httpClientService;

        public ExchangeRateService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public async Task<ExchangeResult> GetExchangeRate(string code)
        {
            var client = _httpClientService.Create();

            var result = await client.GetFromJsonAsync<ExchangeResult>($"api/exchangerate/{code}");

            return result;

        }
    }
}
