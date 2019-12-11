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
            this.buttonPrintRessource.Location = new System.Drawing.Point(117, 153);
            this.buttonPrintRessource.Name = "buttonPrintRessource";
            this.buttonPrintRessource.Size = new System.Drawing.Size(237, 80);
            this.buttonPrintRessource.TabIndex = 0;
            this.buttonPrintRessource.Text = "Print Ressource";
            this.buttonPrintRessource.UseVisualStyleBackColor = true;
            // 
            // buttonPrintDoctorNotice
            // 
            this.buttonPrintDoctorNotice.Location = new System.Drawing.Point(117, 344);
            this.buttonPrintDoctorNotice.Name = "buttonPrintDoctorNotice";
            this.buttonPrintDoctorNotice.Size = new System.Drawing.Size(237, 80);
            this.buttonPrintDoctorNotice.TabIndex = 1;
            this.buttonPrintDoctorNotice.Text = "Print Doctor Notice";
            this.buttonPrintDoctorNotice.UseVisualStyleBackColor = true;
            // 
            // FormPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1717, 987);
            this.Controls.Add(this.buttonPrintDoctorNotice);
            this.Controls.Add(this.buttonPrintRessource);
            this.Name = "FormPrint";
            this.Text = "FormPrint";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPrintRessource;
        private System.Windows.Forms.Button buttonPrintDoctorNotice;
    }
}