using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_App.UserControls
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        private void GetDeciButton_Click(object sender, EventArgs e)
        {
            try { int Dec = Convert.ToInt32(HexValue.Text, 16); DeciValue.Text = Dec.ToString(); } 
            catch { MessageBox.Show("Textbox cannot be left empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void GetHexButton_Click(object sender, EventArgs e)
        {
            int Deci = Int16.Parse(DeciValue.Text);
            try { string Hex = Deci.ToString("X"); HexValue.Text = Hex; }
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
    }
}
