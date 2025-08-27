using System;
using System.Configuration;
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
            if (webBrowserMap != null)
            {
                webBrowserMap.ObjectForScripting = new ScriptManager(this);
            }
        }

        private void MapSelectorForm_Load(object sender, EventArgs e)
        {
            // IMPORTANT: You must get your own Google Maps API key.
            // The key should be stored in your App.config file.
            string apiKey = ConfigurationManager.AppSettings["GoogleMapsApiKey"];
            if (string.IsNullOrEmpty(apiKey) || apiKey == "YOUR_API_KEY")
            {
                MessageBox.Show("Google Maps API key is not configured. Please add it to App.config.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            
            string html = $@"
            <!DOCTYPE html>
            <html>
              <head>
                <meta http-equiv='X-UA-Compatible' content='IE=Edge' />
                <title>Click to get Coordinates</title>
                <style>
                  #map {{ height: 100%; }}
                  html, body {{ height: 100%; margin: 0; padding: 0; }}
                </style>
              </head>
              <body>
                <h3>Click on the map to select a location, then close this window.</h3>
                <div id='map'></div>
                <script>
                  function initMap() {{
                    const map = new google.maps.Map(document.getElementById('map'), {{
                      center: {{lat: -34.397, lng: 150.644}}, // Default to Sydney, Australia
                      zoom: 8
                    }});

                    map.addListener('click', (e) => {{
                      window.external.RecordCoordinates(e.latLng.lat(), e.latLng.lng());
                    }});
                  }}
                </script>
                <script src='https://maps.googleapis.com/maps/api/js?key={apiKey}&callback=initMap' async defer></script>
              </body>
            </html>";

            webBrowserMap.DocumentText = html;
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
            // Ensure the WebBrowser control is behind the button
            this.webBrowserMap.Dock = DockStyle.Fill;
            this.btnConfirm.BringToFront();
        }
    }
}
