using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MunicipalReportingApp.DataStructures;

namespace MunicipalReportingApp
{
    public partial class ReportIssues : Form
    {
        private List<string> _attachments = new List<string>();

        public ReportIssues()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void BtnAttachMedia_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Image and Video Files|*.jpg;*.jpeg;*.png;*.mp4;*.mov";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Store the selected file paths
                    _attachments.AddRange(openFileDialog.FileNames);
                    lblAttachments.Text = $"{_attachments.Count} file(s) attached";
                }
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Create a new issue with actual form data
            var newIssue = new Issue
            {
                Location = txtLocation.Text,
                Category = cboCategory.SelectedItem?.ToString() ?? "Other",
                Description = rtbDescription.Text,
                Attachments = new List<string>(_attachments)
            };

            // Add to global storage
            IssueStorage.Issues.Add(newIssue);

            MessageBox.Show("Issue submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectOnMap_Click(object sender, EventArgs e)
        {
            using (var mapForm = new MapSelectorForm())
            {
                if (mapForm.ShowDialog() == DialogResult.OK)
                {
                    txtLocation.Text = mapForm.SelectedLocation;
                }
            }
        }
    }
}
