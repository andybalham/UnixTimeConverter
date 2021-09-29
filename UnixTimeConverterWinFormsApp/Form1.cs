using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UnixTimeConverterWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            var clipboardText = Clipboard.GetText();

            if (clipboardText != null &&
                IsValidUnixTime(clipboardText))
            {
                var unixTimeStamp = int.Parse(clipboardText);
                DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
                this.clipboardTimeTextBox.Text = dateTime.ToLocalTime().ToString("F");
            }
            else
            {
                this.clipboardTimeTextBox.Text = "No clipboard time";
            }
        }

        private static bool IsValidUnixTime(string text)
        {
            return Regex.IsMatch(text, "^[0-9]+$");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.unixTimeTextBox.Text);
            this.copyButton.Text = "Copied";
            var unixTimeStamp = int.Parse(this.unixTimeTextBox.Text);
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            this.copiedTimeTextBox.Text = dateTime.ToLocalTime().ToString("F");
        }

        private void unixTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            this.copyButton.Text = "Copy";
            this.copiedTimeTextBox.Text = "";
            this.copyButton.Enabled = IsValidUnixTime(this.unixTimeTextBox.Text);
        }

        private void nowButton_Click(object sender, EventArgs e)
        {
            this.baseTimeTextBox.Text = DateTime.Now.ToString("F");

        }

        private void baseTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            
            if (DateTime.TryParse(this.baseTimeTextBox.Text, out var baseTime))
            {
                var unixTimestamp = (Int32)baseTime.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
                this.unixTimeTextBox.Text = unixTimestamp.ToString();
            }
        }
    }
}
