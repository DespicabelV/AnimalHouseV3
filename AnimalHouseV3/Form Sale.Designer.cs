﻿namespace AnimalHouseV3
{
    partial class FormSalePos
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
            this.PrivateCheckBox = new System.Windows.Forms.CheckBox();
            this.BuisnessCheckBox = new System.Windows.Forms.CheckBox();
            this.LabelOwner = new System.Windows.Forms.Label();
            this.BtnSearchOwner = new System.Windows.Forms.Button();
            this.BtnAddBookning = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonAddToCart = new System.Windows.Forms.Button();
            this.DataGridViewItemsInStock = new System.Windows.Forms.DataGridView();
            this.SelectItemColoumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textboxTotalPrisWithTax = new System.Windows.Forms.TextBox();
            this.DataGridViewCart = new System.Windows.Forms.DataGridView();
            this.RessourceCategoryColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RessourceNrColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textboxTotalPrisWithOutTax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnPay = new System.Windows.Forms.Button();
            this.ComboBoxCategory = new System.Windows.Forms.ComboBox();
            this.ComboBoxCart = new System.Windows.Forms.ComboBox();
            this.TxtboxSearchRessourceCategory = new System.Windows.Forms.TextBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.TextboxDiscount = new System.Windows.Forms.TextBox();
            this.ButtonDiscount = new System.Windows.Forms.Button();
            this.OwnerValidCheckBox = new System.Windows.Forms.CheckBox();
            this.ComboBoxBookning = new System.Windows.Forms.ComboBox();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.TextboxAmount = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewItemsInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // PrivateCheckBox
            // 
            this.PrivateCheckBox.AutoSize = true;
            this.PrivateCheckBox.Location = new System.Drawing.Point(288, 253);
            this.PrivateCheckBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.PrivateCheckBox.Name = "PrivateCheckBox";
            this.PrivateCheckBox.Size = new System.Drawing.Size(142, 36);
            this.PrivateCheckBox.TabIndex = 0;
            this.PrivateCheckBox.Text = "Private";
            this.PrivateCheckBox.UseVisualStyleBackColor = true;
            this.PrivateCheckBox.CheckedChanged += new System.EventHandler(this.PrivateCheckBox_CheckedChanged);
            // 
            // BuisnessCheckBox
            // 
            this.BuisnessCheckBox.AutoSize = true;
            this.BuisnessCheckBox.Location = new System.Drawing.Point(67, 253);
            this.BuisnessCheckBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BuisnessCheckBox.Name = "BuisnessCheckBox";
            this.BuisnessCheckBox.Size = new System.Drawing.Size(169, 36);
            this.BuisnessCheckBox.TabIndex = 1;
            this.BuisnessCheckBox.Text = "Business";
            this.BuisnessCheckBox.UseVisualStyleBackColor = true;
            this.BuisnessCheckBox.CheckedChanged += new System.EventHandler(this.BuisnessCheckBox_CheckedChanged);
            // 
            // LabelOwner
            // 
            this.LabelOwner.AutoSize = true;
            this.LabelOwner.Location = new System.Drawing.Point(67, 172);
            this.LabelOwner.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LabelOwner.Name = "LabelOwner";
            this.LabelOwner.Size = new System.Drawing.Size(106, 32);
            this.LabelOwner.TabIndex = 5;
            this.LabelOwner.Text = "Owner:";
            // 
            // BtnSearchOwner
            // 
            this.BtnSearchOwner.Location = new System.Drawing.Point(461, 167);
            this.BtnSearchOwner.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnSearchOwner.Name = "BtnSearchOwner";
            this.BtnSearchOwner.Size = new System.Drawing.Size(155, 48);
            this.BtnSearchOwner.TabIndex = 6;
            this.BtnSearchOwner.Text = "Search";
            this.BtnSearchOwner.UseVisualStyleBackColor = true;
            this.BtnSearchOwner.Click += new System.EventHandler(this.ButtonSearchOwner_Click);
            // 
            // BtnAddBookning
            // 
            this.BtnAddBookning.Location = new System.Drawing.Point(2429, 393);
            this.BtnAddBookning.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnAddBookning.Name = "BtnAddBookning";
            this.BtnAddBookning.Size = new System.Drawing.Size(112, 48);
            this.BtnAddBookning.TabIndex = 8;
            this.BtnAddBookning.Text = "Add";
            this.BtnAddBookning.UseVisualStyleBackColor = true;
            this.BtnAddBookning.Click += new System.EventHandler(this.BtnAddBookning_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2589, 403);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Type:";
            // 
            // ButtonAddToCart
            // 
            this.ButtonAddToCart.Location = new System.Drawing.Point(1429, 1245);
            this.ButtonAddToCart.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ButtonAddToCart.Name = "ButtonAddToCart";
            this.ButtonAddToCart.Size = new System.Drawing.Size(155, 48);
            this.ButtonAddToCart.TabIndex = 11;
            this.ButtonAddToCart.Text = "Add";
            this.ButtonAddToCart.UseVisualStyleBackColor = true;
            this.ButtonAddToCart.Click += new System.EventHandler(this.ButtonAddToCart_Click);
            // 
            // DataGridViewItemsInStock
            // 
            this.DataGridViewItemsInStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewItemsInStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectItemColoumn});
            this.DataGridViewItemsInStock.Location = new System.Drawing.Point(67, 458);
            this.DataGridViewItemsInStock.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DataGridViewItemsInStock.Name = "DataGridViewItemsInStock";
            this.DataGridViewItemsInStock.RowHeadersVisible = false;
            this.DataGridViewItemsInStock.RowHeadersWidth = 102;
            this.DataGridViewItemsInStock.Size = new System.Drawing.Size(1557, 768);
            this.DataGridViewItemsInStock.TabIndex = 14;
            // 
            // SelectItemColoumn
            // 
            this.SelectItemColoumn.FillWeight = 50F;
            this.SelectItemColoumn.HeaderText = "Select Item";
            this.SelectItemColoumn.MinimumWidth = 12;
            this.SelectItemColoumn.Name = "SelectItemColoumn";
            this.SelectItemColoumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectItemColoumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SelectItemColoumn.Width = 50;
            // 
            // textboxTotalPrisWithTax
            // 
            this.textboxTotalPrisWithTax.Enabled = false;
            this.textboxTotalPrisWithTax.Location = new System.Drawing.Point(2597, 1323);
            this.textboxTotalPrisWithTax.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textboxTotalPrisWithTax.Name = "textboxTotalPrisWithTax";
            this.textboxTotalPrisWithTax.Size = new System.Drawing.Size(191, 38);
            this.textboxTotalPrisWithTax.TabIndex = 15;
            this.textboxTotalPrisWithTax.Text = "0";
            // 
            // DataGridViewCart
            // 
            this.DataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RessourceCategoryColoumn,
            this.RessourceNrColoumn,
            this.NameColumn,
            this.AmountColumn,
            this.PriceColumn});
            this.DataGridViewCart.Location = new System.Drawing.Point(1997, 458);
            this.DataGridViewCart.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DataGridViewCart.Name = "DataGridViewCart";
            this.DataGridViewCart.RowHeadersVisible = false;
            this.DataGridViewCart.RowHeadersWidth = 102;
            this.DataGridViewCart.Size = new System.Drawing.Size(997, 768);
            this.DataGridViewCart.TabIndex = 16;
            // 
            // RessourceCategoryColoumn
            // 
            this.RessourceCategoryColoumn.FillWeight = 80F;
            this.RessourceCategoryColoumn.HeaderText = "Ressource Category";
            this.RessourceCategoryColoumn.MinimumWidth = 12;
            this.RessourceCategoryColoumn.Name = "RessourceCategoryColoumn";
            this.RessourceCategoryColoumn.Width = 80;
            // 
            // RessourceNrColoumn
            // 
            this.RessourceNrColoumn.FillWeight = 80F;
            this.RessourceNrColoumn.HeaderText = "Ressource Nr";
            this.RessourceNrColoumn.MinimumWidth = 12;
            this.RessourceNrColoumn.Name = "RessourceNrColoumn";
            this.RessourceNrColoumn.Width = 80;
            // 
            // NameColumn
            // 
            this.NameColumn.FillWeight = 60F;
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 12;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 60;
            // 
            // AmountColumn
            // 
            this.AmountColumn.FillWeight = 50F;
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.MinimumWidth = 12;
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.Width = 50;
            // 
            // PriceColumn
            // 
            this.PriceColumn.FillWeight = 60F;
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.MinimumWidth = 12;
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.Width = 60;
            // 
            // textboxTotalPrisWithOutTax
            // 
            this.textboxTotalPrisWithOutTax.Enabled = false;
            this.textboxTotalPrisWithOutTax.Location = new System.Drawing.Point(2597, 1385);
            this.textboxTotalPrisWithOutTax.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textboxTotalPrisWithOutTax.Name = "textboxTotalPrisWithOutTax";
            this.textboxTotalPrisWithOutTax.Size = new System.Drawing.Size(191, 38);
            this.textboxTotalPrisWithOutTax.TabIndex = 17;
            this.textboxTotalPrisWithOutTax.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2387, 1331);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "With Taxes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2387, 1393);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Without Taxes:";
            // 
            // BtnPay
            // 
            this.BtnPay.Location = new System.Drawing.Point(2835, 1383);
            this.BtnPay.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(155, 48);
            this.BtnPay.TabIndex = 20;
            this.BtnPay.Text = "Pay";
            this.BtnPay.UseVisualStyleBackColor = true;
            this.BtnPay.Click += new System.EventHandler(this.ButtonPay_Click);
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.Items.AddRange(new object[] {
            "Medicin",
            "Hyldevare"});
            this.ComboBoxCategory.Location = new System.Drawing.Point(67, 331);
            this.ComboBoxCategory.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(689, 39);
            this.ComboBoxCategory.TabIndex = 21;
            this.ComboBoxCategory.Text = "Ressource Category";
            this.ComboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategory_SelectedIndexChanged);
            // 
            // ComboBoxCart
            // 
            this.ComboBoxCart.FormattingEnabled = true;
            this.ComboBoxCart.Items.AddRange(new object[] {
            "Business",
            "Standard",
            "Loyality Discount"});
            this.ComboBoxCart.Location = new System.Drawing.Point(2677, 391);
            this.ComboBoxCart.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ComboBoxCart.Name = "ComboBoxCart";
            this.ComboBoxCart.Size = new System.Drawing.Size(311, 39);
            this.ComboBoxCart.TabIndex = 22;
            this.ComboBoxCart.Text = "DiscountType";
            this.ComboBoxCart.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCart_SelectedIndexChanged);
            // 
            // TxtboxSearchRessourceCategory
            // 
            this.TxtboxSearchRessourceCategory.Location = new System.Drawing.Point(67, 396);
            this.TxtboxSearchRessourceCategory.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TxtboxSearchRessourceCategory.Name = "TxtboxSearchRessourceCategory";
            this.TxtboxSearchRessourceCategory.Size = new System.Drawing.Size(519, 38);
            this.TxtboxSearchRessourceCategory.TabIndex = 23;
            this.TxtboxSearchRessourceCategory.Text = "Name";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(608, 393);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(155, 48);
            this.ButtonSearch.TabIndex = 24;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearchRessource_Click);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(2387, 1254);
            this.Label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(134, 32);
            this.Label11.TabIndex = 26;
            this.Label11.Text = "Discount:";
            // 
            // TextboxDiscount
            // 
            this.TextboxDiscount.Enabled = false;
            this.TextboxDiscount.Location = new System.Drawing.Point(2597, 1247);
            this.TextboxDiscount.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TextboxDiscount.Name = "TextboxDiscount";
            this.TextboxDiscount.Size = new System.Drawing.Size(191, 38);
            this.TextboxDiscount.TabIndex = 25;
            this.TextboxDiscount.Text = "0";
            // 
            // ButtonDiscount
            // 
            this.ButtonDiscount.Location = new System.Drawing.Point(2835, 1245);
            this.ButtonDiscount.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ButtonDiscount.Name = "ButtonDiscount";
            this.ButtonDiscount.Size = new System.Drawing.Size(155, 48);
            this.ButtonDiscount.TabIndex = 27;
            this.ButtonDiscount.Text = "Discount";
            this.ButtonDiscount.UseVisualStyleBackColor = true;
            this.ButtonDiscount.Click += new System.EventHandler(this.ButtonDiscount_Click);
            // 
            // OwnerValidCheckBox
            // 
            this.OwnerValidCheckBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.OwnerValidCheckBox.AutoSize = true;
            this.OwnerValidCheckBox.Location = new System.Drawing.Point(632, 172);
            this.OwnerValidCheckBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.OwnerValidCheckBox.Name = "OwnerValidCheckBox";
            this.OwnerValidCheckBox.Size = new System.Drawing.Size(34, 33);
            this.OwnerValidCheckBox.TabIndex = 28;
            this.OwnerValidCheckBox.UseVisualStyleBackColor = true;
            // 
            // ComboBoxBookning
            // 
            this.ComboBoxBookning.FormattingEnabled = true;
            this.ComboBoxBookning.Location = new System.Drawing.Point(2147, 391);
            this.ComboBoxBookning.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ComboBoxBookning.Name = "ComboBoxBookning";
            this.ComboBoxBookning.Size = new System.Drawing.Size(260, 39);
            this.ComboBoxBookning.TabIndex = 29;
            this.ComboBoxBookning.Text = "0";
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Location = new System.Drawing.Point(179, 165);
            this.textBoxOwner.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(260, 38);
            this.textBoxOwner.TabIndex = 30;
            // 
            // TextboxAmount
            // 
            this.TextboxAmount.Location = new System.Drawing.Point(1288, 1247);
            this.TextboxAmount.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TextboxAmount.Name = "TextboxAmount";
            this.TextboxAmount.Size = new System.Drawing.Size(119, 38);
            this.TextboxAmount.TabIndex = 31;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(2939, 26);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(51, 48);
            this.buttonHelp.TabIndex = 32;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1989, 403);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 32);
            this.label4.TabIndex = 33;
            this.label4.Text = "Bookning:";
            // 
            // FormSalePos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(3053, 1557);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonAddToCart);
            this.Controls.Add(this.TextboxAmount);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.BuisnessCheckBox);
            this.Controls.Add(this.PrivateCheckBox);
            this.Controls.Add(this.textBoxOwner);
            this.Controls.Add(this.ComboBoxBookning);
            this.Controls.Add(this.OwnerValidCheckBox);
            this.Controls.Add(this.ButtonDiscount);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.TextboxDiscount);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.TxtboxSearchRessourceCategory);
            this.Controls.Add(this.ComboBoxCart);
            this.Controls.Add(this.ComboBoxCategory);
            this.Controls.Add(this.BtnPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxTotalPrisWithOutTax);
            this.Controls.Add(this.DataGridViewCart);
            this.Controls.Add(this.textboxTotalPrisWithTax);
            this.Controls.Add(this.DataGridViewItemsInStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAddBookning);
            this.Controls.Add(this.BtnSearchOwner);
            this.Controls.Add(this.LabelOwner);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormSalePos";
            this.Text = "Sale";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewItemsInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox PrivateCheckBox;
        private System.Windows.Forms.CheckBox BuisnessCheckBox;
        private System.Windows.Forms.Label LabelOwner;
        private System.Windows.Forms.Button BtnSearchOwner;
        private System.Windows.Forms.Button BtnAddBookning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonAddToCart;
        private System.Windows.Forms.DataGridView DataGridViewItemsInStock;
        private System.Windows.Forms.TextBox textboxTotalPrisWithTax;
        private System.Windows.Forms.DataGridView DataGridViewCart;
        private System.Windows.Forms.TextBox textboxTotalPrisWithOutTax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnPay;
        private System.Windows.Forms.ComboBox ComboBoxCategory;
        private System.Windows.Forms.ComboBox ComboBoxCart;
        private System.Windows.Forms.TextBox TxtboxSearchRessourceCategory;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.TextBox TextboxDiscount;
        private System.Windows.Forms.Button ButtonDiscount;
        private System.Windows.Forms.CheckBox OwnerValidCheckBox;
        private System.Windows.Forms.ComboBox ComboBoxBookning;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectItemColoumn;
        private System.Windows.Forms.TextBox TextboxAmount;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.DataGridViewTextBoxColumn RessourceCategoryColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RessourceNrColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.Label label4;
    }
}