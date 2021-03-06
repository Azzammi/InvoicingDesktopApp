﻿namespace InvoiceOTCNew
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
            System.Windows.Forms.Label outlAddressLabel;
            System.Windows.Forms.Label outlCodeLabel;
            System.Windows.Forms.Label outlNameLabel;
            System.Windows.Forms.Label outlRouteLabel;
            System.Windows.Forms.Label outlSlsmLabel;
            System.Windows.Forms.Label outlStatLabel;
            System.Windows.Forms.Label isppnLabel;
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.outletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outlAddressTextBox = new System.Windows.Forms.TextBox();
            this.outlCodeTextBox = new System.Windows.Forms.TextBox();
            this.outlNameTextBox = new System.Windows.Forms.TextBox();
            this.outlRouteTextBox = new System.Windows.Forms.TextBox();
            this.outlSlsmTextBox = new System.Windows.Forms.TextBox();
            this.isppnCheckBox = new System.Windows.Forms.CheckBox();
            outlAddressLabel = new System.Windows.Forms.Label();
            outlCodeLabel = new System.Windows.Forms.Label();
            outlNameLabel = new System.Windows.Forms.Label();
            outlRouteLabel = new System.Windows.Forms.Label();
            outlSlsmLabel = new System.Windows.Forms.Label();
            outlStatLabel = new System.Windows.Forms.Label();
            isppnLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outletBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // outlAddressLabel
            // 
            outlAddressLabel.AutoSize = true;
            outlAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            outlAddressLabel.ForeColor = System.Drawing.Color.Black;
            outlAddressLabel.Location = new System.Drawing.Point(3, 59);
            outlAddressLabel.Name = "outlAddressLabel";
            outlAddressLabel.Size = new System.Drawing.Size(77, 15);
            outlAddressLabel.TabIndex = 2;
            outlAddressLabel.Text = "outl Address:";
            // 
            // outlCodeLabel
            // 
            outlCodeLabel.AutoSize = true;
            outlCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            outlCodeLabel.ForeColor = System.Drawing.Color.Black;
            outlCodeLabel.Location = new System.Drawing.Point(3, 0);
            outlCodeLabel.Name = "outlCodeLabel";
            outlCodeLabel.Size = new System.Drawing.Size(62, 15);
            outlCodeLabel.TabIndex = 0;
            outlCodeLabel.Text = "outl Code:";
            // 
            // outlNameLabel
            // 
            outlNameLabel.AutoSize = true;
            outlNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            outlNameLabel.ForeColor = System.Drawing.Color.Black;
            outlNameLabel.Location = new System.Drawing.Point(3, 27);
            outlNameLabel.Name = "outlNameLabel";
            outlNameLabel.Size = new System.Drawing.Size(67, 15);
            outlNameLabel.TabIndex = 1;
            outlNameLabel.Text = "outl Name:";
            // 
            // outlRouteLabel
            // 
            outlRouteLabel.AutoSize = true;
            outlRouteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            outlRouteLabel.ForeColor = System.Drawing.Color.Black;
            outlRouteLabel.Location = new System.Drawing.Point(3, 115);
            outlRouteLabel.Name = "outlRouteLabel";
            outlRouteLabel.Size = new System.Drawing.Size(66, 15);
            outlRouteLabel.TabIndex = 3;
            outlRouteLabel.Text = "outl Route:";
            // 
            // outlSlsmLabel
            // 
            outlSlsmLabel.AutoSize = true;
            outlSlsmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            outlSlsmLabel.ForeColor = System.Drawing.Color.Black;
            outlSlsmLabel.Location = new System.Drawing.Point(3, 149);
            outlSlsmLabel.Name = "outlSlsmLabel";
            outlSlsmLabel.Size = new System.Drawing.Size(61, 15);
            outlSlsmLabel.TabIndex = 4;
            outlSlsmLabel.Text = "outl Slsm:";
            // 
            // outlStatLabel
            // 
            outlStatLabel.AutoSize = true;
            outlStatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            outlStatLabel.ForeColor = System.Drawing.Color.Black;
            outlStatLabel.Location = new System.Drawing.Point(3, 180);
            outlStatLabel.Name = "outlStatLabel";
            outlStatLabel.Size = new System.Drawing.Size(54, 15);
            outlStatLabel.TabIndex = 5;
            outlStatLabel.Text = "outl Stat:";
            // 
            // isppnLabel
            // 
            isppnLabel.AutoSize = true;
            isppnLabel.ForeColor = System.Drawing.Color.Black;
            isppnLabel.Location = new System.Drawing.Point(3, 212);
            isppnLabel.Name = "isppnLabel";
            isppnLabel.Size = new System.Drawing.Size(60, 13);
            isppnLabel.TabIndex = 6;
            isppnLabel.Text = "Use PPN ?";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.59846F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.40154F));
            this.tableLayoutPanel2.Controls.Add(outlStatLabel, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.checkBox1, 1, 5);
            this.tableLayoutPanel2.Controls.Add(outlCodeLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(outlNameLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(outlAddressLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(outlRouteLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(outlSlsmLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.outlAddressTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.outlCodeTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.outlNameTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.outlRouteTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.outlSlsmTextBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.isppnCheckBox, 1, 6);
            this.tableLayoutPanel2.Controls.Add(isppnLabel, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 58);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.03175F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.96825F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(407, 233);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.outletBindingSource, "outlStat", true));
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(111, 183);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 19);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Active";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // outletBindingSource
            // 
            this.outletBindingSource.DataSource = typeof(InvoiceOTC.Model.Outlet);
            // 
            // outlAddressTextBox
            // 
            this.outlAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outletBindingSource, "outlAddress", true));
            this.outlAddressTextBox.Location = new System.Drawing.Point(111, 62);
            this.outlAddressTextBox.Multiline = true;
            this.outlAddressTextBox.Name = "outlAddressTextBox";
            this.outlAddressTextBox.Size = new System.Drawing.Size(282, 45);
            this.outlAddressTextBox.TabIndex = 9;
            // 
            // outlCodeTextBox
            // 
            this.outlCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outletBindingSource, "outlCode", true));
            this.outlCodeTextBox.Location = new System.Drawing.Point(111, 3);
            this.outlCodeTextBox.Name = "outlCodeTextBox";
            this.outlCodeTextBox.Size = new System.Drawing.Size(282, 20);
            this.outlCodeTextBox.TabIndex = 7;
            // 
            // outlNameTextBox
            // 
            this.outlNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outletBindingSource, "outlName", true));
            this.outlNameTextBox.Location = new System.Drawing.Point(111, 30);
            this.outlNameTextBox.Name = "outlNameTextBox";
            this.outlNameTextBox.Size = new System.Drawing.Size(282, 20);
            this.outlNameTextBox.TabIndex = 8;
            // 
            // outlRouteTextBox
            // 
            this.outlRouteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outletBindingSource, "outlRoute", true));
            this.outlRouteTextBox.Location = new System.Drawing.Point(111, 118);
            this.outlRouteTextBox.Name = "outlRouteTextBox";
            this.outlRouteTextBox.Size = new System.Drawing.Size(282, 20);
            this.outlRouteTextBox.TabIndex = 10;
            // 
            // outlSlsmTextBox
            // 
            this.outlSlsmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outletBindingSource, "slsmCode", true));
            this.outlSlsmTextBox.Location = new System.Drawing.Point(111, 152);
            this.outlSlsmTextBox.Name = "outlSlsmTextBox";
            this.outlSlsmTextBox.Size = new System.Drawing.Size(282, 20);
            this.outlSlsmTextBox.TabIndex = 11;
            // 
            // isppnCheckBox
            // 
            this.isppnCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.outletBindingSource, "isppn", true));
            this.isppnCheckBox.ForeColor = System.Drawing.Color.Black;
            this.isppnCheckBox.Location = new System.Drawing.Point(111, 215);
            this.isppnCheckBox.Name = "isppnCheckBox";
            this.isppnCheckBox.Size = new System.Drawing.Size(104, 15);
            this.isppnCheckBox.TabIndex = 13;
            this.isppnCheckBox.Text = "Yes";
            this.isppnCheckBox.UseVisualStyleBackColor = true;
            // 
            // FrmOutlet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 332);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "FrmOutlet";
            this.Text = "FrmOutlet";
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outletBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox outlAddressTextBox;
        private System.Windows.Forms.BindingSource outletBindingSource;
        private System.Windows.Forms.TextBox outlCodeTextBox;
        private System.Windows.Forms.TextBox outlNameTextBox;
        private System.Windows.Forms.TextBox outlRouteTextBox;
        private System.Windows.Forms.TextBox outlSlsmTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox isppnCheckBox;
    }
}