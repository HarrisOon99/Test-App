using System;
using System.Drawing;
using System.Windows.Forms;
using Test_App.UserControls;

namespace Test_App
{
    public partial class MainForm : Form
    {

        private bool mouseDown;
        private Point lastLocation;

        public MainForm()
        {
            InitializeComponent();
            UC_Home uc = new UC_Home();
            addUserControl(uc);
        }

        #region Movable program.
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e) { mouseDown = false; }
        #endregion

        #region Adding new tabs.
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            MidPanel.Controls.Clear();
            MidPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void HomeTab_Click(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            addUserControl(uc);
        }

        private void ModbusPLCTab_Click(object sender, EventArgs e)
        {
            UC_Modbus uc = new UC_Modbus();
            addUserControl(uc);
        }

        private void CANBusTab_Click(object sender, EventArgs e)
        {
            UC_CANbus uc = new UC_CANbus();
            addUserControl(uc);
        }
        #endregion

        #region Top bar control.
        private void ExitButton_Click(object sender, EventArgs e) { this.Close(); }

        private void MinButton_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) { this.WindowState = FormWindowState.Maximized; }
            else if (this.WindowState == FormWindowState.Maximized) { this.WindowState = FormWindowState.Normal; }
        }
        #endregion
    }
}