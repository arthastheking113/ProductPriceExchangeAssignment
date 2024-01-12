using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPriceExchange.Shared
{
    public class ExchangeResult
    {
        public int Id { get; set; }
        public decimal Rate { get; set; }
        public string CurrencyCode { get; set; }
    }
}
