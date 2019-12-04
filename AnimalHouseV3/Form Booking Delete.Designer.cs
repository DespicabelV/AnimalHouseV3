namespace AnimalHouseV3
{
    partial class Form_Booking_Delete
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
            this.labelOwner = new System.Windows.Forms.Label();
            this.textBoxBookingSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelReservation = new System.Windows.Forms.Label();
            this.comboBoxBookningChoice = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Location = new System.Drawing.Point(9, 30);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(49, 17);
            this.labelOwner.TabIndex = 0;
            this.labelOwner.Text = "Owner";
            // 
            // textBoxBookingSearch
            // 
            this.textBoxBookingSearch.Location = new System.Drawing.Point(64, 28);
            this.textBoxBookingSearch.Name = "textBoxBookingSearch";
            this.textBoxBookingSearch.Size = new System.Drawing.Size(235, 22);
            this.textBoxBookingSearch.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(306, 26);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelReservation
            // 
            this.labelReservation.AutoSize = true;
            this.labelReservation.Location = new System.Drawing.Point(9, 63);
            this.labelReservation.Name = "labelReservation";
            this.labelReservation.Size = new System.Drawing.Size(84, 17);
            this.labelReservation.TabIndex = 3;
            this.labelReservation.Text = "Reservation";
            // 
            // comboBoxBookningChoice
            // 
            this.comboBoxBookningChoice.FormattingEnabled = true;
            this.comboBoxBookningChoice.Location = new System.Drawing.Point(100, 60);
            this.comboBoxBookningChoice.Name = "comboBoxBookningChoice";
            this.comboBoxBookningChoice.Size = new System.Drawing.Size(199, 24);
            this.comboBoxBookningChoice.TabIndex = 4;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(305, 60);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form_Booking_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 158);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.comboBoxBookningChoice);
            this.Controls.Add(this.labelReservation);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxBookingSearch);
            this.Controls.Add(this.labelOwner);
            this.Name = "Form_Booking_Delete";
            this.Text = "Form_Booking_Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.TextBox textBoxBookingSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelReservation;
        private System.Windows.Forms.ComboBox comboBoxBookningChoice;
        private System.Windows.Forms.Button buttonDelete;
    }
}