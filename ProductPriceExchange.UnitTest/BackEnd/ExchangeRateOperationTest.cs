using Microsoft.EntityFrameworkCore;
using ProductPriceExchange.Server.Data;
using ProductPriceExchange.Server.Data.Models;
using ProductPriceExchange.Server.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPriceExchange.UnitTest.BackEnd
{
    [TestFixture]
    public class ExchangeRateOperationTest
    {
        public ApplicationDbContext mockContext;
        public ExchangeRateOperation operation;
        [OneTimeSetUp] 
        public void OneTimeSetUp() 
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "ExchangeRateOperationTestDatabase")
                .Options;
            mockContext = new ApplicationDbContext(options);
            SeedData();
        }

        public void SeedData()
        {
            mockContext.Add<ExchangeRate>(new ExchangeRate
            {
                CurrencyCode = "USD",
                Rate = 1,
                ValidFromDate = DateTime.Now.Date,
                ValidToDate = null
            });
            mockContext.Add<ExchangeRate>(new ExchangeRate
            {
                CurrencyCode = "EUR",
                Rate = 1,
                ValidFromDate = DateTime.Now.Date,
                ValidToDate = null
            });
            mockContext.SaveChanges();
        }

        [SetUp]
        public void Setup() 
        {
            operation = new ExchangeRateOperation(mockContext);
        }


        [Test]
        [TestCase("")]
        [TestCase(null)]
        [TestCase("  ")]
        public async Task GetExchangeRates_ShouldThrowExceptionWhenInputIsNullOrWhiteSpace(string code)
        {
            //act and assert
            Assert.ThrowsAsync<ArgumentNullException>(async () => await operation.GetExchangeRates(code));
        }

        [Test]
        [TestCase("usd")]
        [TestCase("USD")]
        [TestCase("eur")]
        [TestCase("EUR")]
        public async Task GetExchangeRates_ShouldReturnCorrectValue(string code)
        {
            //act
            var result = await operation.GetExchangeRates(code);

            //assert
            Assert.IsTrue(result.Rate is 1);
        }


    }
}
