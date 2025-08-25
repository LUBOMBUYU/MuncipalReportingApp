using System;
using System.Windows.Forms;
using MunicipalReportingApp.DataStructures; // Ensure this is at the top of the file
using MunicipalReportingApp; // Added to reference the Prompt class

namespace MunicipalReportingApp
{
    public partial class MainMenuForm : Form
    {
        private IssueLinkedList issuesList; // Declare issuesList

        public MainMenuForm()
        {
            InitializeComponent();
            issuesList = new IssueLinkedList(); // Initialize issuesList
            this.StartPosition = FormStartPosition.CenterScreen; // Center the form on the screen
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Prevent resizing
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            // Hide the main menu form
            this.Hide();

            // Open ReportIssues
            using (var reportForm = new ReportIssues())
            {
                reportForm.ShowDialog();
            }

            // Show the main menu form again when ReportIssues closes
            this.Show();
        }

        private void btnViewIssues_Click(object sender, EventArgs e)
        {
            if (issuesList == null || issuesList.Count == 0) // Check issuesList
            {
                MessageBox.Show("No issues submitted yet.");
                return;
            }

            string allIssues = "";
            foreach (var issue in issuesList) // Use issuesList
            {
                allIssues += $"Location: {issue.Location}\n" +
                             $"Category: {issue.Category}\n" +
                             $"Description: {issue.Description}\n" +
                             $"Attachments: {string.Join(", ", issue.Attachments)}\n\n";
            }

            MessageBox.Show(allIssues, "All Issues");
        }

        private void btnSearchIssue_Click(object sender, EventArgs e)
        {
            string searchTerm = Prompt.ShowDialog("Enter issue description to search:", "Search Issue");
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a valid description.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var foundIssue = issuesList.SearchIssue(searchTerm); // Use issuesList
            if (foundIssue != null)
            {
                MessageBox.Show($"Found Issue:\nLocation: {foundIssue.Location}\nCategory: {foundIssue.Category}\nDescription: {foundIssue.Description}\nAttachments: {string.Join(", ", foundIssue.Attachments)}", "Issue Found");
            }
            else
            {
                MessageBox.Show("Issue not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
