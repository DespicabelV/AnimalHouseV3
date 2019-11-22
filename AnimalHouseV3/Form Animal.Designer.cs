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
            this.TxtAnimalName = new System.Windows.Forms.TextBox();
            this.TxtOwnerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAnimalRace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckBoxMale = new System.Windows.Forms.CheckBox();
            this.CheckBoxFemale = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCheckOwner = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.TxtBoxAnimalDoctorNr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtBoxAnimalChip = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAnimalUploadPic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnimalCreate = new System.Windows.Forms.Button();
            this.btnAnimalDelete = new System.Windows.Forms.Button();
            this.btnAnimalUpdate = new System.Windows.Forms.Button();
            this.CheckOwnerRight = new System.Windows.Forms.CheckBox();
            this.CheckOwnerWrong = new System.Windows.Forms.CheckBox();
            this.TextBoxJournal = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AnimalBirthCalender = new System.Windows.Forms.DateTimePicker();
            this.TxtBoxAnimalNr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // TxtAnimalName
            // 
            this.TxtAnimalName.Location = new System.Drawing.Point(200, 77);
            this.TxtAnimalName.Name = "TxtAnimalName";
            this.TxtAnimalName.Size = new System.Drawing.Size(400, 38);
            this.TxtAnimalName.TabIndex = 1;
            // 
            // TxtOwnerName
            // 
            this.TxtOwnerName.Location = new System.Drawing.Point(1190, 81);
            this.TxtOwnerName.Name = "TxtOwnerName";
            this.TxtOwnerName.Size = new System.Drawing.Size(400, 38);
            this.TxtOwnerName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1078, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Owner:";
            // 
            // TxtAnimalRace
            // 
            this.TxtAnimalRace.Location = new System.Drawing.Point(200, 147);
            this.TxtAnimalRace.Name = "TxtAnimalRace";
            this.TxtAnimalRace.Size = new System.Drawing.Size(400, 38);
            this.TxtAnimalRace.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Animal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birthday:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender:";
            // 
            // CheckBoxMale
            // 
            this.CheckBoxMale.AutoSize = true;
            this.CheckBoxMale.Location = new System.Drawing.Point(200, 219);
            this.CheckBoxMale.Name = "CheckBoxMale";
            this.CheckBoxMale.Size = new System.Drawing.Size(115, 36);
            this.CheckBoxMale.TabIndex = 9;
            this.CheckBoxMale.Text = "Male";
            this.CheckBoxMale.UseVisualStyleBackColor = true;
            this.CheckBoxMale.CheckedChanged += new System.EventHandler(this.CheckBoxMale_CheckedChanged);
            // 
            // CheckBoxFemale
            // 
            this.CheckBoxFemale.AutoSize = true;
            this.CheckBoxFemale.Location = new System.Drawing.Point(385, 219);
            this.CheckBoxFemale.Name = "CheckBoxFemale";
            this.CheckBoxFemale.Size = new System.Drawing.Size(148, 36);
            this.CheckBoxFemale.TabIndex = 10;
            this.CheckBoxFemale.Text = "Female";
            this.CheckBoxFemale.UseVisualStyleBackColor = true;
            this.CheckBoxFemale.CheckedChanged += new System.EventHandler(this.CheckBoxFemale_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Animal Nr:";
            // 
            // btnCheckOwner
            // 
            this.btnCheckOwner.Location = new System.Drawing.Point(1070, 162);
            this.btnCheckOwner.Name = "btnCheckOwner";
            this.btnCheckOwner.Size = new System.Drawing.Size(173, 56);
            this.btnCheckOwner.TabIndex = 13;
            this.btnCheckOwner.Text = "Check";
            this.btnCheckOwner.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(649, 455);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 38);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtBoxAnimalDoctorNr
            // 
            this.TxtBoxAnimalDoctorNr.Location = new System.Drawing.Point(1248, 377);
            this.TxtBoxAnimalDoctorNr.Name = "TxtBoxAnimalDoctorNr";
            this.TxtBoxAnimalDoctorNr.Size = new System.Drawing.Size(400, 38);
            this.TxtBoxAnimalDoctorNr.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1126, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Doctor:";
            // 
            // TxtBoxAnimalChip
            // 
            this.TxtBoxAnimalChip.Location = new System.Drawing.Point(1248, 471);
            this.TxtBoxAnimalChip.Name = "TxtBoxAnimalChip";
            this.TxtBoxAnimalChip.Size = new System.Drawing.Size(400, 38);
            this.TxtBoxAnimalChip.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1126, 471);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "Chip:";
            // 
            // btnAnimalUploadPic
            // 
            this.btnAnimalUploadPic.Location = new System.Drawing.Point(1070, 580);
            this.btnAnimalUploadPic.Name = "btnAnimalUploadPic";
            this.btnAnimalUploadPic.Size = new System.Drawing.Size(173, 56);
            this.btnAnimalUploadPic.TabIndex = 19;
            this.btnAnimalUploadPic.Text = "Upload";
            this.btnAnimalUploadPic.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1281, 580);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 295);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnimalCreate
            // 
            this.btnAnimalCreate.Location = new System.Drawing.Point(1373, 912);
            this.btnAnimalCreate.Name = "btnAnimalCreate";
            this.btnAnimalCreate.Size = new System.Drawing.Size(275, 63);
            this.btnAnimalCreate.TabIndex = 21;
            this.btnAnimalCreate.Text = "Create";
            this.btnAnimalCreate.UseVisualStyleBackColor = true;
            this.btnAnimalCreate.Click += new System.EventHandler(this.btnAnimalCreate_Click);
            // 
            // btnAnimalDelete
            // 
            this.btnAnimalDelete.Location = new System.Drawing.Point(1373, 1013);
            this.btnAnimalDelete.Name = "btnAnimalDelete";
            this.btnAnimalDelete.Size = new System.Drawing.Size(275, 63);
            this.btnAnimalDelete.TabIndex = 22;
            this.btnAnimalDelete.Text = "Delete";
            this.btnAnimalDelete.UseVisualStyleBackColor = true;
            // 
            // btnAnimalUpdate
            // 
            this.btnAnimalUpdate.Location = new System.Drawing.Point(1060, 1013);
            this.btnAnimalUpdate.Name = "btnAnimalUpdate";
            this.btnAnimalUpdate.Size = new System.Drawing.Size(275, 63);
            this.btnAnimalUpdate.TabIndex = 23;
            this.btnAnimalUpdate.Text = "Update";
            this.btnAnimalUpdate.UseVisualStyleBackColor = true;
            // 
            // CheckOwnerRight
            // 
            this.CheckOwnerRight.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CheckOwnerRight.AutoSize = true;
            this.CheckOwnerRight.Location = new System.Drawing.Point(1281, 173);
            this.CheckOwnerRight.Name = "CheckOwnerRight";
            this.CheckOwnerRight.Size = new System.Drawing.Size(120, 36);
            this.CheckOwnerRight.TabIndex = 24;
            this.CheckOwnerRight.Text = "Right";
            this.CheckOwnerRight.UseVisualStyleBackColor = true;
            // 
            // CheckOwnerWrong
            // 
            this.CheckOwnerWrong.AutoSize = true;
            this.CheckOwnerWrong.Location = new System.Drawing.Point(1454, 173);
            this.CheckOwnerWrong.Name = "CheckOwnerWrong";
            this.CheckOwnerWrong.Size = new System.Drawing.Size(136, 36);
            this.CheckOwnerWrong.TabIndex = 25;
            this.CheckOwnerWrong.Text = "Wrong";
            this.CheckOwnerWrong.UseVisualStyleBackColor = true;
            // 
            // TextBoxJournal
            // 
            this.TextBoxJournal.Location = new System.Drawing.Point(54, 580);
            this.TextBoxJournal.Name = "TextBoxJournal";
            this.TextBoxJournal.Size = new System.Drawing.Size(546, 500);
            this.TextBoxJournal.TabIndex = 27;
            this.TextBoxJournal.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 544);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 32);
            this.label9.TabIndex = 28;
            this.label9.Text = "Journal:";
            // 
            // AnimalBirthCalender
            // 
            this.AnimalBirthCalender.Location = new System.Drawing.Point(200, 291);
            this.AnimalBirthCalender.Name = "AnimalBirthCalender";
            this.AnimalBirthCalender.Size = new System.Drawing.Size(291, 38);
            this.AnimalBirthCalender.TabIndex = 29;
            this.AnimalBirthCalender.Value = new System.DateTime(2019, 11, 19, 0, 0, 0, 0);
            // 
            // TxtBoxAnimalNr
            // 
            this.TxtBoxAnimalNr.Location = new System.Drawing.Point(200, 455);
            this.TxtBoxAnimalNr.Name = "TxtBoxAnimalNr";
            this.TxtBoxAnimalNr.Size = new System.Drawing.Size(400, 38);
            this.TxtBoxAnimalNr.TabIndex = 12;
            // 
            // Form_Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1790, 1412);
            this.Controls.Add(this.AnimalBirthCalender);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextBoxJournal);
            this.Controls.Add(this.CheckOwnerWrong);
            this.Controls.Add(this.CheckOwnerRight);
            this.Controls.Add(this.btnAnimalUpdate);
            this.Controls.Add(this.btnAnimalDelete);
            this.Controls.Add(this.btnAnimalCreate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAnimalUploadPic);
            this.Controls.Add(this.TxtBoxAnimalChip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtBoxAnimalDoctorNr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCheckOwner);
            this.Controls.Add(this.TxtBoxAnimalNr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CheckBoxFemale);
            this.Controls.Add(this.CheckBoxMale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtAnimalRace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtOwnerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAnimalName);
            this.Controls.Add(this.label1);
            this.Name = "Form_Animal";
            this.Text = "Animal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAnimalName;
        private System.Windows.Forms.TextBox TxtOwnerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAnimalRace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CheckBoxMale;
        private System.Windows.Forms.CheckBox CheckBoxFemale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCheckOwner;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox TxtBoxAnimalDoctorNr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtBoxAnimalChip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAnimalUploadPic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnimalCreate;
        private System.Windows.Forms.Button btnAnimalDelete;
        private System.Windows.Forms.Button btnAnimalUpdate;
        private System.Windows.Forms.CheckBox CheckOwnerRight;
        private System.Windows.Forms.CheckBox CheckOwnerWrong;
        private System.Windows.Forms.RichTextBox TextBoxJournal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker AnimalBirthCalender;
        private System.Windows.Forms.TextBox TxtBoxAnimalNr;
    }
}