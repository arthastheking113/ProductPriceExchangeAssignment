using ProductPriceExchange.ClientService.Services.Interface;
using ProductPriceExchange.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProductPriceExchange.ClientService.Services.Implementation
{
    public class HttpClientService : IHttpClientService
    {

        private readonly IHttpClientFactory _clientFactory;

        public HttpClientService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public HttpClient Create()
        {
            var client = _clientFactory.CreateClient(StaticData.ApiName);

            if (client.BaseAddress is null)
            {
                var url = Environment.GetEnvironmentVariable(StaticData.ServerUrl);
                client.BaseAddress = new Uri(url);
            }

            return client;
        }
    }
}
