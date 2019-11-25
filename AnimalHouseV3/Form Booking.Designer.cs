namespace AnimalHouseV3
{
    partial class Form_Booking
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
            this.buttonAddOwner = new System.Windows.Forms.Button();
            this.buttonAddAnimal = new System.Windows.Forms.Button();
            this.labelOwner = new System.Windows.Forms.Label();
            this.lableAnimal = new System.Windows.Forms.Label();
            this.textBoxOwnerInput = new System.Windows.Forms.TextBox();
            this.comboBoxAnimalChoice = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxOwnerInfo = new System.Windows.Forms.GroupBox();
            this.textBoxOwnerCityInfo = new System.Windows.Forms.TextBox();
            this.textBoxOwnerZipInfo = new System.Windows.Forms.TextBox();
            this.textBoxOwnerStreetInfo = new System.Windows.Forms.TextBox();
            this.textBoxOwnerEmailInfo = new System.Windows.Forms.TextBox();
            this.textBoxOwnerPhoneInfo = new System.Windows.Forms.TextBox();
            this.textBoxOwnerNameInfo = new System.Windows.Forms.TextBox();
            this.groupBoxAnimalInfo = new System.Windows.Forms.GroupBox();
            this.textBoxAnimalChipInfo = new System.Windows.Forms.TextBox();
            this.textBoxAnimalIDInfo = new System.Windows.Forms.TextBox();
            this.textBoxAnimalBDayInfo = new System.Windows.Forms.TextBox();
            this.textBoxAnimalRaceInfo = new System.Windows.Forms.TextBox();
            this.textBoxAnimalGenderInfo = new System.Windows.Forms.TextBox();
            this.textBoxAnimalNameInfo = new System.Windows.Forms.TextBox();
            this.labelTreatments = new System.Windows.Forms.Label();
            this.comboBoxTreatmentsChoice = new System.Windows.Forms.ComboBox();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.comboBoxDoctorChoice = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxTimeChoice = new System.Windows.Forms.GroupBox();
            this.checkBoxCage = new System.Windows.Forms.CheckBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.comboBoxDaysChoice = new System.Windows.Forms.ComboBox();
            this.labelDays = new System.Windows.Forms.Label();
            this.groupBoxOwnerInfo.SuspendLayout();
            this.groupBoxAnimalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddOwner
            // 
            this.buttonAddOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOwner.Location = new System.Drawing.Point(13, 13);
            this.buttonAddOwner.Name = "buttonAddOwner";
            this.buttonAddOwner.Size = new System.Drawing.Size(25, 25);
            this.buttonAddOwner.TabIndex = 0;
            this.buttonAddOwner.Text = "+";
            this.buttonAddOwner.UseVisualStyleBackColor = true;
            this.buttonAddOwner.Click += new System.EventHandler(this.buttonAddOwner_Click);
            // 
            // buttonAddAnimal
            // 
            this.buttonAddAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAnimal.Location = new System.Drawing.Point(13, 48);
            this.buttonAddAnimal.Name = "buttonAddAnimal";
            this.buttonAddAnimal.Size = new System.Drawing.Size(25, 25);
            this.buttonAddAnimal.TabIndex = 1;
            this.buttonAddAnimal.Text = "+";
            this.buttonAddAnimal.UseVisualStyleBackColor = true;
            this.buttonAddAnimal.Click += new System.EventHandler(this.buttonAddAnimal_Click);
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Location = new System.Drawing.Point(45, 18);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(49, 17);
            this.labelOwner.TabIndex = 2;
            this.labelOwner.Text = "Owner";
            // 
            // lableAnimal
            // 
            this.lableAnimal.AutoSize = true;
            this.lableAnimal.Location = new System.Drawing.Point(45, 53);
            this.lableAnimal.Name = "lableAnimal";
            this.lableAnimal.Size = new System.Drawing.Size(50, 17);
            this.lableAnimal.TabIndex = 3;
            this.lableAnimal.Text = "Animal";
            // 
            // textBoxOwnerInput
            // 
            this.textBoxOwnerInput.Location = new System.Drawing.Point(101, 18);
            this.textBoxOwnerInput.Name = "textBoxOwnerInput";
            this.textBoxOwnerInput.Size = new System.Drawing.Size(229, 22);
            this.textBoxOwnerInput.TabIndex = 4;
            // 
            // comboBoxAnimalChoice
            // 
            this.comboBoxAnimalChoice.FormattingEnabled = true;
            this.comboBoxAnimalChoice.Location = new System.Drawing.Point(101, 47);
            this.comboBoxAnimalChoice.Name = "comboBoxAnimalChoice";
            this.comboBoxAnimalChoice.Size = new System.Drawing.Size(229, 24);
            this.comboBoxAnimalChoice.TabIndex = 5;
            this.comboBoxAnimalChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnimalChoice_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(336, 18);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(426, 383);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(670, 10);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(25, 25);
            this.buttonHelp.TabIndex = 8;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // groupBoxOwnerInfo
            // 
            this.groupBoxOwnerInfo.Controls.Add(this.textBoxOwnerCityInfo);
            this.groupBoxOwnerInfo.Controls.Add(this.textBoxOwnerZipInfo);
            this.groupBoxOwnerInfo.Controls.Add(this.textBoxOwnerStreetInfo);
            this.groupBoxOwnerInfo.Controls.Add(this.textBoxOwnerEmailInfo);
            this.groupBoxOwnerInfo.Controls.Add(this.textBoxOwnerPhoneInfo);
            this.groupBoxOwnerInfo.Controls.Add(this.textBoxOwnerNameInfo);
            this.groupBoxOwnerInfo.Location = new System.Drawing.Point(13, 90);
            this.groupBoxOwnerInfo.Name = "groupBoxOwnerInfo";
            this.groupBoxOwnerInfo.Size = new System.Drawing.Size(317, 155);
            this.groupBoxOwnerInfo.TabIndex = 9;
            this.groupBoxOwnerInfo.TabStop = false;
            this.groupBoxOwnerInfo.Text = "Owner";
            // 
            // textBoxOwnerCityInfo
            // 
            this.textBoxOwnerCityInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOwnerCityInfo.Location = new System.Drawing.Point(6, 105);
            this.textBoxOwnerCityInfo.Name = "textBoxOwnerCityInfo";
            this.textBoxOwnerCityInfo.ReadOnly = true;
            this.textBoxOwnerCityInfo.Size = new System.Drawing.Size(224, 22);
            this.textBoxOwnerCityInfo.TabIndex = 6;
            // 
            // textBoxOwnerZipInfo
            // 
            this.textBoxOwnerZipInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOwnerZipInfo.Location = new System.Drawing.Point(236, 105);
            this.textBoxOwnerZipInfo.Name = "textBoxOwnerZipInfo";
            this.textBoxOwnerZipInfo.ReadOnly = true;
            this.textBoxOwnerZipInfo.Size = new System.Drawing.Size(75, 22);
            this.textBoxOwnerZipInfo.TabIndex = 5;
            // 
            // textBoxOwnerStreetInfo
            // 
            this.textBoxOwnerStreetInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOwnerStreetInfo.Location = new System.Drawing.Point(6, 77);
            this.textBoxOwnerStreetInfo.Name = "textBoxOwnerStreetInfo";
            this.textBoxOwnerStreetInfo.ReadOnly = true;
            this.textBoxOwnerStreetInfo.Size = new System.Drawing.Size(305, 22);
            this.textBoxOwnerStreetInfo.TabIndex = 4;
            // 
            // textBoxOwnerEmailInfo
            // 
            this.textBoxOwnerEmailInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOwnerEmailInfo.Location = new System.Drawing.Point(6, 49);
            this.textBoxOwnerEmailInfo.Name = "textBoxOwnerEmailInfo";
            this.textBoxOwnerEmailInfo.ReadOnly = true;
            this.textBoxOwnerEmailInfo.Size = new System.Drawing.Size(305, 22);
            this.textBoxOwnerEmailInfo.TabIndex = 3;
            // 
            // textBoxOwnerPhoneInfo
            // 
            this.textBoxOwnerPhoneInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOwnerPhoneInfo.Location = new System.Drawing.Point(236, 21);
            this.textBoxOwnerPhoneInfo.Name = "textBoxOwnerPhoneInfo";
            this.textBoxOwnerPhoneInfo.ReadOnly = true;
            this.textBoxOwnerPhoneInfo.Size = new System.Drawing.Size(75, 22);
            this.textBoxOwnerPhoneInfo.TabIndex = 2;
            // 
            // textBoxOwnerNameInfo
            // 
            this.textBoxOwnerNameInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOwnerNameInfo.Location = new System.Drawing.Point(6, 21);
            this.textBoxOwnerNameInfo.Name = "textBoxOwnerNameInfo";
            this.textBoxOwnerNameInfo.ReadOnly = true;
            this.textBoxOwnerNameInfo.Size = new System.Drawing.Size(224, 22);
            this.textBoxOwnerNameInfo.TabIndex = 1;
            // 
            // groupBoxAnimalInfo
            // 
            this.groupBoxAnimalInfo.Controls.Add(this.textBoxAnimalChipInfo);
            this.groupBoxAnimalInfo.Controls.Add(this.textBoxAnimalIDInfo);
            this.groupBoxAnimalInfo.Controls.Add(this.textBoxAnimalBDayInfo);
            this.groupBoxAnimalInfo.Controls.Add(this.textBoxAnimalRaceInfo);
            this.groupBoxAnimalInfo.Controls.Add(this.textBoxAnimalGenderInfo);
            this.groupBoxAnimalInfo.Controls.Add(this.textBoxAnimalNameInfo);
            this.groupBoxAnimalInfo.Location = new System.Drawing.Point(13, 251);
            this.groupBoxAnimalInfo.Name = "groupBoxAnimalInfo";
            this.groupBoxAnimalInfo.Size = new System.Drawing.Size(317, 155);
            this.groupBoxAnimalInfo.TabIndex = 10;
            this.groupBoxAnimalInfo.TabStop = false;
            this.groupBoxAnimalInfo.Text = "Animal";
            // 
            // textBoxAnimalChipInfo
            // 
            this.textBoxAnimalChipInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAnimalChipInfo.Location = new System.Drawing.Point(236, 105);
            this.textBoxAnimalChipInfo.Name = "textBoxAnimalChipInfo";
            this.textBoxAnimalChipInfo.ReadOnly = true;
            this.textBoxAnimalChipInfo.Size = new System.Drawing.Size(75, 22);
            this.textBoxAnimalChipInfo.TabIndex = 22;
            // 
            // textBoxAnimalIDInfo
            // 
            this.textBoxAnimalIDInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAnimalIDInfo.Location = new System.Drawing.Point(236, 21);
            this.textBoxAnimalIDInfo.Name = "textBoxAnimalIDInfo";
            this.textBoxAnimalIDInfo.ReadOnly = true;
            this.textBoxAnimalIDInfo.Size = new System.Drawing.Size(75, 22);
            this.textBoxAnimalIDInfo.TabIndex = 23;
            // 
            // textBoxAnimalBDayInfo
            // 
            this.textBoxAnimalBDayInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAnimalBDayInfo.Location = new System.Drawing.Point(6, 77);
            this.textBoxAnimalBDayInfo.Name = "textBoxAnimalBDayInfo";
            this.textBoxAnimalBDayInfo.ReadOnly = true;
            this.textBoxAnimalBDayInfo.Size = new System.Drawing.Size(305, 22);
            this.textBoxAnimalBDayInfo.TabIndex = 22;
            // 
            // textBoxAnimalRaceInfo
            // 
            this.textBoxAnimalRaceInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAnimalRaceInfo.Location = new System.Drawing.Point(6, 49);
            this.textBoxAnimalRaceInfo.Name = "textBoxAnimalRaceInfo";
            this.textBoxAnimalRaceInfo.ReadOnly = true;
            this.textBoxAnimalRaceInfo.Size = new System.Drawing.Size(224, 22);
            this.textBoxAnimalRaceInfo.TabIndex = 8;
            // 
            // textBoxAnimalGenderInfo
            // 
            this.textBoxAnimalGenderInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAnimalGenderInfo.Location = new System.Drawing.Point(236, 49);
            this.textBoxAnimalGenderInfo.Name = "textBoxAnimalGenderInfo";
            this.textBoxAnimalGenderInfo.ReadOnly = true;
            this.textBoxAnimalGenderInfo.Size = new System.Drawing.Size(75, 22);
            this.textBoxAnimalGenderInfo.TabIndex = 7;
            // 
            // textBoxAnimalNameInfo
            // 
            this.textBoxAnimalNameInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAnimalNameInfo.Location = new System.Drawing.Point(6, 21);
            this.textBoxAnimalNameInfo.Name = "textBoxAnimalNameInfo";
            this.textBoxAnimalNameInfo.ReadOnly = true;
            this.textBoxAnimalNameInfo.Size = new System.Drawing.Size(224, 22);
            this.textBoxAnimalNameInfo.TabIndex = 2;
            // 
            // labelTreatments
            // 
            this.labelTreatments.AutoSize = true;
            this.labelTreatments.Location = new System.Drawing.Point(340, 90);
            this.labelTreatments.Name = "labelTreatments";
            this.labelTreatments.Size = new System.Drawing.Size(80, 17);
            this.labelTreatments.TabIndex = 11;
            this.labelTreatments.Text = "Treatments";
            // 
            // comboBoxTreatmentsChoice
            // 
            this.comboBoxTreatmentsChoice.FormattingEnabled = true;
            this.comboBoxTreatmentsChoice.Location = new System.Drawing.Point(426, 87);
            this.comboBoxTreatmentsChoice.Name = "comboBoxTreatmentsChoice";
            this.comboBoxTreatmentsChoice.Size = new System.Drawing.Size(269, 24);
            this.comboBoxTreatmentsChoice.TabIndex = 12;
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Location = new System.Drawing.Point(340, 120);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(50, 17);
            this.labelDoctor.TabIndex = 13;
            this.labelDoctor.Text = "Doctor";
            // 
            // comboBoxDoctorChoice
            // 
            this.comboBoxDoctorChoice.FormattingEnabled = true;
            this.comboBoxDoctorChoice.Location = new System.Drawing.Point(426, 117);
            this.comboBoxDoctorChoice.Name = "comboBoxDoctorChoice";
            this.comboBoxDoctorChoice.Size = new System.Drawing.Size(269, 24);
            this.comboBoxDoctorChoice.TabIndex = 14;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(340, 150);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(38, 17);
            this.labelDate.TabIndex = 15;
            this.labelDate.Text = "Date";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(426, 147);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(269, 22);
            this.dateTimePickerDate.TabIndex = 16;
            // 
            // groupBoxTimeChoice
            // 
            this.groupBoxTimeChoice.Location = new System.Drawing.Point(426, 176);
            this.groupBoxTimeChoice.Name = "groupBoxTimeChoice";
            this.groupBoxTimeChoice.Size = new System.Drawing.Size(269, 141);
            this.groupBoxTimeChoice.TabIndex = 17;
            this.groupBoxTimeChoice.TabStop = false;
            this.groupBoxTimeChoice.Text = "Time";
            // 
            // checkBoxCage
            // 
            this.checkBoxCage.AutoSize = true;
            this.checkBoxCage.Location = new System.Drawing.Point(426, 324);
            this.checkBoxCage.Name = "checkBoxCage";
            this.checkBoxCage.Size = new System.Drawing.Size(63, 21);
            this.checkBoxCage.TabIndex = 18;
            this.checkBoxCage.Text = "Cage";
            this.checkBoxCage.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(620, 383);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 19;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // comboBoxDaysChoice
            // 
            this.comboBoxDaysChoice.FormattingEnabled = true;
            this.comboBoxDaysChoice.Location = new System.Drawing.Point(649, 324);
            this.comboBoxDaysChoice.Name = "comboBoxDaysChoice";
            this.comboBoxDaysChoice.Size = new System.Drawing.Size(46, 24);
            this.comboBoxDaysChoice.TabIndex = 20;
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Location = new System.Drawing.Point(593, 327);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(50, 17);
            this.labelDays.TabIndex = 21;
            this.labelDays.Text = "Day(s)";
            // 
            // Form_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 441);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.comboBoxDaysChoice);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.checkBoxCage);
            this.Controls.Add(this.groupBoxTimeChoice);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBoxDoctorChoice);
            this.Controls.Add(this.labelDoctor);
            this.Controls.Add(this.comboBoxTreatmentsChoice);
            this.Controls.Add(this.labelTreatments);
            this.Controls.Add(this.groupBoxAnimalInfo);
            this.Controls.Add(this.groupBoxOwnerInfo);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxAnimalChoice);
            this.Controls.Add(this.textBoxOwnerInput);
            this.Controls.Add(this.lableAnimal);
            this.Controls.Add(this.labelOwner);
            this.Controls.Add(this.buttonAddAnimal);
            this.Controls.Add(this.buttonAddOwner);
            this.Name = "Form_Booking";
            this.Text = "Form_Booking";
            this.groupBoxOwnerInfo.ResumeLayout(false);
            this.groupBoxOwnerInfo.PerformLayout();
            this.groupBoxAnimalInfo.ResumeLayout(false);
            this.groupBoxAnimalInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddOwner;
        private System.Windows.Forms.Button buttonAddAnimal;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.Label lableAnimal;
        private System.Windows.Forms.TextBox textBoxOwnerInput;
        private System.Windows.Forms.ComboBox comboBoxAnimalChoice;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.GroupBox groupBoxOwnerInfo;
        private System.Windows.Forms.GroupBox groupBoxAnimalInfo;
        private System.Windows.Forms.Label labelTreatments;
        private System.Windows.Forms.ComboBox comboBoxTreatmentsChoice;
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.ComboBox comboBoxDoctorChoice;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.GroupBox groupBoxTimeChoice;
        private System.Windows.Forms.CheckBox checkBoxCage;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ComboBox comboBoxDaysChoice;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.TextBox textBoxOwnerCityInfo;
        private System.Windows.Forms.TextBox textBoxOwnerZipInfo;
        private System.Windows.Forms.TextBox textBoxOwnerStreetInfo;
        private System.Windows.Forms.TextBox textBoxOwnerEmailInfo;
        private System.Windows.Forms.TextBox textBoxOwnerPhoneInfo;
        private System.Windows.Forms.TextBox textBoxOwnerNameInfo;
        private System.Windows.Forms.TextBox textBoxAnimalChipInfo;
        private System.Windows.Forms.TextBox textBoxAnimalIDInfo;
        private System.Windows.Forms.TextBox textBoxAnimalBDayInfo;
        private System.Windows.Forms.TextBox textBoxAnimalRaceInfo;
        private System.Windows.Forms.TextBox textBoxAnimalGenderInfo;
        private System.Windows.Forms.TextBox textBoxAnimalNameInfo;
    }
}