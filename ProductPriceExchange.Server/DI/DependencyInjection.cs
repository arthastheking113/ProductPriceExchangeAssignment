using ProductPriceExchange.ClientService.Services.Implementation;
using ProductPriceExchange.ClientService.Services.Interface;
using ProductPriceExchange.ClientService.State.Implementation;
using ProductPriceExchange.ClientService.State.Interface;
using ProductPriceExchange.Server.Services.Implementation;
using ProductPriceExchange.Server.Services.Interface;

namespace ProductPriceExchange.Server.DI
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterServerServices(this IServiceCollection services)
        {
            return services
                .AddScoped<IProductOperation, ProductOperation>()
                .AddScoped<IExchangeRateOperation, ExchangeRateOperation>()
                .AddScoped<ICountryOperation, CountryOperation>()
                ;
        }
        public static IServiceCollection RegisterClientServices(this IServiceCollection services)
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
