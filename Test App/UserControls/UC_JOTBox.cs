using System;
using System.Windows.Forms;

namespace Test_App.UserControls
{
    public partial class UC_JOTBox : UserControl
    {
        HTTP NewHTTPComs = new HTTP();

        // curl request input for reference:
        // curl -X POST -H "Content-Type: application/json" -d "{\"cmd\": \"get_state\"}" http://100.100.100.100:80/slide1/command
        // curl -X POST -H "Content-Type: application/json" -d "{\"cmd\": \"subscribe\", \"address\": \"http://100.100.100.100:8081/stateupdate/box1\"}" http://100.100.100.100:80/slide1/command
        public UC_JOTBox()
        {
            InitializeComponent();
            M10ComboBox.Items.AddRange(new object[] { "slide1" });
            M10ComboBox.SelectedIndex = 0;
            BoxURL.Text = "http://100.100.100.100:80";
            GetBoxState();
        }

        // Function to get box state.
        private async void GetBoxState()
        {
            try
            {
                string BoxState = await NewHTTPComs.GetState(BoxURL.Text, M10ComboBox.Text);
                if (BoxState == "OFF") { BoxStateText.Text = BoxState; BoxStateText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D4AC0D"); }
                else if (BoxState == "OPEN") { BoxStateText.Text = BoxState; BoxStateText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D4AC0D"); }
                else if (BoxState == "BLOCKED") { BoxStateText.Text = BoxState; BoxStateText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71"); }
                else if (BoxState == "STARVING") { BoxStateText.Text = BoxState; BoxStateText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71"); }
                else if (BoxState == "CRITICAL") { BoxStateText.Text = BoxState; BoxStateText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C"); }
                else { BoxStateText.Text = BoxState; BoxStateText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C"); }
            }
            catch { BoxStateText.Text = "An error has occured."; }
        }

        // Reset box button.
        private async void ResetButton_Click(object sender, EventArgs e) 
        {
            string response = await NewHTTPComs.HTTPSend("{\"cmd\": \"reset\"}", BoxURL.Text, M10ComboBox.Text);
            HTTPOutput.Text += response;
            HTTPOutput.Focus();
            HTTPOutput.Select(HTTPOutput.Text.Length, 0);
        }

        // Initialize box button.
        private async void InitializeButton_Click(object sender, EventArgs e) 
        {
            string response = await NewHTTPComs.HTTPSend("{\"cmd\": \"initialize\"}", BoxURL.Text, M10ComboBox.Text);
            HTTPOutput.Text += response;
            HTTPOutput.Focus();
            HTTPOutput.Select(HTTPOutput.Text.Length, 0);
        }

        // Open box button.
        private async void OpenButton_Click(object sender, EventArgs e) 
        {
            string response = await NewHTTPComs.HTTPSend("{\"cmd\": \"open\"}", BoxURL.Text, M10ComboBox.Text);
            HTTPOutput.Text += response;
            HTTPOutput.Focus();
            HTTPOutput.Select(HTTPOutput.Text.Length, 0);
        }

        // Close box button.
        private async void Close1Button_Click(object sender, EventArgs e) 
        {
            string response = await NewHTTPComs.HTTPSend("{\"cmd\": \"close\"}", BoxURL.Text, M10ComboBox.Text);
            HTTPOutput.Text += response;
            HTTPOutput.Focus();
            HTTPOutput.Select(HTTPOutput.Text.Length, 0);
        }

        // Get state button.
        private void GetStateButton_Click(object sender, EventArgs e) { GetBoxState(); }

        // Write custom command into command prompt. {"cmd": "get_state"}
        private async void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                string userCommand = HTTPOutput.Lines[HTTPOutput.Lines.Length - 1];
                string response = await NewHTTPComs.HTTPSend(userCommand, BoxURL.Text, M10ComboBox.Text);
                HTTPOutput.Text += response + Environment.NewLine;
                HTTPOutput.Focus();
                HTTPOutput.Select(HTTPOutput.Text.Length, 0);
            }
        }

        // Clear command prompt.
        private void ClearButton_Click(object sender, EventArgs e) { HTTPOutput.Text = string.Empty; }
    }
}
