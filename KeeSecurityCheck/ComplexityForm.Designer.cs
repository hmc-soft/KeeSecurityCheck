namespace KeeSecurityCheck
{
    partial class ComplexityForm
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
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(7, 20);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(285, 20);
            this.passwordBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Check Complexity";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(4, 52);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(89, 13);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Not Yet Checked";
            // 
            // ComplexityForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 86);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(320, 125);
            this.MinimumSize = new System.Drawing.Size(320, 125);
            this.Name = "ComplexityForm";
            this.Text = "Check Password Complexity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label resultLabel;
    }
}