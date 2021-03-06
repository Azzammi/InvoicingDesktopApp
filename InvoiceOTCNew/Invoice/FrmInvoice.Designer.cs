﻿namespace InvoiceOTCNew
{
    partial class FrmInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dueDateLabel;
            System.Windows.Forms.Label idPaymentLabel;
            System.Windows.Forms.Label isPayedLabel;
            System.Windows.Forms.Label isPPNLabel;
            System.Windows.Forms.Label issuedDateLabel;
            System.Windows.Forms.Label nomorInvoiceLabel;
            System.Windows.Forms.Label nomorPOLabel;
            System.Windows.Forms.Label outletCodeLabel;
            System.Windows.Forms.Label periodeLabel;
            System.Windows.Forms.Label ppnLabel;
            System.Windows.Forms.Label subTotalLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemSort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.ppnTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.countBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.periodeTextBox = new System.Windows.Forms.TextBox();
            this.nomorInvoiceTextBox = new System.Windows.Forms.TextBox();
            this.issuedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nomorPOTextBox = new System.Windows.Forms.TextBox();
            this.isPPNCheckBox = new System.Windows.Forms.CheckBox();
            this.dueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idPaymentTextBox = new System.Windows.Forms.TextBox();
            this.isPayedCheckBox = new System.Windows.Forms.CheckBox();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dueDateLabel = new System.Windows.Forms.Label();
            idPaymentLabel = new System.Windows.Forms.Label();
            isPayedLabel = new System.Windows.Forms.Label();
            isPPNLabel = new System.Windows.Forms.Label();
            issuedDateLabel = new System.Windows.Forms.Label();
            nomorInvoiceLabel = new System.Windows.Forms.Label();
            nomorPOLabel = new System.Windows.Forms.Label();
            outletCodeLabel = new System.Windows.Forms.Label();
            periodeLabel = new System.Windows.Forms.Label();
            ppnLabel = new System.Windows.Forms.Label();
            subTotalLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pItemsBindingSource)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            dueDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dueDateLabel.ForeColor = System.Drawing.Color.Black;
            dueDateLabel.Location = new System.Drawing.Point(3, 111);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new System.Drawing.Size(143, 28);
            dueDateLabel.TabIndex = 0;
            dueDateLabel.Text = "DUE DATE";
            // 
            // idPaymentLabel
            // 
            idPaymentLabel.AutoSize = true;
            idPaymentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            idPaymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idPaymentLabel.ForeColor = System.Drawing.Color.Black;
            idPaymentLabel.Location = new System.Drawing.Point(3, 197);
            idPaymentLabel.Name = "idPaymentLabel";
            idPaymentLabel.Size = new System.Drawing.Size(143, 31);
            idPaymentLabel.TabIndex = 2;
            idPaymentLabel.Text = "ID PAYMENT";
            // 
            // isPayedLabel
            // 
            isPayedLabel.AutoSize = true;
            isPayedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            isPayedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            isPayedLabel.ForeColor = System.Drawing.Color.Black;
            isPayedLabel.Location = new System.Drawing.Point(3, 228);
            isPayedLabel.Name = "isPayedLabel";
            isPayedLabel.Size = new System.Drawing.Size(143, 41);
            isPayedLabel.TabIndex = 6;
            isPayedLabel.Text = "IS PAYED";
            // 
            // isPPNLabel
            // 
            isPPNLabel.AutoSize = true;
            isPPNLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            isPPNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            isPPNLabel.ForeColor = System.Drawing.Color.Black;
            isPPNLabel.Location = new System.Drawing.Point(3, 139);
            isPPNLabel.Name = "isPPNLabel";
            isPPNLabel.Size = new System.Drawing.Size(143, 30);
            isPPNLabel.TabIndex = 8;
            isPPNLabel.Text = "IS PPN:";
            // 
            // issuedDateLabel
            // 
            issuedDateLabel.AutoSize = true;
            issuedDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            issuedDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            issuedDateLabel.ForeColor = System.Drawing.Color.Black;
            issuedDateLabel.Location = new System.Drawing.Point(3, 28);
            issuedDateLabel.Name = "issuedDateLabel";
            issuedDateLabel.Size = new System.Drawing.Size(143, 28);
            issuedDateLabel.TabIndex = 11;
            issuedDateLabel.Text = "ISSUED";
            // 
            // nomorInvoiceLabel
            // 
            nomorInvoiceLabel.AutoSize = true;
            nomorInvoiceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            nomorInvoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomorInvoiceLabel.ForeColor = System.Drawing.Color.Black;
            nomorInvoiceLabel.Location = new System.Drawing.Point(3, 0);
            nomorInvoiceLabel.Name = "nomorInvoiceLabel";
            nomorInvoiceLabel.Size = new System.Drawing.Size(143, 28);
            nomorInvoiceLabel.TabIndex = 1;
            nomorInvoiceLabel.Text = "NO. INVOICE";
            // 
            // nomorPOLabel
            // 
            nomorPOLabel.AutoSize = true;
            nomorPOLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            nomorPOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomorPOLabel.ForeColor = System.Drawing.Color.Black;
            nomorPOLabel.Location = new System.Drawing.Point(3, 83);
            nomorPOLabel.Name = "nomorPOLabel";
            nomorPOLabel.Size = new System.Drawing.Size(143, 28);
            nomorPOLabel.TabIndex = 14;
            nomorPOLabel.Text = "NOMOR PO";
            // 
            // outletCodeLabel
            // 
            outletCodeLabel.AutoSize = true;
            outletCodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            outletCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            outletCodeLabel.ForeColor = System.Drawing.Color.Black;
            outletCodeLabel.Location = new System.Drawing.Point(3, 56);
            outletCodeLabel.Name = "outletCodeLabel";
            outletCodeLabel.Size = new System.Drawing.Size(143, 27);
            outletCodeLabel.TabIndex = 16;
            outletCodeLabel.Text = "OUTLET";
            // 
            // periodeLabel
            // 
            periodeLabel.AutoSize = true;
            periodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            periodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            periodeLabel.ForeColor = System.Drawing.Color.Black;
            periodeLabel.Location = new System.Drawing.Point(3, 169);
            periodeLabel.Name = "periodeLabel";
            periodeLabel.Size = new System.Drawing.Size(143, 28);
            periodeLabel.TabIndex = 20;
            periodeLabel.Text = "PERIODE";
            // 
            // ppnLabel
            // 
            ppnLabel.AutoSize = true;
            ppnLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            ppnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ppnLabel.ForeColor = System.Drawing.Color.Black;
            ppnLabel.Location = new System.Drawing.Point(3, 30);
            ppnLabel.Name = "ppnLabel";
            ppnLabel.Size = new System.Drawing.Size(226, 34);
            ppnLabel.TabIndex = 22;
            ppnLabel.Text = "PPN";
            // 
            // subTotalLabel
            // 
            subTotalLabel.AutoSize = true;
            subTotalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            subTotalLabel.ForeColor = System.Drawing.Color.Black;
            subTotalLabel.Location = new System.Drawing.Point(3, 0);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new System.Drawing.Size(226, 30);
            subTotalLabel.TabIndex = 24;
            subTotalLabel.Text = "SUBTOTAL";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalLabel.ForeColor = System.Drawing.Color.Black;
            totalLabel.Location = new System.Drawing.Point(3, 64);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(226, 29);
            totalLabel.TabIndex = 26;
            totalLabel.Text = "TOTAL";
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(InvoiceOTC.Model.Invoice);
            // 
            // outletBindingSource
            // 
            this.outletBindingSource.DataSource = typeof(InvoiceOTC.Model.Outlet);
            this.outletBindingSource.CurrentChanged += new System.EventHandler(this.outletBindingSource_CurrentChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(InvoiceOTC.Model.Product);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 58);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.01661F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.89037F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.92691F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(954, 602);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.itemSort,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.subTotalDataGridViewTextBoxColumn1});
            this.tableLayoutPanel4.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.DataSource = this.pItemsBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(948, 192);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "itemCode";
            this.dataGridViewTextBoxColumn1.DataSource = this.productBindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "itemName";
            this.dataGridViewTextBoxColumn1.HeaderText = "itemCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "itemCode";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // itemSort
            // 
            this.itemSort.HeaderText = "Item Sort";
            this.itemSort.Name = "itemSort";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "itemQty";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "itemQty";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "discount";
            this.dataGridViewTextBoxColumn3.HeaderText = "discount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "itemPrice";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn4.HeaderText = "itemPrice";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // subTotalDataGridViewTextBoxColumn1
            // 
            this.subTotalDataGridViewTextBoxColumn1.DataPropertyName = "subTotal";
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.subTotalDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.subTotalDataGridViewTextBoxColumn1.HeaderText = "subTotal";
            this.subTotalDataGridViewTextBoxColumn1.Name = "subTotalDataGridViewTextBoxColumn1";
            // 
            // pItemsBindingSource
            // 
            this.pItemsBindingSource.DataMember = "p_Items";
            this.pItemsBindingSource.DataSource = this.invoiceBindingSource;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(480, 472);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(471, 127);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(subTotalLabel, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.subTotalTextBox, 1, 0);
            this.tableLayoutPanel7.Controls.Add(ppnLabel, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.ppnTextBox, 1, 1);
            this.tableLayoutPanel7.Controls.Add(totalLabel, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.totalTextBox, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.countBtn, 1, 3);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 4;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.2973F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.7027F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(465, 121);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "subTotal", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.subTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalTextBox.Location = new System.Drawing.Point(235, 3);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.Size = new System.Drawing.Size(227, 22);
            this.subTotalTextBox.TabIndex = 0;
            this.subTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ppnTextBox
            // 
            this.ppnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "ppn", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.ppnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppnTextBox.Location = new System.Drawing.Point(235, 33);
            this.ppnTextBox.Name = "ppnTextBox";
            this.ppnTextBox.Size = new System.Drawing.Size(227, 22);
            this.ppnTextBox.TabIndex = 1;
            this.ppnTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "total", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.totalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(235, 67);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(227, 22);
            this.totalTextBox.TabIndex = 2;
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // countBtn
            // 
            this.countBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countBtn.Location = new System.Drawing.Point(235, 96);
            this.countBtn.Name = "countBtn";
            this.countBtn.Size = new System.Drawing.Size(227, 22);
            this.countBtn.TabIndex = 3;
            this.countBtn.Text = "Hitung";
            this.countBtn.UseVisualStyleBackColor = true;
            this.countBtn.Click += new System.EventHandler(this.countBtn_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel4.SetColumnSpan(this.tableLayoutPanel5, 2);
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.82278F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.17722F));
            this.tableLayoutPanel5.Controls.Add(periodeLabel, 0, 10);
            this.tableLayoutPanel5.Controls.Add(this.periodeTextBox, 1, 10);
            this.tableLayoutPanel5.Controls.Add(this.nomorInvoiceTextBox, 1, 0);
            this.tableLayoutPanel5.Controls.Add(nomorInvoiceLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(issuedDateLabel, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.issuedDateDateTimePicker, 1, 1);
            this.tableLayoutPanel5.Controls.Add(outletCodeLabel, 0, 3);
            this.tableLayoutPanel5.Controls.Add(nomorPOLabel, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.nomorPOTextBox, 1, 4);
            this.tableLayoutPanel5.Controls.Add(isPPNLabel, 0, 7);
            this.tableLayoutPanel5.Controls.Add(this.isPPNCheckBox, 1, 7);
            this.tableLayoutPanel5.Controls.Add(dueDateLabel, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.dueDateDateTimePicker, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.idPaymentTextBox, 1, 14);
            this.tableLayoutPanel5.Controls.Add(idPaymentLabel, 0, 14);
            this.tableLayoutPanel5.Controls.Add(isPayedLabel, 0, 15);
            this.tableLayoutPanel5.Controls.Add(this.isPayedCheckBox, 1, 15);
            this.tableLayoutPanel5.Controls.Add(this.comboBoxAdv1, 1, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 17;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(948, 265);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // periodeTextBox
            // 
            this.periodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "periode", true));
            this.periodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodeTextBox.Location = new System.Drawing.Point(152, 172);
            this.periodeTextBox.Name = "periodeTextBox";
            this.periodeTextBox.Size = new System.Drawing.Size(303, 22);
            this.periodeTextBox.TabIndex = 8;
            // 
            // nomorInvoiceTextBox
            // 
            this.nomorInvoiceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "nomorInvoice", true));
            this.nomorInvoiceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomorInvoiceTextBox.Location = new System.Drawing.Point(152, 3);
            this.nomorInvoiceTextBox.Name = "nomorInvoiceTextBox";
            this.nomorInvoiceTextBox.Size = new System.Drawing.Size(109, 22);
            this.nomorInvoiceTextBox.TabIndex = 2;
            // 
            // issuedDateDateTimePicker
            // 
            this.issuedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "issuedDate", true));
            this.issuedDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedDateDateTimePicker.Location = new System.Drawing.Point(152, 31);
            this.issuedDateDateTimePicker.Name = "issuedDateDateTimePicker";
            this.issuedDateDateTimePicker.Size = new System.Drawing.Size(303, 22);
            this.issuedDateDateTimePicker.TabIndex = 3;
            // 
            // nomorPOTextBox
            // 
            this.nomorPOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "nomorPO", true));
            this.nomorPOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomorPOTextBox.Location = new System.Drawing.Point(152, 86);
            this.nomorPOTextBox.Name = "nomorPOTextBox";
            this.nomorPOTextBox.Size = new System.Drawing.Size(303, 22);
            this.nomorPOTextBox.TabIndex = 5;
            // 
            // isPPNCheckBox
            // 
            this.isPPNCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.invoiceBindingSource, "isPPN", true));
            this.isPPNCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isPPNCheckBox.ForeColor = System.Drawing.Color.Black;
            this.isPPNCheckBox.Location = new System.Drawing.Point(152, 142);
            this.isPPNCheckBox.Name = "isPPNCheckBox";
            this.isPPNCheckBox.Size = new System.Drawing.Size(200, 24);
            this.isPPNCheckBox.TabIndex = 7;
            this.isPPNCheckBox.Text = "PPN 10%";
            this.isPPNCheckBox.UseVisualStyleBackColor = true;
            // 
            // dueDateDateTimePicker
            // 
            this.dueDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "dueDate", true));
            this.dueDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateDateTimePicker.Location = new System.Drawing.Point(152, 114);
            this.dueDateDateTimePicker.Name = "dueDateDateTimePicker";
            this.dueDateDateTimePicker.Size = new System.Drawing.Size(303, 22);
            this.dueDateDateTimePicker.TabIndex = 6;
            // 
            // idPaymentTextBox
            // 
            this.idPaymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "idPayment", true));
            this.idPaymentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPaymentTextBox.Location = new System.Drawing.Point(152, 200);
            this.idPaymentTextBox.Name = "idPaymentTextBox";
            this.idPaymentTextBox.Size = new System.Drawing.Size(303, 22);
            this.idPaymentTextBox.TabIndex = 9;
            // 
            // isPayedCheckBox
            // 
            this.isPayedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.invoiceBindingSource, "isPayed", true));
            this.isPayedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isPayedCheckBox.ForeColor = System.Drawing.Color.Black;
            this.isPayedCheckBox.Location = new System.Drawing.Point(152, 231);
            this.isPayedCheckBox.Name = "isPayedCheckBox";
            this.isPayedCheckBox.Size = new System.Drawing.Size(200, 24);
            this.isPayedCheckBox.TabIndex = 10;
            this.isPayedCheckBox.Text = "Payed";
            this.isPayedCheckBox.UseVisualStyleBackColor = true;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(303, 24);
            this.comboBoxAdv1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoiceBindingSource, "outletCode", true));
            this.comboBoxAdv1.DataSource = this.outletBindingSource;
            this.comboBoxAdv1.DisplayMember = "outlName";
            this.comboBoxAdv1.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.System;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Location = new System.Drawing.Point(152, 59);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(303, 24);
            this.comboBoxAdv1.TabIndex = 4;
            this.comboBoxAdv1.ValueMember = "outlCode";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.067941F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.93206F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.qtyLabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 472);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.89764F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.10236F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(471, 127);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qty";
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Location = new System.Drawing.Point(41, 0);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(13, 13);
            this.qtyLabel.TabIndex = 1;
            this.qtyLabel.Text = "0";
            // 
            // detailBindingSource
            // 
            this.detailBindingSource.DataMember = "detail";
            this.detailBindingSource.DataSource = this.invoiceBindingSource;
            this.detailBindingSource.CurrentItemChanged += new System.EventHandler(this.detailBindingSource_CurrentItemChanged);
            // 
            // itemCode
            // 
            this.itemCode.DataPropertyName = "itemCode";
            this.itemCode.DataSource = this.productBindingSource;
            this.itemCode.DisplayMember = "itemName";
            this.itemCode.HeaderText = "itemCode";
            this.itemCode.Name = "itemCode";
            this.itemCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemCode.ValueMember = "itemCode";
            // 
            // itemQty
            // 
            this.itemQty.DataPropertyName = "itemQty";
            this.itemQty.HeaderText = "itemQty";
            this.itemQty.Name = "itemQty";
            // 
            // discount
            // 
            this.discount.DataPropertyName = "discount";
            this.discount.HeaderText = "discount";
            this.discount.Name = "discount";
            // 
            // itemPrice
            // 
            this.itemPrice.DataPropertyName = "itemPrice";
            this.itemPrice.HeaderText = "itemPrice";
            this.itemPrice.Name = "itemPrice";
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "subTotal";
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "subTotal";
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 701);
            this.Controls.Add(this.tableLayoutPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInvoice";
            this.Text = "FrmInvoice";
            this.Controls.SetChildIndex(this.tableLayoutPanel4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pItemsBindingSource)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.BindingSource outletBindingSource;        
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DateTimePicker dueDateDateTimePicker;
        private System.Windows.Forms.TextBox idPaymentTextBox;
        private System.Windows.Forms.CheckBox isPayedCheckBox;
        private System.Windows.Forms.CheckBox isPPNCheckBox;
        private System.Windows.Forms.DateTimePicker issuedDateDateTimePicker;
        private System.Windows.Forms.TextBox nomorInvoiceTextBox;
        private System.Windows.Forms.TextBox nomorPOTextBox;
        private System.Windows.Forms.TextBox periodeTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;        
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.TextBox ppnTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource detailBindingSource;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private System.Windows.Forms.Button countBtn;
        private System.Windows.Forms.BindingSource pItemsBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn1;
    }
}