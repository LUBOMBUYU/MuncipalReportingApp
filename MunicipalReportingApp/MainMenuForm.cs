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
            // Hide the main form and open the ReportIssues form
            this.Hide();
            using (var reportForm = new ReportIssues())
            {
                reportForm.ShowDialog();
            }
            this.Show(); // Show the main form again after ReportIssues form is closed
        }

        private void btnViewIssues_Click(object sender, EventArgs e)
        {
            MessageBox.Show("View Issues feature will be added in later updates", "Feature Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearchIssue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search Issue feature will be added in later updates", "Feature Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
