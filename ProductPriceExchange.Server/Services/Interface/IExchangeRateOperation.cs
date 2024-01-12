using ProductPriceExchange.Shared;

namespace ProductPriceExchange.Server.Services.Interface
{
    public interface IExchangeRateOperation
    {
        public Task<ExchangeResult> GetExchangeRates(string currencyCode);
    }
}
