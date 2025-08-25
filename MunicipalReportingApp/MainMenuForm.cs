using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MunicipalReportingApp.DataStructures; // Ensure this is at the top of the file

namespace MunicipalReportingApp
{
    public partial class MainMenuForm : Form
    {
        private readonly IssueLinkedList issuesList; // Declare and make readonly

        public MainMenuForm()
        {
            InitializeComponent();
            issuesList = new IssueLinkedList(); // Initialize issuesList

            // Add a sample issue for demonstration purposes so View/Search can be tested.
            issuesList.Add(new Issue
            {
                Location = "City Hall, 123 Main St",
                Category = "Pothole",
                Description = "Large pothole in front of main entrance",
                Attachments = new List<string> { "pothole_image.jpg" }
            });

            this.StartPosition = FormStartPosition.CenterScreen; // Center the form on the screen
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Prevent resizing
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            // Hide the main menu form
            this.Hide();

            // Open ReportIssues
            // Pass the list to the ReportIssues form so it can add new issues.
            // You will need to modify the ReportIssues form to accept this list.
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

            var sb = new StringBuilder();
            foreach (var issue in issuesList) // Use issuesList
            {
                sb.AppendLine($"Location: {issue.Location}");
                sb.AppendLine($"Category: {issue.Category}");
                sb.AppendLine($"Description: {issue.Description}");
                sb.AppendLine($"Attachments: {string.Join(", ", issue.Attachments)}");
                sb.AppendLine();
            }

            MessageBox.Show(sb.ToString(), "All Issues");
        }

        private void btnSearchIssue_Click(object sender, EventArgs e)
        {
            // Assuming Prompt is a static class or a class with a static method ShowDialog
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
