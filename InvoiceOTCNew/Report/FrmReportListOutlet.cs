﻿using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using InvoiceOTCNew.Report;
using InvoiceOTCNew.Report.CrFiles;

namespace InvoiceOTCNew
{
    public partial class FrmReportListOutlet : TemplateReportFrm
    {
        #region Declaration
        private IOutletRepository outletRepo;
        #endregion

        #region Constructor
        public FrmReportListOutlet()
        {
            InitializeComponent();

            outletRepo = new OutletRepository();
            LoadReport();
        }
        #endregion

        #region Load Method
        protected override void LoadReport()
        {
            RptListOutlet crInvoice = new RptListOutlet();

            //Set DataSource First
            crInvoice.Database.Tables["InvoiceOTC_Model_Outlet"].SetDataSource(outletRepo.GetAll());

            crViewer.ReportSource = crInvoice;
            crViewer.Refresh();
        }
        #endregion

    }
}
