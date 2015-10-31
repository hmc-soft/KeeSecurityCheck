namespace KeeSecurityCheck
{
    partial class SecurityCheckForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.complexitySlider = new System.Windows.Forms.TrackBar();
            this.checkComplexity = new System.Windows.Forms.CheckBox();
            this.lengthToCheckInput = new System.Windows.Forms.NumericUpDown();
            this.checkLength = new System.Windows.Forms.CheckBox();
            this.checkDuplicates = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.runCheckButton = new System.Windows.Forms.Button();
            this.checkResultsView = new System.Windows.Forms.TreeView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.complexitySlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthToCheckInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.complexitySlider);
            this.groupBox1.Controls.Add(this.checkComplexity);
            this.groupBox1.Controls.Add(this.lengthToCheckInput);
            this.groupBox1.Controls.Add(this.checkLength);
            this.groupBox1.Controls.Add(this.checkDuplicates);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // complexitySlider
            // 
            this.complexitySlider.LargeChange = 1;
            this.complexitySlider.Location = new System.Drawing.Point(9, 91);
            this.complexitySlider.Maximum = 5;
            this.complexitySlider.Minimum = 2;
            this.complexitySlider.Name = "complexitySlider";
            this.complexitySlider.Size = new System.Drawing.Size(258, 45);
            this.complexitySlider.TabIndex = 4;
            this.complexitySlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.complexitySlider.Value = 3;
            // 
            // checkComplexity
            // 
            this.checkComplexity.AutoSize = true;
            this.checkComplexity.Checked = true;
            this.checkComplexity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkComplexity.Location = new System.Drawing.Point(7, 68);
            this.checkComplexity.Name = "checkComplexity";
            this.checkComplexity.Size = new System.Drawing.Size(159, 17);
            this.checkComplexity.TabIndex = 3;
            this.checkComplexity.Text = "Check Password Complexity";
            this.checkComplexity.UseVisualStyleBackColor = true;
            // 
            // lengthToCheckInput
            // 
            this.lengthToCheckInput.Location = new System.Drawing.Point(156, 44);
            this.lengthToCheckInput.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.lengthToCheckInput.Name = "lengthToCheckInput";
            this.lengthToCheckInput.Size = new System.Drawing.Size(111, 20);
            this.lengthToCheckInput.TabIndex = 2;
            this.lengthToCheckInput.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // checkLength
            // 
            this.checkLength.AutoSize = true;
            this.checkLength.Checked = true;
            this.checkLength.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkLength.Location = new System.Drawing.Point(7, 44);
            this.checkLength.Name = "checkLength";
            this.checkLength.Size = new System.Drawing.Size(142, 17);
            this.checkLength.TabIndex = 1;
            this.checkLength.Text = "Check Password Length";
            this.checkLength.UseVisualStyleBackColor = true;
            // 
            // checkDuplicates
            // 
            this.checkDuplicates.AutoSize = true;
            this.checkDuplicates.Checked = true;
            this.checkDuplicates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDuplicates.Location = new System.Drawing.Point(7, 20);
            this.checkDuplicates.Name = "checkDuplicates";
            this.checkDuplicates.Size = new System.Drawing.Size(177, 17);
            this.checkDuplicates.TabIndex = 0;
            this.checkDuplicates.Text = "Check For Duplicate Passwords";
            this.checkDuplicates.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.runCheckButton);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.checkResultsView);
            this.splitContainer1.Size = new System.Drawing.Size(283, 486);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Very\r\nStrong";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Strong";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Medium";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Weak";
            // 
            // runCheckButton
            // 
            this.runCheckButton.Location = new System.Drawing.Point(202, 182);
            this.runCheckButton.Name = "runCheckButton";
            this.runCheckButton.Size = new System.Drawing.Size(75, 23);
            this.runCheckButton.TabIndex = 1;
            this.runCheckButton.Text = "Run Check";
            this.runCheckButton.UseVisualStyleBackColor = true;
            this.runCheckButton.Click += new System.EventHandler(this.runCheckButton_Click);
            // 
            // checkResultsView
            // 
            this.checkResultsView.Location = new System.Drawing.Point(4, 4);
            this.checkResultsView.Name = "checkResultsView";
            this.checkResultsView.Size = new System.Drawing.Size(276, 238);
            this.checkResultsView.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(101, 17);
            this.statusLabel.Text = "Check not Started";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Check Password";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SecurityCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 486);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 525);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 525);
            this.Name = "SecurityCheckForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Security Check by HMC-soft";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.complexitySlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthToCheckInput)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar complexitySlider;
        private System.Windows.Forms.CheckBox checkComplexity;
        private System.Windows.Forms.NumericUpDown lengthToCheckInput;
        private System.Windows.Forms.CheckBox checkLength;
        private System.Windows.Forms.CheckBox checkDuplicates;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button runCheckButton;
        private System.Windows.Forms.TreeView checkResultsView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}