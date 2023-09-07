using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kvaser.CanLib;

namespace Test_App.UserControls
{
    public partial class UC_CANbus : UserControl
    {
        CanFD NewCANComs;
        int handle;
        int ChannelNum = 0;

        public UC_CANbus()
        {
            InitializeComponent();
            Canlib.canInitializeLibrary();
            ABSComboBox.Items.AddRange(new object[] { "500 kbits/s, 80%", "1000 kbits/s, 80%" });
            ABSComboBox.SelectedIndex = 1;
            DBSComboBox.Items.AddRange(new object[] { "500 kbits/s, 80%", "1000 kbits/s, 80%", "2000 kbits/s, 60%", "2000 kbits/s, 80%", "4000 kbits/s, 80%", "8000 kbits/s, 80%" });
            DBSComboBox.SelectedIndex = 4;
            ASJWComboBox.Items.AddRange(new object[] { "1", "2", "4", "8", "12", "16" });
            ASJWComboBox.SelectedIndex = 5;
            DSJWComboBox.Items.AddRange(new object[] { "1", "2", "3", "4" });
            DSJWComboBox.SelectedIndex = 3;
            CanInID.Text = "198197251";
            CanOutID.Text = "472858628";
            CanDataLength.Text = "6";
        }

        // Connect to selected CAN channel.
        private void CANConnect_Click(object sender, EventArgs e)
        {
            if (CANConnect.Text == "Go On Bus")
            {
                CANConnect.Text = "Go Off Bus";
                NewCANComs = new CanFD();
                handle = NewCANComs.CanFD_open(ChannelNum);
                CanStateText.Text = "On Bus";
                CanStateText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71");
            }
            else if (CANConnect.Text == "Go Off Bus")
            {
                CANConnect.Text = "Go On Bus";
                NewCANComs.CanFD_close(handle);
                CanStateText.Text = "Off Bus";
                CanStateText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D4AC0D");
            }
        }

        // Send CAN message 
        private void SendButton_Click(object sender, EventArgs e)
        {
            int InputID = Int32.Parse(CanInID.Text);
            int OutputID = Int32.Parse(CanOutID.Text);
            int DLC = Int16.Parse(CanDataLength.Text);
            byte[] SendMssg = CanConverter(CanData1.Text);
            byte[] ReceivedMssg = new byte[64];
            
            try 
            {
                if (CanStateText.Text == "Off Bus") { throw new InvalidOperationException("Can state not on bus."); }
                NewCANComs.CanFD_write(handle, InputID, SendMssg, DLC); 
            } 
            catch { MessageBox.Show("Status not on bus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            try { ReceivedMssg = NewCANComs.CanFD_read(handle, OutputID); } catch { }
            CanOutput.Text = null;
            CanPrint(SendMssg, InputID);
            CanPrint(ReceivedMssg, OutputID);
        }

        // Print received CAN message onto output window.
        private void CanPrint (byte[] data, int Identifier)
        {
            if (data[0] == 0 && data[1] == 0) { return; }
            CanOutput.Text += Identifier + Environment.NewLine;
            for (int x = 0; x < data.Length; x++)
            {
                CanOutput.Text += data[x] + " ";
                if (x == 15 | x == 31 | x == 47) { CanOutput.Text += Environment.NewLine; }
            }
            CanOutput.Text += Environment.NewLine + Environment.NewLine;
        }

        // Convert hex input string into byte array.
        private Byte[] CanConverter(string HexMssg)
        {
            string[] StrArray = new string[64];
            byte[] ByteArray = new byte[64];
            for (int i = 0; i < HexMssg.Length/2; i++) { StrArray[i] = HexMssg[i * 2].ToString() + HexMssg[i * 2 + 1].ToString(); }
            for (int i = 0; i < StrArray.Length; i++) { ByteArray[i] = (byte)Convert.ToInt32(StrArray[i], 16); }
            return ByteArray;
        }

        // Monitors the CAN channel and read messages sent.
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Canlib.canStatus status;
            byte[] data = new byte[64];

            try
            {
                if (CanStateText.Text == "Off Bus") { throw new InvalidOperationException("Can state not on bus."); }
                status = Canlib.canReadWait(handle, out int id, data, out int dlc, out int flags, out long timestamp, 100);
                if (status == Canlib.canStatus.canOK)
                {
                    CanOutput.Text = null;
                    CanPrint(data, id);
                }
            } 
            catch { MessageBox.Show("Status not on bus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
}
    }
}
