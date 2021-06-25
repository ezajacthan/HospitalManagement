namespace ProjectApplication
{
    partial class AddPatientForm
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
            this.uxFirstLabel = new System.Windows.Forms.Label();
            this.uxLastLabel = new System.Windows.Forms.Label();
            this.uxPhoneLabel = new System.Windows.Forms.Label();
            this.uxEmailLabel = new System.Windows.Forms.Label();
            this.uxAddressLabel = new System.Windows.Forms.Label();
            this.uxStateLabel = new System.Windows.Forms.Label();
            this.uxZipLabel = new System.Windows.Forms.Label();
            this.uxCountryLabel = new System.Windows.Forms.Label();
            this.uxBirthdayLabel = new System.Windows.Forms.Label();
            this.uxSexLabel = new System.Windows.Forms.Label();
            this.uxEmergencyIDLabel = new System.Windows.Forms.Label();
            this.uxAddPatientToDatabaseButton = new System.Windows.Forms.Button();
            this.uxCityLabel = new System.Windows.Forms.Label();
            this.uxFirstBox = new System.Windows.Forms.TextBox();
            this.uxLastBox = new System.Windows.Forms.TextBox();
            this.uxPhoneBox = new System.Windows.Forms.TextBox();
            this.uxEmailBox = new System.Windows.Forms.TextBox();
            this.uxAddressBox = new System.Windows.Forms.TextBox();
            this.uxCityBox = new System.Windows.Forms.TextBox();
            this.uxStateBox = new System.Windows.Forms.TextBox();
            this.uxZipBox = new System.Windows.Forms.TextBox();
            this.uxCountryBox = new System.Windows.Forms.TextBox();
            this.uxEmergencyIDBox = new System.Windows.Forms.TextBox();
            this.uxBirthdatePicker = new System.Windows.Forms.DateTimePicker();
            this.uxAddSexBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the patient\'s information:";
            // 
            // uxFirstLabel
            // 
            this.uxFirstLabel.AutoSize = true;
            this.uxFirstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxFirstLabel.Location = new System.Drawing.Point(13, 57);
            this.uxFirstLabel.Name = "uxFirstLabel";
            this.uxFirstLabel.Size = new System.Drawing.Size(97, 20);
            this.uxFirstLabel.TabIndex = 1;
            this.uxFirstLabel.Text = "First Name:";
            // 
            // uxLastLabel
            // 
            this.uxLastLabel.AutoSize = true;
            this.uxLastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLastLabel.Location = new System.Drawing.Point(382, 56);
            this.uxLastLabel.Name = "uxLastLabel";
            this.uxLastLabel.Size = new System.Drawing.Size(96, 20);
            this.uxLastLabel.TabIndex = 2;
            this.uxLastLabel.Text = "Last Name:";
            // 
            // uxPhoneLabel
            // 
            this.uxPhoneLabel.AutoSize = true;
            this.uxPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPhoneLabel.Location = new System.Drawing.Point(13, 116);
            this.uxPhoneLabel.Name = "uxPhoneLabel";
            this.uxPhoneLabel.Size = new System.Drawing.Size(125, 20);
            this.uxPhoneLabel.TabIndex = 3;
            this.uxPhoneLabel.Text = "Phone Number:";
            // 
            // uxEmailLabel
            // 
            this.uxEmailLabel.AutoSize = true;
            this.uxEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEmailLabel.Location = new System.Drawing.Point(382, 116);
            this.uxEmailLabel.Name = "uxEmailLabel";
            this.uxEmailLabel.Size = new System.Drawing.Size(123, 20);
            this.uxEmailLabel.TabIndex = 4;
            this.uxEmailLabel.Text = "Email Address:";
            // 
            // uxAddressLabel
            // 
            this.uxAddressLabel.AutoSize = true;
            this.uxAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddressLabel.Location = new System.Drawing.Point(16, 180);
            this.uxAddressLabel.Name = "uxAddressLabel";
            this.uxAddressLabel.Size = new System.Drawing.Size(76, 20);
            this.uxAddressLabel.TabIndex = 5;
            this.uxAddressLabel.Text = "Address:";
            // 
            // uxStateLabel
            // 
            this.uxStateLabel.AutoSize = true;
            this.uxStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStateLabel.Location = new System.Drawing.Point(278, 230);
            this.uxStateLabel.Name = "uxStateLabel";
            this.uxStateLabel.Size = new System.Drawing.Size(53, 20);
            this.uxStateLabel.TabIndex = 6;
            this.uxStateLabel.Text = "State:";
            // 
            // uxZipLabel
            // 
            this.uxZipLabel.AutoSize = true;
            this.uxZipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxZipLabel.Location = new System.Drawing.Point(444, 228);
            this.uxZipLabel.Name = "uxZipLabel";
            this.uxZipLabel.Size = new System.Drawing.Size(80, 20);
            this.uxZipLabel.TabIndex = 8;
            this.uxZipLabel.Text = "Zip Code:";
            // 
            // uxCountryLabel
            // 
            this.uxCountryLabel.AutoSize = true;
            this.uxCountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCountryLabel.Location = new System.Drawing.Point(19, 287);
            this.uxCountryLabel.Name = "uxCountryLabel";
            this.uxCountryLabel.Size = new System.Drawing.Size(72, 20);
            this.uxCountryLabel.TabIndex = 9;
            this.uxCountryLabel.Text = "Country:";
            // 
            // uxBirthdayLabel
            // 
            this.uxBirthdayLabel.AutoSize = true;
            this.uxBirthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBirthdayLabel.Location = new System.Drawing.Point(19, 335);
            this.uxBirthdayLabel.Name = "uxBirthdayLabel";
            this.uxBirthdayLabel.Size = new System.Drawing.Size(205, 20);
            this.uxBirthdayLabel.TabIndex = 10;
            this.uxBirthdayLabel.Text = "Birthdate (MM-DD-YYYY):";
            // 
            // uxSexLabel
            // 
            this.uxSexLabel.AutoSize = true;
            this.uxSexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSexLabel.Location = new System.Drawing.Point(501, 337);
            this.uxSexLabel.Name = "uxSexLabel";
            this.uxSexLabel.Size = new System.Drawing.Size(232, 20);
            this.uxSexLabel.TabIndex = 11;
            this.uxSexLabel.Text = "Sex (1 for female, 0 for male):";
            // 
            // uxEmergencyIDLabel
            // 
            this.uxEmergencyIDLabel.AutoSize = true;
            this.uxEmergencyIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEmergencyIDLabel.Location = new System.Drawing.Point(19, 387);
            this.uxEmergencyIDLabel.Name = "uxEmergencyIDLabel";
            this.uxEmergencyIDLabel.Size = new System.Drawing.Size(183, 20);
            this.uxEmergencyIDLabel.TabIndex = 12;
            this.uxEmergencyIDLabel.Text = "Emergency Contact ID:";
            // 
            // uxAddPatientToDatabaseButton
            // 
            this.uxAddPatientToDatabaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxAddPatientToDatabaseButton.Location = new System.Drawing.Point(449, 377);
            this.uxAddPatientToDatabaseButton.Name = "uxAddPatientToDatabaseButton";
            this.uxAddPatientToDatabaseButton.Size = new System.Drawing.Size(339, 42);
            this.uxAddPatientToDatabaseButton.TabIndex = 13;
            this.uxAddPatientToDatabaseButton.Text = "Add Patient to Database";
            this.uxAddPatientToDatabaseButton.UseVisualStyleBackColor = true;
            this.uxAddPatientToDatabaseButton.Click += new System.EventHandler(this.uxAddPatientToDatabaseButton_Click);
            // 
            // uxCityLabel
            // 
            this.uxCityLabel.AutoSize = true;
            this.uxCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCityLabel.Location = new System.Drawing.Point(19, 231);
            this.uxCityLabel.Name = "uxCityLabel";
            this.uxCityLabel.Size = new System.Drawing.Size(43, 20);
            this.uxCityLabel.TabIndex = 14;
            this.uxCityLabel.Text = "City:";
            // 
            // uxFirstBox
            // 
            this.uxFirstBox.Location = new System.Drawing.Point(117, 57);
            this.uxFirstBox.MaxLength = 64;
            this.uxFirstBox.Name = "uxFirstBox";
            this.uxFirstBox.Size = new System.Drawing.Size(259, 22);
            this.uxFirstBox.TabIndex = 15;
            // 
            // uxLastBox
            // 
            this.uxLastBox.Location = new System.Drawing.Point(484, 57);
            this.uxLastBox.MaxLength = 64;
            this.uxLastBox.Name = "uxLastBox";
            this.uxLastBox.Size = new System.Drawing.Size(334, 22);
            this.uxLastBox.TabIndex = 16;
            // 
            // uxPhoneBox
            // 
            this.uxPhoneBox.Location = new System.Drawing.Point(145, 112);
            this.uxPhoneBox.MaxLength = 64;
            this.uxPhoneBox.Name = "uxPhoneBox";
            this.uxPhoneBox.Size = new System.Drawing.Size(231, 22);
            this.uxPhoneBox.TabIndex = 17;
            // 
            // uxEmailBox
            // 
            this.uxEmailBox.Location = new System.Drawing.Point(511, 116);
            this.uxEmailBox.MaxLength = 64;
            this.uxEmailBox.Name = "uxEmailBox";
            this.uxEmailBox.Size = new System.Drawing.Size(307, 22);
            this.uxEmailBox.TabIndex = 18;
            // 
            // uxAddressBox
            // 
            this.uxAddressBox.Location = new System.Drawing.Point(99, 180);
            this.uxAddressBox.MaxLength = 64;
            this.uxAddressBox.Name = "uxAddressBox";
            this.uxAddressBox.Size = new System.Drawing.Size(719, 22);
            this.uxAddressBox.TabIndex = 19;
            // 
            // uxCityBox
            // 
            this.uxCityBox.Location = new System.Drawing.Point(69, 228);
            this.uxCityBox.MaxLength = 64;
            this.uxCityBox.Name = "uxCityBox";
            this.uxCityBox.Size = new System.Drawing.Size(203, 22);
            this.uxCityBox.TabIndex = 20;
            // 
            // uxStateBox
            // 
            this.uxStateBox.Location = new System.Drawing.Point(338, 228);
            this.uxStateBox.MaxLength = 64;
            this.uxStateBox.Name = "uxStateBox";
            this.uxStateBox.Size = new System.Drawing.Size(105, 22);
            this.uxStateBox.TabIndex = 21;
            // 
            // uxZipBox
            // 
            this.uxZipBox.Location = new System.Drawing.Point(531, 231);
            this.uxZipBox.MaxLength = 64;
            this.uxZipBox.Name = "uxZipBox";
            this.uxZipBox.Size = new System.Drawing.Size(287, 22);
            this.uxZipBox.TabIndex = 22;
            // 
            // uxCountryBox
            // 
            this.uxCountryBox.Location = new System.Drawing.Point(98, 287);
            this.uxCountryBox.Name = "uxCountryBox";
            this.uxCountryBox.Size = new System.Drawing.Size(720, 22);
            this.uxCountryBox.TabIndex = 23;
            // 
            // uxEmergencyIDBox
            // 
            this.uxEmergencyIDBox.Location = new System.Drawing.Point(209, 384);
            this.uxEmergencyIDBox.MaxLength = 5;
            this.uxEmergencyIDBox.Name = "uxEmergencyIDBox";
            this.uxEmergencyIDBox.Size = new System.Drawing.Size(234, 22);
            this.uxEmergencyIDBox.TabIndex = 26;
            // 
            // uxBirthdatePicker
            // 
            this.uxBirthdatePicker.Location = new System.Drawing.Point(231, 335);
            this.uxBirthdatePicker.Name = "uxBirthdatePicker";
            this.uxBirthdatePicker.Size = new System.Drawing.Size(264, 22);
            this.uxBirthdatePicker.TabIndex = 27;
            // 
            // uxAddSexBox
            // 
            this.uxAddSexBox.Location = new System.Drawing.Point(740, 335);
            this.uxAddSexBox.Name = "uxAddSexBox";
            this.uxAddSexBox.Size = new System.Drawing.Size(78, 22);
            this.uxAddSexBox.TabIndex = 28;
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 452);
            this.Controls.Add(this.uxAddSexBox);
            this.Controls.Add(this.uxBirthdatePicker);
            this.Controls.Add(this.uxEmergencyIDBox);
            this.Controls.Add(this.uxCountryBox);
            this.Controls.Add(this.uxZipBox);
            this.Controls.Add(this.uxStateBox);
            this.Controls.Add(this.uxCityBox);
            this.Controls.Add(this.uxAddressBox);
            this.Controls.Add(this.uxEmailBox);
            this.Controls.Add(this.uxPhoneBox);
            this.Controls.Add(this.uxLastBox);
            this.Controls.Add(this.uxFirstBox);
            this.Controls.Add(this.uxCityLabel);
            this.Controls.Add(this.uxAddPatientToDatabaseButton);
            this.Controls.Add(this.uxEmergencyIDLabel);
            this.Controls.Add(this.uxSexLabel);
            this.Controls.Add(this.uxBirthdayLabel);
            this.Controls.Add(this.uxCountryLabel);
            this.Controls.Add(this.uxZipLabel);
            this.Controls.Add(this.uxStateLabel);
            this.Controls.Add(this.uxAddressLabel);
            this.Controls.Add(this.uxEmailLabel);
            this.Controls.Add(this.uxPhoneLabel);
            this.Controls.Add(this.uxLastLabel);
            this.Controls.Add(this.uxFirstLabel);
            this.Controls.Add(this.label1);
            this.Name = "AddPatientForm";
            this.Text = "AddPatientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uxFirstLabel;
        private System.Windows.Forms.Label uxLastLabel;
        private System.Windows.Forms.Label uxPhoneLabel;
        private System.Windows.Forms.Label uxEmailLabel;
        private System.Windows.Forms.Label uxAddressLabel;
        private System.Windows.Forms.Label uxStateLabel;
        private System.Windows.Forms.Label uxZipLabel;
        private System.Windows.Forms.Label uxCountryLabel;
        private System.Windows.Forms.Label uxBirthdayLabel;
        private System.Windows.Forms.Label uxSexLabel;
        private System.Windows.Forms.Label uxEmergencyIDLabel;
        private System.Windows.Forms.Button uxAddPatientToDatabaseButton;
        private System.Windows.Forms.Label uxCityLabel;
        private System.Windows.Forms.TextBox uxFirstBox;
        private System.Windows.Forms.TextBox uxLastBox;
        private System.Windows.Forms.TextBox uxPhoneBox;
        private System.Windows.Forms.TextBox uxEmailBox;
        private System.Windows.Forms.TextBox uxAddressBox;
        private System.Windows.Forms.TextBox uxCityBox;
        private System.Windows.Forms.TextBox uxStateBox;
        private System.Windows.Forms.TextBox uxZipBox;
        private System.Windows.Forms.TextBox uxCountryBox;
        private System.Windows.Forms.TextBox uxEmergencyIDBox;
        private System.Windows.Forms.DateTimePicker uxBirthdatePicker;
        private System.Windows.Forms.TextBox uxAddSexBox;
    }
}