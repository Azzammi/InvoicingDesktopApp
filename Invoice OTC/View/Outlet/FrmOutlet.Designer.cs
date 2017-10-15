﻿namespace Invoice_OTC.View
{
    partial class FrmOutlet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOutlet));
            this.outletItemBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outletItemDataGridView = new System.Windows.Forms.DataGridView();
            this.slsmCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outletCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outletNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outletAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outletRouteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outletStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.outletItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.findStrip1 = new Invoice_OTC.Controller.FindStrip();
            ((System.ComponentModel.ISupportInitialize)(this.outletItemBindingNavigator)).BeginInit();
            this.outletItemBindingNavigator.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outletItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outletItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // outletItemBindingNavigator
            // 
            this.outletItemBindingNavigator.AddNewItem = null;
            this.outletItemBindingNavigator.BindingSource = this.outletItemBindingSource;
            this.outletItemBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.outletItemBindingNavigator.DeleteItem = null;
            this.outletItemBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton1});
            this.outletItemBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.outletItemBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.outletItemBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.outletItemBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.outletItemBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.outletItemBindingNavigator.Name = "outletItemBindingNavigator";
            this.outletItemBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.outletItemBindingNavigator.Size = new System.Drawing.Size(811, 25);
            this.outletItemBindingNavigator.TabIndex = 0;
            this.outletItemBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = global::Invoice_OTC.Properties.Resources.View_Details_50px;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(123, 22);
            this.toolStripButton1.Text = "Import From Excel";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletesToolStripMenuItem,
            this.deleteAllToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // deletesToolStripMenuItem
            // 
            this.deletesToolStripMenuItem.Name = "deletesToolStripMenuItem";
            this.deletesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.deletesToolStripMenuItem.Text = "Delete(s)";
            this.deletesToolStripMenuItem.Click += new System.EventHandler(this.deletesToolStripMenuItem_Click);
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.deleteAllToolStripMenuItem.Text = "Delete All";
            this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.deleteAllToolStripMenuItem_Click);
            // 
            // outletItemDataGridView
            // 
            this.outletItemDataGridView.AutoGenerateColumns = false;
            this.outletItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outletItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slsmCodeDataGridViewTextBoxColumn,
            this.outletCodeDataGridViewTextBoxColumn,
            this.outletNameDataGridViewTextBoxColumn,
            this.outletAddressDataGridViewTextBoxColumn,
            this.outletRouteDataGridViewTextBoxColumn,
            this.outletStatusDataGridViewCheckBoxColumn});
            this.outletItemDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.outletItemDataGridView.DataSource = this.outletItemBindingSource;
            this.outletItemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outletItemDataGridView.Location = new System.Drawing.Point(0, 57);
            this.outletItemDataGridView.Name = "outletItemDataGridView";
            this.outletItemDataGridView.Size = new System.Drawing.Size(811, 342);
            this.outletItemDataGridView.TabIndex = 3;
            // 
            // slsmCodeDataGridViewTextBoxColumn
            // 
            this.slsmCodeDataGridViewTextBoxColumn.DataPropertyName = "SlsmCode";
            this.slsmCodeDataGridViewTextBoxColumn.HeaderText = "SlsmCode";
            this.slsmCodeDataGridViewTextBoxColumn.Name = "slsmCodeDataGridViewTextBoxColumn";
            // 
            // outletCodeDataGridViewTextBoxColumn
            // 
            this.outletCodeDataGridViewTextBoxColumn.DataPropertyName = "OutletCode";
            this.outletCodeDataGridViewTextBoxColumn.HeaderText = "OutletCode";
            this.outletCodeDataGridViewTextBoxColumn.Name = "outletCodeDataGridViewTextBoxColumn";
            // 
            // outletNameDataGridViewTextBoxColumn
            // 
            this.outletNameDataGridViewTextBoxColumn.DataPropertyName = "OutletName";
            this.outletNameDataGridViewTextBoxColumn.HeaderText = "OutletName";
            this.outletNameDataGridViewTextBoxColumn.Name = "outletNameDataGridViewTextBoxColumn";
            // 
            // outletAddressDataGridViewTextBoxColumn
            // 
            this.outletAddressDataGridViewTextBoxColumn.DataPropertyName = "OutletAddress";
            this.outletAddressDataGridViewTextBoxColumn.HeaderText = "OutletAddress";
            this.outletAddressDataGridViewTextBoxColumn.Name = "outletAddressDataGridViewTextBoxColumn";
            // 
            // outletRouteDataGridViewTextBoxColumn
            // 
            this.outletRouteDataGridViewTextBoxColumn.DataPropertyName = "OutletRoute";
            this.outletRouteDataGridViewTextBoxColumn.HeaderText = "OutletRoute";
            this.outletRouteDataGridViewTextBoxColumn.Name = "outletRouteDataGridViewTextBoxColumn";
            // 
            // outletStatusDataGridViewCheckBoxColumn
            // 
            this.outletStatusDataGridViewCheckBoxColumn.DataPropertyName = "OutletStatus";
            this.outletStatusDataGridViewCheckBoxColumn.HeaderText = "OutletStatus";
            this.outletStatusDataGridViewCheckBoxColumn.Name = "outletStatusDataGridViewCheckBoxColumn";
            // 
            // outletItemBindingSource
            // 
            this.outletItemBindingSource.DataSource = typeof(Invoice_OTC.Model.outletItem);
            this.outletItemBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.outletItemBindingSource_AddingNew);
            this.outletItemBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.outletItemBindingSource_ListChanged);
            // 
            // findStrip1
            // 
            this.findStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.findStrip1.bindingSource = this.outletItemBindingSource;
            this.findStrip1.Location = new System.Drawing.Point(0, 25);
            this.findStrip1.Name = "findStrip1";
            this.findStrip1.Size = new System.Drawing.Size(811, 32);
            this.findStrip1.TabIndex = 2;
            this.findStrip1.Text = "findStrip1";
            this.findStrip1.ItemFound += new Invoice_OTC.Controller.ItemFoundEventHandler(this.findStrip1_ItemFound);
            // 
            // FrmOutlet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 399);
            this.Controls.Add(this.outletItemDataGridView);
            this.Controls.Add(this.findStrip1);
            this.Controls.Add(this.outletItemBindingNavigator);
            this.Name = "FrmOutlet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOutlet";
            this.Load += new System.EventHandler(this.FrmOutlet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outletItemBindingNavigator)).EndInit();
            this.outletItemBindingNavigator.ResumeLayout(false);
            this.outletItemBindingNavigator.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outletItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outletItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource outletItemBindingSource;
        private System.Windows.Forms.BindingNavigator outletItemBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deletesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllToolStripMenuItem;
        private System.Windows.Forms.DataGridView outletItemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn slsmCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outletCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outletNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outletAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outletRouteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn outletStatusDataGridViewCheckBoxColumn;
        private Controller.FindStrip findStrip1;
    }
}