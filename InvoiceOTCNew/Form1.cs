﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;

using FSCollections;


namespace InvoiceOTCNew
{
    public partial class Form1 : Form, IBaseFormCRUD
    {
        #region Declaration
        private IProductRepository product;
        private IInvoiceRepository invoiceRepo;
        private IOutletRepository outletRepo;
        public FSBindingList<Product> productList { get; set; }
        #endregion

        public Form1()
        {
            InitializeComponent();
            product = new ProductRepository();
            invoiceRepo = new InvoiceRepository();
            outletRepo = new OutletRepository();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
          
            productBindingSource.DataSource = product.GetAll();
            productDataGridView.DataSource = TimeZoneInfo.GetSystemTimeZones();

            InvoiceBindingSource.DataSource = invoiceRepo.GetAll();
            OutletBindingSource.DataSource = outletRepo.GetAll();
            this.reportViewer1.RefreshReport();
        }

        public void BindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            // Exit if no project list
            if (productList == null) return;

            // Get the item affected
            int index = e.NewIndex;
            Product changedProduct = null;
            if ((index > -1) && (index < productList.Count))
            {
                changedProduct = productList[index];
            }

            // Get the type of change that occured
            ListChangedType changeType = e.ListChangedType;

            // Dispatch a change handler

            switch (changeType)
            {
                case ListChangedType.ItemChanged:
                    var result = product.Update(changedProduct);
                    break;

                case ListChangedType.ItemMoved:
                    // Not supported in this app
                    break;
            }
        }

        public void BindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            var newProduct = new Product
            {
                itemCode = "FG00002"
            };

            var result = product.Save(newProduct);
        }
    }
}
