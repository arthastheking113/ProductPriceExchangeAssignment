﻿using Microsoft.EntityFrameworkCore;
using ProductPriceExchange.Server.Data;
using ProductPriceExchange.Server.Services.Interface;
using ProductPriceExchange.Shared;

namespace ProductPriceExchange.Server.Services.Implementation
{
    public class ExchangeRateOperation : IExchangeRateOperation
    {
        private readonly ApplicationDbContext _context;

        public ExchangeRateOperation(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ExchangeResult> GetExchangeRates(string currencyCode)
        {
            var currentTime = DateTime.UtcNow;

            var rate = await _context
                .ExchangeRates
                .AsNoTracking()
                .Where(c => 
                    c.CurrencyCode.ToLower() == currencyCode.ToLower() &&
                    c.ValidFromDate <= currentTime &&
                    (
                        c.ValidToDate == null ||
                        (
                            c.ValidToDate.HasValue &&
                            c.ValidToDate.Value <= currentTime
                        )
                    )
                )
                .Select(c => new ExchangeResult
                {
                    Id = c.Id,
                    Rate = c.Rate,
                    CurrencyCode = c.CurrencyCode
                })
                .FirstOrDefaultAsync();


            return rate;
        }
    }
}
