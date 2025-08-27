namespace MunicipalReportingApp
{
    partial class MapSelectorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.WebBrowser webBrowserMap;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.webBrowserMap = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserMap
            // 
            this.webBrowserMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMap.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMap.Name = "webBrowserMap";
            this.webBrowserMap.Size = new System.Drawing.Size(800, 600);
            this.webBrowserMap.TabIndex = 0;
            // 
            // MapSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.webBrowserMap);
            this.Name = "MapSelectorForm";
            this.Text = "Select Location on Map";
            this.Load += new System.EventHandler(this.MapSelectorForm_Load);
            this.ResumeLayout(false);
        }
    }
}