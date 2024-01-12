﻿using ProductPriceExchange.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace ProductPriceExchange.ClientService.Services.Interface
{
    public interface IProductService
    {
        public Task<List<ProductResult>> GetProducts();
    }
}
