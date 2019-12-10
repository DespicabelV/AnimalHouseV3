namespace AnimalHouseV3
{
    partial class FormImportMedicin
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
            this.richTextBoxInformation = new System.Windows.Forms.RichTextBox();
            this.buttonUpdatePrice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxInformation
            // 
            this.richTextBoxInformation.Location = new System.Drawing.Point(230, 12);
            this.richTextBoxInformation.Name = "richTextBoxInformation";
            this.richTextBoxInformation.Size = new System.Drawing.Size(406, 426);
            this.richTextBoxInformation.TabIndex = 1;
            this.richTextBoxInformation.Text = "";
            // 
            // buttonUpdatePrice
            // 
            this.buttonUpdatePrice.Location = new System.Drawing.Point(54, 113);
            this.buttonUpdatePrice.Name = "buttonUpdatePrice";
            this.buttonUpdatePrice.Size = new System.Drawing.Size(107, 23);
            this.buttonUpdatePrice.TabIndex = 2;
            this.buttonUpdatePrice.Text = "Update Price";
            this.buttonUpdatePrice.UseVisualStyleBackColor = true;
            this.buttonUpdatePrice.Click += new System.EventHandler(this.buttonUpdatePrice_Click);
            // 
            // FormImportMedicin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdatePrice);
            this.Controls.Add(this.richTextBoxInformation);
            this.Name = "FormImportMedicin";
            this.Text = "FormImportMedicin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInformation;
        private System.Windows.Forms.Button buttonUpdatePrice;
    }
}