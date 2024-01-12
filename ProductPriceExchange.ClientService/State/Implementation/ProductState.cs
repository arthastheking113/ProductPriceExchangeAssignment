using ProductPriceExchange.ClientService.State.Interface;
using ProductPriceExchange.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPriceExchange.ClientService.State.Implementation
{
    public class ProductState : IProductState
    {
        public event Func<string, Task> OnMessage;

        public async Task ChangeRate(string code)
        {
            OnMessage?.Invoke(code);
        }
    }
}
