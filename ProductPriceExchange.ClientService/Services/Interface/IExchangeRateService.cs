using ProductPriceExchange.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPriceExchange.ClientService.Services.Interface
{
    public interface IExchangeRateService
    {
        public Task<ExchangeResult> GetExchangeRate(string code);
    }
}
