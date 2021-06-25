namespace ProjectApplication
{
    partial class SearchPage
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
            this.uxPatientSearch = new System.Windows.Forms.GroupBox();
            this.uxGetPatientTreatments = new System.Windows.Forms.Button();
            this.uxGetPatientEmergencyContactInfo = new System.Windows.Forms.Button();
            this.uxGetPatientDoctors = new System.Windows.Forms.Button();
            this.uxGetPatientInfo = new System.Windows.Forms.Button();
            this.uxGetPatientConditions = new System.Windows.Forms.Button();
            this.uxGetPatientStays = new System.Windows.Forms.Button();
            this.uxPatientBirthDateLabel = new System.Windows.Forms.Label();
            this.uxPatientLastName = new System.Windows.Forms.TextBox();
            this.uxPatientFirstName = new System.Windows.Forms.TextBox();
            this.uxPatientBirthDate = new System.Windows.Forms.DateTimePicker();
            this.uxPatientLastNameLabel = new System.Windows.Forms.Label();
            this.uxPatientFirstNameLabel = new System.Windows.Forms.Label();
            this.uxDoctorSearch = new System.Windows.Forms.GroupBox();
            this.uxDoctorUnit = new System.Windows.Forms.TextBox();
            this.uxGetDoctorConditionHistory = new System.Windows.Forms.Button();
            this.uxGetDoctorInfo = new System.Windows.Forms.Button();
            this.uxGetDoctorPatients = new System.Windows.Forms.Button();
            this.uxDoctorUnitLabel = new System.Windows.Forms.Label();
            this.uxDoctorLastName = new System.Windows.Forms.TextBox();
            this.uxDoctorFirstName = new System.Windows.Forms.TextBox();
            this.uxDoctorLastNameLabel = new System.Windows.Forms.Label();
            this.uxDoctorFirstNameLabel = new System.Windows.Forms.Label();
            this.uxConditionSearch = new System.Windows.Forms.GroupBox();
            this.uxGetConditionHistory = new System.Windows.Forms.Button();
            this.uxGetConditionPatients = new System.Windows.Forms.Button();
            this.uxGetConditionDoctors = new System.Windows.Forms.Button();
            this.uxConditionCommonName = new System.Windows.Forms.TextBox();
            this.uxConditionCommonNameLabel = new System.Windows.Forms.Label();
            this.uxResultsGrid = new System.Windows.Forms.DataGridView();
            this.uxPatientSearch.SuspendLayout();
            this.uxDoctorSearch.SuspendLayout();
            this.uxConditionSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxResultsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxPatientSearch
            // 
            this.uxPatientSearch.Controls.Add(this.uxGetPatientTreatments);
            this.uxPatientSearch.Controls.Add(this.uxGetPatientEmergencyContactInfo);
            this.uxPatientSearch.Controls.Add(this.uxGetPatientDoctors);
            this.uxPatientSearch.Controls.Add(this.uxGetPatientInfo);
            this.uxPatientSearch.Controls.Add(this.uxGetPatientConditions);
            this.uxPatientSearch.Controls.Add(this.uxGetPatientStays);
            this.uxPatientSearch.Controls.Add(this.uxPatientBirthDateLabel);
            this.uxPatientSearch.Controls.Add(this.uxPatientLastName);
            this.uxPatientSearch.Controls.Add(this.uxPatientFirstName);
            this.uxPatientSearch.Controls.Add(this.uxPatientBirthDate);
            this.uxPatientSearch.Controls.Add(this.uxPatientLastNameLabel);
            this.uxPatientSearch.Controls.Add(this.uxPatientFirstNameLabel);
            this.uxPatientSearch.Location = new System.Drawing.Point(12, 12);
            this.uxPatientSearch.Name = "uxPatientSearch";
            this.uxPatientSearch.Size = new System.Drawing.Size(1169, 123);
            this.uxPatientSearch.TabIndex = 1;
            this.uxPatientSearch.TabStop = false;
            this.uxPatientSearch.Text = "Patient Search";
            // 
            // uxGetPatientTreatments
            // 
            this.uxGetPatientTreatments.Location = new System.Drawing.Point(1034, 72);
            this.uxGetPatientTreatments.Name = "uxGetPatientTreatments";
            this.uxGetPatientTreatments.Size = new System.Drawing.Size(129, 35);
            this.uxGetPatientTreatments.TabIndex = 10;
            this.uxGetPatientTreatments.Text = "Treatments";
            this.uxGetPatientTreatments.UseVisualStyleBackColor = true;
            this.uxGetPatientTreatments.Click += new System.EventHandler(this.uxGetPatientTreatments_Click);
            // 
            // uxGetPatientEmergencyContactInfo
            // 
            this.uxGetPatientEmergencyContactInfo.Location = new System.Drawing.Point(816, 72);
            this.uxGetPatientEmergencyContactInfo.Name = "uxGetPatientEmergencyContactInfo";
            this.uxGetPatientEmergencyContactInfo.Size = new System.Drawing.Size(212, 35);
            this.uxGetPatientEmergencyContactInfo.TabIndex = 7;
            this.uxGetPatientEmergencyContactInfo.Text = "Emergency Contact Info";
            this.uxGetPatientEmergencyContactInfo.UseVisualStyleBackColor = true;
            this.uxGetPatientEmergencyContactInfo.Click += new System.EventHandler(this.uxGetPatientEmergencyContactInfo_Click);
            // 
            // uxGetPatientDoctors
            // 
            this.uxGetPatientDoctors.Location = new System.Drawing.Point(951, 25);
            this.uxGetPatientDoctors.Name = "uxGetPatientDoctors";
            this.uxGetPatientDoctors.Size = new System.Drawing.Size(93, 35);
            this.uxGetPatientDoctors.TabIndex = 11;
            this.uxGetPatientDoctors.Text = "Doctors";
            this.uxGetPatientDoctors.UseVisualStyleBackColor = true;
            this.uxGetPatientDoctors.Click += new System.EventHandler(this.uxGetPatientDoctors_Click);
            // 
            // uxGetPatientInfo
            // 
            this.uxGetPatientInfo.Location = new System.Drawing.Point(779, 25);
            this.uxGetPatientInfo.Name = "uxGetPatientInfo";
            this.uxGetPatientInfo.Size = new System.Drawing.Size(80, 35);
            this.uxGetPatientInfo.TabIndex = 6;
            this.uxGetPatientInfo.Text = "Info";
            this.uxGetPatientInfo.UseVisualStyleBackColor = true;
            this.uxGetPatientInfo.Click += new System.EventHandler(this.uxGetPatientInfo_Click);
            // 
            // uxGetPatientConditions
            // 
            this.uxGetPatientConditions.Location = new System.Drawing.Point(1050, 25);
            this.uxGetPatientConditions.Name = "uxGetPatientConditions";
            this.uxGetPatientConditions.Size = new System.Drawing.Size(113, 35);
            this.uxGetPatientConditions.TabIndex = 9;
            this.uxGetPatientConditions.Text = "Conditions";
            this.uxGetPatientConditions.UseVisualStyleBackColor = true;
            this.uxGetPatientConditions.Click += new System.EventHandler(this.uxGetPatientConditions_Click);
            // 
            // uxGetPatientStays
            // 
            this.uxGetPatientStays.Location = new System.Drawing.Point(865, 25);
            this.uxGetPatientStays.Name = "uxGetPatientStays";
            this.uxGetPatientStays.Size = new System.Drawing.Size(80, 35);
            this.uxGetPatientStays.TabIndex = 8;
            this.uxGetPatientStays.Text = "Stays";
            this.uxGetPatientStays.UseVisualStyleBackColor = true;
            this.uxGetPatientStays.Click += new System.EventHandler(this.uxGetPatientStays_Click);
            // 
            // uxPatientBirthDateLabel
            // 
            this.uxPatientBirthDateLabel.AutoSize = true;
            this.uxPatientBirthDateLabel.Location = new System.Drawing.Point(475, 40);
            this.uxPatientBirthDateLabel.Name = "uxPatientBirthDateLabel";
            this.uxPatientBirthDateLabel.Size = new System.Drawing.Size(85, 20);
            this.uxPatientBirthDateLabel.TabIndex = 5;
            this.uxPatientBirthDateLabel.Text = "Birth Date:";
            // 
            // uxPatientLastName
            // 
            this.uxPatientLastName.Location = new System.Drawing.Point(255, 72);
            this.uxPatientLastName.Name = "uxPatientLastName";
            this.uxPatientLastName.Size = new System.Drawing.Size(195, 26);
            this.uxPatientLastName.TabIndex = 4;
            // 
            // uxPatientFirstName
            // 
            this.uxPatientFirstName.Location = new System.Drawing.Point(32, 72);
            this.uxPatientFirstName.Name = "uxPatientFirstName";
            this.uxPatientFirstName.Size = new System.Drawing.Size(195, 26);
            this.uxPatientFirstName.TabIndex = 3;
            // 
            // uxPatientBirthDate
            // 
            this.uxPatientBirthDate.Checked = false;
            this.uxPatientBirthDate.CustomFormat = "MM/dd/yyyy";
            this.uxPatientBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.uxPatientBirthDate.Location = new System.Drawing.Point(479, 70);
            this.uxPatientBirthDate.Name = "uxPatientBirthDate";
            this.uxPatientBirthDate.Size = new System.Drawing.Size(195, 26);
            this.uxPatientBirthDate.TabIndex = 2;
            // 
            // uxPatientLastNameLabel
            // 
            this.uxPatientLastNameLabel.AutoSize = true;
            this.uxPatientLastNameLabel.Location = new System.Drawing.Point(251, 40);
            this.uxPatientLastNameLabel.Name = "uxPatientLastNameLabel";
            this.uxPatientLastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.uxPatientLastNameLabel.TabIndex = 1;
            this.uxPatientLastNameLabel.Text = "Last Name:";
            // 
            // uxPatientFirstNameLabel
            // 
            this.uxPatientFirstNameLabel.AutoSize = true;
            this.uxPatientFirstNameLabel.Location = new System.Drawing.Point(28, 40);
            this.uxPatientFirstNameLabel.Name = "uxPatientFirstNameLabel";
            this.uxPatientFirstNameLabel.Size = new System.Drawing.Size(90, 20);
            this.uxPatientFirstNameLabel.TabIndex = 0;
            this.uxPatientFirstNameLabel.Text = "First Name:";
            // 
            // uxDoctorSearch
            // 
            this.uxDoctorSearch.Controls.Add(this.uxDoctorUnit);
            this.uxDoctorSearch.Controls.Add(this.uxGetDoctorConditionHistory);
            this.uxDoctorSearch.Controls.Add(this.uxGetDoctorInfo);
            this.uxDoctorSearch.Controls.Add(this.uxGetDoctorPatients);
            this.uxDoctorSearch.Controls.Add(this.uxDoctorUnitLabel);
            this.uxDoctorSearch.Controls.Add(this.uxDoctorLastName);
            this.uxDoctorSearch.Controls.Add(this.uxDoctorFirstName);
            this.uxDoctorSearch.Controls.Add(this.uxDoctorLastNameLabel);
            this.uxDoctorSearch.Controls.Add(this.uxDoctorFirstNameLabel);
            this.uxDoctorSearch.Location = new System.Drawing.Point(12, 141);
            this.uxDoctorSearch.Name = "uxDoctorSearch";
            this.uxDoctorSearch.Size = new System.Drawing.Size(1169, 123);
            this.uxDoctorSearch.TabIndex = 2;
            this.uxDoctorSearch.TabStop = false;
            this.uxDoctorSearch.Text = "Doctor Search";
            // 
            // uxDoctorUnit
            // 
            this.uxDoctorUnit.Location = new System.Drawing.Point(479, 72);
            this.uxDoctorUnit.Name = "uxDoctorUnit";
            this.uxDoctorUnit.Size = new System.Drawing.Size(195, 26);
            this.uxDoctorUnit.TabIndex = 12;
            // 
            // uxGetDoctorConditionHistory
            // 
            this.uxGetDoctorConditionHistory.Location = new System.Drawing.Point(984, 72);
            this.uxGetDoctorConditionHistory.Name = "uxGetDoctorConditionHistory";
            this.uxGetDoctorConditionHistory.Size = new System.Drawing.Size(179, 35);
            this.uxGetDoctorConditionHistory.TabIndex = 11;
            this.uxGetDoctorConditionHistory.Text = "Condition History";
            this.uxGetDoctorConditionHistory.UseVisualStyleBackColor = true;
            this.uxGetDoctorConditionHistory.Click += new System.EventHandler(this.uxGetDoctorConditionHistory_Click);
            // 
            // uxGetDoctorInfo
            // 
            this.uxGetDoctorInfo.Location = new System.Drawing.Point(984, 25);
            this.uxGetDoctorInfo.Name = "uxGetDoctorInfo";
            this.uxGetDoctorInfo.Size = new System.Drawing.Size(80, 35);
            this.uxGetDoctorInfo.TabIndex = 6;
            this.uxGetDoctorInfo.Text = "Info";
            this.uxGetDoctorInfo.UseVisualStyleBackColor = true;
            this.uxGetDoctorInfo.Click += new System.EventHandler(this.uxGetDoctorInfo_Click);
            // 
            // uxGetDoctorPatients
            // 
            this.uxGetDoctorPatients.Location = new System.Drawing.Point(1070, 25);
            this.uxGetDoctorPatients.Name = "uxGetDoctorPatients";
            this.uxGetDoctorPatients.Size = new System.Drawing.Size(93, 35);
            this.uxGetDoctorPatients.TabIndex = 8;
            this.uxGetDoctorPatients.Text = "Patients";
            this.uxGetDoctorPatients.UseVisualStyleBackColor = true;
            this.uxGetDoctorPatients.Click += new System.EventHandler(this.uxGetDoctorPatients_Click);
            // 
            // uxDoctorUnitLabel
            // 
            this.uxDoctorUnitLabel.AutoSize = true;
            this.uxDoctorUnitLabel.Location = new System.Drawing.Point(475, 40);
            this.uxDoctorUnitLabel.Name = "uxDoctorUnitLabel";
            this.uxDoctorUnitLabel.Size = new System.Drawing.Size(42, 20);
            this.uxDoctorUnitLabel.TabIndex = 5;
            this.uxDoctorUnitLabel.Text = "Unit:";
            // 
            // uxDoctorLastName
            // 
            this.uxDoctorLastName.Location = new System.Drawing.Point(255, 72);
            this.uxDoctorLastName.Name = "uxDoctorLastName";
            this.uxDoctorLastName.Size = new System.Drawing.Size(195, 26);
            this.uxDoctorLastName.TabIndex = 4;
            // 
            // uxDoctorFirstName
            // 
            this.uxDoctorFirstName.Location = new System.Drawing.Point(32, 72);
            this.uxDoctorFirstName.Name = "uxDoctorFirstName";
            this.uxDoctorFirstName.Size = new System.Drawing.Size(195, 26);
            this.uxDoctorFirstName.TabIndex = 3;
            // 
            // uxDoctorLastNameLabel
            // 
            this.uxDoctorLastNameLabel.AutoSize = true;
            this.uxDoctorLastNameLabel.Location = new System.Drawing.Point(251, 40);
            this.uxDoctorLastNameLabel.Name = "uxDoctorLastNameLabel";
            this.uxDoctorLastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.uxDoctorLastNameLabel.TabIndex = 1;
            this.uxDoctorLastNameLabel.Text = "Last Name:";
            // 
            // uxDoctorFirstNameLabel
            // 
            this.uxDoctorFirstNameLabel.AutoSize = true;
            this.uxDoctorFirstNameLabel.Location = new System.Drawing.Point(28, 40);
            this.uxDoctorFirstNameLabel.Name = "uxDoctorFirstNameLabel";
            this.uxDoctorFirstNameLabel.Size = new System.Drawing.Size(90, 20);
            this.uxDoctorFirstNameLabel.TabIndex = 0;
            this.uxDoctorFirstNameLabel.Text = "First Name:";
            // 
            // uxConditionSearch
            // 
            this.uxConditionSearch.Controls.Add(this.uxGetConditionHistory);
            this.uxConditionSearch.Controls.Add(this.uxGetConditionPatients);
            this.uxConditionSearch.Controls.Add(this.uxGetConditionDoctors);
            this.uxConditionSearch.Controls.Add(this.uxConditionCommonName);
            this.uxConditionSearch.Controls.Add(this.uxConditionCommonNameLabel);
            this.uxConditionSearch.Location = new System.Drawing.Point(12, 270);
            this.uxConditionSearch.Name = "uxConditionSearch";
            this.uxConditionSearch.Size = new System.Drawing.Size(1169, 123);
            this.uxConditionSearch.TabIndex = 3;
            this.uxConditionSearch.TabStop = false;
            this.uxConditionSearch.Text = "Condition Search";
            // 
            // uxGetConditionHistory
            // 
            this.uxGetConditionHistory.Location = new System.Drawing.Point(1070, 72);
            this.uxGetConditionHistory.Name = "uxGetConditionHistory";
            this.uxGetConditionHistory.Size = new System.Drawing.Size(93, 35);
            this.uxGetConditionHistory.TabIndex = 11;
            this.uxGetConditionHistory.Text = "History";
            this.uxGetConditionHistory.UseVisualStyleBackColor = true;
            this.uxGetConditionHistory.Click += new System.EventHandler(this.uxGetConditionHistory_Click);
            // 
            // uxGetConditionPatients
            // 
            this.uxGetConditionPatients.Location = new System.Drawing.Point(972, 25);
            this.uxGetConditionPatients.Name = "uxGetConditionPatients";
            this.uxGetConditionPatients.Size = new System.Drawing.Size(92, 35);
            this.uxGetConditionPatients.TabIndex = 6;
            this.uxGetConditionPatients.Text = "Patients";
            this.uxGetConditionPatients.UseVisualStyleBackColor = true;
            this.uxGetConditionPatients.Click += new System.EventHandler(this.uxGetConditionPatients_Click);
            // 
            // uxGetConditionDoctors
            // 
            this.uxGetConditionDoctors.Location = new System.Drawing.Point(1070, 25);
            this.uxGetConditionDoctors.Name = "uxGetConditionDoctors";
            this.uxGetConditionDoctors.Size = new System.Drawing.Size(93, 35);
            this.uxGetConditionDoctors.TabIndex = 8;
            this.uxGetConditionDoctors.Text = "Doctors";
            this.uxGetConditionDoctors.UseVisualStyleBackColor = true;
            this.uxGetConditionDoctors.Click += new System.EventHandler(this.uxGetConditionDoctors_Click);
            // 
            // uxConditionCommonName
            // 
            this.uxConditionCommonName.Location = new System.Drawing.Point(32, 70);
            this.uxConditionCommonName.Name = "uxConditionCommonName";
            this.uxConditionCommonName.Size = new System.Drawing.Size(195, 26);
            this.uxConditionCommonName.TabIndex = 3;
            // 
            // uxConditionCommonNameLabel
            // 
            this.uxConditionCommonNameLabel.AutoSize = true;
            this.uxConditionCommonNameLabel.Location = new System.Drawing.Point(28, 40);
            this.uxConditionCommonNameLabel.Name = "uxConditionCommonNameLabel";
            this.uxConditionCommonNameLabel.Size = new System.Drawing.Size(123, 20);
            this.uxConditionCommonNameLabel.TabIndex = 0;
            this.uxConditionCommonNameLabel.Text = "Common Name:";
            // 
            // uxResultsGrid
            // 
            this.uxResultsGrid.AllowUserToAddRows = false;
            this.uxResultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxResultsGrid.Location = new System.Drawing.Point(13, 400);
            this.uxResultsGrid.Name = "uxResultsGrid";
            this.uxResultsGrid.ReadOnly = true;
            this.uxResultsGrid.RowHeadersWidth = 62;
            this.uxResultsGrid.RowTemplate.Height = 28;
            this.uxResultsGrid.Size = new System.Drawing.Size(1168, 354);
            this.uxResultsGrid.TabIndex = 4;
            // 
            // SearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 766);
            this.Controls.Add(this.uxResultsGrid);
            this.Controls.Add(this.uxConditionSearch);
            this.Controls.Add(this.uxDoctorSearch);
            this.Controls.Add(this.uxPatientSearch);
            this.Name = "SearchPage";
            this.Text = "Search Hospital Database";
            this.uxPatientSearch.ResumeLayout(false);
            this.uxPatientSearch.PerformLayout();
            this.uxDoctorSearch.ResumeLayout(false);
            this.uxDoctorSearch.PerformLayout();
            this.uxConditionSearch.ResumeLayout(false);
            this.uxConditionSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxResultsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox uxPatientSearch;
        private System.Windows.Forms.Label uxPatientBirthDateLabel;
        private System.Windows.Forms.TextBox uxPatientLastName;
        private System.Windows.Forms.TextBox uxPatientFirstName;
        private System.Windows.Forms.DateTimePicker uxPatientBirthDate;
        private System.Windows.Forms.Label uxPatientLastNameLabel;
        private System.Windows.Forms.Label uxPatientFirstNameLabel;
        private System.Windows.Forms.Button uxGetPatientDoctors;
        private System.Windows.Forms.Button uxGetPatientTreatments;
        private System.Windows.Forms.Button uxGetPatientConditions;
        private System.Windows.Forms.Button uxGetPatientStays;
        private System.Windows.Forms.Button uxGetPatientEmergencyContactInfo;
        private System.Windows.Forms.Button uxGetPatientInfo;
        private System.Windows.Forms.GroupBox uxDoctorSearch;
        private System.Windows.Forms.TextBox uxDoctorUnit;
        private System.Windows.Forms.Button uxGetDoctorConditionHistory;
        private System.Windows.Forms.Button uxGetDoctorInfo;
        private System.Windows.Forms.Button uxGetDoctorPatients;
        private System.Windows.Forms.Label uxDoctorUnitLabel;
        private System.Windows.Forms.TextBox uxDoctorLastName;
        private System.Windows.Forms.TextBox uxDoctorFirstName;
        private System.Windows.Forms.Label uxDoctorLastNameLabel;
        private System.Windows.Forms.Label uxDoctorFirstNameLabel;
        private System.Windows.Forms.GroupBox uxConditionSearch;
        private System.Windows.Forms.Button uxGetConditionHistory;
        private System.Windows.Forms.Button uxGetConditionPatients;
        private System.Windows.Forms.Button uxGetConditionDoctors;
        private System.Windows.Forms.TextBox uxConditionCommonName;
        private System.Windows.Forms.Label uxConditionCommonNameLabel;
        private System.Windows.Forms.DataGridView uxResultsGrid;
    }
}