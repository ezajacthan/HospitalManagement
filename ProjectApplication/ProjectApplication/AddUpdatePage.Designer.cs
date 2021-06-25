namespace ProjectApplication
{
    partial class AddUpdatePage
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
            this.uxAddLabel = new System.Windows.Forms.Label();
            this.uxAddPatientButton = new System.Windows.Forms.Button();
            this.uxAddDoctorButton = new System.Windows.Forms.Button();
            this.uxAddPatientStay = new System.Windows.Forms.Button();
            this.uxAddConditionButton = new System.Windows.Forms.Button();
            this.uxAddTreatmentButton = new System.Windows.Forms.Button();
            this.uxAddContactButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxAddLabel
            // 
            this.uxAddLabel.AutoSize = true;
            this.uxAddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddLabel.Location = new System.Drawing.Point(133, 11);
            this.uxAddLabel.Name = "uxAddLabel";
            this.uxAddLabel.Size = new System.Drawing.Size(612, 38);
            this.uxAddLabel.TabIndex = 0;
            this.uxAddLabel.Text = "Please select what you would like to add:";
            // 
            // uxAddPatientButton
            // 
            this.uxAddPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddPatientButton.Location = new System.Drawing.Point(45, 74);
            this.uxAddPatientButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxAddPatientButton.Name = "uxAddPatientButton";
            this.uxAddPatientButton.Size = new System.Drawing.Size(333, 134);
            this.uxAddPatientButton.TabIndex = 1;
            this.uxAddPatientButton.Text = "Add/Update Patient";
            this.uxAddPatientButton.UseVisualStyleBackColor = true;
            this.uxAddPatientButton.Click += new System.EventHandler(this.uxAddPatientButton_Click);
            // 
            // uxAddDoctorButton
            // 
            this.uxAddDoctorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddDoctorButton.Location = new System.Drawing.Point(465, 74);
            this.uxAddDoctorButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxAddDoctorButton.Name = "uxAddDoctorButton";
            this.uxAddDoctorButton.Size = new System.Drawing.Size(333, 134);
            this.uxAddDoctorButton.TabIndex = 2;
            this.uxAddDoctorButton.Text = "Add/Update Doctor";
            this.uxAddDoctorButton.UseVisualStyleBackColor = true;
            this.uxAddDoctorButton.Click += new System.EventHandler(this.uxAddDoctorButton_Click);
            // 
            // uxAddPatientStay
            // 
            this.uxAddPatientStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxAddPatientStay.Location = new System.Drawing.Point(45, 238);
            this.uxAddPatientStay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxAddPatientStay.Name = "uxAddPatientStay";
            this.uxAddPatientStay.Size = new System.Drawing.Size(333, 134);
            this.uxAddPatientStay.TabIndex = 3;
            this.uxAddPatientStay.Text = "Add/Update Patient Stay";
            this.uxAddPatientStay.UseVisualStyleBackColor = true;
            this.uxAddPatientStay.Click += new System.EventHandler(this.uxAddPatientStay_Click);
            // 
            // uxAddConditionButton
            // 
            this.uxAddConditionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxAddConditionButton.Location = new System.Drawing.Point(45, 414);
            this.uxAddConditionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxAddConditionButton.Name = "uxAddConditionButton";
            this.uxAddConditionButton.Size = new System.Drawing.Size(333, 134);
            this.uxAddConditionButton.TabIndex = 5;
            this.uxAddConditionButton.Text = "Add/Update Condition";
            this.uxAddConditionButton.UseVisualStyleBackColor = true;
            this.uxAddConditionButton.Click += new System.EventHandler(this.uxAddConditionButton_Click);
            // 
            // uxAddTreatmentButton
            // 
            this.uxAddTreatmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxAddTreatmentButton.Location = new System.Drawing.Point(465, 414);
            this.uxAddTreatmentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxAddTreatmentButton.Name = "uxAddTreatmentButton";
            this.uxAddTreatmentButton.Size = new System.Drawing.Size(333, 134);
            this.uxAddTreatmentButton.TabIndex = 6;
            this.uxAddTreatmentButton.Text = "Add/Update Treatment";
            this.uxAddTreatmentButton.UseVisualStyleBackColor = true;
            this.uxAddTreatmentButton.Click += new System.EventHandler(this.uxAddTreatmentButton_Click);
            // 
            // uxAddContactButton
            // 
            this.uxAddContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxAddContactButton.Location = new System.Drawing.Point(465, 238);
            this.uxAddContactButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxAddContactButton.Name = "uxAddContactButton";
            this.uxAddContactButton.Size = new System.Drawing.Size(333, 134);
            this.uxAddContactButton.TabIndex = 7;
            this.uxAddContactButton.Text = "Add/Update Contact Info";
            this.uxAddContactButton.UseVisualStyleBackColor = true;
            this.uxAddContactButton.Click += new System.EventHandler(this.uxAddContactButton_Click);
            // 
            // AddUpdatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.uxAddContactButton);
            this.Controls.Add(this.uxAddTreatmentButton);
            this.Controls.Add(this.uxAddConditionButton);
            this.Controls.Add(this.uxAddPatientStay);
            this.Controls.Add(this.uxAddDoctorButton);
            this.Controls.Add(this.uxAddPatientButton);
            this.Controls.Add(this.uxAddLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddUpdatePage";
            this.Text = "AddUpdatePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxAddLabel;
        private System.Windows.Forms.Button uxAddPatientButton;
        private System.Windows.Forms.Button uxAddDoctorButton;
        private System.Windows.Forms.Button uxAddConditionButton;
        private System.Windows.Forms.Button uxAddTreatmentButton;
        private System.Windows.Forms.Button uxAddPatientStay;
        private System.Windows.Forms.Button uxAddContactButton;
    }
}