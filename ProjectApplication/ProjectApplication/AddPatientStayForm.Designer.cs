namespace ProjectApplication
{
    partial class AddPatientStayForm
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
            this.uxPatientIDLabel = new System.Windows.Forms.Label();
            this.uxAdmittanceLabel = new System.Windows.Forms.Label();
            this.uxDischargeLabel = new System.Windows.Forms.Label();
            this.uxRoomNumberLabel = new System.Windows.Forms.Label();
            this.uxUnitLabel = new System.Windows.Forms.Label();
            this.uxConditionLabel = new System.Windows.Forms.Label();
            this.uxTreatmentLabel = new System.Windows.Forms.Label();
            this.uxDoctorIdLabel = new System.Windows.Forms.Label();
            this.uxAddPatientStayToDatabaseButton = new System.Windows.Forms.Button();
            this.uxPatientIDBox = new System.Windows.Forms.TextBox();
            this.uxDoctorIDBox = new System.Windows.Forms.TextBox();
            this.uxRoomNumberBox = new System.Windows.Forms.TextBox();
            this.uxUnitBox = new System.Windows.Forms.TextBox();
            this.uxConditionBox = new System.Windows.Forms.TextBox();
            this.uxTreatmentBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(119, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the patient\'s stay information:";
            // 
            // uxPatientIDLabel
            // 
            this.uxPatientIDLabel.AutoSize = true;
            this.uxPatientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPatientIDLabel.Location = new System.Drawing.Point(20, 89);
            this.uxPatientIDLabel.Name = "uxPatientIDLabel";
            this.uxPatientIDLabel.Size = new System.Drawing.Size(102, 25);
            this.uxPatientIDLabel.TabIndex = 1;
            this.uxPatientIDLabel.Text = "Patient ID:";
            // 
            // uxAdmittanceLabel
            // 
            this.uxAdmittanceLabel.AutoSize = true;
            this.uxAdmittanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAdmittanceLabel.Location = new System.Drawing.Point(300, 89);
            this.uxAdmittanceLabel.Name = "uxAdmittanceLabel";
            this.uxAdmittanceLabel.Size = new System.Drawing.Size(304, 25);
            this.uxAdmittanceLabel.TabIndex = 2;
            this.uxAdmittanceLabel.Text = "Admittance Date(MM-DD-YYYY):";
            // 
            // uxDischargeLabel
            // 
            this.uxDischargeLabel.AutoSize = true;
            this.uxDischargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDischargeLabel.Location = new System.Drawing.Point(300, 154);
            this.uxDischargeLabel.Name = "uxDischargeLabel";
            this.uxDischargeLabel.Size = new System.Drawing.Size(305, 25);
            this.uxDischargeLabel.TabIndex = 3;
            this.uxDischargeLabel.Text = "Discharge Date: (MM-DD-YYYY):";
            // 
            // uxRoomNumberLabel
            // 
            this.uxRoomNumberLabel.AutoSize = true;
            this.uxRoomNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRoomNumberLabel.Location = new System.Drawing.Point(14, 222);
            this.uxRoomNumberLabel.Name = "uxRoomNumberLabel";
            this.uxRoomNumberLabel.Size = new System.Drawing.Size(143, 25);
            this.uxRoomNumberLabel.TabIndex = 4;
            this.uxRoomNumberLabel.Text = "Room Number:";
            // 
            // uxUnitLabel
            // 
            this.uxUnitLabel.AutoSize = true;
            this.uxUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUnitLabel.Location = new System.Drawing.Point(300, 225);
            this.uxUnitLabel.Name = "uxUnitLabel";
            this.uxUnitLabel.Size = new System.Drawing.Size(52, 25);
            this.uxUnitLabel.TabIndex = 5;
            this.uxUnitLabel.Text = "Unit:";
            // 
            // uxConditionLabel
            // 
            this.uxConditionLabel.AutoSize = true;
            this.uxConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxConditionLabel.Location = new System.Drawing.Point(14, 302);
            this.uxConditionLabel.Name = "uxConditionLabel";
            this.uxConditionLabel.Size = new System.Drawing.Size(125, 25);
            this.uxConditionLabel.TabIndex = 6;
            this.uxConditionLabel.Text = "Condition ID:";
            // 
            // uxTreatmentLabel
            // 
            this.uxTreatmentLabel.AutoSize = true;
            this.uxTreatmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTreatmentLabel.Location = new System.Drawing.Point(446, 302);
            this.uxTreatmentLabel.Name = "uxTreatmentLabel";
            this.uxTreatmentLabel.Size = new System.Drawing.Size(131, 25);
            this.uxTreatmentLabel.TabIndex = 7;
            this.uxTreatmentLabel.Text = "Treatment ID:";
            // 
            // uxDoctorIdLabel
            // 
            this.uxDoctorIdLabel.AutoSize = true;
            this.uxDoctorIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDoctorIdLabel.Location = new System.Drawing.Point(14, 151);
            this.uxDoctorIdLabel.Name = "uxDoctorIdLabel";
            this.uxDoctorIdLabel.Size = new System.Drawing.Size(187, 25);
            this.uxDoctorIdLabel.TabIndex = 8;
            this.uxDoctorIdLabel.Text = "Doctor\'s ID Number:";
            // 
            // uxAddPatientStayToDatabaseButton
            // 
            this.uxAddPatientStayToDatabaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxAddPatientStayToDatabaseButton.Location = new System.Drawing.Point(225, 368);
            this.uxAddPatientStayToDatabaseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxAddPatientStayToDatabaseButton.Name = "uxAddPatientStayToDatabaseButton";
            this.uxAddPatientStayToDatabaseButton.Size = new System.Drawing.Size(434, 71);
            this.uxAddPatientStayToDatabaseButton.TabIndex = 9;
            this.uxAddPatientStayToDatabaseButton.Text = "Add Patient Stay to Database";
            this.uxAddPatientStayToDatabaseButton.UseVisualStyleBackColor = true;
            this.uxAddPatientStayToDatabaseButton.Click += new System.EventHandler(this.uxAddPatientStayToDatabaseButton_Click);
            // 
            // uxPatientIDBox
            // 
            this.uxPatientIDBox.Location = new System.Drawing.Point(126, 89);
            this.uxPatientIDBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxPatientIDBox.MaxLength = 10;
            this.uxPatientIDBox.Name = "uxPatientIDBox";
            this.uxPatientIDBox.Size = new System.Drawing.Size(88, 26);
            this.uxPatientIDBox.TabIndex = 10;
            // 
            // uxDoctorIDBox
            // 
            this.uxDoctorIDBox.Location = new System.Drawing.Point(205, 149);
            this.uxDoctorIDBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxDoctorIDBox.MaxLength = 10;
            this.uxDoctorIDBox.Name = "uxDoctorIDBox";
            this.uxDoctorIDBox.Size = new System.Drawing.Size(80, 26);
            this.uxDoctorIDBox.TabIndex = 11;
            // 
            // uxRoomNumberBox
            // 
            this.uxRoomNumberBox.Location = new System.Drawing.Point(159, 219);
            this.uxRoomNumberBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxRoomNumberBox.MaxLength = 3;
            this.uxRoomNumberBox.Name = "uxRoomNumberBox";
            this.uxRoomNumberBox.Size = new System.Drawing.Size(112, 26);
            this.uxRoomNumberBox.TabIndex = 14;
            // 
            // uxUnitBox
            // 
            this.uxUnitBox.Location = new System.Drawing.Point(357, 222);
            this.uxUnitBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxUnitBox.MaxLength = 64;
            this.uxUnitBox.Name = "uxUnitBox";
            this.uxUnitBox.Size = new System.Drawing.Size(529, 26);
            this.uxUnitBox.TabIndex = 15;
            // 
            // uxConditionBox
            // 
            this.uxConditionBox.Location = new System.Drawing.Point(140, 302);
            this.uxConditionBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxConditionBox.MaxLength = 64;
            this.uxConditionBox.Name = "uxConditionBox";
            this.uxConditionBox.Size = new System.Drawing.Size(299, 26);
            this.uxConditionBox.TabIndex = 16;
            // 
            // uxTreatmentBox
            // 
            this.uxTreatmentBox.Location = new System.Drawing.Point(578, 301);
            this.uxTreatmentBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxTreatmentBox.MaxLength = 64;
            this.uxTreatmentBox.Name = "uxTreatmentBox";
            this.uxTreatmentBox.Size = new System.Drawing.Size(308, 26);
            this.uxTreatmentBox.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(600, 86);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(286, 26);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(600, 151);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(285, 26);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // AddPatientStayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 454);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.uxTreatmentBox);
            this.Controls.Add(this.uxConditionBox);
            this.Controls.Add(this.uxUnitBox);
            this.Controls.Add(this.uxRoomNumberBox);
            this.Controls.Add(this.uxDoctorIDBox);
            this.Controls.Add(this.uxPatientIDBox);
            this.Controls.Add(this.uxAddPatientStayToDatabaseButton);
            this.Controls.Add(this.uxDoctorIdLabel);
            this.Controls.Add(this.uxTreatmentLabel);
            this.Controls.Add(this.uxConditionLabel);
            this.Controls.Add(this.uxUnitLabel);
            this.Controls.Add(this.uxRoomNumberLabel);
            this.Controls.Add(this.uxDischargeLabel);
            this.Controls.Add(this.uxAdmittanceLabel);
            this.Controls.Add(this.uxPatientIDLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddPatientStayForm";
            this.Text = "AddPatientStayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uxPatientIDLabel;
        private System.Windows.Forms.Label uxAdmittanceLabel;
        private System.Windows.Forms.Label uxDischargeLabel;
        private System.Windows.Forms.Label uxRoomNumberLabel;
        private System.Windows.Forms.Label uxUnitLabel;
        private System.Windows.Forms.Label uxConditionLabel;
        private System.Windows.Forms.Label uxTreatmentLabel;
        private System.Windows.Forms.Label uxDoctorIdLabel;
        private System.Windows.Forms.Button uxAddPatientStayToDatabaseButton;
        private System.Windows.Forms.TextBox uxPatientIDBox;
        private System.Windows.Forms.TextBox uxDoctorIDBox;
        private System.Windows.Forms.TextBox uxRoomNumberBox;
        private System.Windows.Forms.TextBox uxUnitBox;
        private System.Windows.Forms.TextBox uxConditionBox;
        private System.Windows.Forms.TextBox uxTreatmentBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}