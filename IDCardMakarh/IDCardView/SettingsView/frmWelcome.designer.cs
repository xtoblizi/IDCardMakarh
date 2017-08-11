namespace IDCardView.Settings
{
    partial class frmWelcome
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
            this.label2 = new System.Windows.Forms.Label();
            this.grpBoxSelectMode = new System.Windows.Forms.GroupBox();
            this.grpBoxDescription = new System.Windows.Forms.GroupBox();
            this.lnkLblHelp = new System.Windows.Forms.LinkLabel();
            this.btnNext = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grpBoxSelectMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Product Evaluation Mode";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thanks for your interest in IDCard Maker";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // grpBoxSelectMode
            // 
            this.grpBoxSelectMode.Controls.Add(this.comboBox1);
            this.grpBoxSelectMode.Location = new System.Drawing.Point(16, 68);
            this.grpBoxSelectMode.Name = "grpBoxSelectMode";
            this.grpBoxSelectMode.Size = new System.Drawing.Size(188, 88);
            this.grpBoxSelectMode.TabIndex = 2;
            this.grpBoxSelectMode.TabStop = false;
            this.grpBoxSelectMode.Text = "Select Usage Mode";
            this.grpBoxSelectMode.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grpBoxDescription
            // 
            this.grpBoxDescription.Location = new System.Drawing.Point(219, 12);
            this.grpBoxDescription.Name = "grpBoxDescription";
            this.grpBoxDescription.Size = new System.Drawing.Size(215, 144);
            this.grpBoxDescription.TabIndex = 3;
            this.grpBoxDescription.TabStop = false;
            this.grpBoxDescription.Text = "Description";
            this.grpBoxDescription.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lnkLblHelp
            // 
            this.lnkLblHelp.AutoSize = true;
            this.lnkLblHelp.Location = new System.Drawing.Point(18, 174);
            this.lnkLblHelp.Name = "lnkLblHelp";
            this.lnkLblHelp.Size = new System.Drawing.Size(165, 13);
            this.lnkLblHelp.TabIndex = 4;
            this.lnkLblHelp.TabStop = true;
            this.lnkLblHelp.Text = "More Details about Usage Modes";
            this.lnkLblHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNext.Location = new System.Drawing.Point(367, 166);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(67, 28);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(447, 206);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lnkLblHelp);
            this.Controls.Add(this.grpBoxDescription);
            this.Controls.Add(this.grpBoxSelectMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmWelcome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to IDcard Maker";
            this.grpBoxSelectMode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBoxSelectMode;
        private System.Windows.Forms.GroupBox grpBoxDescription;
        private System.Windows.Forms.LinkLabel lnkLblHelp;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}