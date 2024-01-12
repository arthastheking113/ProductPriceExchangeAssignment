using ProductPriceExchange.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPriceExchange.ClientService.State.Interface
{
    public interface IProductState
    {
        event Func<string, Task> OnMessage;
        Task ChangeRate(string code);
    }
}
