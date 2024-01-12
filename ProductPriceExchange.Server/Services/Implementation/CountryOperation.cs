using Microsoft.EntityFrameworkCore;
using ProductPriceExchange.Server.Data;
using ProductPriceExchange.Server.Services.Interface;
using ProductPriceExchange.Shared;

namespace ProductPriceExchange.Server.Services.Implementation
{
    public class CountryOperation : ICountryOperation
    {
        private readonly ApplicationDbContext _context;

        public CountryOperation(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<CountryResult>> GetCountries()
        {
            return await _context
                .Countries
                .AsNoTracking()
                .Select(c => new CountryResult 
                { 
                    Id = c.Id, 
                    Name = c.Name,
                    CountryCode = c.CountryCode, 
                    CurrencyCode = c.CurrencyCode 
                })
                .OrderBy(c => c.Id)
                .ToListAsync();
        }
    }
}
