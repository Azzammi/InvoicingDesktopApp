﻿namespace InvoiceOTCNew
{
    partial class FrmProduct
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
            System.Windows.Forms.Label brandLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label itemCodeLabel;
            System.Windows.Forms.Label itemNameLabel;
            System.Windows.Forms.Label itemSortLabel;
            System.Windows.Forms.Label jenisLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label statLabel;
            System.Windows.Forms.Label subCategoryLabel;
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.itemCodeTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemSortTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.jenisComboBox = new System.Windows.Forms.ComboBox();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.subCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.statCheckBox = new System.Windows.Forms.CheckBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            brandLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            itemCodeLabel = new System.Windows.Forms.Label();
            itemNameLabel = new System.Windows.Forms.Label();
            itemSortLabel = new System.Windows.Forms.Label();
            jenisLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            statLabel = new System.Windows.Forms.Label();
            subCategoryLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            brandLabel.ForeColor = System.Drawing.Color.White;
            brandLabel.Location = new System.Drawing.Point(3, 124);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(100, 31);
            brandLabel.TabIndex = 0;
            brandLabel.Text = "brand:";
            brandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryLabel.ForeColor = System.Drawing.Color.White;
            categoryLabel.Location = new System.Drawing.Point(3, 155);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(100, 30);
            categoryLabel.TabIndex = 2;
            categoryLabel.Text = "category:";
            categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // itemCodeLabel
            // 
            itemCodeLabel.AutoSize = true;
            itemCodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            itemCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            itemCodeLabel.ForeColor = System.Drawing.Color.White;
            itemCodeLabel.Location = new System.Drawing.Point(3, 0);
            itemCodeLabel.Name = "itemCodeLabel";
            itemCodeLabel.Size = new System.Drawing.Size(100, 28);
            itemCodeLabel.TabIndex = 4;
            itemCodeLabel.Text = "item Code:";
            itemCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            itemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            itemNameLabel.ForeColor = System.Drawing.Color.White;
            itemNameLabel.Location = new System.Drawing.Point(3, 28);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(100, 33);
            itemNameLabel.TabIndex = 6;
            itemNameLabel.Text = "item Name:";
            itemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // itemSortLabel
            // 
            itemSortLabel.AutoSize = true;
            itemSortLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            itemSortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            itemSortLabel.ForeColor = System.Drawing.Color.White;
            itemSortLabel.Location = new System.Drawing.Point(3, 61);
            itemSortLabel.Name = "itemSortLabel";
            itemSortLabel.Size = new System.Drawing.Size(100, 31);
            itemSortLabel.TabIndex = 8;
            itemSortLabel.Text = "item Sort:";
            itemSortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // jenisLabel
            // 
            jenisLabel.AutoSize = true;
            jenisLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            jenisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jenisLabel.ForeColor = System.Drawing.Color.White;
            jenisLabel.Location = new System.Drawing.Point(3, 92);
            jenisLabel.Name = "jenisLabel";
            jenisLabel.Size = new System.Drawing.Size(100, 32);
            jenisLabel.TabIndex = 10;
            jenisLabel.Text = "jenis:";
            jenisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.ForeColor = System.Drawing.Color.White;
            priceLabel.Location = new System.Drawing.Point(3, 214);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(100, 27);
            priceLabel.TabIndex = 12;
            priceLabel.Text = "price:";
            priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statLabel
            // 
            statLabel.AutoSize = true;
            statLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            statLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statLabel.ForeColor = System.Drawing.Color.White;
            statLabel.Location = new System.Drawing.Point(3, 241);
            statLabel.Name = "statLabel";
            statLabel.Size = new System.Drawing.Size(100, 21);
            statLabel.TabIndex = 14;
            statLabel.Text = "stat:";
            statLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subCategoryLabel
            // 
            subCategoryLabel.AutoSize = true;
            subCategoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            subCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            subCategoryLabel.ForeColor = System.Drawing.Color.White;
            subCategoryLabel.Location = new System.Drawing.Point(3, 185);
            subCategoryLabel.Name = "subCategoryLabel";
            subCategoryLabel.Size = new System.Drawing.Size(100, 29);
            subCategoryLabel.TabIndex = 16;
            subCategoryLabel.Text = "sub Category:";
            subCategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.9589F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.0411F));
            this.tableLayoutPanel4.Controls.Add(itemCodeLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(itemNameLabel, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.itemCodeTextBox, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.itemSortTextBox, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.itemNameTextBox, 1, 1);
            this.tableLayoutPanel4.Controls.Add(itemSortLabel, 0, 2);
            this.tableLayoutPanel4.Controls.Add(categoryLabel, 0, 5);
            this.tableLayoutPanel4.Controls.Add(brandLabel, 0, 4);
            this.tableLayoutPanel4.Controls.Add(jenisLabel, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.jenisComboBox, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.brandComboBox, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.categoryComboBox, 1, 5);
            this.tableLayoutPanel4.Controls.Add(subCategoryLabel, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.subCategoryComboBox, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.statCheckBox, 1, 8);
            this.tableLayoutPanel4.Controls.Add(statLabel, 0, 8);
            this.tableLayoutPanel4.Controls.Add(priceLabel, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.priceTextBox, 1, 7);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 58);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 9;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.71429F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(296, 262);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // itemCodeTextBox
            // 
            this.itemCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "itemCode", true));
            this.itemCodeTextBox.Location = new System.Drawing.Point(109, 3);
            this.itemCodeTextBox.Name = "itemCodeTextBox";
            this.itemCodeTextBox.Size = new System.Drawing.Size(178, 20);
            this.itemCodeTextBox.TabIndex = 0;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(InvoiceOTC.Model.Product);
            // 
            // itemSortTextBox
            // 
            this.itemSortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "itemSort", true));
            this.itemSortTextBox.Location = new System.Drawing.Point(109, 64);
            this.itemSortTextBox.Name = "itemSortTextBox";
            this.itemSortTextBox.Size = new System.Drawing.Size(178, 20);
            this.itemSortTextBox.TabIndex = 9;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "itemName", true));
            this.itemNameTextBox.Location = new System.Drawing.Point(109, 31);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(178, 20);
            this.itemNameTextBox.TabIndex = 1;
            // 
            // jenisComboBox
            // 
            this.jenisComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "jenis", true));
            this.jenisComboBox.FormattingEnabled = true;
            this.jenisComboBox.Location = new System.Drawing.Point(109, 95);
            this.jenisComboBox.Name = "jenisComboBox";
            this.jenisComboBox.Size = new System.Drawing.Size(178, 21);
            this.jenisComboBox.TabIndex = 11;
            // 
            // brandComboBox
            // 
            this.brandComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "brand", true));
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(109, 127);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(178, 21);
            this.brandComboBox.TabIndex = 1;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "category", true));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(109, 158);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(178, 21);
            this.categoryComboBox.TabIndex = 3;
            // 
            // subCategoryComboBox
            // 
            this.subCategoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "subCategory", true));
            this.subCategoryComboBox.FormattingEnabled = true;
            this.subCategoryComboBox.Location = new System.Drawing.Point(109, 188);
            this.subCategoryComboBox.Name = "subCategoryComboBox";
            this.subCategoryComboBox.Size = new System.Drawing.Size(178, 21);
            this.subCategoryComboBox.TabIndex = 17;
            // 
            // statCheckBox
            // 
            this.statCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "stat", true));
            this.statCheckBox.Location = new System.Drawing.Point(109, 244);
            this.statCheckBox.Name = "statCheckBox";
            this.statCheckBox.Size = new System.Drawing.Size(121, 15);
            this.statCheckBox.TabIndex = 15;
            this.statCheckBox.Text = "checkBox1";
            this.statCheckBox.UseVisualStyleBackColor = true;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(109, 217);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(178, 20);
            this.priceTextBox.TabIndex = 13;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 367);
            this.Controls.Add(this.tableLayoutPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel4, 0);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox itemCodeTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox itemSortTextBox;
        private System.Windows.Forms.ComboBox jenisComboBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.CheckBox statCheckBox;
        private System.Windows.Forms.ComboBox subCategoryComboBox;
    }
}