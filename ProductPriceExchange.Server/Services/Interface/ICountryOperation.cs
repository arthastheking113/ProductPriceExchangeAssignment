using ProductPriceExchange.Shared;

namespace ProductPriceExchange.Server.Services.Interface
{
    public interface ICountryOperation
    {
        public Task<List<CountryResult>> GetCountries();
    }
}
