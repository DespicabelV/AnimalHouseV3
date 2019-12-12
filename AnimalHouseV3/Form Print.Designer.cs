namespace AnimalHouseV3
{
    partial class FormPrint
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
            this.buttonPrintRessource = new System.Windows.Forms.Button();
            this.buttonPrintDoctorNotice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPrintRessource
            // 
            this.buttonPrintRessource.Location = new System.Drawing.Point(11, 46);
            this.buttonPrintRessource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPrintRessource.Name = "buttonPrintRessource";
            this.buttonPrintRessource.Size = new System.Drawing.Size(118, 67);
            this.buttonPrintRessource.TabIndex = 0;
            this.buttonPrintRessource.Text = "Print Ressource";
            this.buttonPrintRessource.UseVisualStyleBackColor = true;
            this.buttonPrintRessource.Click += new System.EventHandler(this.buttonPrintRessource_Click);
            // 
            // buttonPrintDoctorNotice
            // 
            this.buttonPrintDoctorNotice.Location = new System.Drawing.Point(240, 46);
            this.buttonPrintDoctorNotice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPrintDoctorNotice.Name = "buttonPrintDoctorNotice";
            this.buttonPrintDoctorNotice.Size = new System.Drawing.Size(118, 67);
            this.buttonPrintDoctorNotice.TabIndex = 1;
            this.buttonPrintDoctorNotice.Text = "Print Doctor Notice";
            this.buttonPrintDoctorNotice.UseVisualStyleBackColor = true;
            this.buttonPrintDoctorNotice.Click += new System.EventHandler(this.buttonPrintDoctorNotice_Click);
            // 
            // FormPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 185);
            this.Controls.Add(this.buttonPrintDoctorNotice);
            this.Controls.Add(this.buttonPrintRessource);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPrint";
            this.Text = "FormPrint";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPrintRessource;
        private System.Windows.Forms.Button buttonPrintDoctorNotice;
    }
}