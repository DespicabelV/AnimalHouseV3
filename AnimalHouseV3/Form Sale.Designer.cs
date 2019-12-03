namespace AnimalHouseV3
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
            this.txtboxTotalPrisWithTax = new System.Windows.Forms.TextBox();
            this.DataGridViewCart = new System.Windows.Forms.DataGridView();
            this.RessourceCategoryColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RessourceNrColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtboxTotalPrisWithOutTax = new System.Windows.Forms.TextBox();
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
            this.OwnerValid = new System.Windows.Forms.CheckBox();
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
            this.PrivateCheckBox.Location = new System.Drawing.Point(108, 106);
            this.PrivateCheckBox.Name = "PrivateCheckBox";
            this.PrivateCheckBox.Size = new System.Drawing.Size(59, 17);
            this.PrivateCheckBox.TabIndex = 0;
            this.PrivateCheckBox.Text = "Private";
            this.PrivateCheckBox.UseVisualStyleBackColor = true;
            this.PrivateCheckBox.CheckedChanged += new System.EventHandler(this.PrivateCheckBox_CheckedChanged);
            // 
            // BuisnessCheckBox
            // 
            this.BuisnessCheckBox.AutoSize = true;
            this.BuisnessCheckBox.Location = new System.Drawing.Point(25, 106);
            this.BuisnessCheckBox.Name = "BuisnessCheckBox";
            this.BuisnessCheckBox.Size = new System.Drawing.Size(68, 17);
            this.BuisnessCheckBox.TabIndex = 1;
            this.BuisnessCheckBox.Text = "Business";
            this.BuisnessCheckBox.UseVisualStyleBackColor = true;
            this.BuisnessCheckBox.CheckedChanged += new System.EventHandler(this.BuisnessCheckBox_CheckedChanged);
            // 
            // LabelOwner
            // 
            this.LabelOwner.AutoSize = true;
            this.LabelOwner.Location = new System.Drawing.Point(25, 72);
            this.LabelOwner.Name = "LabelOwner";
            this.LabelOwner.Size = new System.Drawing.Size(41, 13);
            this.LabelOwner.TabIndex = 5;
            this.LabelOwner.Text = "Owner:";
            // 
            // BtnSearchOwner
            // 
            this.BtnSearchOwner.Location = new System.Drawing.Point(173, 70);
            this.BtnSearchOwner.Name = "BtnSearchOwner";
            this.BtnSearchOwner.Size = new System.Drawing.Size(58, 20);
            this.BtnSearchOwner.TabIndex = 6;
            this.BtnSearchOwner.Text = "Search";
            this.BtnSearchOwner.UseVisualStyleBackColor = true;
            this.BtnSearchOwner.Click += new System.EventHandler(this.BtnSearchOwner_Click);
            // 
            // BtnAddBookning
            // 
            this.BtnAddBookning.Location = new System.Drawing.Point(911, 165);
            this.BtnAddBookning.Name = "BtnAddBookning";
            this.BtnAddBookning.Size = new System.Drawing.Size(42, 20);
            this.BtnAddBookning.TabIndex = 8;
            this.BtnAddBookning.Text = "Add";
            this.BtnAddBookning.UseVisualStyleBackColor = true;
            this.BtnAddBookning.Click += new System.EventHandler(this.BtnAddBookning_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(971, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Type:";
            // 
            // ButtonAddToCart
            // 
            this.ButtonAddToCart.Location = new System.Drawing.Point(536, 522);
            this.ButtonAddToCart.Name = "ButtonAddToCart";
            this.ButtonAddToCart.Size = new System.Drawing.Size(58, 20);
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
            this.DataGridViewItemsInStock.Location = new System.Drawing.Point(25, 192);
            this.DataGridViewItemsInStock.Name = "DataGridViewItemsInStock";
            this.DataGridViewItemsInStock.Size = new System.Drawing.Size(584, 322);
            this.DataGridViewItemsInStock.TabIndex = 14;
            // 
            // SelectItemColoumn
            // 
            this.SelectItemColoumn.FillWeight = 50F;
            this.SelectItemColoumn.HeaderText = "Select Item";
            this.SelectItemColoumn.Name = "SelectItemColoumn";
            this.SelectItemColoumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectItemColoumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SelectItemColoumn.Width = 50;
            // 
            // txtboxTotalPrisWithTax
            // 
            this.txtboxTotalPrisWithTax.Enabled = false;
            this.txtboxTotalPrisWithTax.Location = new System.Drawing.Point(974, 555);
            this.txtboxTotalPrisWithTax.Name = "txtboxTotalPrisWithTax";
            this.txtboxTotalPrisWithTax.Size = new System.Drawing.Size(74, 20);
            this.txtboxTotalPrisWithTax.TabIndex = 15;
            this.txtboxTotalPrisWithTax.Text = "0";
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
            this.DataGridViewCart.Location = new System.Drawing.Point(749, 192);
            this.DataGridViewCart.Name = "DataGridViewCart";
            this.DataGridViewCart.Size = new System.Drawing.Size(374, 322);
            this.DataGridViewCart.TabIndex = 16;
            // 
            // RessourceCategoryColoumn
            // 
            this.RessourceCategoryColoumn.FillWeight = 80F;
            this.RessourceCategoryColoumn.HeaderText = "Ressource Category";
            this.RessourceCategoryColoumn.Name = "RessourceCategoryColoumn";
            this.RessourceCategoryColoumn.Width = 80;
            // 
            // RessourceNrColoumn
            // 
            this.RessourceNrColoumn.FillWeight = 80F;
            this.RessourceNrColoumn.HeaderText = "Ressource Nr";
            this.RessourceNrColoumn.Name = "RessourceNrColoumn";
            this.RessourceNrColoumn.Width = 80;
            // 
            // NameColumn
            // 
            this.NameColumn.FillWeight = 60F;
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 60;
            // 
            // AmountColumn
            // 
            this.AmountColumn.FillWeight = 50F;
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.Width = 50;
            // 
            // PriceColumn
            // 
            this.PriceColumn.FillWeight = 60F;
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.Width = 60;
            // 
            // txtboxTotalPrisWithOutTax
            // 
            this.txtboxTotalPrisWithOutTax.Enabled = false;
            this.txtboxTotalPrisWithOutTax.Location = new System.Drawing.Point(974, 581);
            this.txtboxTotalPrisWithOutTax.Name = "txtboxTotalPrisWithOutTax";
            this.txtboxTotalPrisWithOutTax.Size = new System.Drawing.Size(74, 20);
            this.txtboxTotalPrisWithOutTax.TabIndex = 17;
            this.txtboxTotalPrisWithOutTax.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(895, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "With Taxes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(895, 584);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Without Taxes:";
            // 
            // BtnPay
            // 
            this.BtnPay.Location = new System.Drawing.Point(1063, 580);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(58, 20);
            this.BtnPay.TabIndex = 20;
            this.BtnPay.Text = "Pay";
            this.BtnPay.UseVisualStyleBackColor = true;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.Items.AddRange(new object[] {
            "Medicin",
            "Hyldevare"});
            this.ComboBoxCategory.Location = new System.Drawing.Point(25, 139);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(261, 21);
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
            this.ComboBoxCart.Location = new System.Drawing.Point(1004, 164);
            this.ComboBoxCart.Name = "ComboBoxCart";
            this.ComboBoxCart.Size = new System.Drawing.Size(119, 21);
            this.ComboBoxCart.TabIndex = 22;
            this.ComboBoxCart.Text = "DiscountType";
            this.ComboBoxCart.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCart_SelectedIndexChanged);
            // 
            // TxtboxSearchRessourceCategory
            // 
            this.TxtboxSearchRessourceCategory.Location = new System.Drawing.Point(25, 166);
            this.TxtboxSearchRessourceCategory.Name = "TxtboxSearchRessourceCategory";
            this.TxtboxSearchRessourceCategory.Size = new System.Drawing.Size(197, 20);
            this.TxtboxSearchRessourceCategory.TabIndex = 23;
            this.TxtboxSearchRessourceCategory.Text = "Name";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(228, 165);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(58, 20);
            this.ButtonSearch.TabIndex = 24;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(895, 526);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(52, 13);
            this.Label11.TabIndex = 26;
            this.Label11.Text = "Discount:";
            // 
            // TextboxDiscount
            // 
            this.TextboxDiscount.Enabled = false;
            this.TextboxDiscount.Location = new System.Drawing.Point(974, 523);
            this.TextboxDiscount.Name = "TextboxDiscount";
            this.TextboxDiscount.Size = new System.Drawing.Size(74, 20);
            this.TextboxDiscount.TabIndex = 25;
            this.TextboxDiscount.Text = "0";
            // 
            // ButtonDiscount
            // 
            this.ButtonDiscount.Location = new System.Drawing.Point(1063, 522);
            this.ButtonDiscount.Name = "ButtonDiscount";
            this.ButtonDiscount.Size = new System.Drawing.Size(58, 20);
            this.ButtonDiscount.TabIndex = 27;
            this.ButtonDiscount.Text = "Discount";
            this.ButtonDiscount.UseVisualStyleBackColor = true;
            this.ButtonDiscount.Click += new System.EventHandler(this.ButtonDiscount_Click);
            // 
            // OwnerValid
            // 
            this.OwnerValid.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.OwnerValid.AutoSize = true;
            this.OwnerValid.Location = new System.Drawing.Point(237, 72);
            this.OwnerValid.Name = "OwnerValid";
            this.OwnerValid.Size = new System.Drawing.Size(15, 14);
            this.OwnerValid.TabIndex = 28;
            this.OwnerValid.UseVisualStyleBackColor = true;
            // 
            // ComboBoxBookning
            // 
            this.ComboBoxBookning.FormattingEnabled = true;
            this.ComboBoxBookning.Location = new System.Drawing.Point(805, 164);
            this.ComboBoxBookning.Name = "ComboBoxBookning";
            this.ComboBoxBookning.Size = new System.Drawing.Size(100, 21);
            this.ComboBoxBookning.TabIndex = 29;
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Location = new System.Drawing.Point(67, 69);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(100, 20);
            this.textBoxOwner.TabIndex = 30;
            // 
            // TextboxAmount
            // 
            this.TextboxAmount.Location = new System.Drawing.Point(483, 523);
            this.TextboxAmount.Name = "TextboxAmount";
            this.TextboxAmount.Size = new System.Drawing.Size(47, 20);
            this.TextboxAmount.TabIndex = 31;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(1102, 11);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(19, 20);
            this.buttonHelp.TabIndex = 32;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(746, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Bookning:";
            // 
            // FormSalePos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 653);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonAddToCart);
            this.Controls.Add(this.TextboxAmount);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.BuisnessCheckBox);
            this.Controls.Add(this.PrivateCheckBox);
            this.Controls.Add(this.textBoxOwner);
            this.Controls.Add(this.ComboBoxBookning);
            this.Controls.Add(this.OwnerValid);
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
            this.Controls.Add(this.txtboxTotalPrisWithOutTax);
            this.Controls.Add(this.DataGridViewCart);
            this.Controls.Add(this.txtboxTotalPrisWithTax);
            this.Controls.Add(this.DataGridViewItemsInStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAddBookning);
            this.Controls.Add(this.BtnSearchOwner);
            this.Controls.Add(this.LabelOwner);
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
        private System.Windows.Forms.TextBox txtboxTotalPrisWithTax;
        private System.Windows.Forms.DataGridView DataGridViewCart;
        private System.Windows.Forms.TextBox txtboxTotalPrisWithOutTax;
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
        private System.Windows.Forms.CheckBox OwnerValid;
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