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
            this.buttonUpdatePrice = new System.Windows.Forms.Button();
            this.richTextBoxInformation = new System.Windows.Forms.RichTextBox();
            this.buttonChangeFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUpdatePrice
            // 
            this.buttonUpdatePrice.Location = new System.Drawing.Point(216, 393);
            this.buttonUpdatePrice.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonUpdatePrice.Name = "buttonUpdatePrice";
            this.buttonUpdatePrice.Size = new System.Drawing.Size(248, 55);
            this.buttonUpdatePrice.TabIndex = 0;
            this.buttonUpdatePrice.Text = "Update Price";
            this.buttonUpdatePrice.UseVisualStyleBackColor = true;
            this.buttonUpdatePrice.Click += new System.EventHandler(this.buttonUpdatePrice_Click_1);
            // 
            // richTextBoxInformation
            // 
            this.richTextBoxInformation.Location = new System.Drawing.Point(787, 52);
            this.richTextBoxInformation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.richTextBoxInformation.Name = "richTextBoxInformation";
            this.richTextBoxInformation.Size = new System.Drawing.Size(1279, 898);
            this.richTextBoxInformation.TabIndex = 1;
            this.richTextBoxInformation.Text = "";
            // 
            // buttonChangeFile
            // 
            this.buttonChangeFile.Location = new System.Drawing.Point(216, 565);
            this.buttonChangeFile.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonChangeFile.Name = "buttonChangeFile";
            this.buttonChangeFile.Size = new System.Drawing.Size(248, 55);
            this.buttonChangeFile.TabIndex = 2;
            this.buttonChangeFile.Text = "Change File";
            this.buttonChangeFile.UseVisualStyleBackColor = true;
            this.buttonChangeFile.Click += new System.EventHandler(this.buttonChangeFile_Click);
            // 
            // FormImportMedicin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.Controls.Add(this.buttonChangeFile);
            this.Controls.Add(this.richTextBoxInformation);
            this.Controls.Add(this.buttonUpdatePrice);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormImportMedicin";
            this.Text = "FormImportMedicin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdatePrice;
        private System.Windows.Forms.RichTextBox richTextBoxInformation;
        private System.Windows.Forms.Button buttonChangeFile;
    }
}