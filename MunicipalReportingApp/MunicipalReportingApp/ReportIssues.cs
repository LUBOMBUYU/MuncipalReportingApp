using System;
using System.Windows.Forms;

namespace MunicipalReportingApp
{
    public partial class ReportIssues : Form
    {
        public ReportIssues()
        {
            InitializeComponent();
        }

        private void ReportIssues_Load(object sender, EventArgs e)
        {
            lblAttachments.Text = "No attachments yet";
        }

        // Attach media files (images/videos)
        private void BtnAttachMedia_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Image and Video Files|*.jpg;*.jpeg;*.png;*.mp4;*.mov";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    lblAttachments.Text = string.Join(", ", openFileDialog.SafeFileNames);
            }
        }

        // Submit a new issue
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string location = txtLocation.Text.Trim();
            string category = cboCategory.SelectedItem?.ToString() ?? "";
            string description = rtbDescription.Text.Trim();
            string[] attachments = lblAttachments.Text == "No attachments yet"
                                    ? Array.Empty<string>()
                                    : lblAttachments.Text.Split(new[] { ", " }, StringSplitOptions.None);

            if (string.IsNullOrEmpty(location) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all fields before submitting.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a new issue object
            var newIssue = new ReportedIssue
            {
                Location = location,
                Category = category,
                Description = description,
                Attachments = attachments
            };

            // Save globally
            IssueStorage.Issues.Add(newIssue);

            MessageBox.Show("Issue submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear form
            txtLocation.Clear();
            cboCategory.SelectedIndex = -1;
            rtbDescription.Clear();
            lblAttachments.Text = "No attachments yet";
        }

        // Close form
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Optional: View all issues
        private void BtnViewIssues_Click(object sender, EventArgs e)
        {
            if (IssueStorage.Issues.Count == 0)
            {
                MessageBox.Show("No issues submitted yet.");
                return;
            }

            string allIssues = "";
            foreach (var issue in IssueStorage.Issues)
            {
                allIssues += $"Location: {issue.Location}\n" +
                             $"Category: {issue.Category}\n" +
                             $"Description: {issue.Description}\n" +
                             $"Attachments: {string.Join(", ", issue.Attachments)}\n\n";
            }

            MessageBox.Show(allIssues, "All Issues");
        }
    }
}
