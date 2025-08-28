using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MunicipalReportingApp
{
    public partial class MapSelectorForm : Form
    {
        // Nested class for better encapsulation and clarity.
        [ComVisible(true)]
        public class ScriptManager
        {
            private readonly MapSelectorForm _form;
            public ScriptManager(MapSelectorForm form) { _form = form; }

            public void RecordCoordinates(double lat, double lng)
            {
                _form.SetCoordinates(lat, lng);
            }
        }

        public string SelectedLocation { get; private set; } = string.Empty;
        private Button btnConfirm = new Button(); // Add a confirm button for better UX

        public MapSelectorForm()
        {
            InitializeComponent();
            InitializeCustomComponents(); // Method to set up our custom controls
            // Allow C# to be called from JavaScript
            // The webBrowserMap control has been removed, so this part is no longer needed.
        }

        private void MapSelectorForm_Load(object sender, EventArgs e)
        {
            // For mobile app, we'll need to implement a different approach
            // This will be replaced with mobile-specific map implementation
            // For now, we'll use a simple placeholder
        }

        private void pictureBoxMap_Click(object sender, EventArgs e)
        {
            // Handle map click for location selection
            var mouseEventArgs = (MouseEventArgs)e;
            // Simulate coordinates based on click position
            double lat = -34.397 + (mouseEventArgs.Y / 600.0) * 0.1;
            double lng = 150.644 + (mouseEventArgs.X / 800.0) * 0.1;
            SetCoordinates(lat, lng);
        }

        public void SetCoordinates(double lat, double lng)
        {
            // Use Invoke to ensure thread safety when updating UI from a different thread (like the one JS runs on)
            this.Invoke((MethodInvoker)delegate {
                this.SelectedLocation = $"{lat:F6}, {lng:F6}"; // Format for precision
                this.Text = $"Location Selected: {this.SelectedLocation}";
                this.btnConfirm.Enabled = true; // Enable the confirm button
            });
        }

        private void InitializeCustomComponents()
        {
            this.btnConfirm = new Button
            {
                Text = "Confirm Selection",
                Dock = DockStyle.Bottom,
                Height = 40,
                Enabled = false, // Disabled until a location is picked
                Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold),
                BackColor = System.Drawing.Color.FromArgb(40, 167, 69),
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat
            };
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.Click += (sender, e) => {
                this.DialogResult = DialogResult.OK;
                this.Close();
            };

            this.Controls.Add(this.btnConfirm);
            // For mobile app, we'll need to adjust the layout accordingly
            this.btnConfirm.BringToFront();
        }
    }
}
