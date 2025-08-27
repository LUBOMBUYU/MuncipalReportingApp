using System;
using System.Windows.Forms;

namespace MunicipalReportingApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Prevent resizing
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            // Open the ReportIssues form
            using (var reportForm = new ReportIssues())
            {
                reportForm.ShowDialog();
            }
        }

        private void btnViewIssues_Click(object sender, EventArgs e)
        {
            // Logic to view reported issues
        }

        private void btnSearchIssue_Click(object sender, EventArgs e)
        {
            // Logic to search for an issue
        }
    }
}
