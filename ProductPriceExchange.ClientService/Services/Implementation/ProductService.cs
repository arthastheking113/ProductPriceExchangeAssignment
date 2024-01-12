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
    public class ProductService : IProductService
    {
        private readonly IHttpClientService _httpClientService;

        public ProductService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }
        public async Task<List<ProductResult>> GetProducts()
        {
            var client = _httpClientService.Create();

            var result = await client.GetFromJsonAsync<List<ProductResult>>("api/product");

            return result;
        }
    }
}
