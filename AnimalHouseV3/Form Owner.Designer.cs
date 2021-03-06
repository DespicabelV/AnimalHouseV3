﻿namespace AnimalHouseV3
{
    partial class Form_Owner
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.TextBoxTelephoneNR = new System.Windows.Forms.TextBox();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.TextBoxStreet = new System.Windows.Forms.TextBox();
            this.TextBoxZipCode = new System.Windows.Forms.TextBox();
            this.TextBoxCity = new System.Windows.Forms.TextBox();
            this.ButtonSearchOwner = new System.Windows.Forms.Button();
            this.ButtonCreateOwner = new System.Windows.Forms.Button();
            this.ButtonUpdateOwner = new System.Windows.Forms.Button();
            this.ButtonDeleteOwner = new System.Windows.Forms.Button();
            this.ButtonAddPet = new System.Windows.Forms.Button();
            this.PrivateCheck = new System.Windows.Forms.CheckBox();
            this.BusinessCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxNr = new System.Windows.Forms.TextBox();
            this.TextBoxFloor = new System.Windows.Forms.TextBox();
            this.ButtonHelpOwner = new System.Windows.Forms.Button();
            this.labelCVRNR = new System.Windows.Forms.Label();
            this.TextBoxCVRNR = new System.Windows.Forms.TextBox();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.TextBoxCompanyName = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dyrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalhousev3DataSet = new AnimalHouseV3.Animalhousev3DataSet();
            this.ApartmentCheck = new System.Windows.Forms.CheckBox();
            this.dyrTableAdapter = new AnimalHouseV3.Animalhousev3DataSetTableAdapters.DyrTableAdapter();
            this.dataGridViewOwnerDyr = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dyrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalhousev3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwnerDyr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telephone Nr:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 455);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 554);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Street:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(848, 591);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 32);
            this.label10.TabIndex = 9;
            this.label10.Text = "Zip-Code:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(848, 498);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 32);
            this.label11.TabIndex = 10;
            this.label11.Text = "City:";
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(232, 85);
            this.TextBoxFirstName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(384, 38);
            this.TextBoxFirstName.TabIndex = 11;
            // 
            // TextBoxTelephoneNR
            // 
            this.TextBoxTelephoneNR.Location = new System.Drawing.Point(228, 213);
            this.TextBoxTelephoneNR.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxTelephoneNR.Name = "TextBoxTelephoneNR";
            this.TextBoxTelephoneNR.Size = new System.Drawing.Size(388, 38);
            this.TextBoxTelephoneNR.TabIndex = 12;
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Location = new System.Drawing.Point(232, 149);
            this.TextBoxLastName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(384, 38);
            this.TextBoxLastName.TabIndex = 13;
            // 
            // TextBoxStreet
            // 
            this.TextBoxStreet.Location = new System.Drawing.Point(126, 544);
            this.TextBoxStreet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxStreet.Name = "TextBoxStreet";
            this.TextBoxStreet.Size = new System.Drawing.Size(426, 38);
            this.TextBoxStreet.TabIndex = 17;
            // 
            // TextBoxZipCode
            // 
            this.TextBoxZipCode.Location = new System.Drawing.Point(1000, 585);
            this.TextBoxZipCode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxZipCode.Name = "TextBoxZipCode";
            this.TextBoxZipCode.Size = new System.Drawing.Size(120, 38);
            this.TextBoxZipCode.TabIndex = 18;
            // 
            // TextBoxCity
            // 
            this.TextBoxCity.Location = new System.Drawing.Point(924, 492);
            this.TextBoxCity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxCity.Name = "TextBoxCity";
            this.TextBoxCity.Size = new System.Drawing.Size(196, 38);
            this.TextBoxCity.TabIndex = 21;
            // 
            // ButtonSearchOwner
            // 
            this.ButtonSearchOwner.Location = new System.Drawing.Point(470, 287);
            this.ButtonSearchOwner.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonSearchOwner.Name = "ButtonSearchOwner";
            this.ButtonSearchOwner.Size = new System.Drawing.Size(150, 70);
            this.ButtonSearchOwner.TabIndex = 23;
            this.ButtonSearchOwner.Text = "Search";
            this.ButtonSearchOwner.UseVisualStyleBackColor = true;
            this.ButtonSearchOwner.Click += new System.EventHandler(this.ButtonSearchOwner_Click);
            // 
            // ButtonCreateOwner
            // 
            this.ButtonCreateOwner.Location = new System.Drawing.Point(206, 39);
            this.ButtonCreateOwner.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonCreateOwner.Name = "ButtonCreateOwner";
            this.ButtonCreateOwner.Size = new System.Drawing.Size(212, 97);
            this.ButtonCreateOwner.TabIndex = 24;
            this.ButtonCreateOwner.Text = "Create";
            this.ButtonCreateOwner.UseVisualStyleBackColor = true;
            this.ButtonCreateOwner.Click += new System.EventHandler(this.ButtonCreateOwner_Click);
            // 
            // ButtonUpdateOwner
            // 
            this.ButtonUpdateOwner.Location = new System.Drawing.Point(206, 147);
            this.ButtonUpdateOwner.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonUpdateOwner.Name = "ButtonUpdateOwner";
            this.ButtonUpdateOwner.Size = new System.Drawing.Size(212, 91);
            this.ButtonUpdateOwner.TabIndex = 25;
            this.ButtonUpdateOwner.Text = "Update";
            this.ButtonUpdateOwner.UseVisualStyleBackColor = true;
            this.ButtonUpdateOwner.Click += new System.EventHandler(this.ButtonUpdateOwner_Click);
            // 
            // ButtonDeleteOwner
            // 
            this.ButtonDeleteOwner.Location = new System.Drawing.Point(206, 250);
            this.ButtonDeleteOwner.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonDeleteOwner.Name = "ButtonDeleteOwner";
            this.ButtonDeleteOwner.Size = new System.Drawing.Size(212, 91);
            this.ButtonDeleteOwner.TabIndex = 26;
            this.ButtonDeleteOwner.Text = "Delete";
            this.ButtonDeleteOwner.UseVisualStyleBackColor = true;
            this.ButtonDeleteOwner.Click += new System.EventHandler(this.ButtonDeleteOwner_Click);
            // 
            // ButtonAddPet
            // 
            this.ButtonAddPet.Location = new System.Drawing.Point(702, 1013);
            this.ButtonAddPet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonAddPet.Name = "ButtonAddPet";
            this.ButtonAddPet.Size = new System.Drawing.Size(192, 79);
            this.ButtonAddPet.TabIndex = 27;
            this.ButtonAddPet.Text = "Add Pet";
            this.ButtonAddPet.UseVisualStyleBackColor = true;
            this.ButtonAddPet.Click += new System.EventHandler(this.ButtonAddPet_Click);
            // 
            // PrivateCheck
            // 
            this.PrivateCheck.AutoSize = true;
            this.PrivateCheck.Checked = true;
            this.PrivateCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PrivateCheck.Location = new System.Drawing.Point(18, 287);
            this.PrivateCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PrivateCheck.Name = "PrivateCheck";
            this.PrivateCheck.Size = new System.Drawing.Size(142, 36);
            this.PrivateCheck.TabIndex = 28;
            this.PrivateCheck.Text = "Private";
            this.PrivateCheck.UseVisualStyleBackColor = true;
            this.PrivateCheck.CheckedChanged += new System.EventHandler(this.PrivateCheck_CheckedChanged);
            // 
            // BusinessCheck
            // 
            this.BusinessCheck.AutoSize = true;
            this.BusinessCheck.Location = new System.Drawing.Point(178, 287);
            this.BusinessCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BusinessCheck.Name = "BusinessCheck";
            this.BusinessCheck.Size = new System.Drawing.Size(169, 36);
            this.BusinessCheck.TabIndex = 29;
            this.BusinessCheck.Text = "Business";
            this.BusinessCheck.UseVisualStyleBackColor = true;
            this.BusinessCheck.CheckedChanged += new System.EventHandler(this.BusinessCheck_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 504);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 32);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nr:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(602, 591);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 32);
            this.label5.TabIndex = 31;
            this.label5.Text = "Floor:";
            // 
            // TextBoxNr
            // 
            this.TextBoxNr.Location = new System.Drawing.Point(702, 498);
            this.TextBoxNr.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxNr.Name = "TextBoxNr";
            this.TextBoxNr.Size = new System.Drawing.Size(70, 38);
            this.TextBoxNr.TabIndex = 32;
            this.TextBoxNr.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // TextBoxFloor
            // 
            this.TextBoxFloor.AcceptsReturn = true;
            this.TextBoxFloor.Location = new System.Drawing.Point(702, 591);
            this.TextBoxFloor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxFloor.Name = "TextBoxFloor";
            this.TextBoxFloor.Size = new System.Drawing.Size(70, 38);
            this.TextBoxFloor.TabIndex = 33;
            this.TextBoxFloor.Visible = false;
            // 
            // ButtonHelpOwner
            // 
            this.ButtonHelpOwner.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonHelpOwner.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHelpOwner.Location = new System.Drawing.Point(1674, 23);
            this.ButtonHelpOwner.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonHelpOwner.Name = "ButtonHelpOwner";
            this.ButtonHelpOwner.Size = new System.Drawing.Size(46, 54);
            this.ButtonHelpOwner.TabIndex = 34;
            this.ButtonHelpOwner.Text = "?";
            this.ButtonHelpOwner.UseVisualStyleBackColor = false;
            this.ButtonHelpOwner.Click += new System.EventHandler(this.ButtonHelpOwner_Click);
            // 
            // labelCVRNR
            // 
            this.labelCVRNR.AutoSize = true;
            this.labelCVRNR.Location = new System.Drawing.Point(1150, 110);
            this.labelCVRNR.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCVRNR.Name = "labelCVRNR";
            this.labelCVRNR.Size = new System.Drawing.Size(122, 32);
            this.labelCVRNR.TabIndex = 35;
            this.labelCVRNR.Text = "CVRNR:";
            this.labelCVRNR.Visible = false;
            // 
            // TextBoxCVRNR
            // 
            this.TextBoxCVRNR.Location = new System.Drawing.Point(1282, 101);
            this.TextBoxCVRNR.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxCVRNR.Name = "TextBoxCVRNR";
            this.TextBoxCVRNR.Size = new System.Drawing.Size(196, 38);
            this.TextBoxCVRNR.TabIndex = 36;
            this.TextBoxCVRNR.Visible = false;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(1046, 217);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(226, 32);
            this.labelCompanyName.TabIndex = 37;
            this.labelCompanyName.Text = "Company Name:";
            this.labelCompanyName.Visible = false;
            // 
            // TextBoxCompanyName
            // 
            this.TextBoxCompanyName.Location = new System.Drawing.Point(1282, 219);
            this.TextBoxCompanyName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxCompanyName.Name = "TextBoxCompanyName";
            this.TextBoxCompanyName.Size = new System.Drawing.Size(196, 38);
            this.TextBoxCompanyName.TabIndex = 38;
            this.TextBoxCompanyName.Visible = false;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(126, 450);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(426, 38);
            this.TextBoxEmail.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonDeleteOwner);
            this.groupBox1.Controls.Add(this.ButtonUpdateOwner);
            this.groupBox1.Controls.Add(this.ButtonCreateOwner);
            this.groupBox1.Location = new System.Drawing.Point(1282, 758);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(454, 362);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            // 
            // dyrBindingSource
            // 
            this.dyrBindingSource.DataMember = "Dyr";
            this.dyrBindingSource.DataSource = this.animalhousev3DataSet;
            // 
            // animalhousev3DataSet
            // 
            this.animalhousev3DataSet.DataSetName = "Animalhousev3DataSet";
            this.animalhousev3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ApartmentCheck
            // 
            this.ApartmentCheck.AutoSize = true;
            this.ApartmentCheck.Location = new System.Drawing.Point(358, 601);
            this.ApartmentCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ApartmentCheck.Name = "ApartmentCheck";
            this.ApartmentCheck.Size = new System.Drawing.Size(184, 36);
            this.ApartmentCheck.TabIndex = 41;
            this.ApartmentCheck.Text = "Apartment";
            this.ApartmentCheck.UseVisualStyleBackColor = true;
            this.ApartmentCheck.CheckedChanged += new System.EventHandler(this.ApartmentCheck_CheckChanged);
            // 
            // dyrTableAdapter
            // 
            this.dyrTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewOwnerDyr
            // 
            this.dataGridViewOwnerDyr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOwnerDyr.Location = new System.Drawing.Point(76, 775);
            this.dataGridViewOwnerDyr.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridViewOwnerDyr.Name = "dataGridViewOwnerDyr";
            this.dataGridViewOwnerDyr.RowHeadersWidth = 51;
            this.dataGridViewOwnerDyr.Size = new System.Drawing.Size(480, 291);
            this.dataGridViewOwnerDyr.TabIndex = 42;
            // 
            // Form_Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1744, 1137);
            this.Controls.Add(this.dataGridViewOwnerDyr);
            this.Controls.Add(this.ApartmentCheck);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextBoxCompanyName);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.TextBoxCVRNR);
            this.Controls.Add(this.labelCVRNR);
            this.Controls.Add(this.ButtonHelpOwner);
            this.Controls.Add(this.TextBoxFloor);
            this.Controls.Add(this.TextBoxNr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BusinessCheck);
            this.Controls.Add(this.PrivateCheck);
            this.Controls.Add(this.ButtonAddPet);
            this.Controls.Add(this.ButtonSearchOwner);
            this.Controls.Add(this.TextBoxCity);
            this.Controls.Add(this.TextBoxZipCode);
            this.Controls.Add(this.TextBoxStreet);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxLastName);
            this.Controls.Add(this.TextBoxTelephoneNR);
            this.Controls.Add(this.TextBoxFirstName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form_Owner";
            this.Text = "Form_Owner";
            this.Load += new System.EventHandler(this.Form_Owner_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dyrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalhousev3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwnerDyr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.TextBox TextBoxTelephoneNR;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.TextBox TextBoxStreet;
        private System.Windows.Forms.TextBox TextBoxZipCode;
        private System.Windows.Forms.TextBox TextBoxCity;
        private System.Windows.Forms.Button ButtonSearchOwner;
        private System.Windows.Forms.Button ButtonCreateOwner;
        private System.Windows.Forms.Button ButtonUpdateOwner;
        private System.Windows.Forms.Button ButtonDeleteOwner;
        private System.Windows.Forms.Button ButtonAddPet;
        private System.Windows.Forms.CheckBox PrivateCheck;
        private System.Windows.Forms.CheckBox BusinessCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxNr;
        private System.Windows.Forms.TextBox TextBoxFloor;
        private System.Windows.Forms.Button ButtonHelpOwner;
        private System.Windows.Forms.Label labelCVRNR;
        private System.Windows.Forms.TextBox TextBoxCVRNR;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox TextBoxCompanyName;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ApartmentCheck;
        private Animalhousev3DataSet animalhousev3DataSet;
        private System.Windows.Forms.BindingSource dyrBindingSource;
        private Animalhousev3DataSetTableAdapters.DyrTableAdapter dyrTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewOwnerDyr;
    }
}