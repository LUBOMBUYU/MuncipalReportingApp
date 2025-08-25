using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalReportingApp
{
    partial class MainMenuForm
    {
        private Button btnReportIssues;
        private Button btnViewIssues;
        private Button btnSearchIssue;
        private Button btnLocalEvents;
        private Button btnServiceRequestStatus;
        private Label lblTitle;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnReportIssues = new Button();
            this.btnViewIssues = new System.Windows.Forms.Button();
            this.btnSearchIssue = new System.Windows.Forms.Button();
            this.btnLocalEvents = new Button();
            this.btnServiceRequestStatus = new Button();
            this.SuspendLayout();
            

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblTitle.Location = new System.Drawing.Point(55, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(390, 37);
            this.lblTitle.Text = "Municipal Reporting System";

            // 
            // btnReportIssues
            // 
            this.btnReportIssues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnReportIssues.FlatAppearance.BorderSize = 0;
            this.btnReportIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportIssues.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReportIssues.ForeColor = System.Drawing.Color.White;
            this.btnReportIssues.Location = new System.Drawing.Point(125, 100);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(250, 45);
            this.btnReportIssues.Text = "Report a New Issue";
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
            // 
            this.btnLocalEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnLocalEvents.FlatAppearance.BorderSize = 0;
            this.btnLocalEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalEvents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLocalEvents.ForeColor = System.Drawing.Color.White;
            this.btnLocalEvents.Location = new System.Drawing.Point(125, 265);
            this.btnLocalEvents.Name = "btnLocalEvents";
            this.btnLocalEvents.Size = new System.Drawing.Size(250, 45);
            this.btnLocalEvents.Text = "Local Events";
            this.btnLocalEvents.Click += new EventHandler(this.btnLocalEvents_Click);
            this.btnLocalEvents.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnLocalEvents.MouseLeave += new System.EventHandler(this.Button_MouseLeave);

            // 
            // btnServiceRequestStatus
            // 
            this.btnServiceRequestStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnServiceRequestStatus.FlatAppearance.BorderSize = 0;
            this.btnServiceRequestStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceRequestStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnServiceRequestStatus.ForeColor = System.Drawing.Color.White;
            this.btnServiceRequestStatus.Location = new System.Drawing.Point(125, 320);
            this.btnServiceRequestStatus.Name = "btnServiceRequestStatus";
            this.btnServiceRequestStatus.Size = new System.Drawing.Size(250, 45);
            this.btnServiceRequestStatus.Text = "Service Request Status";
            this.btnServiceRequestStatus.Click += new EventHandler(this.btnServiceRequestStatus_Click);
            this.btnServiceRequestStatus.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnServiceRequestStatus.MouseLeave += new System.EventHandler(this.Button_MouseLeave);

            // 
            // MainMenuForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReportIssues);
            this.Controls.Add(this.btnViewIssues);
            this.Controls.Add(this.btnSearchIssue);
            this.Controls.Add(this.btnLocalEvents);
            this.Controls.Add(this.btnServiceRequestStatus);
            this.Name = "MainMenuForm";
            this.Text = "Municipal Reporting App";
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
