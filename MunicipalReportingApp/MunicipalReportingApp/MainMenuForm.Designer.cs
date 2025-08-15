using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalReportingApp
{
    partial class MainMenuForm
    {
        private Button btnReportIssues;
        private Button btnLocalEvents;
        private Button btnServiceRequestStatus;

        private void InitializeComponent()
        {
            this.btnReportIssues = new Button();
            this.btnLocalEvents = new Button();
            this.btnServiceRequestStatus = new Button();
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

            // btnLocalEvents
            this.btnLocalEvents.Location = new Point(150, 160);
            this.btnLocalEvents.Name = "btnLocalEvents";
            this.btnLocalEvents.Size = new Size(200, 50);
            this.btnLocalEvents.Text = "Local Events";
            this.btnLocalEvents.BackColor = Color.DodgerBlue;
            this.btnLocalEvents.ForeColor = Color.White;
            this.btnLocalEvents.FlatStyle = FlatStyle.Flat;
            this.btnLocalEvents.Click += new EventHandler(this.btnLocalEvents_Click);

            // btnServiceRequestStatus
            this.btnServiceRequestStatus.Location = new Point(150, 240);
            this.btnServiceRequestStatus.Name = "btnServiceRequestStatus";
            this.btnServiceRequestStatus.Size = new Size(200, 50);
            this.btnServiceRequestStatus.Text = "Service Request Status";
            this.btnServiceRequestStatus.BackColor = Color.DodgerBlue;
            this.btnServiceRequestStatus.ForeColor = Color.White;
            this.btnServiceRequestStatus.FlatStyle = FlatStyle.Flat;
            this.btnServiceRequestStatus.Click += new EventHandler(this.btnServiceRequestStatus_Click);

            // MainMenuForm
            this.ClientSize = new Size(500, 400);
            this.Controls.Add(this.btnReportIssues);
            this.Controls.Add(this.btnLocalEvents);
            this.Controls.Add(this.btnServiceRequestStatus);
            this.Name = "MainMenuForm";
            this.Text = "Municipal Reporting App";
            this.BackColor = Color.LightBlue;

            this.ResumeLayout(false);
        }
    }
}
