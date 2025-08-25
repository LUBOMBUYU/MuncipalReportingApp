using System.Drawing;
using System.Windows.Forms;

namespace MunicipalReportingApp
{
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 160,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false,
                AutoScaleMode = AutoScaleMode.Font,
                ClientSize = new Size(384, 121)
            };

            Label textLabel = new Label() { Left = 12, Top = 12, Text = text, AutoSize = true };
            TextBox textBox = new TextBox() { Left = 12, Top = 36, Width = 360, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
            Button confirmation = new Button() { Text = "OK", Left = 228, Width = 75, Top = 72, DialogResult = DialogResult.OK, Anchor = AnchorStyles.Top | AnchorStyles.Right };
            Button cancel = new Button() { Text = "Cancel", Left = 309, Width = 75, Top = 72, DialogResult = DialogResult.Cancel, Anchor = AnchorStyles.Top | AnchorStyles.Right };

            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : string.Empty;
        }
    }
}