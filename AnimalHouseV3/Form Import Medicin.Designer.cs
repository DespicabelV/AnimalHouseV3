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
            this.buttonUpdatePrice.Location = new System.Drawing.Point(81, 165);
            this.buttonUpdatePrice.Name = "buttonUpdatePrice";
            this.buttonUpdatePrice.Size = new System.Drawing.Size(93, 23);
            this.buttonUpdatePrice.TabIndex = 0;
            this.buttonUpdatePrice.Text = "Update Price";
            this.buttonUpdatePrice.UseVisualStyleBackColor = true;
            this.buttonUpdatePrice.Click += new System.EventHandler(this.buttonUpdatePrice_Click_1);
            // 
            // richTextBoxInformation
            // 
            this.richTextBoxInformation.Location = new System.Drawing.Point(295, 22);
            this.richTextBoxInformation.Name = "richTextBoxInformation";
            this.richTextBoxInformation.Size = new System.Drawing.Size(482, 379);
            this.richTextBoxInformation.TabIndex = 1;
            this.richTextBoxInformation.Text = "";
            // 
            // buttonChangeFile
            // 
            this.buttonChangeFile.Location = new System.Drawing.Point(81, 237);
            this.buttonChangeFile.Name = "buttonChangeFile";
            this.buttonChangeFile.Size = new System.Drawing.Size(93, 23);
            this.buttonChangeFile.TabIndex = 2;
            this.buttonChangeFile.Text = "Change File";
            this.buttonChangeFile.UseVisualStyleBackColor = true;
            this.buttonChangeFile.Click += new System.EventHandler(this.buttonChangeFile_Click);
            // 
            // FormImportMedicin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonChangeFile);
            this.Controls.Add(this.richTextBoxInformation);
            this.Controls.Add(this.buttonUpdatePrice);
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