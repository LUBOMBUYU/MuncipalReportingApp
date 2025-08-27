namespace MunicipalReportingApp
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnViewIssues;
        private System.Windows.Forms.Button btnSearchIssue;
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
           // Title Label
this.lblTitle.Text = "Municipal Reporting App";
this.lblTitle.Font = new System.Drawing.Font("Arial", 24, System.Drawing.FontStyle.Bold);
this.lblTitle.AutoSize = true;
this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
this.lblTitle.BackColor = System.Drawing.Color.Transparent;
// Center horizontally
this.lblTitle.Location = new System.Drawing.Point((1000 - this.lblTitle.PreferredWidth) / 2, 30);

// btnReportIssues
this.btnReportIssues.Location = new System.Drawing.Point((1000 - 200) / 2, 120); // X = 200
this.btnReportIssues.Name = "btnReportIssues";
this.btnReportIssues.Size = new System.Drawing.Size(200, 50);
this.btnReportIssues.Text = "Report Issues";
this.btnReportIssues.BackColor = System.Drawing.Color.DodgerBlue;
this.btnReportIssues.ForeColor = System.Drawing.Color.White;
this.btnReportIssues.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);

// btnViewIssues
this.btnViewIssues.Location = new System.Drawing.Point((1000 - 200) / 2, 190);
this.btnViewIssues.Name = "btnViewIssues";
this.btnViewIssues.Size = new System.Drawing.Size(200, 50);
this.btnViewIssues.Text = "View Issues";
this.btnViewIssues.BackColor = System.Drawing.Color.DodgerBlue;
this.btnViewIssues.ForeColor = System.Drawing.Color.White;
this.btnViewIssues.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
this.btnViewIssues.Click += new System.EventHandler(this.btnViewIssues_Click);

// btnSearchIssue
this.btnSearchIssue.Location = new System.Drawing.Point((1000 - 200) / 2, 260);
this.btnSearchIssue.Name = "btnSearchIssue";
this.btnSearchIssue.Size = new System.Drawing.Size(200, 50);
this.btnSearchIssue.Text = "Search Issue";
this.btnSearchIssue.BackColor = System.Drawing.Color.DodgerBlue;
this.btnSearchIssue.ForeColor = System.Drawing.Color.White;
this.btnSearchIssue.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
this.btnSearchIssue.Click += new System.EventHandler(this.btnSearchIssue_Click);

            
            // MainMenuForm
            this.ClientSize = new System.Drawing.Size(1000, 400);
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReportIssues);
            this.Controls.Add(this.btnViewIssues);
            // Logo
            var logoPictureBox = new System.Windows.Forms.PictureBox
            {
                Image = Image.FromFile("images/muncipality app.png"), // Reference the logo from the specified path
                SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                Location = new System.Drawing.Point(10, this.ClientSize.Height - 100), // Adjust as needed
                Size = new System.Drawing.Size(100, 100) // Adjust size as needed
            };
            this.Controls.Add(logoPictureBox);
            this.Controls.Add(this.btnSearchIssue);
            this.Text = "Municipal Reporting App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
