using Microsoft.EntityFrameworkCore;
using ProductPriceExchange.Server.Data;
using ProductPriceExchange.Server.Services.Interface;
using ProductPriceExchange.Shared;

namespace ProductPriceExchange.Server.Services.Implementation
{
    public class ProductOperation : IProductOperation
    {
        private readonly ApplicationDbContext _context;

        public ProductOperation(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<ProductResult>> GetProducts()
        {
            return await _context
                .Products
                .AsNoTracking()
                .Select(c => new ProductResult
                {
                    Id = c.Id,
                    Name = c.Name,
                    Price = c.Price,
                    OriginalPrice = c.Price,
                    Desc = c.Description
                })
                .ToListAsync();
        }
    }
}
