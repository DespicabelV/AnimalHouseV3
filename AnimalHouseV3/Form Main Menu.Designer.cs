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
            this.ButtonBooking = new System.Windows.Forms.Button();
            this.ButtonOwner = new System.Windows.Forms.Button();
            this.ButtonAnimal = new System.Windows.Forms.Button();
            this.ButtonSale = new System.Windows.Forms.Button();
            this.ButtonImportMedicin = new System.Windows.Forms.Button();
            this.ButtonPrint = new System.Windows.Forms.Button();
            this.groupBoxPatientLine = new System.Windows.Forms.GroupBox();
            this.buttonStartTest = new System.Windows.Forms.Button();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.buttonClearList = new System.Windows.Forms.Button();
            this.buttonTreatPatient = new System.Windows.Forms.Button();
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatientTreatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDocktor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDoneTreatment = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBoxPatientLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonBooking
            // 
            this.ButtonBooking.Location = new System.Drawing.Point(15, 38);
            this.ButtonBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonBooking.Name = "ButtonBooking";
            this.ButtonBooking.Size = new System.Drawing.Size(129, 48);
            this.ButtonBooking.TabIndex = 0;
            this.ButtonBooking.Text = "Bookning";
            this.ButtonBooking.UseVisualStyleBackColor = true;
            this.ButtonBooking.Click += new System.EventHandler(this.ButtonBookning_Click);
            // 
            // ButtonOwner
            // 
            this.ButtonOwner.Location = new System.Drawing.Point(15, 111);
            this.ButtonOwner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonOwner.Name = "ButtonOwner";
            this.ButtonOwner.Size = new System.Drawing.Size(129, 48);
            this.ButtonOwner.TabIndex = 1;
            this.ButtonOwner.Text = "Owner";
            this.ButtonOwner.UseVisualStyleBackColor = true;
            this.ButtonOwner.Click += new System.EventHandler(this.ButtonOwner_Click);
            // 
            // ButtonAnimal
            // 
            this.ButtonAnimal.Location = new System.Drawing.Point(15, 180);
            this.ButtonAnimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAnimal.Name = "ButtonAnimal";
            this.ButtonAnimal.Size = new System.Drawing.Size(129, 48);
            this.ButtonAnimal.TabIndex = 3;
            this.ButtonAnimal.Text = "Animal";
            this.ButtonAnimal.UseVisualStyleBackColor = true;
            this.ButtonAnimal.Click += new System.EventHandler(this.ButtonAnimal_Click);
            // 
            // ButtonSale
            // 
            this.ButtonSale.Location = new System.Drawing.Point(15, 246);
            this.ButtonSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSale.Name = "ButtonSale";
            this.ButtonSale.Size = new System.Drawing.Size(129, 48);
            this.ButtonSale.TabIndex = 2;
            this.ButtonSale.Text = "Sale";
            this.ButtonSale.UseVisualStyleBackColor = true;
            this.ButtonSale.Click += new System.EventHandler(this.ButtonSale_Click);
            // 
            // ButtonImportMedicin
            // 
            this.ButtonImportMedicin.Location = new System.Drawing.Point(15, 475);
            this.ButtonImportMedicin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonImportMedicin.Name = "ButtonImportMedicin";
            this.ButtonImportMedicin.Size = new System.Drawing.Size(129, 48);
            this.ButtonImportMedicin.TabIndex = 4;
            this.ButtonImportMedicin.Text = "Import Medicin";
            this.ButtonImportMedicin.UseVisualStyleBackColor = true;
            this.ButtonImportMedicin.Click += new System.EventHandler(this.ImportMedicin_Click);
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.Location = new System.Drawing.Point(175, 475);
            this.ButtonPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(129, 48);
            this.ButtonPrint.TabIndex = 5;
            this.ButtonPrint.Text = "Print";
            this.ButtonPrint.UseVisualStyleBackColor = true;
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // groupBoxPatientLine
            // 
            this.groupBoxPatientLine.Controls.Add(this.buttonStartTest);
            this.groupBoxPatientLine.Controls.Add(this.richTextBoxInfo);
            this.groupBoxPatientLine.Controls.Add(this.buttonClearList);
            this.groupBoxPatientLine.Controls.Add(this.buttonTreatPatient);
            this.groupBoxPatientLine.Controls.Add(this.buttonAddPatient);
            this.groupBoxPatientLine.Controls.Add(this.dataGridViewPatients);
            this.groupBoxPatientLine.Location = new System.Drawing.Point(310, 12);
            this.groupBoxPatientLine.Name = "groupBoxPatientLine";
            this.groupBoxPatientLine.Size = new System.Drawing.Size(780, 580);
            this.groupBoxPatientLine.TabIndex = 6;
            this.groupBoxPatientLine.TabStop = false;
            this.groupBoxPatientLine.Text = "Patien Line Test";
            // 
            // buttonStartTest
            // 
            this.buttonStartTest.Location = new System.Drawing.Point(645, 370);
            this.buttonStartTest.Name = "buttonStartTest";
            this.buttonStartTest.Size = new System.Drawing.Size(129, 48);
            this.buttonStartTest.TabIndex = 7;
            this.buttonStartTest.Text = "Start patient line test";
            this.buttonStartTest.UseVisualStyleBackColor = true;
            this.buttonStartTest.Click += new System.EventHandler(this.buttonStartTest_Click);
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Location = new System.Drawing.Point(7, 425);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(482, 149);
            this.richTextBoxInfo.TabIndex = 4;
            this.richTextBoxInfo.Text = "";
            // 
            // buttonClearList
            // 
            this.buttonClearList.Location = new System.Drawing.Point(360, 370);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.Size = new System.Drawing.Size(129, 48);
            this.buttonClearList.TabIndex = 3;
            this.buttonClearList.Text = "Clear List";
            this.buttonClearList.UseVisualStyleBackColor = true;
            this.buttonClearList.Click += new System.EventHandler(this.buttonClearList_Click);
            // 
            // buttonTreatPatient
            // 
            this.buttonTreatPatient.Location = new System.Drawing.Point(185, 370);
            this.buttonTreatPatient.Name = "buttonTreatPatient";
            this.buttonTreatPatient.Size = new System.Drawing.Size(129, 48);
            this.buttonTreatPatient.TabIndex = 2;
            this.buttonTreatPatient.Text = "Treatment";
            this.buttonTreatPatient.UseVisualStyleBackColor = true;
            this.buttonTreatPatient.Click += new System.EventHandler(this.buttonTreatPatient_Click);
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.Location = new System.Drawing.Point(5, 370);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(129, 48);
            this.buttonAddPatient.TabIndex = 1;
            this.buttonAddPatient.Text = "Add Patient";
            this.buttonAddPatient.UseVisualStyleBackColor = true;
            this.buttonAddPatient.Click += new System.EventHandler(this.buttonAddPatient_Click);
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.ColumnPatientName,
            this.ColumnPatientTreatment,
            this.ColumnDocktor,
            this.ColumnTime,
            this.ColumnDoneTreatment});
            this.dataGridViewPatients.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.RowHeadersVisible = false;
            this.dataGridViewPatients.RowHeadersWidth = 51;
            this.dataGridViewPatients.RowTemplate.Height = 24;
            this.dataGridViewPatients.Size = new System.Drawing.Size(768, 329);
            this.dataGridViewPatients.TabIndex = 0;
            // 
            // Check
            // 
            this.Check.HeaderText = "X";
            this.Check.MinimumWidth = 6;
            this.Check.Name = "Check";
            this.Check.Width = 25;
            // 
            // ColumnPatientName
            // 
            this.ColumnPatientName.HeaderText = "Patient Name";
            this.ColumnPatientName.MinimumWidth = 6;
            this.ColumnPatientName.Name = "ColumnPatientName";
            this.ColumnPatientName.ReadOnly = true;
            this.ColumnPatientName.Width = 125;
            // 
            // ColumnPatientTreatment
            // 
            this.ColumnPatientTreatment.HeaderText = "Treatment";
            this.ColumnPatientTreatment.MinimumWidth = 6;
            this.ColumnPatientTreatment.Name = "ColumnPatientTreatment";
            this.ColumnPatientTreatment.ReadOnly = true;
            this.ColumnPatientTreatment.Width = 125;
            // 
            // ColumnDocktor
            // 
            this.ColumnDocktor.HeaderText = "Docktor";
            this.ColumnDocktor.MinimumWidth = 6;
            this.ColumnDocktor.Name = "ColumnDocktor";
            this.ColumnDocktor.ReadOnly = true;
            this.ColumnDocktor.Width = 125;
            // 
            // ColumnTime
            // 
            this.ColumnTime.HeaderText = "Time";
            this.ColumnTime.MinimumWidth = 6;
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            this.ColumnTime.Width = 125;
            // 
            // ColumnDoneTreatment
            // 
            this.ColumnDoneTreatment.HeaderText = "Done";
            this.ColumnDoneTreatment.MinimumWidth = 6;
            this.ColumnDoneTreatment.Name = "ColumnDoneTreatment";
            this.ColumnDoneTreatment.ReadOnly = true;
            this.ColumnDoneTreatment.Width = 50;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 604);
            this.Controls.Add(this.groupBoxPatientLine);
            this.Controls.Add(this.ButtonPrint);
            this.Controls.Add(this.ButtonImportMedicin);
            this.Controls.Add(this.ButtonAnimal);
            this.Controls.Add(this.ButtonSale);
            this.Controls.Add(this.ButtonOwner);
            this.Controls.Add(this.ButtonBooking);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.groupBoxPatientLine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonBooking;
        private System.Windows.Forms.Button ButtonOwner;
        private System.Windows.Forms.Button ButtonAnimal;
        private System.Windows.Forms.Button ButtonSale;
        private System.Windows.Forms.Button ButtonImportMedicin;
        private System.Windows.Forms.Button ButtonPrint;
        private System.Windows.Forms.GroupBox groupBoxPatientLine;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.Button buttonClearList;
        private System.Windows.Forms.Button buttonTreatPatient;
        private System.Windows.Forms.Button buttonAddPatient;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPatientTreatment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDocktor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnDoneTreatment;
        private System.Windows.Forms.Button buttonStartTest;
    }
}

