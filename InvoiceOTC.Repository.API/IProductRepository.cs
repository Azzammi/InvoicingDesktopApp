﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InvoiceOTC.Model;

namespace InvoiceOTC.Repository.API
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        /// <summary>
        /// Return product by id
        /// </summary>
        /// <param name="itemCode"></param>
        /// <returns></returns>
        Product GetItemByID(string itemCode);
    }
}