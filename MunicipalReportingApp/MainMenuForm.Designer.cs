using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalReportingApp
{
    partial class MainMenuForm
    {
        private Label lblTitle;
        private Button btnReportIssues;
        private Button btnViewIssues;
        private Button btnSearchIssue;
        private Button btnLocalEvents;
        private Button btnServiceRequestStatus;

        private void InitializeComponent()
        {
            this.btnReportIssues = new Button();
            this.btnViewIssues = new System.Windows.Forms.Button();
            this.btnSearchIssue = new System.Windows.Forms.Button();
            this.btnLocalEvents = new Button();
            this.btnServiceRequestStatus = new Button();
            this.headerPanel = new Panel();
            this.SuspendLayout();

            // btnReportIssues
            this.btnReportIssues.Location = new Point(150, 80);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new Size(200, 50);
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.BackColor = Color.DodgerBlue;
            this.btnReportIssues.ForeColor = Color.White;
            this.btnReportIssues.FlatStyle = FlatStyle.Flat;
            this.btnReportIssues.Click += new EventHandler(this.btnReportIssues_Click);
            this.btnReportIssues.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnReportIssues.MouseLeave += new System.EventHandler(this.Button_MouseLeave);

            // 
            // btnViewIssues
            // 
            this.btnViewIssues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnViewIssues.FlatAppearance.BorderSize = 0;
            this.btnViewIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewIssues.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewIssues.ForeColor = System.Drawing.Color.White;
            this.btnViewIssues.Location = new System.Drawing.Point(125, 155);
            this.btnViewIssues.Name = "btnViewIssues";
            this.btnViewIssues.Size = new System.Drawing.Size(250, 45);
            this.btnViewIssues.Text = "View Submitted Issues";
            this.btnViewIssues.Click += new System.EventHandler(this.btnViewIssues_Click);
            this.btnViewIssues.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnViewIssues.MouseLeave += new System.EventHandler(this.Button_MouseLeave);

            // 
            // btnSearchIssue
            // 
            this.btnSearchIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSearchIssue.FlatAppearance.BorderSize = 0;
            this.btnSearchIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchIssue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchIssue.ForeColor = System.Drawing.Color.White;
            this.btnSearchIssue.Location = new System.Drawing.Point(125, 210);
            this.btnSearchIssue.Name = "btnSearchIssue";
            this.btnSearchIssue.Size = new System.Drawing.Size(250, 45);
            this.btnSearchIssue.Text = "Search for an Issue";
            this.btnSearchIssue.Click += new System.EventHandler(this.btnSearchIssue_Click);
            this.btnSearchIssue.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnSearchIssue.MouseLeave += new System.EventHandler(this.Button_MouseLeave);

            // 
            // btnLocalEvents
            this.btnLocalEvents.Location = new Point(150, 160);
            this.btnLocalEvents.Name = "btnLocalEvents";
            this.btnLocalEvents.Size = new Size(200, 50);
            this.btnLocalEvents.Text = "Local Events";
            this.btnLocalEvents.BackColor = Color.DodgerBlue;
            this.btnLocalEvents.ForeColor = Color.White;
            this.btnLocalEvents.FlatStyle = FlatStyle.Flat;
            this.btnLocalEvents.Click += new EventHandler(this.btnLocalEvents_Click);
            this.btnLocalEvents.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnLocalEvents.MouseLeave += new System.EventHandler(this.Button_MouseLeave);

            // 
            // btnServiceRequestStatus
            this.btnServiceRequestStatus.Location = new Point(150, 240);
            this.btnServiceRequestStatus.Name = "btnServiceRequestStatus";
            this.btnServiceRequestStatus.Size = new Size(200, 50);
            this.btnServiceRequestStatus.Text = "Service Request Status";
            this.btnServiceRequestStatus.BackColor = Color.DodgerBlue;
            this.btnServiceRequestStatus.ForeColor = Color.White;
            this.btnServiceRequestStatus.FlatStyle = FlatStyle.Flat;
            this.btnServiceRequestStatus.Click += new EventHandler(this.btnServiceRequestStatus_Click);
            this.btnServiceRequestStatus.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnServiceRequestStatus.MouseLeave += new System.EventHandler(this.Button_MouseLeave);

            // 
            // MainMenuForm
            this.ClientSize = new Size(500, 400);
            this.Controls.Add(this.btnReportIssues);
            this.Controls.Add(this.btnViewIssues);
            this.Controls.Add(this.btnSearchIssue);
            this.Controls.Add(this.btnLocalEvents);
            this.Controls.Add(this.btnServiceRequestStatus);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "MainMenuForm";
            this.Text = "Municipal Reporting App";
            this.BackColor = Color.LightBlue;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = Color.FromArgb(0, 86, 179); // Darker shade for hover
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = Color.FromArgb(0, 123, 255); // Original color
            }
        }
    }
}
