using System;
using System.Windows.Forms;

namespace MunicipalReportingApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            // Hide the main menu form
            this.Hide();

            // Open ReportIssues as a modal dialog
            using (var reportForm = new ReportIssues())
            {
                reportForm.ShowDialog();
            }

            // Show the main menu form again when ReportIssues closes
            this.Show();
        }

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Local Events clicked!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnServiceRequestStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Service Request Status clicked!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
