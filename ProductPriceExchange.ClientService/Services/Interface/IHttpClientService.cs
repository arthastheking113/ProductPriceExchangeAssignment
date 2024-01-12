using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPriceExchange.ClientService.Services.Interface
{
    public interface IHttpClientService
    {
        public HttpClient Create();
    }
}
