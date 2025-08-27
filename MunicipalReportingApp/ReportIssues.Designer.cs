namespace MunicipalReportingApp
{
    partial class ReportIssues
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblAttachments;
        private System.Windows.Forms.Button btnAttachMedia;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSelectOnMap;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblCopyright;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblAttachments = new System.Windows.Forms.Label();
            this.btnAttachMedia = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSelectOnMap = new System.Windows.Forms.Button();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.footerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblTitle.Size = new System.Drawing.Size(582, 77);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Report an Issue";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Location
            // 
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLocation.Location = new System.Drawing.Point(45, 100);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(120, 30);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location:";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLocation.Location = new System.Drawing.Point(175, 100);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(215, 30);
            this.txtLocation.TabIndex = 2;
            // 
            // btnSelectOnMap
            // 
            this.btnSelectOnMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnSelectOnMap.FlatAppearance.BorderSize = 0;
            this.btnSelectOnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectOnMap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelectOnMap.ForeColor = System.Drawing.Color.White;
            this.btnSelectOnMap.Location = new System.Drawing.Point(400, 100);
            this.btnSelectOnMap.Name = "btnSelectOnMap";
            this.btnSelectOnMap.Size = new System.Drawing.Size(125, 30);
            this.btnSelectOnMap.TabIndex = 3;
            this.btnSelectOnMap.Text = "Select on Map";
            this.btnSelectOnMap.UseVisualStyleBackColor = false;
            this.btnSelectOnMap.Click += new System.EventHandler(this.btnSelectOnMap_Click);
            // 
            // Category
            // 
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategory.Location = new System.Drawing.Point(45, 150);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(120, 30);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category:";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "Road Maintenance",
            "Water Supply",
            "Electricity",
            "Waste Management",
            "Other"});
            this.cboCategory.Location = new System.Drawing.Point(175, 150);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(350, 31);
            this.cboCategory.TabIndex = 5;
            // 
            // Description
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.Location = new System.Drawing.Point(45, 200);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(120, 30);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbDescription.Location = new System.Drawing.Point(175, 200);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(350, 150);
            this.rtbDescription.TabIndex = 7;
            this.rtbDescription.Text = "";
            // 
            // Attachments
            // 
            this.lblAttachments.ForeColor = System.Drawing.Color.Gray;
            this.lblAttachments.Location = new System.Drawing.Point(335, 370);
            this.lblAttachments.Name = "lblAttachments";
            this.lblAttachments.Size = new System.Drawing.Size(190, 40);
            this.lblAttachments.TabIndex = 9;
            this.lblAttachments.Text = "No file chosen...";
            this.lblAttachments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAttachMedia
            // 
            this.btnAttachMedia.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAttachMedia.FlatAppearance.BorderSize = 0;
            this.btnAttachMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttachMedia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAttachMedia.ForeColor = System.Drawing.Color.White;
            this.btnAttachMedia.Location = new System.Drawing.Point(175, 370);
            this.btnAttachMedia.Name = "btnAttachMedia";
            this.btnAttachMedia.Size = new System.Drawing.Size(150, 40);
            this.btnAttachMedia.TabIndex = 8;
            this.btnAttachMedia.Text = "Attach Media";
            this.btnAttachMedia.UseVisualStyleBackColor = false;
            this.btnAttachMedia.Click += new System.EventHandler(this.BtnAttachMedia_Click);
            // 
            // Submit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(175, 430);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 45);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // Back
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(305, 430);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 45);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.lblCopyright);
            this.footerPanel.Controls.Add(this.lblCompany);
            this.footerPanel.Controls.Add(this.logoPictureBox);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 500);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(582, 100);
            this.footerPanel.TabIndex = 12;
            // 
            // logoPictureBox
            // 
            // IMPORTANT: Set the Image property in the form's constructor in ReportIssues.cs
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
            this.lblCompany.Location = new System.Drawing.Point(126, 30);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(420, 23);
            this.lblCompany.TabIndex = 1;
            this.lblCompany.Text = "Municipal Services Inc.";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCopyright.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCopyright.Location = new System.Drawing.Point(126, 55);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(420, 19);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "© 2024 Municipal Services Inc. All rights reserved.";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReportIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(582, 600);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSelectOnMap);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblAttachments);
            this.Controls.Add(this.btnAttachMedia);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReportIssues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report an Issue";
            this.footerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
