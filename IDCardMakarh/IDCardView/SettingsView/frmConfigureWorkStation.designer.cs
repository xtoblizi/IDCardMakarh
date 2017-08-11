namespace IDCardView.Settings
{
    partial class frmConfigureWorkStation
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
            this.grpBoxWorkStation = new System.Windows.Forms.GroupBox();
            this.cmbWorkstationConfig = new System.Windows.Forms.ComboBox();
            this.grpBoxDescription = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.chkbShowOnStartup = new System.Windows.Forms.CheckBox();
            this.grpBoxWorkStation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxWorkStation
            // 
            this.grpBoxWorkStation.Controls.Add(this.cmbWorkstationConfig);
            this.grpBoxWorkStation.Location = new System.Drawing.Point(12, 12);
            this.grpBoxWorkStation.Name = "grpBoxWorkStation";
            this.grpBoxWorkStation.Size = new System.Drawing.Size(188, 91);
            this.grpBoxWorkStation.TabIndex = 0;
            this.grpBoxWorkStation.TabStop = false;
            this.grpBoxWorkStation.Text = "Select WorstationConfiguration";
            // 
            // cmbWorkstationConfig
            // 
            this.cmbWorkstationConfig.FormattingEnabled = true;
            this.cmbWorkstationConfig.Location = new System.Drawing.Point(9, 36);
            this.cmbWorkstationConfig.Name = "cmbWorkstationConfig";
            this.cmbWorkstationConfig.Size = new System.Drawing.Size(167, 21);
            this.cmbWorkstationConfig.TabIndex = 0;
            // 
            // grpBoxDescription
            // 
            this.grpBoxDescription.Location = new System.Drawing.Point(207, 12);
            this.grpBoxDescription.Name = "grpBoxDescription";
            this.grpBoxDescription.Size = new System.Drawing.Size(222, 151);
            this.grpBoxDescription.TabIndex = 1;
            this.grpBoxDescription.TabStop = false;
            this.grpBoxDescription.Text = "Description";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHelp.Location = new System.Drawing.Point(12, 138);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(78, 26);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNext.Location = new System.Drawing.Point(96, 139);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(78, 26);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // chkbShowOnStartup
            // 
            this.chkbShowOnStartup.AutoSize = true;
            this.chkbShowOnStartup.Location = new System.Drawing.Point(15, 112);
            this.chkbShowOnStartup.Name = "chkbShowOnStartup";
            this.chkbShowOnStartup.Size = new System.Drawing.Size(103, 17);
            this.chkbShowOnStartup.TabIndex = 4;
            this.chkbShowOnStartup.Text = "Show on startup";
            this.chkbShowOnStartup.UseVisualStyleBackColor = true;
            // 
            // frmConfigureWorkStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(441, 175);
            this.Controls.Add(this.chkbShowOnStartup);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.grpBoxDescription);
            this.Controls.Add(this.grpBoxWorkStation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmConfigureWorkStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure WorkStation";
            this.grpBoxWorkStation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxWorkStation;
        private System.Windows.Forms.ComboBox cmbWorkstationConfig;
        private System.Windows.Forms.GroupBox grpBoxDescription;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.CheckBox chkbShowOnStartup;
    }
}