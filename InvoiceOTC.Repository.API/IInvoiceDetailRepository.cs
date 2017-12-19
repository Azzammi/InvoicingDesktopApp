﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InvoiceOTC.Model;

namespace InvoiceOTC.Repository.API
{
    public interface IInvoiceDetailRepository : IBaseRepository<InvoiceDetail>
    {
        int Save(int invoiceID, InvoiceDetail obj);
        int Delete(int invoiceID);
        //InvoiceDetail GetInvoiceDetailByItemCode(int invoiceID, string itemCode);
    }
}