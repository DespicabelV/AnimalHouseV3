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
            this.Owner = new System.Windows.Forms.Label();
            this.BtnSearchOwner = new System.Windows.Forms.Button();
            this.BtnAddBookning = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonAddToCart = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameDataGripView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceDataGripView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStockDataGripView = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtboxTotalPrisWithTax = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Name2DataGripView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty1DataGripView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price1DataGripView = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.textBoxOwnerSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // PrivateCheckBox
            // 
            this.PrivateCheckBox.AutoSize = true;
            this.PrivateCheckBox.Location = new System.Drawing.Point(25, 46);
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
            this.BuisnessCheckBox.Location = new System.Drawing.Point(90, 47);
            this.BuisnessCheckBox.Name = "BuisnessCheckBox";
            this.BuisnessCheckBox.Size = new System.Drawing.Size(68, 17);
            this.BuisnessCheckBox.TabIndex = 1;
            this.BuisnessCheckBox.Text = "Business";
            this.BuisnessCheckBox.UseVisualStyleBackColor = true;
            this.BuisnessCheckBox.CheckedChanged += new System.EventHandler(this.BuisnessCheckBox_CheckedChanged);
            // 
            // Owner
            // 
            this.Owner.AutoSize = true;
            this.Owner.Location = new System.Drawing.Point(443, 45);
            this.Owner.Name = "Owner";
            this.Owner.Size = new System.Drawing.Size(41, 13);
            this.Owner.TabIndex = 5;
            this.Owner.Text = "Owner:";
            // 
            // BtnSearchOwner
            // 
            this.BtnSearchOwner.Location = new System.Drawing.Point(593, 42);
            this.BtnSearchOwner.Name = "BtnSearchOwner";
            this.BtnSearchOwner.Size = new System.Drawing.Size(58, 20);
            this.BtnSearchOwner.TabIndex = 6;
            this.BtnSearchOwner.Text = "Search";
            this.BtnSearchOwner.UseVisualStyleBackColor = true;
            this.BtnSearchOwner.Click += new System.EventHandler(this.BtnSearchOwner_Click);
            // 
            // BtnAddBookning
            // 
            this.BtnAddBookning.Location = new System.Drawing.Point(593, 68);
            this.BtnAddBookning.Name = "BtnAddBookning";
            this.BtnAddBookning.Size = new System.Drawing.Size(58, 20);
            this.BtnAddBookning.TabIndex = 8;
            this.BtnAddBookning.Text = "Add";
            this.BtnAddBookning.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cart";
            // 
            // ButtonAddToCart
            // 
            this.ButtonAddToCart.Location = new System.Drawing.Point(228, 556);
            this.ButtonAddToCart.Name = "ButtonAddToCart";
            this.ButtonAddToCart.Size = new System.Drawing.Size(58, 20);
            this.ButtonAddToCart.TabIndex = 11;
            this.ButtonAddToCart.Text = "Add";
            this.ButtonAddToCart.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameDataGripView,
            this.PriceDataGripView,
            this.QtyColumn,
            this.InStockDataGripView});
            this.dataGridView1.Location = new System.Drawing.Point(25, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(261, 348);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NameDataGripView
            // 
            this.NameDataGripView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameDataGripView.FillWeight = 75F;
            this.NameDataGripView.HeaderText = "Name";
            this.NameDataGripView.Name = "NameDataGripView";
            // 
            // PriceDataGripView
            // 
            this.PriceDataGripView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriceDataGripView.FillWeight = 75F;
            this.PriceDataGripView.HeaderText = "Price";
            this.PriceDataGripView.Name = "PriceDataGripView";
            // 
            // QtyColumn
            // 
            this.QtyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QtyColumn.FillWeight = 75F;
            this.QtyColumn.HeaderText = "Qty";
            this.QtyColumn.Name = "QtyColumn";
            // 
            // InStockDataGripView
            // 
            this.InStockDataGripView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.InStockDataGripView.FillWeight = 75F;
            this.InStockDataGripView.HeaderText = "In Stock";
            this.InStockDataGripView.Name = "InStockDataGripView";
            this.InStockDataGripView.Width = 53;
            // 
            // txtboxTotalPrisWithTax
            // 
            this.txtboxTotalPrisWithTax.Location = new System.Drawing.Point(513, 559);
            this.txtboxTotalPrisWithTax.Name = "txtboxTotalPrisWithTax";
            this.txtboxTotalPrisWithTax.Size = new System.Drawing.Size(74, 20);
            this.txtboxTotalPrisWithTax.TabIndex = 15;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name2DataGripView,
            this.Qty1DataGripView,
            this.Price1DataGripView});
            this.dataGridView2.Location = new System.Drawing.Point(437, 193);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(295, 322);
            this.dataGridView2.TabIndex = 16;
            // 
            // Name2DataGripView
            // 
            this.Name2DataGripView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name2DataGripView.FillWeight = 75F;
            this.Name2DataGripView.HeaderText = "Name";
            this.Name2DataGripView.Name = "Name2DataGripView";
            // 
            // Qty1DataGripView
            // 
            this.Qty1DataGripView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty1DataGripView.FillWeight = 75F;
            this.Qty1DataGripView.HeaderText = "Qty";
            this.Qty1DataGripView.Name = "Qty1DataGripView";
            // 
            // Price1DataGripView
            // 
            this.Price1DataGripView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price1DataGripView.FillWeight = 75F;
            this.Price1DataGripView.HeaderText = "Price";
            this.Price1DataGripView.Name = "Price1DataGripView";
            // 
            // txtboxTotalPrisWithOutTax
            // 
            this.txtboxTotalPrisWithOutTax.Location = new System.Drawing.Point(513, 585);
            this.txtboxTotalPrisWithOutTax.Name = "txtboxTotalPrisWithOutTax";
            this.txtboxTotalPrisWithOutTax.Size = new System.Drawing.Size(74, 20);
            this.txtboxTotalPrisWithOutTax.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "With Taxes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 588);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Without Taxes:";
            // 
            // BtnPay
            // 
            this.BtnPay.Location = new System.Drawing.Point(619, 572);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(58, 20);
            this.BtnPay.TabIndex = 20;
            this.BtnPay.Text = "Pay";
            this.BtnPay.UseVisualStyleBackColor = true;
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.Items.AddRange(new object[] {
            "Medicin",
            "Shelf Ressource"});
            this.ComboBoxCategory.Location = new System.Drawing.Point(25, 139);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(261, 21);
            this.ComboBoxCategory.TabIndex = 21;
            this.ComboBoxCategory.Text = "Ressource Category";
            // 
            // ComboBoxCart
            // 
            this.ComboBoxCart.FormattingEnabled = true;
            this.ComboBoxCart.Items.AddRange(new object[] {
            "Buisness",
            "Standard",
            "Loyality Discount"});
            this.ComboBoxCart.Location = new System.Drawing.Point(475, 165);
            this.ComboBoxCart.Name = "ComboBoxCart";
            this.ComboBoxCart.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxCart.TabIndex = 22;
            this.ComboBoxCart.Text = "DiscountType";
            // 
            // TxtboxSearchRessourceCategory
            // 
            this.TxtboxSearchRessourceCategory.Location = new System.Drawing.Point(25, 166);
            this.TxtboxSearchRessourceCategory.Name = "TxtboxSearchRessourceCategory";
            this.TxtboxSearchRessourceCategory.Size = new System.Drawing.Size(197, 20);
            this.TxtboxSearchRessourceCategory.TabIndex = 23;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(228, 165);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(58, 20);
            this.ButtonSearch.TabIndex = 24;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(434, 530);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(52, 13);
            this.Label11.TabIndex = 26;
            this.Label11.Text = "Discount:";
            // 
            // TextboxDiscount
            // 
            this.TextboxDiscount.Location = new System.Drawing.Point(513, 527);
            this.TextboxDiscount.Name = "TextboxDiscount";
            this.TextboxDiscount.Size = new System.Drawing.Size(74, 20);
            this.TextboxDiscount.TabIndex = 25;
            // 
            // ButtonDiscount
            // 
            this.ButtonDiscount.Location = new System.Drawing.Point(619, 526);
            this.ButtonDiscount.Name = "ButtonDiscount";
            this.ButtonDiscount.Size = new System.Drawing.Size(58, 20);
            this.ButtonDiscount.TabIndex = 27;
            this.ButtonDiscount.Text = "Discount";
            this.ButtonDiscount.UseVisualStyleBackColor = true;
            // 
            // OwnerValid
            // 
            this.OwnerValid.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.OwnerValid.AutoSize = true;
            this.OwnerValid.Location = new System.Drawing.Point(657, 44);
            this.OwnerValid.Name = "OwnerValid";
            this.OwnerValid.Size = new System.Drawing.Size(15, 14);
            this.OwnerValid.TabIndex = 28;
            this.OwnerValid.UseVisualStyleBackColor = true;
            // 
            // ComboBoxBookning
            // 
            this.ComboBoxBookning.FormattingEnabled = true;
            this.ComboBoxBookning.Location = new System.Drawing.Point(487, 67);
            this.ComboBoxBookning.Name = "ComboBoxBookning";
            this.ComboBoxBookning.Size = new System.Drawing.Size(100, 21);
            this.ComboBoxBookning.TabIndex = 29;
            this.ComboBoxBookning.Text = "Bookning";
            // 
            // textBoxOwnerSearch
            // 
            this.textBoxOwnerSearch.Location = new System.Drawing.Point(487, 41);
            this.textBoxOwnerSearch.Name = "textBoxOwnerSearch";
            this.textBoxOwnerSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxOwnerSearch.TabIndex = 30;
            // 
            // FormSalePos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 617);
            this.Controls.Add(this.textBoxOwnerSearch);
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
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtboxTotalPrisWithTax);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButtonAddToCart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAddBookning);
            this.Controls.Add(this.BtnSearchOwner);
            this.Controls.Add(this.Owner);
            this.Controls.Add(this.BuisnessCheckBox);
            this.Controls.Add(this.PrivateCheckBox);
            this.Name = "FormSalePos";
            this.Text = "Form Sale";
            this.Load += new System.EventHandler(this.FormSalePos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox PrivateCheckBox;
        private System.Windows.Forms.CheckBox BuisnessCheckBox;
        private System.Windows.Forms.Label Owner;
        private System.Windows.Forms.Button BtnSearchOwner;
        private System.Windows.Forms.Button BtnAddBookning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonAddToCart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtboxTotalPrisWithTax;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtboxTotalPrisWithOutTax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name2DataGripView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty1DataGripView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price1DataGripView;
        private System.Windows.Forms.ComboBox ComboBoxCategory;
        private System.Windows.Forms.ComboBox ComboBoxCart;
        private System.Windows.Forms.TextBox TxtboxSearchRessourceCategory;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.TextBox TextboxDiscount;
        private System.Windows.Forms.Button ButtonDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDataGripView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceDataGripView;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn InStockDataGripView;
        private System.Windows.Forms.CheckBox OwnerValid;
        private System.Windows.Forms.ComboBox ComboBoxBookning;
        private System.Windows.Forms.TextBox textBoxOwnerSearch;
    }
}