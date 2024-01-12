namespace ProductPriceExchange.Server.Data.Models
{
    public class ExchangeRate
    {
        public int Id { get; set; }
        public decimal Rate { get; set; }
        public string CurrencyCode { get; set; }
        public DateTimeOffset ValidFromDate { get; set; }
        public DateTimeOffset? ValidToDate { get; set; }
    }
}
