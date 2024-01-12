using ProductPriceExchange.Shared;

namespace ProductPriceExchange.Server.Services.Interface
{
    public interface IProductOperation
    {
        public Task<List<ProductResult>> GetProducts();
    }
}
