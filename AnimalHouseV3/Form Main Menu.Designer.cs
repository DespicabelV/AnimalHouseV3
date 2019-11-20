namespace AnimalHouseV3
{
    partial class MainMenu
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
            this.BtnBookning = new System.Windows.Forms.Button();
            this.BtnEjer = new System.Windows.Forms.Button();
            this.BtnDyr = new System.Windows.Forms.Button();
            this.BtnSalg = new System.Windows.Forms.Button();
            this.BtnIndlæsMedicin = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBookning
            // 
            this.BtnBookning.Location = new System.Drawing.Point(11, 31);
            this.BtnBookning.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnBookning.Name = "BtnBookning";
            this.BtnBookning.Size = new System.Drawing.Size(97, 39);
            this.BtnBookning.TabIndex = 0;
            this.BtnBookning.Text = "Bookning";
            this.BtnBookning.UseVisualStyleBackColor = true;
            this.BtnBookning.Click += new System.EventHandler(this.BtnBookning_Click);
            // 
            // BtnEjer
            // 
            this.BtnEjer.Location = new System.Drawing.Point(11, 90);
            this.BtnEjer.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEjer.Name = "BtnEjer";
            this.BtnEjer.Size = new System.Drawing.Size(97, 39);
            this.BtnEjer.TabIndex = 1;
            this.BtnEjer.Text = "Owner";
            this.BtnEjer.UseVisualStyleBackColor = true;
            this.BtnEjer.Click += new System.EventHandler(this.BtnEjer_Click);
            // 
            // BtnDyr
            // 
            this.BtnDyr.Location = new System.Drawing.Point(11, 146);
            this.BtnDyr.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDyr.Name = "BtnDyr";
            this.BtnDyr.Size = new System.Drawing.Size(97, 39);
            this.BtnDyr.TabIndex = 3;
            this.BtnDyr.Text = "Animal";
            this.BtnDyr.UseVisualStyleBackColor = true;
            this.BtnDyr.Click += new System.EventHandler(this.BtnDyr_Click);
            // 
            // BtnSalg
            // 
            this.BtnSalg.Location = new System.Drawing.Point(11, 200);
            this.BtnSalg.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalg.Name = "BtnSalg";
            this.BtnSalg.Size = new System.Drawing.Size(97, 39);
            this.BtnSalg.TabIndex = 2;
            this.BtnSalg.Text = "Sale";
            this.BtnSalg.UseVisualStyleBackColor = true;
            this.BtnSalg.Click += new System.EventHandler(this.BtnSalg_Click);
            // 
            // BtnIndlæsMedicin
            // 
            this.BtnIndlæsMedicin.Location = new System.Drawing.Point(11, 386);
            this.BtnIndlæsMedicin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnIndlæsMedicin.Name = "BtnIndlæsMedicin";
            this.BtnIndlæsMedicin.Size = new System.Drawing.Size(97, 39);
            this.BtnIndlæsMedicin.TabIndex = 4;
            this.BtnIndlæsMedicin.Text = "Import Medicin";
            this.BtnIndlæsMedicin.UseVisualStyleBackColor = true;
            this.BtnIndlæsMedicin.Click += new System.EventHandler(this.BtnIndlæsMedicin_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(131, 386);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(97, 39);
            this.BtnPrint.TabIndex = 5;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 491);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnIndlæsMedicin);
            this.Controls.Add(this.BtnDyr);
            this.Controls.Add(this.BtnSalg);
            this.Controls.Add(this.BtnEjer);
            this.Controls.Add(this.BtnBookning);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBookning;
        private System.Windows.Forms.Button BtnEjer;
        private System.Windows.Forms.Button BtnDyr;
        private System.Windows.Forms.Button BtnSalg;
        private System.Windows.Forms.Button BtnIndlæsMedicin;
        private System.Windows.Forms.Button BtnPrint;
    }
}

