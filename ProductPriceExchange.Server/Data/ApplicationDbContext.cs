using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProductPriceExchange.Server.Data.Models;

namespace ProductPriceExchange.Server.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ExchangeRate> ExchangeRates { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
