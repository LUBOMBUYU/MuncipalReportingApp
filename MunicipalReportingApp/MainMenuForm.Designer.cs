using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalReportingApp
{
    partial class MainMenuForm
    {
        private Label lblTitle;
        private Button btnReportIssues;
        private Button btnLocalEvents;
        private Button btnServiceRequestStatus;
        private Panel headerPanel;

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.btnReportIssues = new Button();
            this.btnLocalEvents = new Button();
            this.btnServiceRequestStatus = new Button();
            this.headerPanel = new Panel();
            this.SuspendLayout();

            // Header Panel
            this.headerPanel.Dock = DockStyle.Top;
            this.headerPanel.Height = 80;
            this.headerPanel.BackColor = Color.DodgerBlue;

            // Title Label
            this.lblTitle.Text = "Municipal Reporting App";
            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.AutoSize = false;
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitle.Dock = DockStyle.Fill;

            this.headerPanel.Controls.Add(this.lblTitle);

            // Common button style
            Size buttonSize = new Size(250, 60);
            Font buttonFont = new Font("Segoe UI", 12F, FontStyle.Bold);

            // btnReportIssues
            this.btnReportIssues.Size = buttonSize;
            this.btnReportIssues.Location = new Point(125, 120);
            this.btnReportIssues.Text = "📋 Report Issues";
            this.btnReportIssues.Font = buttonFont;
            this.btnReportIssues.BackColor = Color.White;
            this.btnReportIssues.ForeColor = Color.DodgerBlue;
            this.btnReportIssues.FlatStyle = FlatStyle.Flat;
            this.btnReportIssues.FlatAppearance.BorderSize = 2;
            this.btnReportIssues.FlatAppearance.BorderColor = Color.DodgerBlue;
            this.btnReportIssues.Click += new EventHandler(this.btnReportIssues_Click);

            // btnLocalEvents
            this.btnLocalEvents.Size = buttonSize;
            this.btnLocalEvents.Location = new Point(125, 200);
            this.btnLocalEvents.Text = "🎉 Local Events";
            this.btnLocalEvents.Font = buttonFont;
            this.btnLocalEvents.BackColor = Color.White;
            this.btnLocalEvents.ForeColor = Color.DodgerBlue;
            this.btnLocalEvents.FlatStyle = FlatStyle.Flat;
            this.btnLocalEvents.FlatAppearance.BorderSize = 2;
            this.btnLocalEvents.FlatAppearance.BorderColor = Color.DodgerBlue;
            this.btnLocalEvents.Click += new EventHandler(this.btnLocalEvents_Click);

            // btnServiceRequestStatus
            this.btnServiceRequestStatus.Size = buttonSize;
            this.btnServiceRequestStatus.Location = new Point(125, 280);
            this.btnServiceRequestStatus.Text = "⚙️ Service Status";
            this.btnServiceRequestStatus.Font = buttonFont;
            this.btnServiceRequestStatus.BackColor = Color.White;
            this.btnServiceRequestStatus.ForeColor = Color.DodgerBlue;
            this.btnServiceRequestStatus.FlatStyle = FlatStyle.Flat;
            this.btnServiceRequestStatus.FlatAppearance.BorderSize = 2;
            this.btnServiceRequestStatus.FlatAppearance.BorderColor = Color.DodgerBlue;
            this.btnServiceRequestStatus.Click += new EventHandler(this.btnServiceRequestStatus_Click);

            // MainMenuForm
            this.ClientSize = new Size(500, 450);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.btnReportIssues);
            this.Controls.Add(this.btnLocalEvents);
            this.Controls.Add(this.btnServiceRequestStatus);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "MainMenuForm";
            this.Text = "Municipal Reporting App";
            this.BackColor = Color.WhiteSmoke;

            this.ResumeLayout(false);
        }
    }
}
