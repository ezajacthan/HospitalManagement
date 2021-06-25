namespace ProjectApplication
{
    partial class AddConditionForm
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
            this.uxCommonLabel = new System.Windows.Forms.Label();
            this.uxTechnicalLabel = new System.Windows.Forms.Label();
            this.uxCommonBox = new System.Windows.Forms.TextBox();
            this.uxTechnicalBox = new System.Windows.Forms.TextBox();
            this.uxAddConditionToDatabaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the condition information:";
            // 
            // uxCommonLabel
            // 
            this.uxCommonLabel.AutoSize = true;
            this.uxCommonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCommonLabel.Location = new System.Drawing.Point(13, 65);
            this.uxCommonLabel.Name = "uxCommonLabel";
            this.uxCommonLabel.Size = new System.Drawing.Size(130, 20);
            this.uxCommonLabel.TabIndex = 1;
            this.uxCommonLabel.Text = "Common Name:";
            // 
            // uxTechnicalLabel
            // 
            this.uxTechnicalLabel.AutoSize = true;
            this.uxTechnicalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTechnicalLabel.Location = new System.Drawing.Point(418, 65);
            this.uxTechnicalLabel.Name = "uxTechnicalLabel";
            this.uxTechnicalLabel.Size = new System.Drawing.Size(135, 20);
            this.uxTechnicalLabel.TabIndex = 2;
            this.uxTechnicalLabel.Text = "Technical Name:";
            // 
            // uxCommonBox
            // 
            this.uxCommonBox.Location = new System.Drawing.Point(150, 65);
            this.uxCommonBox.MaxLength = 64;
            this.uxCommonBox.Name = "uxCommonBox";
            this.uxCommonBox.Size = new System.Drawing.Size(262, 22);
            this.uxCommonBox.TabIndex = 3;
            // 
            // uxTechnicalBox
            // 
            this.uxTechnicalBox.Location = new System.Drawing.Point(559, 65);
            this.uxTechnicalBox.MaxLength = 64;
            this.uxTechnicalBox.Name = "uxTechnicalBox";
            this.uxTechnicalBox.Size = new System.Drawing.Size(229, 22);
            this.uxTechnicalBox.TabIndex = 4;
            // 
            // uxAddConditionToDatabaseButton
            // 
            this.uxAddConditionToDatabaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxAddConditionToDatabaseButton.Location = new System.Drawing.Point(208, 113);
            this.uxAddConditionToDatabaseButton.Name = "uxAddConditionToDatabaseButton";
            this.uxAddConditionToDatabaseButton.Size = new System.Drawing.Size(368, 76);
            this.uxAddConditionToDatabaseButton.TabIndex = 5;
            this.uxAddConditionToDatabaseButton.Text = "Add Condition to Database";
            this.uxAddConditionToDatabaseButton.UseVisualStyleBackColor = true;
            this.uxAddConditionToDatabaseButton.Click += new System.EventHandler(this.uxAddConditionToDatabaseButton_Click);
            // 
            // AddConditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 226);
            this.Controls.Add(this.uxAddConditionToDatabaseButton);
            this.Controls.Add(this.uxTechnicalBox);
            this.Controls.Add(this.uxCommonBox);
            this.Controls.Add(this.uxTechnicalLabel);
            this.Controls.Add(this.uxCommonLabel);
            this.Controls.Add(this.label1);
            this.Name = "AddConditionForm";
            this.Text = "AddConditionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uxCommonLabel;
        private System.Windows.Forms.Label uxTechnicalLabel;
        private System.Windows.Forms.TextBox uxCommonBox;
        private System.Windows.Forms.TextBox uxTechnicalBox;
        private System.Windows.Forms.Button uxAddConditionToDatabaseButton;
    }
}