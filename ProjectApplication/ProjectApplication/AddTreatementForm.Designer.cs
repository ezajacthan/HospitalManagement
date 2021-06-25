namespace ProjectApplication
{
    partial class AddTreatementForm
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
            this.uxNameLabel = new System.Windows.Forms.Label();
            this.uxAppTypeLabel = new System.Windows.Forms.Label();
            this.uxAppFreqLabel = new System.Windows.Forms.Label();
            this.uxAddTreatmentToDatabaseButton = new System.Windows.Forms.Button();
            this.uxNameBox = new System.Windows.Forms.TextBox();
            this.uxAppTypeBox = new System.Windows.Forms.TextBox();
            this.uxAppFreqBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the treatment information:";
            // 
            // uxNameLabel
            // 
            this.uxNameLabel.AutoSize = true;
            this.uxNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNameLabel.Location = new System.Drawing.Point(13, 66);
            this.uxNameLabel.Name = "uxNameLabel";
            this.uxNameLabel.Size = new System.Drawing.Size(58, 20);
            this.uxNameLabel.TabIndex = 1;
            this.uxNameLabel.Text = "Name:";
            // 
            // uxAppTypeLabel
            // 
            this.uxAppTypeLabel.AutoSize = true;
            this.uxAppTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAppTypeLabel.Location = new System.Drawing.Point(419, 65);
            this.uxAppTypeLabel.Name = "uxAppTypeLabel";
            this.uxAppTypeLabel.Size = new System.Drawing.Size(137, 20);
            this.uxAppTypeLabel.TabIndex = 2;
            this.uxAppTypeLabel.Text = "Application Type:";
            // 
            // uxAppFreqLabel
            // 
            this.uxAppFreqLabel.AutoSize = true;
            this.uxAppFreqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAppFreqLabel.Location = new System.Drawing.Point(13, 115);
            this.uxAppFreqLabel.Name = "uxAppFreqLabel";
            this.uxAppFreqLabel.Size = new System.Drawing.Size(179, 20);
            this.uxAppFreqLabel.TabIndex = 3;
            this.uxAppFreqLabel.Text = "Application Frequency:";
            // 
            // uxAddTreatmentToDatabaseButton
            // 
            this.uxAddTreatmentToDatabaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxAddTreatmentToDatabaseButton.Location = new System.Drawing.Point(422, 115);
            this.uxAddTreatmentToDatabaseButton.Name = "uxAddTreatmentToDatabaseButton";
            this.uxAddTreatmentToDatabaseButton.Size = new System.Drawing.Size(366, 69);
            this.uxAddTreatmentToDatabaseButton.TabIndex = 4;
            this.uxAddTreatmentToDatabaseButton.Text = "Add Treatment to Database";
            this.uxAddTreatmentToDatabaseButton.UseVisualStyleBackColor = true;
            this.uxAddTreatmentToDatabaseButton.Click += new System.EventHandler(this.uxAddTreatmentToDatabaseButton_Click);
            // 
            // uxNameBox
            // 
            this.uxNameBox.Location = new System.Drawing.Point(77, 65);
            this.uxNameBox.MaxLength = 64;
            this.uxNameBox.Name = "uxNameBox";
            this.uxNameBox.Size = new System.Drawing.Size(336, 22);
            this.uxNameBox.TabIndex = 5;
            // 
            // uxAppTypeBox
            // 
            this.uxAppTypeBox.Location = new System.Drawing.Point(562, 66);
            this.uxAppTypeBox.MaxLength = 64;
            this.uxAppTypeBox.Name = "uxAppTypeBox";
            this.uxAppTypeBox.Size = new System.Drawing.Size(226, 22);
            this.uxAppTypeBox.TabIndex = 6;
            // 
            // uxAppFreqBox
            // 
            this.uxAppFreqBox.Location = new System.Drawing.Point(198, 115);
            this.uxAppFreqBox.MaxLength = 64;
            this.uxAppFreqBox.Name = "uxAppFreqBox";
            this.uxAppFreqBox.Size = new System.Drawing.Size(215, 22);
            this.uxAppFreqBox.TabIndex = 7;
            // 
            // AddTreatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 225);
            this.Controls.Add(this.uxAppFreqBox);
            this.Controls.Add(this.uxAppTypeBox);
            this.Controls.Add(this.uxNameBox);
            this.Controls.Add(this.uxAddTreatmentToDatabaseButton);
            this.Controls.Add(this.uxAppFreqLabel);
            this.Controls.Add(this.uxAppTypeLabel);
            this.Controls.Add(this.uxNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "AddTreatementForm";
            this.Text = "AddTreatementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uxNameLabel;
        private System.Windows.Forms.Label uxAppTypeLabel;
        private System.Windows.Forms.Label uxAppFreqLabel;
        private System.Windows.Forms.Button uxAddTreatmentToDatabaseButton;
        private System.Windows.Forms.TextBox uxNameBox;
        private System.Windows.Forms.TextBox uxAppTypeBox;
        private System.Windows.Forms.TextBox uxAppFreqBox;
    }
}