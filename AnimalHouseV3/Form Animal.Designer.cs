namespace AnimalHouseV3
{
    partial class Form_Animal
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextAnimalName = new System.Windows.Forms.TextBox();
            this.TextOwnerPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextAnimal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckBoxMale = new System.Windows.Forms.CheckBox();
            this.CheckBoxFemale = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxAnimalChip = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAnimalUploadPic = new System.Windows.Forms.Button();
            this.PictureBoxAnimal = new System.Windows.Forms.PictureBox();
            this.btnAnimalCreate = new System.Windows.Forms.Button();
            this.btnAnimalDelete = new System.Windows.Forms.Button();
            this.btnAnimalUpdate = new System.Windows.Forms.Button();
            this.CheckOwnerRight = new System.Windows.Forms.CheckBox();
            this.CheckOwnerWrong = new System.Windows.Forms.CheckBox();
            this.TextBoxJournal = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AnimalBirthCalender = new System.Windows.Forms.DateTimePicker();
            this.TextBoxAnimalNr = new System.Windows.Forms.TextBox();
            this.DoctorComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TextJournalTitle = new System.Windows.Forms.TextBox();
            this.JournalCalender = new System.Windows.Forms.DateTimePicker();
            this.btnJournal = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupboxFillin = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowJournal = new System.Windows.Forms.Button();
            this.ButtonCheckOwner_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // TextAnimalName
            // 
            this.TextAnimalName.Location = new System.Drawing.Point(100, 39);
            this.TextAnimalName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextAnimalName.Name = "TextAnimalName";
            this.TextAnimalName.Size = new System.Drawing.Size(201, 22);
            this.TextAnimalName.TabIndex = 1;
            // 
            // TextOwnerPhone
            // 
            this.TextOwnerPhone.Location = new System.Drawing.Point(595, 42);
            this.TextOwnerPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextOwnerPhone.Name = "TextOwnerPhone";
            this.TextOwnerPhone.Size = new System.Drawing.Size(201, 22);
            this.TextOwnerPhone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Owner:";
            // 
            // TextAnimal
            // 
            this.TextAnimal.Location = new System.Drawing.Point(100, 76);
            this.TextAnimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextAnimal.Name = "TextAnimal";
            this.TextAnimal.Size = new System.Drawing.Size(201, 22);
            this.TextAnimal.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Animal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birthday:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender:";
            // 
            // CheckBoxMale
            // 
            this.CheckBoxMale.AutoSize = true;
            this.CheckBoxMale.Location = new System.Drawing.Point(100, 113);
            this.CheckBoxMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBoxMale.Name = "CheckBoxMale";
            this.CheckBoxMale.Size = new System.Drawing.Size(60, 21);
            this.CheckBoxMale.TabIndex = 9;
            this.CheckBoxMale.Text = "Male";
            this.CheckBoxMale.UseVisualStyleBackColor = true;
            this.CheckBoxMale.CheckedChanged += new System.EventHandler(this.CheckBoxMale_CheckedChanged);
            // 
            // CheckBoxFemale
            // 
            this.CheckBoxFemale.AutoSize = true;
            this.CheckBoxFemale.Location = new System.Drawing.Point(192, 113);
            this.CheckBoxFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBoxFemale.Name = "CheckBoxFemale";
            this.CheckBoxFemale.Size = new System.Drawing.Size(76, 21);
            this.CheckBoxFemale.TabIndex = 10;
            this.CheckBoxFemale.Text = "Female";
            this.CheckBoxFemale.UseVisualStyleBackColor = true;
            this.CheckBoxFemale.CheckedChanged += new System.EventHandler(this.CheckBoxFemale_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Animal Nr:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Doctor:";
            // 
            // TextBoxAnimalChip
            // 
            this.TextBoxAnimalChip.Location = new System.Drawing.Point(100, 236);
            this.TextBoxAnimalChip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxAnimalChip.Name = "TextBoxAnimalChip";
            this.TextBoxAnimalChip.Size = new System.Drawing.Size(201, 22);
            this.TextBoxAnimalChip.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Chip:";
            // 
            // btnAnimalUploadPic
            // 
            this.btnAnimalUploadPic.Location = new System.Drawing.Point(611, 558);
            this.btnAnimalUploadPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnimalUploadPic.Name = "btnAnimalUploadPic";
            this.btnAnimalUploadPic.Size = new System.Drawing.Size(139, 33);
            this.btnAnimalUploadPic.TabIndex = 19;
            this.btnAnimalUploadPic.Text = "Upload Picture";
            this.btnAnimalUploadPic.UseVisualStyleBackColor = true;
            this.btnAnimalUploadPic.Click += new System.EventHandler(this.buttonAnimalUploadPic_Click);
            // 
            // PictureBoxAnimal
            // 
            this.PictureBoxAnimal.Image = global::AnimalHouseV3.Properties.Resources.Labrador_edit;
            this.PictureBoxAnimal.Location = new System.Drawing.Point(596, 402);
            this.PictureBoxAnimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBoxAnimal.Name = "PictureBoxAnimal";
            this.PictureBoxAnimal.Size = new System.Drawing.Size(184, 153);
            this.PictureBoxAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxAnimal.TabIndex = 20;
            this.PictureBoxAnimal.TabStop = false;
            // 
            // btnAnimalCreate
            // 
            this.btnAnimalCreate.Location = new System.Drawing.Point(752, 558);
            this.btnAnimalCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnimalCreate.Name = "btnAnimalCreate";
            this.btnAnimalCreate.Size = new System.Drawing.Size(139, 33);
            this.btnAnimalCreate.TabIndex = 21;
            this.btnAnimalCreate.Text = "Create";
            this.btnAnimalCreate.UseVisualStyleBackColor = true;
            this.btnAnimalCreate.Click += new System.EventHandler(this.buttonAnimalCreate_Click);
            // 
            // btnAnimalDelete
            // 
            this.btnAnimalDelete.Location = new System.Drawing.Point(752, 593);
            this.btnAnimalDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnimalDelete.Name = "btnAnimalDelete";
            this.btnAnimalDelete.Size = new System.Drawing.Size(139, 33);
            this.btnAnimalDelete.TabIndex = 22;
            this.btnAnimalDelete.Text = "Delete";
            this.btnAnimalDelete.UseVisualStyleBackColor = true;
            this.btnAnimalDelete.Click += new System.EventHandler(this.buttonAnimalDelete_Click);
            // 
            // btnAnimalUpdate
            // 
            this.btnAnimalUpdate.Location = new System.Drawing.Point(611, 593);
            this.btnAnimalUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnimalUpdate.Name = "btnAnimalUpdate";
            this.btnAnimalUpdate.Size = new System.Drawing.Size(139, 33);
            this.btnAnimalUpdate.TabIndex = 23;
            this.btnAnimalUpdate.Text = "Update";
            this.btnAnimalUpdate.UseVisualStyleBackColor = true;
            this.btnAnimalUpdate.Click += new System.EventHandler(this.buttonAnimalUpdate_Click);
            // 
            // CheckOwnerRight
            // 
            this.CheckOwnerRight.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CheckOwnerRight.AutoSize = true;
            this.CheckOwnerRight.Location = new System.Drawing.Point(640, 89);
            this.CheckOwnerRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckOwnerRight.Name = "CheckOwnerRight";
            this.CheckOwnerRight.Size = new System.Drawing.Size(63, 21);
            this.CheckOwnerRight.TabIndex = 24;
            this.CheckOwnerRight.Text = "Right";
            this.CheckOwnerRight.UseVisualStyleBackColor = true;
            // 
            // CheckOwnerWrong
            // 
            this.CheckOwnerWrong.AutoSize = true;
            this.CheckOwnerWrong.Location = new System.Drawing.Point(727, 89);
            this.CheckOwnerWrong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckOwnerWrong.Name = "CheckOwnerWrong";
            this.CheckOwnerWrong.Size = new System.Drawing.Size(72, 21);
            this.CheckOwnerWrong.TabIndex = 25;
            this.CheckOwnerWrong.Text = "Wrong";
            this.CheckOwnerWrong.UseVisualStyleBackColor = true;
            // 
            // TextBoxJournal
            // 
            this.TextBoxJournal.Location = new System.Drawing.Point(27, 434);
            this.TextBoxJournal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxJournal.Name = "TextBoxJournal";
            this.TextBoxJournal.Size = new System.Drawing.Size(275, 194);
            this.TextBoxJournal.TabIndex = 27;
            this.TextBoxJournal.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Journal:";
            // 
            // AnimalBirthCalender
            // 
            this.AnimalBirthCalender.Location = new System.Drawing.Point(100, 150);
            this.AnimalBirthCalender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnimalBirthCalender.Name = "AnimalBirthCalender";
            this.AnimalBirthCalender.Size = new System.Drawing.Size(201, 22);
            this.AnimalBirthCalender.TabIndex = 29;
            this.AnimalBirthCalender.Value = new System.DateTime(2019, 12, 2, 0, 0, 0, 0);
            // 
            // TextBoxAnimalNr
            // 
            this.TextBoxAnimalNr.Location = new System.Drawing.Point(596, 146);
            this.TextBoxAnimalNr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxAnimalNr.Name = "TextBoxAnimalNr";
            this.TextBoxAnimalNr.Size = new System.Drawing.Size(93, 22);
            this.TextBoxAnimalNr.TabIndex = 12;
            // 
            // DoctorComboBox
            // 
            this.DoctorComboBox.FormattingEnabled = true;
            this.DoctorComboBox.Location = new System.Drawing.Point(100, 185);
            this.DoctorComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoctorComboBox.Name = "DoctorComboBox";
            this.DoctorComboBox.Size = new System.Drawing.Size(201, 24);
            this.DoctorComboBox.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Title:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Date:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 414);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Comment:";
            // 
            // TextJournalTitle
            // 
            this.TextJournalTitle.Location = new System.Drawing.Point(100, 308);
            this.TextJournalTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextJournalTitle.Name = "TextJournalTitle";
            this.TextJournalTitle.Size = new System.Drawing.Size(201, 22);
            this.TextJournalTitle.TabIndex = 34;
            // 
            // JournalCalender
            // 
            this.JournalCalender.Location = new System.Drawing.Point(100, 366);
            this.JournalCalender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JournalCalender.Name = "JournalCalender";
            this.JournalCalender.Size = new System.Drawing.Size(201, 22);
            this.JournalCalender.TabIndex = 35;
            this.JournalCalender.Value = new System.DateTime(2019, 12, 2, 13, 17, 56, 0);
            // 
            // btnJournal
            // 
            this.btnJournal.Location = new System.Drawing.Point(308, 594);
            this.btnJournal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJournal.Name = "btnJournal";
            this.btnJournal.Size = new System.Drawing.Size(109, 32);
            this.btnJournal.TabIndex = 36;
            this.btnJournal.Text = "Comment";
            this.btnJournal.UseVisualStyleBackColor = true;
            this.btnJournal.Click += new System.EventHandler(this.buttonJournal_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(861, 7);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(25, 25);
            this.buttonHelp.TabIndex = 37;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // groupboxFillin
            // 
            this.groupboxFillin.Location = new System.Drawing.Point(19, 23);
            this.groupboxFillin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupboxFillin.Name = "groupboxFillin";
            this.groupboxFillin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupboxFillin.Size = new System.Drawing.Size(301, 257);
            this.groupboxFillin.TabIndex = 38;
            this.groupboxFillin.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(700, 144);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 28);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(493, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(325, 175);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // btnShowJournal
            // 
            this.btnShowJournal.Location = new System.Drawing.Point(308, 555);
            this.btnShowJournal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowJournal.Name = "btnShowJournal";
            this.btnShowJournal.Size = new System.Drawing.Size(111, 34);
            this.btnShowJournal.TabIndex = 40;
            this.btnShowJournal.Text = "Show Journal";
            this.btnShowJournal.UseVisualStyleBackColor = true;
            this.btnShowJournal.Click += new System.EventHandler(this.buttonShowJournal_Click);
            // 
            // ButtonCheckOwner_Click
            // 
            this.ButtonCheckOwner_Click.Location = new System.Drawing.Point(535, 84);
            this.ButtonCheckOwner_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonCheckOwner_Click.Name = "ButtonCheckOwner_Click";
            this.ButtonCheckOwner_Click.Size = new System.Drawing.Size(85, 30);
            this.ButtonCheckOwner_Click.TabIndex = 13;
            this.ButtonCheckOwner_Click.Text = "Check";
            this.ButtonCheckOwner_Click.UseVisualStyleBackColor = true;
            this.ButtonCheckOwner_Click.Click += new System.EventHandler(this.ButtonCheckOwner_Click_Click);
            // 
            // Form_Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(895, 621);
            this.Controls.Add(this.btnShowJournal);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.btnJournal);
            this.Controls.Add(this.JournalCalender);
            this.Controls.Add(this.TextJournalTitle);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DoctorComboBox);
            this.Controls.Add(this.AnimalBirthCalender);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextBoxJournal);
            this.Controls.Add(this.CheckOwnerWrong);
            this.Controls.Add(this.CheckOwnerRight);
            this.Controls.Add(this.btnAnimalUpdate);
            this.Controls.Add(this.btnAnimalDelete);
            this.Controls.Add(this.btnAnimalCreate);
            this.Controls.Add(this.PictureBoxAnimal);
            this.Controls.Add(this.btnAnimalUploadPic);
            this.Controls.Add(this.TextBoxAnimalChip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ButtonCheckOwner_Click);
            this.Controls.Add(this.TextBoxAnimalNr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CheckBoxFemale);
            this.Controls.Add(this.CheckBoxMale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextAnimal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextOwnerPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextAnimalName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupboxFillin);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Animal";
            this.Text = "Animal";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextAnimalName;
        private System.Windows.Forms.TextBox TextOwnerPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextAnimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CheckBoxMale;
        private System.Windows.Forms.CheckBox CheckBoxFemale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxAnimalChip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAnimalUploadPic;
        private System.Windows.Forms.PictureBox PictureBoxAnimal;
        private System.Windows.Forms.Button btnAnimalCreate;
        private System.Windows.Forms.Button btnAnimalDelete;
        private System.Windows.Forms.Button btnAnimalUpdate;
        private System.Windows.Forms.CheckBox CheckOwnerRight;
        private System.Windows.Forms.CheckBox CheckOwnerWrong;
        private System.Windows.Forms.RichTextBox TextBoxJournal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker AnimalBirthCalender;
        private System.Windows.Forms.TextBox TextBoxAnimalNr;
        private System.Windows.Forms.ComboBox DoctorComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TextJournalTitle;
        private System.Windows.Forms.DateTimePicker JournalCalender;
        private System.Windows.Forms.Button btnJournal;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.GroupBox groupboxFillin;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowJournal;
        private System.Windows.Forms.Button ButtonCheckOwner_Click;
    }
}