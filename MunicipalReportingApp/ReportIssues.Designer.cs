namespace MunicipalReportingApp
{
    partial class ReportIssues
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
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
            this.components = new System.ComponentModel.Container();

            // Form properties
            this.Text = "Report an Issue";
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.LightBlue;

            // Title
            lblTitle = new System.Windows.Forms.Label()
            {
                Text = "Report an Issue",
                Font = new System.Drawing.Font("Arial", 18, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(180, 20),
                AutoSize = true
            };
            this.Controls.Add(lblTitle);

            // Location
            lblLocation = new System.Windows.Forms.Label() { Text = "Location:", Location = new System.Drawing.Point(50, 80), AutoSize = true };
            txtLocation = new System.Windows.Forms.TextBox() { Location = new System.Drawing.Point(150, 75), Width = 350 };
            this.Controls.Add(lblLocation);
            this.Controls.Add(txtLocation);

            // Category
            lblCategory = new System.Windows.Forms.Label() { Text = "Category:", Location = new System.Drawing.Point(50, 130), AutoSize = true };
            cboCategory = new System.Windows.Forms.ComboBox()
            {
                Location = new System.Drawing.Point(150, 125),
                Width = 350,
                DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            };
            cboCategory.Items.AddRange(new string[] { "Road Maintenance", "Water Supply", "Electricity", "Waste Management", "Other" });
            this.Controls.Add(lblCategory);
            this.Controls.Add(cboCategory);

            // Description
            lblDescription = new System.Windows.Forms.Label() { Text = "Description:", Location = new System.Drawing.Point(50, 180), AutoSize = true };
            rtbDescription = new System.Windows.Forms.RichTextBox() { Location = new System.Drawing.Point(150, 175), Width = 350, Height = 150 };
            this.Controls.Add(lblDescription);
            this.Controls.Add(rtbDescription);

            // Attachments
            lblAttachments = new System.Windows.Forms.Label() { Text = "No attachments", Location = new System.Drawing.Point(150, 340), AutoSize = true };
            btnAttachMedia = new System.Windows.Forms.Button() { Text = "Attach Media", Location = new System.Drawing.Point(50, 335), Width = 80 };
            btnAttachMedia.BackColor = System.Drawing.Color.DodgerBlue;
            btnAttachMedia.ForeColor = System.Drawing.Color.White;
            btnAttachMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAttachMedia.Click += BtnAttachMedia_Click;
            this.Controls.Add(lblAttachments);
            this.Controls.Add(btnAttachMedia);

            // Submit
            btnSubmit = new System.Windows.Forms.Button() { Text = "Submit", Location = new System.Drawing.Point(150, 400), Width = 100 };
            btnSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            btnSubmit.ForeColor = System.Drawing.Color.White;
            btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubmit.Click += BtnSubmit_Click;
            this.Controls.Add(btnSubmit);

            // Back
            btnBack = new System.Windows.Forms.Button() { Text = "Back", Location = new System.Drawing.Point(270, 400), Width = 100 };
            btnBack.BackColor = System.Drawing.Color.Gray;
            btnBack.ForeColor = System.Drawing.Color.White;
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.Click += BtnBack_Click;
            this.Controls.Add(btnBack);

            this.Load += new System.EventHandler(this.ReportIssues_Load);
        }
    }
}
