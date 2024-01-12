using ProductPriceExchange.ClientService.Services.Implementation;
using ProductPriceExchange.ClientService.Services.Interface;
using ProductPriceExchange.ClientService.State.Implementation;
using ProductPriceExchange.ClientService.State.Interface;

namespace ProductPriceExchange.Client.DI
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterService(this IServiceCollection services)
        {
            return services
                .AddScoped<IProductService, ProductService>()
                .AddScoped<IExchangeRateService, ExchangeRateService>()
                .AddScoped<ICountryCodeService, CountryCodeService>()
                .AddScoped<IProductState, ProductState>()
                .AddScoped<IHttpClientService, HttpClientService>()
                ;
        }
    }
}
