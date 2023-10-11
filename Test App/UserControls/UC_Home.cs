using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Test_App.UserControls
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        private void SerialSend(string sendMssg)
        {
            string portName = "COM10";
            int baudRate = 9600;
            Parity parity = Parity.None;
            int dataBits = 8;
            StopBits stopBits = StopBits.One;
            string receivedMssg = "";
            SerialPort serialPort = new SerialPort(portName, baudRate, parity, dataBits, stopBits);

            try
            {
                serialPort.Open();
                serialPort.WriteLine(sendMssg + "\r");
                
                for (int i = 0; i < serialPort.BytesToRead; i++)
                {
                    string readIncoming = serialPort.ReadLine();
                    receivedMssg += readIncoming + Environment.NewLine;
                }
                SerialOutput.Text += "\r\n" + receivedMssg;
            }
            catch (Exception ex) { SerialOutput.Text += "Error: " + ex.Message; }
            finally { if (serialPort.IsOpen) { serialPort.Close(); } }
        }

        private void SerialOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If enter key is pressed.
            if (e.KeyChar == (char)13)
            {
                string LastLine = SerialOutput.Lines[SerialOutput.Lines.Length - 1];
                SerialSend(LastLine);
                SerialOutput.Focus();
                SerialOutput.Select(SerialOutput.Text.Length, 0);
            }
        }

        private void GetDeciButton_Click(object sender, EventArgs e)
        {
            try { int Dec = Convert.ToInt32(HexValue.Text, 16); DeciValue.Text = Dec.ToString(); } 
            catch { MessageBox.Show("Textbox cannot be left empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void GetHexButton_Click(object sender, EventArgs e)
        {
            try  { int Deci = Int16.Parse(DeciValue.Text); string Hex = Deci.ToString("X"); HexValue.Text = Hex;  }
            catch { MessageBox.Show("Textbox cannot be left empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void GetHexButton_MouseHover(object sender, EventArgs e)
        {
            DeciValue.FillColor = System.Drawing.ColorTranslator.FromHtml("#AED6F1");
        }

        private void GetHexButton_MouseLeave(object sender, EventArgs e)
        {
            DeciValue.FillColor = System.Drawing.ColorTranslator.FromHtml("#EAEDED");
        }

        private void GetDeciButton_MouseHover(object sender, EventArgs e)
        {
            HexValue.FillColor = System.Drawing.ColorTranslator.FromHtml("#D2B4DE");
        }

        private void GetDeciButton_MouseLeave(object sender, EventArgs e)
        {
            HexValue.FillColor = System.Drawing.ColorTranslator.FromHtml("#EAEDED");
        }

        private void BitConverterButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] IntArray = InputText.Text.Split(' ');
                byte[] bitInput = Array.ConvertAll(IntArray, Convert.ToByte);
                IntValue.Text = BitConverter.ToSingle(bitInput, 0).ToString();
            }
            catch { MessageBox.Show("Textbox cannot be left empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
