namespace ProjectApplication
{
    partial class LandingPage
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
            this.uxWelcomeMessage = new System.Windows.Forms.Label();
            this.uxSearch = new System.Windows.Forms.Button();
            this.uxAddUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxWelcomeMessage
            // 
            this.uxWelcomeMessage.AutoSize = true;
            this.uxWelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWelcomeMessage.Location = new System.Drawing.Point(39, 69);
            this.uxWelcomeMessage.Name = "uxWelcomeMessage";
            this.uxWelcomeMessage.Size = new System.Drawing.Size(717, 29);
            this.uxWelcomeMessage.TabIndex = 1;
            this.uxWelcomeMessage.Text = "Welcome to the CIS560 Hospital Database Management Program!";
            // 
            // uxSearch
            // 
            this.uxSearch.Location = new System.Drawing.Point(62, 165);
            this.uxSearch.Name = "uxSearch";
            this.uxSearch.Size = new System.Drawing.Size(268, 226);
            this.uxSearch.TabIndex = 2;
            this.uxSearch.Text = "Search Database";
            this.uxSearch.UseVisualStyleBackColor = true;
            this.uxSearch.Click += new System.EventHandler(this.uxSearch_Click);
            // 
            // uxAddUpdate
            // 
            this.uxAddUpdate.Location = new System.Drawing.Point(461, 165);
            this.uxAddUpdate.Name = "uxAddUpdate";
            this.uxAddUpdate.Size = new System.Drawing.Size(268, 226);
            this.uxAddUpdate.TabIndex = 3;
            this.uxAddUpdate.Text = "Update/Add to Database";
            this.uxAddUpdate.UseVisualStyleBackColor = true;
            this.uxAddUpdate.Click += new System.EventHandler(this.uxAddUpdate_Click);
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxAddUpdate);
            this.Controls.Add(this.uxSearch);
            this.Controls.Add(this.uxWelcomeMessage);
            this.Name = "LandingPage";
            this.Text = "Hospital Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label uxWelcomeMessage;
        private System.Windows.Forms.Button uxSearch;
        private System.Windows.Forms.Button uxAddUpdate;
    }
}

