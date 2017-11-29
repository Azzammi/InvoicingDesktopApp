﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using log4net;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;

namespace InvoiceOTC.Repository.Service
{
    public class InvoiceRepository : IInvoiceRepository
    {
        #region Declaration
        protected string m_Sql;
        protected ILog m_Log;
        protected IDapperContext context;
        protected InvoiceDetailRepository m_Detail;
        #endregion

        #region Constructor
        public InvoiceRepository()
        {
            context = new DapperContext();
            m_Detail = new InvoiceDetailRepository();
        }
        public InvoiceRepository(ILog log)
        {
            m_Log = log;
            context = new DapperContext();
            m_Detail = new InvoiceDetailRepository(log);
        }
        #endregion

        #region Methods
        public int Delete(Invoice obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"Delete From Invoice Where invoiceID = @invoiceID";
                result = context.db.Execute(m_Sql, obj);

                foreach(InvoiceDetail detail in obj.p_Items)
                {
                    m_Detail.Delete(detail);
                }
            }
            catch
            {

            }

            return result;
        }

        public IList<Invoice> GetAll()
        {
            IList<Invoice> listOfInvoice = new List<Invoice>();
            try
            {
                m_Sql = @"SELECT * FROM Invoiced AS A INNER JOIN InvoiceDetail AS B ON A.InvoiceID = B.InvoiceID;";

                //listOfInvoice = context.db.Query<Invoice>(m_Sql).ToList();
                /////Dapper Mapping
                //var data = context.db.Query<Invoice, InvoiceDetail, Invoice>(m_Sql, (Invoice, InvoiceDetail) => { Invoice.invoiceID = InvoiceDetail.invoiceID; return Invoice; });

                ////DAPPER Multi Mapping One on One
                //var invoices = context.db.Query<Invoice, InvoiceDetail, Invoice>(
                //    m_Sql,
                //    (invoice, invoiceDetail) =>
                //    {
                //        invoice.detail = invoiceDetail;
                //        return invoice;
                //    },
                //    splitOn: "InvoiceID")
                //.Distinct()
                //.ToList();

                var invoiceDictionary = new Dictionary<int, Invoice>();

                listOfInvoice = context.db.Query<Invoice, InvoiceDetail, Invoice>(
                        m_Sql,
                        (invoice, invoiceDetail) =>
                        {
                            Invoice invoiceEntry;

                            if (!invoiceDictionary.TryGetValue(invoice.invoiceID, out invoiceEntry))
                            {
                                invoiceEntry = invoice;
                                invoiceEntry.detail = new List<InvoiceDetail>();
                                invoiceDictionary.Add(invoiceEntry.invoiceID, invoiceEntry);
                            }

                            invoiceEntry.detail.Add(invoiceDetail);
                            return invoiceEntry;
                        },
                        splitOn: "rotiID")
                    .Distinct()
                    .ToList();
            }
            catch
            {

            }
            return listOfInvoice;
        }

        public Invoice GetInvoiceByID(int idInvoice)
        {
            throw new NotImplementedException();
        }

        public Invoice GetInvoiceByNomor(int nomorInvoice)
        {
            throw new NotImplementedException();
        }

        public IList<InvoiceDetail> GetInvoiceDetail()
        {
            IList<InvoiceDetail> listOfDetail = new List<InvoiceDetail>();
            try
            {
                m_Sql = @"SELECT [rotiID],[InvoiceID],[itemCode],[itemQty],[discount],[itemPrice],[subTotal] FROM [OTF_Invoice].[dbo].[invoiceDetail]";

                listOfDetail = context.db.Query<InvoiceDetail>(m_Sql).ToList();
            }
            catch
            {

            }
            return listOfDetail;
        }

        public int Save(Invoice obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"INSERT INTO [OTF_Invoice].[dbo].[INVOICED]
                            ([noInvoice]
                            ,[dueDate]
                            ,[outletCode]
                            ,[subTotal]
                            ,[ppn]
                            ,[total]
                            ,[issuedDate]
                            ,[isPPN]
                            ,[nomorPO]
                            ,[periode]
                            ,[pengguna]
                            ,[id_payment]
                            ,[isPayed])
                        VALUES 
                            (@nomorInvoice
                            ,@dueDate
                            ,@outletCode
                            ,@subTotal
                            ,@ppn
                            ,@total
                            ,@issuedDate
                            ,@isPPN
                            ,@nomorPO
                            ,@periode
                            ,@pengguna
                            ,@paymentMethod
                            ,@isPayed; ";

                result = context.db.Execute(m_Sql);
            }
            catch
            {

            }
            return result; 
        }

        public int Update(Invoice obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"Update INVOICED SET noInvoice = @nomorInvoice, " +
                        "dueDate = @dueDate, " +
                        "outletCode = @outletCode, " +
                        "subTotal = @subTotal, " +
                        "ppn = @ppn, " +
                        "total = @total, " +
                        "issuedDate = @issuedDate, " +
                        "isPPN = @isPPN, " +
                        "nomorPO = @nomorPO, " +
                        //"pengguna = '{0}' " +
                        "WHERE InvoiceID = @invoiceID";

                result = context.db.Execute(m_Sql);
            }
            catch
            {

            }
            return result;
        }
        #endregion
    }
}
