﻿namespace AnimalHouseV3
{
    partial class FormBooking
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
            this.textBoxAnimalDoctorInfo = new System.Windows.Forms.TextBox();
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
            this.checkBoxCage = new System.Windows.Forms.CheckBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.comboBoxDaysChoice = new System.Windows.Forms.ComboBox();
            this.labelDays = new System.Windows.Forms.Label();
            this.comboBoxTimeChoice = new System.Windows.Forms.ComboBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonTimeSearch = new System.Windows.Forms.Button();
            this.comboBoxCageChoice = new System.Windows.Forms.ComboBox();
            this.labelCageChoice = new System.Windows.Forms.Label();
            this.buttonBookningSearch = new System.Windows.Forms.Button();
            this.textBoxBookingSearch = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.comboBoxBookningChoice = new System.Windows.Forms.ComboBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.groupBoxFindBookning = new System.Windows.Forms.GroupBox();
            this.groupBoxOwnerInfo.SuspendLayout();
            this.groupBoxAnimalInfo.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxFindBookning.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddOwner
            // 
            this.buttonAddOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOwner.Location = new System.Drawing.Point(12, 41);
            this.buttonAddOwner.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonAddOwner.Name = "buttonAddOwner";
            this.buttonAddOwner.Size = new System.Drawing.Size(50, 48);
            this.buttonAddOwner.TabIndex = 0;
            this.buttonAddOwner.Text = "+";
            this.buttonAddOwner.UseVisualStyleBackColor = true;
            this.buttonAddOwner.Click += new System.EventHandler(this.buttonAddOwner_Click);
            // 
            // buttonAddAnimal
            // 
            this.buttonAddAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAnimal.Location = new System.Drawing.Point(12, 108);
            this.buttonAddAnimal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonAddAnimal.Name = "buttonAddAnimal";
            this.buttonAddAnimal.Size = new System.Drawing.Size(50, 48);
            this.buttonAddAnimal.TabIndex = 1;
            this.buttonAddAnimal.Text = "+";
            this.buttonAddAnimal.UseVisualStyleBackColor = true;
            this.buttonAddAnimal.Click += new System.EventHandler(this.buttonAddAnimal_Click);
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Location = new System.Drawing.Point(76, 50);
            this.labelOwner.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(98, 32);
            this.labelOwner.TabIndex = 2;
            this.labelOwner.Text = "Owner";
            // 
            // lableAnimal
            // 
            this.lableAnimal.AutoSize = true;
            this.lableAnimal.Location = new System.Drawing.Point(76, 118);
            this.lableAnimal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lableAnimal.Name = "lableAnimal";
            this.lableAnimal.Size = new System.Drawing.Size(103, 32);
            this.lableAnimal.TabIndex = 3;
            this.lableAnimal.Text = "Animal";
            // 
            // textBoxOwnerInput
            // 
            this.textBoxOwnerInput.Location = new System.Drawing.Point(188, 50);
            this.textBoxOwnerInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxOwnerInput.Name = "textBoxOwnerInput";
            this.textBoxOwnerInput.Size = new System.Drawing.Size(454, 38);
            this.textBoxOwnerInput.TabIndex = 4;
            // 
            // comboBoxAnimalChoice
            // 
            this.comboBoxAnimalChoice.FormattingEnabled = true;
            this.comboBoxAnimalChoice.Location = new System.Drawing.Point(188, 107);
            this.comboBoxAnimalChoice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxAnimalChoice.Name = "comboBoxAnimalChoice";
            this.comboBoxAnimalChoice.Size = new System.Drawing.Size(454, 39);
            this.comboBoxAnimalChoice.TabIndex = 5;
            this.comboBoxAnimalChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnimalChoice_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(658, 50);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(150, 45);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(528, 169);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(212, 45);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(1640, 23);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(50, 48);
            this.buttonHelp.TabIndex = 8;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // groupBoxOwnerInfo
            // 
            this.groupBoxOwnerInfo.Controls.Add(this.textBoxOwnerCityInfo);
            this.groupBoxOwnerInfo.Controls.Add(this.textBoxOwnerZipInfo);
            this.groupBoxOwnerInfo.Controls.Add(this.textBoxOwnerStreetInfo);
            this.groupBoxOwnerInfo.Controls.Add(this.textBoxOwnerEmailInfo);
            this.groupBoxOwnerInfo.Controls.Add(this.textBoxOwnerPhoneInfo);
            this.groupBoxOwnerInfo.Controls.Add(this.textBoxOwnerNameInfo);
            this.groupBoxOwnerInfo.Location = new System.Drawing.Point(26, 231);
            this.groupBoxOwnerInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxOwnerInfo.Name = "groupBoxOwnerInfo";
            this.groupBoxOwnerInfo.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxOwnerInfo.Size = new System.Drawing.Size(634, 300);
            this.groupBoxOwnerInfo.TabIndex = 9;
            this.groupBoxOwnerInfo.TabStop = false;
            this.groupBoxOwnerInfo.Text = "Owner";
            // 
            // textBoxOwnerCityInfo
            // 
            this.textBoxOwnerCityInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOwnerCityInfo.Location = new System.Drawing.Point(12, 203);
            this.textBoxOwnerCityInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxOwnerCityInfo.Name = "textBoxOwnerCityInfo";
            this.textBoxOwnerCityInfo.ReadOnly = true;
            this.textBoxOwnerCityInfo.Size = new System.Drawing.Size(444, 38);
            this.textBoxOwnerCityInfo.TabIndex = 6;
            // 
            // textBoxOwnerZipInfo
            // 
            this.textBoxOwnerZipInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOwnerZipInfo.Location = new System.Drawing.Point(472, 203);
            this.textBoxOwnerZipInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxOwnerZipInfo.Name = "textBoxOwnerZipInfo";
            this.textBoxOwnerZipInfo.ReadOnly = true;
            this.textBoxOwnerZipInfo.Size = new System.Drawing.Size(146, 38);
            this.textBoxOwnerZipInfo.TabIndex = 5;
            // 
            // textBoxOwnerStreetInfo
            // 
            this.textBoxOwnerStreetInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOwnerStreetInfo.Location = new System.Drawing.Point(12, 149);
            this.textBoxOwnerStreetInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxOwnerStreetInfo.Name = "textBoxOwnerStreetInfo";
            this.textBoxOwnerStreetInfo.ReadOnly = true;
            this.textBoxOwnerStreetInfo.Size = new System.Drawing.Size(606, 38);
            this.textBoxOwnerStreetInfo.TabIndex = 4;
            // 
            // textBoxOwnerEmailInfo
            // 
            this.textBoxOwnerEmailInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOwnerEmailInfo.Location = new System.Drawing.Point(12, 95);
            this.textBoxOwnerEmailInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxOwnerEmailInfo.Name = "textBoxOwnerEmailInfo";
            this.textBoxOwnerEmailInfo.ReadOnly = true;
            this.textBoxOwnerEmailInfo.Size = new System.Drawing.Size(606, 38);
            this.textBoxOwnerEmailInfo.TabIndex = 3;
            // 
            // textBoxOwnerPhoneInfo
            // 
            this.textBoxOwnerPhoneInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOwnerPhoneInfo.Location = new System.Drawing.Point(472, 41);
            this.textBoxOwnerPhoneInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxOwnerPhoneInfo.Name = "textBoxOwnerPhoneInfo";
            this.textBoxOwnerPhoneInfo.ReadOnly = true;
            this.textBoxOwnerPhoneInfo.Size = new System.Drawing.Size(146, 38);
            this.textBoxOwnerPhoneInfo.TabIndex = 2;
            // 
            // textBoxOwnerNameInfo
            // 
            this.textBoxOwnerNameInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOwnerNameInfo.Location = new System.Drawing.Point(12, 41);
            this.textBoxOwnerNameInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxOwnerNameInfo.Name = "textBoxOwnerNameInfo";
            this.textBoxOwnerNameInfo.ReadOnly = true;
            this.textBoxOwnerNameInfo.Size = new System.Drawing.Size(444, 38);
            this.textBoxOwnerNameInfo.TabIndex = 1;
            // 
            // groupBoxAnimalInfo
            // 
            this.groupBoxAnimalInfo.Controls.Add(this.textBoxAnimalDoctorInfo);
            this.groupBoxAnimalInfo.Controls.Add(this.textBoxAnimalChipInfo);
            this.groupBoxAnimalInfo.Controls.Add(this.textBoxAnimalIDInfo);
            this.groupBoxAnimalInfo.Controls.Add(this.textBoxAnimalBDayInfo);
            this.groupBoxAnimalInfo.Controls.Add(this.textBoxAnimalRaceInfo);
            this.groupBoxAnimalInfo.Controls.Add(this.textBoxAnimalGenderInfo);
            this.groupBoxAnimalInfo.Controls.Add(this.textBoxAnimalNameInfo);
            this.groupBoxAnimalInfo.Location = new System.Drawing.Point(26, 542);
            this.groupBoxAnimalInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxAnimalInfo.Name = "groupBoxAnimalInfo";
            this.groupBoxAnimalInfo.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxAnimalInfo.Size = new System.Drawing.Size(634, 300);
            this.groupBoxAnimalInfo.TabIndex = 10;
            this.groupBoxAnimalInfo.TabStop = false;
            this.groupBoxAnimalInfo.Text = "Animal";
            // 
            // textBoxAnimalDoctorInfo
            // 
            this.textBoxAnimalDoctorInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAnimalDoctorInfo.Location = new System.Drawing.Point(12, 203);
            this.textBoxAnimalDoctorInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxAnimalDoctorInfo.Name = "textBoxAnimalDoctorInfo";
            this.textBoxAnimalDoctorInfo.ReadOnly = true;
            this.textBoxAnimalDoctorInfo.Size = new System.Drawing.Size(444, 38);
            this.textBoxAnimalDoctorInfo.TabIndex = 24;
            // 
            // textBoxAnimalChipInfo
            // 
            this.textBoxAnimalChipInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAnimalChipInfo.Location = new System.Drawing.Point(472, 203);
            this.textBoxAnimalChipInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxAnimalChipInfo.Name = "textBoxAnimalChipInfo";
            this.textBoxAnimalChipInfo.ReadOnly = true;
            this.textBoxAnimalChipInfo.Size = new System.Drawing.Size(146, 38);
            this.textBoxAnimalChipInfo.TabIndex = 22;
            // 
            // textBoxAnimalIDInfo
            // 
            this.textBoxAnimalIDInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAnimalIDInfo.Location = new System.Drawing.Point(472, 41);
            this.textBoxAnimalIDInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxAnimalIDInfo.Name = "textBoxAnimalIDInfo";
            this.textBoxAnimalIDInfo.ReadOnly = true;
            this.textBoxAnimalIDInfo.Size = new System.Drawing.Size(146, 38);
            this.textBoxAnimalIDInfo.TabIndex = 23;
            // 
            // textBoxAnimalBDayInfo
            // 
            this.textBoxAnimalBDayInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAnimalBDayInfo.Location = new System.Drawing.Point(12, 149);
            this.textBoxAnimalBDayInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxAnimalBDayInfo.Name = "textBoxAnimalBDayInfo";
            this.textBoxAnimalBDayInfo.ReadOnly = true;
            this.textBoxAnimalBDayInfo.Size = new System.Drawing.Size(606, 38);
            this.textBoxAnimalBDayInfo.TabIndex = 22;
            // 
            // textBoxAnimalRaceInfo
            // 
            this.textBoxAnimalRaceInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAnimalRaceInfo.Location = new System.Drawing.Point(12, 95);
            this.textBoxAnimalRaceInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxAnimalRaceInfo.Name = "textBoxAnimalRaceInfo";
            this.textBoxAnimalRaceInfo.ReadOnly = true;
            this.textBoxAnimalRaceInfo.Size = new System.Drawing.Size(444, 38);
            this.textBoxAnimalRaceInfo.TabIndex = 8;
            // 
            // textBoxAnimalGenderInfo
            // 
            this.textBoxAnimalGenderInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAnimalGenderInfo.Location = new System.Drawing.Point(472, 95);
            this.textBoxAnimalGenderInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxAnimalGenderInfo.Name = "textBoxAnimalGenderInfo";
            this.textBoxAnimalGenderInfo.ReadOnly = true;
            this.textBoxAnimalGenderInfo.Size = new System.Drawing.Size(146, 38);
            this.textBoxAnimalGenderInfo.TabIndex = 7;
            // 
            // textBoxAnimalNameInfo
            // 
            this.textBoxAnimalNameInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAnimalNameInfo.Location = new System.Drawing.Point(12, 41);
            this.textBoxAnimalNameInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxAnimalNameInfo.Name = "textBoxAnimalNameInfo";
            this.textBoxAnimalNameInfo.ReadOnly = true;
            this.textBoxAnimalNameInfo.Size = new System.Drawing.Size(444, 38);
            this.textBoxAnimalNameInfo.TabIndex = 2;
            // 
            // labelTreatments
            // 
            this.labelTreatments.AutoSize = true;
            this.labelTreatments.Location = new System.Drawing.Point(904, 273);
            this.labelTreatments.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTreatments.Name = "labelTreatments";
            this.labelTreatments.Size = new System.Drawing.Size(158, 32);
            this.labelTreatments.TabIndex = 11;
            this.labelTreatments.Text = "Treatments";
            // 
            // comboBoxTreatmentsChoice
            // 
            this.comboBoxTreatmentsChoice.FormattingEnabled = true;
            this.comboBoxTreatmentsChoice.Location = new System.Drawing.Point(1076, 267);
            this.comboBoxTreatmentsChoice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxTreatmentsChoice.Name = "comboBoxTreatmentsChoice";
            this.comboBoxTreatmentsChoice.Size = new System.Drawing.Size(534, 39);
            this.comboBoxTreatmentsChoice.TabIndex = 12;
            this.comboBoxTreatmentsChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxTreatmentsChoice_SelectedIndexChanged);
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Location = new System.Drawing.Point(904, 331);
            this.labelDoctor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(98, 32);
            this.labelDoctor.TabIndex = 13;
            this.labelDoctor.Text = "Doctor";
            // 
            // comboBoxDoctorChoice
            // 
            this.comboBoxDoctorChoice.FormattingEnabled = true;
            this.comboBoxDoctorChoice.Location = new System.Drawing.Point(1076, 326);
            this.comboBoxDoctorChoice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxDoctorChoice.Name = "comboBoxDoctorChoice";
            this.comboBoxDoctorChoice.Size = new System.Drawing.Size(534, 39);
            this.comboBoxDoctorChoice.TabIndex = 14;
            this.comboBoxDoctorChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoctorChoice_SelectedIndexChanged);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(904, 389);
            this.labelDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(75, 32);
            this.labelDate.TabIndex = 15;
            this.labelDate.Text = "Date";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(1076, 384);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(534, 38);
            this.dateTimePickerDate.TabIndex = 16;
            // 
            // checkBoxCage
            // 
            this.checkBoxCage.AutoSize = true;
            this.checkBoxCage.Location = new System.Drawing.Point(1076, 498);
            this.checkBoxCage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxCage.Name = "checkBoxCage";
            this.checkBoxCage.Size = new System.Drawing.Size(121, 36);
            this.checkBoxCage.TabIndex = 18;
            this.checkBoxCage.Text = "Cage";
            this.checkBoxCage.UseVisualStyleBackColor = true;
            this.checkBoxCage.CheckedChanged += new System.EventHandler(this.checkBoxCage_CheckedChanged);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(1464, 699);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(150, 89);
            this.buttonCreate.TabIndex = 19;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Visible = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // comboBoxDaysChoice
            // 
            this.comboBoxDaysChoice.FormattingEnabled = true;
            this.comboBoxDaysChoice.Location = new System.Drawing.Point(1522, 498);
            this.comboBoxDaysChoice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxDaysChoice.Name = "comboBoxDaysChoice";
            this.comboBoxDaysChoice.Size = new System.Drawing.Size(88, 39);
            this.comboBoxDaysChoice.TabIndex = 20;
            this.comboBoxDaysChoice.Visible = false;
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Location = new System.Drawing.Point(1410, 504);
            this.labelDays.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(97, 32);
            this.labelDays.TabIndex = 21;
            this.labelDays.Text = "Day(s)";
            this.labelDays.Visible = false;
            // 
            // comboBoxTimeChoice
            // 
            this.comboBoxTimeChoice.FormattingEnabled = true;
            this.comboBoxTimeChoice.Location = new System.Drawing.Point(1076, 440);
            this.comboBoxTimeChoice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxTimeChoice.Name = "comboBoxTimeChoice";
            this.comboBoxTimeChoice.Size = new System.Drawing.Size(372, 39);
            this.comboBoxTimeChoice.TabIndex = 22;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(904, 446);
            this.labelTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(78, 32);
            this.labelTime.TabIndex = 23;
            this.labelTime.Text = "Time";
            // 
            // buttonTimeSearch
            // 
            this.buttonTimeSearch.Location = new System.Drawing.Point(1464, 440);
            this.buttonTimeSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonTimeSearch.Name = "buttonTimeSearch";
            this.buttonTimeSearch.Size = new System.Drawing.Size(150, 45);
            this.buttonTimeSearch.TabIndex = 24;
            this.buttonTimeSearch.Text = "Search";
            this.buttonTimeSearch.UseVisualStyleBackColor = true;
            this.buttonTimeSearch.Click += new System.EventHandler(this.buttonTimeSearch_Click);
            // 
            // comboBoxCageChoice
            // 
            this.comboBoxCageChoice.FormattingEnabled = true;
            this.comboBoxCageChoice.Location = new System.Drawing.Point(1252, 556);
            this.comboBoxCageChoice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxCageChoice.Name = "comboBoxCageChoice";
            this.comboBoxCageChoice.Size = new System.Drawing.Size(358, 39);
            this.comboBoxCageChoice.TabIndex = 25;
            this.comboBoxCageChoice.Visible = false;
            // 
            // labelCageChoice
            // 
            this.labelCageChoice.AutoSize = true;
            this.labelCageChoice.Location = new System.Drawing.Point(1070, 562);
            this.labelCageChoice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCageChoice.Name = "labelCageChoice";
            this.labelCageChoice.Size = new System.Drawing.Size(172, 32);
            this.labelCageChoice.TabIndex = 26;
            this.labelCageChoice.Text = "Chose Cage";
            this.labelCageChoice.Visible = false;
            // 
            // buttonBookningSearch
            // 
            this.buttonBookningSearch.Location = new System.Drawing.Point(528, 50);
            this.buttonBookningSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonBookningSearch.Name = "buttonBookningSearch";
            this.buttonBookningSearch.Size = new System.Drawing.Size(212, 107);
            this.buttonBookningSearch.TabIndex = 27;
            this.buttonBookningSearch.Text = "Search Bookning";
            this.buttonBookningSearch.UseVisualStyleBackColor = true;
            this.buttonBookningSearch.Click += new System.EventHandler(this.buttonBookningSearch_Click);
            // 
            // textBoxBookingSearch
            // 
            this.textBoxBookingSearch.Location = new System.Drawing.Point(12, 52);
            this.textBoxBookingSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxBookingSearch.Name = "textBoxBookingSearch";
            this.textBoxBookingSearch.Size = new System.Drawing.Size(500, 38);
            this.textBoxBookingSearch.TabIndex = 28;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(1464, 699);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(150, 89);
            this.buttonUpdate.TabIndex = 29;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // comboBoxBookningChoice
            // 
            this.comboBoxBookningChoice.FormattingEnabled = true;
            this.comboBoxBookningChoice.Location = new System.Drawing.Point(12, 107);
            this.comboBoxBookningChoice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxBookningChoice.Name = "comboBoxBookningChoice";
            this.comboBoxBookningChoice.Size = new System.Drawing.Size(500, 39);
            this.comboBoxBookningChoice.TabIndex = 30;
            this.comboBoxBookningChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxBookningChoice_SelectedIndexChanged);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.buttonAddOwner);
            this.groupBoxSearch.Controls.Add(this.buttonAddAnimal);
            this.groupBoxSearch.Controls.Add(this.labelOwner);
            this.groupBoxSearch.Controls.Add(this.lableAnimal);
            this.groupBoxSearch.Controls.Add(this.textBoxOwnerInput);
            this.groupBoxSearch.Controls.Add(this.comboBoxAnimalChoice);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(24, 23);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxSearch.Size = new System.Drawing.Size(838, 174);
            this.groupBoxSearch.TabIndex = 31;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Create Bookning";
            // 
            // groupBoxFindBookning
            // 
            this.groupBoxFindBookning.Controls.Add(this.textBoxBookingSearch);
            this.groupBoxFindBookning.Controls.Add(this.buttonDelete);
            this.groupBoxFindBookning.Controls.Add(this.comboBoxBookningChoice);
            this.groupBoxFindBookning.Controls.Add(this.buttonBookningSearch);
            this.groupBoxFindBookning.Location = new System.Drawing.Point(874, 23);
            this.groupBoxFindBookning.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxFindBookning.Name = "groupBoxFindBookning";
            this.groupBoxFindBookning.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxFindBookning.Size = new System.Drawing.Size(754, 232);
            this.groupBoxFindBookning.TabIndex = 32;
            this.groupBoxFindBookning.TabStop = false;
            this.groupBoxFindBookning.Text = "Find And Edit Bookning";
            // 
            // FormBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1716, 814);
            this.Controls.Add(this.groupBoxFindBookning);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelCageChoice);
            this.Controls.Add(this.comboBoxCageChoice);
            this.Controls.Add(this.buttonTimeSearch);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.comboBoxTimeChoice);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.comboBoxDaysChoice);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.checkBoxCage);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBoxDoctorChoice);
            this.Controls.Add(this.labelDoctor);
            this.Controls.Add(this.comboBoxTreatmentsChoice);
            this.Controls.Add(this.labelTreatments);
            this.Controls.Add(this.groupBoxAnimalInfo);
            this.Controls.Add(this.groupBoxOwnerInfo);
            this.Controls.Add(this.buttonHelp);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormBooking";
            this.Text = "Form_Booking";
            this.groupBoxOwnerInfo.ResumeLayout(false);
            this.groupBoxOwnerInfo.PerformLayout();
            this.groupBoxAnimalInfo.ResumeLayout(false);
            this.groupBoxAnimalInfo.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxFindBookning.ResumeLayout(false);
            this.groupBoxFindBookning.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxAnimalDoctorInfo;
        private System.Windows.Forms.ComboBox comboBoxTimeChoice;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonTimeSearch;
        private System.Windows.Forms.ComboBox comboBoxCageChoice;
        private System.Windows.Forms.Label labelCageChoice;
        private System.Windows.Forms.Button buttonBookningSearch;
        private System.Windows.Forms.TextBox textBoxBookingSearch;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ComboBox comboBoxBookningChoice;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxFindBookning;
    }
}