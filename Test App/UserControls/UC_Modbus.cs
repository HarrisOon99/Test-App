using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Test_App.UserControls
{
    public partial class UC_Modbus : UserControl
    {
        ModbusTCP NewTCPComs;
        Socket client = null;

        public UC_Modbus()
        {
            InitializeComponent();
            FunctionComboBox.Items.AddRange(new object[] 
            { "Read Coils (0x01)", "Read Discrete Inputs (0x02)", "Read Holding Registers (0x03)", "Read Input Registers (0x04)",
              "Write Single Coil (0x05)", "Write Single Holding Registers (0x06)", });
        }

        // Connect PLC using Modbus TCP
        private void TCPConnect_Click(object sender, EventArgs e)
        {
            if (TCPConnect.Text == "Connect")
            { 
                TCPConnect.Text = "Disconnect";
                NewTCPComs = new ModbusTCP();
                client = NewTCPComs.modbusTCP_open();
                if (client != null) 
                { 
                    ModStateText.Text = "CONNECTED";
                    ModStateText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71");
                    ChckState();
                }
                else 
                { 
                    ModStateText.Text = "ERROR";
                    ModStateText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
                    TCPConnect.Text = "Connect";
                    MessageBox.Show("PLC cannot be connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (TCPConnect.Text == "Disconnect") 
            { 
                TCPConnect.Text = "Connect";
                ModStateText.Text = "DISCONNECTED";
                ModStateText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D4AC0D");
                NewTCPComs.ModbusTCP_close(client);
            }
        }

        // Check input states when connecting through TCP.
        public void ChckState()
        {
            int InitPower = NewTCPComs.TCP_Mssg_Send(client, 1, 1285, 1, 1);
            int InitMUX0 = NewTCPComs.TCP_Mssg_Send(client, 1, 1297, 1, 1);
            int InitMUX1 = NewTCPComs.TCP_Mssg_Send(client, 1, 1298, 1, 1);
            int InitMUX2 = NewTCPComs.TCP_Mssg_Send(client, 1, 1299, 1, 1);
            int InitMUX3 = NewTCPComs.TCP_Mssg_Send(client, 1, 1300, 1, 1);
            int InitMUX4 = NewTCPComs.TCP_Mssg_Send(client, 1, 1301, 1, 1);
            int InitDIN1 = NewTCPComs.TCP_Mssg_Send(client, 1, 1302, 1, 1);
            int InitDIN2 = NewTCPComs.TCP_Mssg_Send(client, 1, 1303, 1, 1);
            int InitILIM = NewTCPComs.TCP_Mssg_Send(client, 1, 1304, 1, 1);
            int MCMILIM = NewTCPComs.TCP_Mssg_Send(client, 1, 1288, 1, 1);

            if (InitPower == 1) { PowerButton.Text = "ON"; PowerButton.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71"); }
            else { PowerButton.Text = "OFF"; PowerButton.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C"); }
            if (InitMUX0 == 1) { MUX0Button.Text = "ON"; MUX0Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71"); }
            else { MUX0Button.Text = "OFF"; MUX0Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C"); }
            if (InitMUX1 == 1) { MUX1Button.Text = "ON"; MUX1Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71"); }
            else { MUX1Button.Text = "OFF"; MUX1Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C"); }
            if (InitMUX2 == 1) { MUX2Button.Text = "ON"; MUX2Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71"); }
            else { MUX2Button.Text = "OFF"; MUX2Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C"); }
            if (InitMUX3 == 1) { MUX3Button.Text = "ON"; MUX3Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71"); }
            else { MUX3Button.Text = "OFF"; MUX3Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C"); }
            if (InitMUX4 == 1) { MUX4Button.Text = "ON"; MUX4Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71"); }
            else { MUX4Button.Text = "OFF"; MUX4Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C"); }
            if (InitDIN1 == 1) { DIN1Button.Text = "ON"; DIN1Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71"); }
            else { DIN1Button.Text = "OFF"; DIN1Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C"); }
            if (InitDIN2 == 1) { DIN2Button.Text = "ON"; DIN2Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71"); }
            else { DIN2Button.Text = "OFF"; DIN2Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C"); }
            if (InitILIM == 1) { ILIMButton.Text = "ON"; ILIMButton.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71"); }
            else { ILIMButton.Text = "OFF"; ILIMButton.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C"); }
            if (MCMILIM == 1) { MCMButton.Text = "ON"; MCMButton.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71"); }
            else { MCMButton.Text = "OFF"; MCMButton.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C"); }
        }

        // Toggle PIM on and off
        private void PowerButton_Click(object sender, EventArgs e)
        {
            if (!NewTCPComs.SocketConnected(client))
            {
                MessageBox.Show("PLC disconnected", "Timeout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TCPConnect.Text = "Connect";
                ModStateText.Text = "DISCONNECTED";
                ModStateText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D4AC0D");
                NewTCPComs.ModbusTCP_close(client);
            }
            else
            {
                if (PowerButton.Text == "OFF")
                {
                    try { NewTCPComs.TCP_Mssg_Send(client, 1, 1285, 5, 1); }
                    catch
                    {
                        MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        PowerButton.Text = "OFF";
                        PowerButton.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
                        return;
                    }
                    PowerButton.Text = "ON";
                    PowerButton.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71");
                }
                else if (PowerButton.Text == "ON") { PIMAllOff(); }
            }
        }

        // Turn off all PIM inputs.
        public void PIMAllOff()
        {
            try
            {
                NewTCPComs.TCP_Mssg_Send(client, 1, 1285, 5, 0);        // Turn off PIM.
                NewTCPComs.TCP_Mssg_Send(client, 1, 1297, 5, 0);        // Turn off MUX 0.
                NewTCPComs.TCP_Mssg_Send(client, 1, 1298, 5, 0);        // Turn off MUX 1.
                NewTCPComs.TCP_Mssg_Send(client, 1, 1299, 5, 0);        // Turn off MUX 2.
                NewTCPComs.TCP_Mssg_Send(client, 1, 1300, 5, 0);        // Turn off MUX 3.
                NewTCPComs.TCP_Mssg_Send(client, 1, 1301, 5, 0);        // Turn off MUX 4.
                NewTCPComs.TCP_Mssg_Send(client, 1, 1302, 5, 0);        // Turn off DIN 1.
                NewTCPComs.TCP_Mssg_Send(client, 1, 1303, 5, 0);        // Turn off DIN 2.
                NewTCPComs.TCP_Mssg_Send(client, 1, 1304, 5, 0);        // Turn off ILIM.
            }
            catch
            {
                MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PowerButton.Text = "ON";
                PowerButton.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71");
                return;
            }

            PowerButton.Text = "OFF"; PowerButton.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
            MUX0Button.Text = "OFF"; MUX0Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
            MUX1Button.Text = "OFF"; MUX1Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
            MUX2Button.Text = "OFF"; MUX2Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
            MUX3Button.Text = "OFF"; MUX3Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
            MUX4Button.Text = "OFF"; MUX4Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
            DIN1Button.Text = "OFF"; DIN1Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
            DIN2Button.Text = "OFF"; DIN2Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
            ILIMButton.Text = "OFF"; ILIMButton.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
        }

        #region Toggle PIM inputs.
        // Toggle MCM on and off
        private void MCMButton_Click(object sender, EventArgs e)
        {
            if (MCMButton.Text == "OFF")
            {
                try { NewTCPComs.TCP_Mssg_Send(client, 1, 1288, 5, 1); }
                catch
                {
                    MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MCMButton.Text = "OFF";
                    MCMButton.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
                    return;
                }
                MCMButton.Text = "ON";
                MCMButton.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71");
            }
            else if (MCMButton.Text == "ON")
            {
                try { NewTCPComs.TCP_Mssg_Send(client, 1, 1288, 5, 0); }
                catch
                {
                    MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MCMButton.Text = "ON";
                    MCMButton.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71");
                    return;
                }
                MCMButton.Text = "OFF";
                MCMButton.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
            }
        }

        // Toggle MUX channel 0 on and off.
        private void MUX0Button_Click(object sender, EventArgs e)
        {
            if (MUX0Button.Text == "OFF")
            {
                try { NewTCPComs.TCP_Mssg_Send (client, 1, 1297, 5, 1); }
                catch
                {
                    MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MUX0Button.Text = "OFF";
                    MUX0Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
                    return;
                }
                MUX0Button.Text = "ON";
                MUX0Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71");
            }
            else if (MUX0Button.Text == "ON")
            {
                try { NewTCPComs.TCP_Mssg_Send (client, 1, 1297, 5, 0); }
                catch
                {
                    MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MUX0Button.Text = "ON";
                    MUX0Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71");
                    return;
                }
                MUX0Button.Text = "OFF";
                MUX0Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
            }
        }

        // Toggle MUX channel 1 on and off.
        private void MUX1Button_Click(object sender, EventArgs e)
        {
            if (MUX1Button.Text == "OFF")
            {
                try { NewTCPComs.TCP_Mssg_Send (client, 1, 1298, 5, 1); }
                catch
                {
                    MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MUX1Button.Text = "OFF";
                    MUX1Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
                    return;
                }
                MUX1Button.Text = "ON";
                MUX1Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71");
            }
            else if (MUX1Button.Text == "ON")
            {
                try { NewTCPComs.TCP_Mssg_Send (client, 1, 1298, 5, 0); }
                catch
                {
                    MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MUX1Button.Text = "ON";
                    MUX1Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71");
                    return;
                }
                MUX1Button.Text = "OFF";
                MUX1Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
            }
        }

        // Toggle MUX channel 2 on and off.
        private void MUX2Button_Click(object sender, EventArgs e)
        {
            if (MUX2Button.Text == "OFF")
            {
                try { NewTCPComs.TCP_Mssg_Send (client, 1, 1299, 5, 1); }
                catch
                {
                    MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MUX2Button.Text = "OFF";
                    MUX2Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
                    return;
                }
                MUX2Button.Text = "ON";
                MUX2Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71");
            }
            else if (MUX2Button.Text == "ON")
            {
                try { NewTCPComs.TCP_Mssg_Send (client, 1, 1299, 5, 0); }
                catch
                {
                    MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MUX2Button.Text = "ON";
                    MUX2Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71");
                    return;
                }
                MUX2Button.Text = "OFF";
                MUX2Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
            }
        }

        // Toggle MUX channel 3 on and off.
        private void MUX3Button_Click(object sender, EventArgs e)
        {
            if (MUX3Button.Text == "OFF")
            {
                try { NewTCPComs.TCP_Mssg_Send (client, 1, 1300, 5, 1); }
                catch
                {
                    MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MUX3Button.Text = "OFF";
                    MUX3Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
                    return;
                }
                MUX3Button.Text = "ON";
                MUX3Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71");
            }
            else if (MUX3Button.Text == "ON")
            {
                try { NewTCPComs.TCP_Mssg_Send (client, 1, 1300, 5, 0); }
                catch
                {
                    MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MUX3Button.Text = "ON";
                    MUX3Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71");
                    return;
                }
                MUX3Button.Text = "OFF";
                MUX3Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
            }
        }

        // Toggle MUX channel 4 on and off.
        private void MUX4Button_Click(object sender, EventArgs e)
        {
            if (MUX4Button.Text == "OFF")
            {
                try { NewTCPComs.TCP_Mssg_Send (client, 1, 1301, 5, 1); }
                catch
                {
                    MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MUX4Button.Text = "OFF";
                    MUX4Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
                    return;
                }
                MUX4Button.Text = "ON";
                MUX4Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71");
            }
            else if (MUX4Button.Text == "ON")
            {
                try { NewTCPComs.TCP_Mssg_Send (client, 1, 1301, 5, 0); }
                catch
                {
                    MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MUX4Button.Text = "ON";
                    MUX4Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71");
                    return;
                }
                MUX4Button.Text = "OFF";
                MUX4Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
            }
        }

        // Toggle digital input bank 1 on and off.
        private void DIN1Button_Click(object sender, EventArgs e)
        {
            if (DIN1Button.Text == "OFF")
            {
                try { NewTCPComs.TCP_Mssg_Send (client, 1, 1302, 5, 1); }
                catch
                {
                    MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DIN1Button.Text = "OFF";
                    DIN1Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
                    return;
                }
                DIN1Button.Text = "ON";
                DIN1Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71");
            }
            else if (DIN1Button.Text == "ON")
            {
                try { NewTCPComs.TCP_Mssg_Send (client, 1, 1302, 5, 0); }
                catch
                {
                    MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DIN1Button.Text = "ON";
                    DIN1Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71");
                    return;
                }
                DIN1Button.Text = "OFF";
                DIN1Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
            }
        }

        // Toggle digital input bank 2 on and off.
        private void DIN2Button_Click(object sender, EventArgs e)
        {
            if (DIN2Button.Text == "OFF")
            {
                try { NewTCPComs.TCP_Mssg_Send (client, 1, 1303, 5, 1); }
                catch
                {
                    MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DIN2Button.Text = "OFF";
                    DIN2Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
                    return;
                }
                DIN2Button.Text = "ON";
                DIN2Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71");
            }
            else if (DIN2Button.Text == "ON")
            {
                try { NewTCPComs.TCP_Mssg_Send (client, 1, 1303, 5, 0); }
                catch
                {
                    MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DIN2Button.Text = "ON";
                    DIN2Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71");
                    return;
                }
                DIN2Button.Text = "OFF";
                DIN2Button.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
            }
        }

        // Toggle digital limiting current on and off.
        private void ILIMButton_Click(object sender, EventArgs e)
        {
            if (ILIMButton.Text == "OFF")
            {
                try { NewTCPComs.TCP_Mssg_Send (client, 1, 1304, 5, 1); }
                catch
                {
                    MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ILIMButton.Text = "OFF";
                    ILIMButton.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
                    return;
                }
                ILIMButton.Text = "ON";
                ILIMButton.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71");
            }
            else if (ILIMButton.Text == "ON")
            {
                try { NewTCPComs.TCP_Mssg_Send (client, 1, 1304, 5, 0); }
                catch
                {
                    MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ILIMButton.Text = "ON";
                    ILIMButton.FillColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71");
                    return;
                }
                ILIMButton.Text = "OFF";
                ILIMButton.FillColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
            }
        }
        #endregion

        // Read Analog Voltage register 4200.
        private void VReadButton_Click(object sender, EventArgs e)
        {
            try
            {
                int AVoltage = NewTCPComs.TCP_Mssg_Send(client, 1, 4200, 3, 1);
                if (AVoltage >= 65000) { AVoltage -= 65536; }
                ModbusOutput.Text += "Reading analog voltage. Returned value: " + AVoltage + Environment.NewLine;
            }
            catch { MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // Read Analog Current register 4201.
        private void AReadButton_Click(object sender, EventArgs e)
        {
            try
            {
                int ACurrent = NewTCPComs.TCP_Mssg_Send(client, 1, 4201, 3, 1);
                ModbusOutput.Text += "Reading analog current. Returned value: " + ACurrent + Environment.NewLine;
            }
            catch { MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // Send custom command function.
        private void CmmdSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (FunctionComboBox.Text == "") { throw new ArgumentException("Please select function code."); }
                else if (StrtAddrInp.Text == "") { throw new ArgumentException("Please enter start address."); }
                else if (AddrValSend.Text == "" && FunctionComboBox.SelectedIndex == 4) { throw new ArgumentException("Please enter a value to be sent."); }
                else if (AddrValSend.Text == "" && FunctionComboBox.SelectedIndex == 5) { throw new ArgumentException("Please enter a value to be sent."); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            byte FunctionCode;
            int startAddr = Convert.ToUInt16(StrtAddrInp.Text);
            UInt16 desiredVal;

            if (FunctionComboBox.SelectedIndex == 0) { FunctionCode = 1; }
            else if (FunctionComboBox.SelectedIndex == 1) { FunctionCode = 2; }
            else if (FunctionComboBox.SelectedIndex == 2) { FunctionCode = 3; }
            else if (FunctionComboBox.SelectedIndex == 3) { FunctionCode = 4; }
            else if (FunctionComboBox.SelectedIndex == 4) { FunctionCode = 5; }
            else { FunctionCode = 6; }

            if (FunctionCode == 5 || FunctionCode == 6) { desiredVal = Convert.ToUInt16(AddrValSend.Text); }
            else { desiredVal = 1; }

            try 
            { 
                int PLCReply = NewTCPComs.TCP_Mssg_Send(client, 1, startAddr, FunctionCode, desiredVal);
                int Returned = PLCReply;
                if (Returned > 60000) { Returned -= 65535; }
                if (FunctionCode == 1) { ModbusOutput.Text += "Reading coil " + startAddr + "." + " Returned value: " + Returned + Environment.NewLine; }
                else if (FunctionCode == 2) { ModbusOutput.Text += "Reading discrete input " + startAddr + "." + " Returned value: " + Returned + Environment.NewLine; }
                else if (FunctionCode == 3) { ModbusOutput.Text += "Reading holding register " + startAddr + "." + " Returned value: " + Returned + Environment.NewLine; }
                else if (FunctionCode == 4) { ModbusOutput.Text += "Reading input register " + startAddr + "." + " Returned value: " + Returned + Environment.NewLine; }
                else if (FunctionCode == 5) { ModbusOutput.Text += "Write " + desiredVal + " to coil " + startAddr + "." + Environment.NewLine; }
                else { ModbusOutput.Text += "Write " + desiredVal + " to holding register " + startAddr + "." + Environment.NewLine; }
            } 
            catch { MessageBox.Show("PLC not connected through ethernet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ModbusOutput.Text = string.Empty;
        }
    }
}
