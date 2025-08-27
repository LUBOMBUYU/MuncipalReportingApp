using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MunicipalReportingApp.DataStructures;

namespace MunicipalReportingApp
{
    public partial class ReportIssues : Form
    {
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
                    // Handle file attachment logic
                }
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Create a new issue
            var newIssue = new Issue
            {
                Location = "Sample Location",
                Category = "Sample Category",
                Description = "Sample Description",
                Attachments = new List<string>()
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
    }
}
