namespace MunicipalReportingApp
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnViewIssues;
        private System.Windows.Forms.Button btnSearchIssue;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnViewIssues = new System.Windows.Forms.Button();
            this.btnSearchIssue = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(500, 80);
            this.headerPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 80);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Municipal Reporting App";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReportIssues.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReportIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportIssues.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReportIssues.ForeColor = System.Drawing.Color.White;
            this.btnReportIssues.Location = new System.Drawing.Point(125, 150);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(250, 45);
            this.btnReportIssues.TabIndex = 1;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = false;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // btnViewIssues
            // 
            this.btnViewIssues.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewIssues.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewIssues.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewIssues.ForeColor = System.Drawing.Color.White;
            this.btnViewIssues.Location = new System.Drawing.Point(125, 215);
            this.btnViewIssues.Name = "btnViewIssues";
            this.btnViewIssues.Size = new System.Drawing.Size(250, 45);
            this.btnViewIssues.TabIndex = 2;
            this.btnViewIssues.Text = "View Submitted Issues";
            this.btnViewIssues.UseVisualStyleBackColor = false;
            this.btnViewIssues.Click += new System.EventHandler(this.btnViewIssues_Click);
            // 
            // btnSearchIssue
            // 
            this.btnSearchIssue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchIssue.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearchIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchIssue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchIssue.ForeColor = System.Drawing.Color.White;
            this.btnSearchIssue.Location = new System.Drawing.Point(125, 280);
            this.btnSearchIssue.Name = "btnSearchIssue";
            this.btnSearchIssue.Size = new System.Drawing.Size(250, 45);
            this.btnSearchIssue.TabIndex = 3;
            this.btnSearchIssue.Text = "Search for an Issue";
            this.btnSearchIssue.UseVisualStyleBackColor = false;
            this.btnSearchIssue.Click += new System.EventHandler(this.btnSearchIssue_Click);
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.lblCopyright);
            this.footerPanel.Controls.Add(this.lblCompany);
            this.footerPanel.Controls.Add(this.logoPictureBox);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 400);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(500, 100);
            this.footerPanel.TabIndex = 4;
            // 
            // logoPictureBox
            // 
            // IMPORTANT: Set the Image property in the form's constructor in MainMenuForm.cs
            // to avoid errors if the image file is missing at design time.
            // Example: this.logoPictureBox.Image = Image.FromFile("images/muncipality app.png");
            this.logoPictureBox.Location = new System.Drawing.Point(26, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(94, 94);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // lblCompany
            // 
            this.lblCompany.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCompany.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCompany.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCompany.Location = new System.Drawing.Point(125, 30);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(250, 23);
            this.lblCompany.TabIndex = 1;
            this.lblCompany.Text = "Municipal Services Inc.";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCopyright.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCopyright.Location = new System.Drawing.Point(125, 55);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(250, 19);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "© 2024 Municipal Services Inc. All rights reserved.";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.btnSearchIssue);
            this.Controls.Add(this.btnViewIssues);
            this.Controls.Add(this.btnReportIssues);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Municipal Reporting App - Municipal Services Inc.";
            this.headerPanel.ResumeLayout(false);
            this.footerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
