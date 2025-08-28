namespace MunicipalReportingApp
{
    partial class MapSelectorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxMap;

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
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMap.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(800, 600);
            this.pictureBoxMap.TabIndex = 0;
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.Click += new System.EventHandler(this.pictureBoxMap_Click);
            // 
            // MapSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pictureBoxMap);
            this.Name = "MapSelectorForm";
            this.Text = "Select Location on Map";
            this.Load += new System.EventHandler(this.MapSelectorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
