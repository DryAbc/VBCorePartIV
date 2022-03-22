﻿using miniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Services
{
   public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
    }
}
