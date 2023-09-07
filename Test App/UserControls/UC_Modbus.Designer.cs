namespace Test_App.UserControls
{
    partial class UC_Modbus
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TCPConnect = new Guna.UI2.WinForms.Guna2Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ModStateText = new System.Windows.Forms.TextBox();
            this.PowerButton = new Guna.UI2.WinForms.Guna2Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.MUX0Button = new Guna.UI2.WinForms.Guna2Button();
            this.MUX1Button = new Guna.UI2.WinForms.Guna2Button();
            this.MUX2Button = new Guna.UI2.WinForms.Guna2Button();
            this.MUX3Button = new Guna.UI2.WinForms.Guna2Button();
            this.MUX4Button = new Guna.UI2.WinForms.Guna2Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.DIN1Button = new Guna.UI2.WinForms.Guna2Button();
            this.DIN2Button = new Guna.UI2.WinForms.Guna2Button();
            this.ILIMButton = new Guna.UI2.WinForms.Guna2Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.VReadButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.MCMButton = new Guna.UI2.WinForms.Guna2Button();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.FunctionComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.CmmdSend = new Guna.UI2.WinForms.Guna2Button();
            this.StrtAddrInp = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddrValSend = new Guna.UI2.WinForms.Guna2TextBox();
            this.OutputPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ModbusOutput = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.ClearButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.guna2GradientPanel3.SuspendLayout();
            this.OutputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCPConnect
            // 
            this.TCPConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.TCPConnect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.TCPConnect.BorderRadius = 5;
            this.TCPConnect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TCPConnect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TCPConnect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TCPConnect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TCPConnect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.TCPConnect.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCPConnect.ForeColor = System.Drawing.Color.White;
            this.TCPConnect.Location = new System.Drawing.Point(90, 26);
            this.TCPConnect.Name = "TCPConnect";
            this.TCPConnect.Size = new System.Drawing.Size(183, 51);
            this.TCPConnect.TabIndex = 0;
            this.TCPConnect.Text = "Connect";
            this.TCPConnect.Click += new System.EventHandler(this.TCPConnect_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(90, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(81, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "PLC STATE: ";
            // 
            // ModStateText
            // 
            this.ModStateText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.ModStateText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModStateText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModStateText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.ModStateText.Location = new System.Drawing.Point(166, 83);
            this.ModStateText.Name = "ModStateText";
            this.ModStateText.ReadOnly = true;
            this.ModStateText.Size = new System.Drawing.Size(126, 20);
            this.ModStateText.TabIndex = 2;
            this.ModStateText.Text = "DISCONNECTED";
            // 
            // PowerButton
            // 
            this.PowerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.PowerButton.BorderRadius = 5;
            this.PowerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PowerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PowerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PowerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PowerButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.PowerButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PowerButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PowerButton.Location = new System.Drawing.Point(166, 65);
            this.PowerButton.Name = "PowerButton";
            this.PowerButton.Size = new System.Drawing.Size(126, 20);
            this.PowerButton.TabIndex = 3;
            this.PowerButton.Text = "OFF";
            this.PowerButton.Click += new System.EventHandler(this.PowerButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(17, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(107, 24);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "PIM Power: ";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(17, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(89, 24);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "MUX 0:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(17, 117);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(89, 24);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "MUX 1:";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(17, 143);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(89, 24);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "MUX 2:";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(17, 169);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(89, 24);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "MUX 3:";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(17, 195);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(89, 24);
            this.textBox7.TabIndex = 10;
            this.textBox7.Text = "MUX 4:";
            // 
            // MUX0Button
            // 
            this.MUX0Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.MUX0Button.BorderRadius = 5;
            this.MUX0Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MUX0Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MUX0Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MUX0Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MUX0Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.MUX0Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MUX0Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MUX0Button.Location = new System.Drawing.Point(166, 91);
            this.MUX0Button.Name = "MUX0Button";
            this.MUX0Button.Size = new System.Drawing.Size(126, 20);
            this.MUX0Button.TabIndex = 11;
            this.MUX0Button.Text = "OFF";
            this.MUX0Button.Click += new System.EventHandler(this.MUX0Button_Click);
            // 
            // MUX1Button
            // 
            this.MUX1Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.MUX1Button.BorderRadius = 5;
            this.MUX1Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MUX1Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MUX1Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MUX1Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MUX1Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.MUX1Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MUX1Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MUX1Button.Location = new System.Drawing.Point(166, 117);
            this.MUX1Button.Name = "MUX1Button";
            this.MUX1Button.Size = new System.Drawing.Size(126, 20);
            this.MUX1Button.TabIndex = 12;
            this.MUX1Button.Text = "OFF";
            this.MUX1Button.Click += new System.EventHandler(this.MUX1Button_Click);
            // 
            // MUX2Button
            // 
            this.MUX2Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.MUX2Button.BorderRadius = 5;
            this.MUX2Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MUX2Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MUX2Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MUX2Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MUX2Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.MUX2Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MUX2Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MUX2Button.Location = new System.Drawing.Point(166, 143);
            this.MUX2Button.Name = "MUX2Button";
            this.MUX2Button.Size = new System.Drawing.Size(126, 20);
            this.MUX2Button.TabIndex = 13;
            this.MUX2Button.Text = "OFF";
            this.MUX2Button.Click += new System.EventHandler(this.MUX2Button_Click);
            // 
            // MUX3Button
            // 
            this.MUX3Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.MUX3Button.BorderRadius = 5;
            this.MUX3Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MUX3Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MUX3Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MUX3Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MUX3Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.MUX3Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MUX3Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MUX3Button.Location = new System.Drawing.Point(166, 169);
            this.MUX3Button.Name = "MUX3Button";
            this.MUX3Button.Size = new System.Drawing.Size(126, 20);
            this.MUX3Button.TabIndex = 14;
            this.MUX3Button.Text = "OFF";
            this.MUX3Button.Click += new System.EventHandler(this.MUX3Button_Click);
            // 
            // MUX4Button
            // 
            this.MUX4Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.MUX4Button.BorderRadius = 5;
            this.MUX4Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MUX4Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MUX4Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MUX4Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MUX4Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.MUX4Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MUX4Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MUX4Button.Location = new System.Drawing.Point(166, 195);
            this.MUX4Button.Name = "MUX4Button";
            this.MUX4Button.Size = new System.Drawing.Size(126, 20);
            this.MUX4Button.TabIndex = 15;
            this.MUX4Button.Text = "OFF";
            this.MUX4Button.Click += new System.EventHandler(this.MUX4Button_Click);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(17, 221);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(89, 24);
            this.textBox8.TabIndex = 16;
            this.textBox8.Text = "DIN 1:";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(17, 247);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(89, 24);
            this.textBox9.TabIndex = 17;
            this.textBox9.Text = "DIN 2:";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(17, 273);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(89, 24);
            this.textBox10.TabIndex = 18;
            this.textBox10.Text = "DIN ILIM:";
            // 
            // DIN1Button
            // 
            this.DIN1Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.DIN1Button.BorderRadius = 5;
            this.DIN1Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DIN1Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DIN1Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DIN1Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DIN1Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.DIN1Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DIN1Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DIN1Button.Location = new System.Drawing.Point(166, 221);
            this.DIN1Button.Name = "DIN1Button";
            this.DIN1Button.Size = new System.Drawing.Size(126, 20);
            this.DIN1Button.TabIndex = 19;
            this.DIN1Button.Text = "OFF";
            this.DIN1Button.Click += new System.EventHandler(this.DIN1Button_Click);
            // 
            // DIN2Button
            // 
            this.DIN2Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.DIN2Button.BorderRadius = 5;
            this.DIN2Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DIN2Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DIN2Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DIN2Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DIN2Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.DIN2Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DIN2Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DIN2Button.Location = new System.Drawing.Point(166, 247);
            this.DIN2Button.Name = "DIN2Button";
            this.DIN2Button.Size = new System.Drawing.Size(126, 20);
            this.DIN2Button.TabIndex = 20;
            this.DIN2Button.Text = "OFF";
            this.DIN2Button.Click += new System.EventHandler(this.DIN2Button_Click);
            // 
            // ILIMButton
            // 
            this.ILIMButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.ILIMButton.BorderRadius = 5;
            this.ILIMButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ILIMButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ILIMButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ILIMButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ILIMButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.ILIMButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ILIMButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ILIMButton.Location = new System.Drawing.Point(166, 273);
            this.ILIMButton.Name = "ILIMButton";
            this.ILIMButton.Size = new System.Drawing.Size(126, 20);
            this.ILIMButton.TabIndex = 21;
            this.ILIMButton.Text = "OFF";
            this.ILIMButton.Click += new System.EventHandler(this.ILIMButton_Click);
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(53, 185);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(311, 36);
            this.textBox11.TabIndex = 22;
            this.textBox11.Text = "PIM Input and Outputs";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(17, 333);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(134, 24);
            this.textBox12.TabIndex = 23;
            this.textBox12.Text = "Analog Voltage: ";
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(17, 359);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(134, 24);
            this.textBox13.TabIndex = 24;
            this.textBox13.Text = "Analog Current: ";
            // 
            // VReadButton
            // 
            this.VReadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.VReadButton.BorderRadius = 5;
            this.VReadButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.VReadButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.VReadButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.VReadButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.VReadButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(176)))), ((int)(((byte)(65)))));
            this.VReadButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.VReadButton.ForeColor = System.Drawing.Color.Black;
            this.VReadButton.Location = new System.Drawing.Point(166, 333);
            this.VReadButton.Name = "VReadButton";
            this.VReadButton.Size = new System.Drawing.Size(126, 20);
            this.VReadButton.TabIndex = 27;
            this.VReadButton.Text = "CHECK";
            this.VReadButton.Click += new System.EventHandler(this.VReadButton_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(176)))), ((int)(((byte)(65)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(166, 359);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(126, 20);
            this.guna2Button1.TabIndex = 28;
            this.guna2Button1.Text = "CHECK";
            this.guna2Button1.Click += new System.EventHandler(this.AReadButton_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.guna2GradientPanel1.BorderRadius = 10;
            this.guna2GradientPanel1.Controls.Add(this.MCMButton);
            this.guna2GradientPanel1.Controls.Add(this.textBox19);
            this.guna2GradientPanel1.Controls.Add(this.guna2Button1);
            this.guna2GradientPanel1.Controls.Add(this.ILIMButton);
            this.guna2GradientPanel1.Controls.Add(this.DIN2Button);
            this.guna2GradientPanel1.Controls.Add(this.VReadButton);
            this.guna2GradientPanel1.Controls.Add(this.DIN1Button);
            this.guna2GradientPanel1.Controls.Add(this.textBox9);
            this.guna2GradientPanel1.Controls.Add(this.MUX4Button);
            this.guna2GradientPanel1.Controls.Add(this.textBox10);
            this.guna2GradientPanel1.Controls.Add(this.MUX3Button);
            this.guna2GradientPanel1.Controls.Add(this.textBox8);
            this.guna2GradientPanel1.Controls.Add(this.MUX2Button);
            this.guna2GradientPanel1.Controls.Add(this.textBox13);
            this.guna2GradientPanel1.Controls.Add(this.MUX1Button);
            this.guna2GradientPanel1.Controls.Add(this.textBox12);
            this.guna2GradientPanel1.Controls.Add(this.MUX0Button);
            this.guna2GradientPanel1.Controls.Add(this.textBox2);
            this.guna2GradientPanel1.Controls.Add(this.PowerButton);
            this.guna2GradientPanel1.Controls.Add(this.textBox3);
            this.guna2GradientPanel1.Controls.Add(this.textBox4);
            this.guna2GradientPanel1.Controls.Add(this.textBox5);
            this.guna2GradientPanel1.Controls.Add(this.textBox7);
            this.guna2GradientPanel1.Controls.Add(this.textBox6);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(36, 171);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(353, 411);
            this.guna2GradientPanel1.TabIndex = 29;
            // 
            // MCMButton
            // 
            this.MCMButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.MCMButton.BorderRadius = 5;
            this.MCMButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MCMButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MCMButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MCMButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MCMButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.MCMButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MCMButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MCMButton.Location = new System.Drawing.Point(166, 299);
            this.MCMButton.Name = "MCMButton";
            this.MCMButton.Size = new System.Drawing.Size(126, 20);
            this.MCMButton.TabIndex = 72;
            this.MCMButton.Text = "OFF";
            this.MCMButton.Click += new System.EventHandler(this.MCMButton_Click);
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox19.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox19.Location = new System.Drawing.Point(17, 299);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(116, 24);
            this.textBox19.TabIndex = 71;
            this.textBox19.Text = "MCM Power:";
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BorderColor = System.Drawing.Color.Black;
            this.guna2GradientPanel2.BorderRadius = 10;
            this.guna2GradientPanel2.Controls.Add(this.ModStateText);
            this.guna2GradientPanel2.Controls.Add(this.textBox1);
            this.guna2GradientPanel2.Controls.Add(this.TCPConnect);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.guna2GradientPanel2.Location = new System.Drawing.Point(36, 38);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(353, 113);
            this.guna2GradientPanel2.TabIndex = 30;
            // 
            // FunctionComboBox
            // 
            this.FunctionComboBox.BackColor = System.Drawing.Color.Transparent;
            this.FunctionComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FunctionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FunctionComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.FunctionComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FunctionComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FunctionComboBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FunctionComboBox.ForeColor = System.Drawing.Color.Black;
            this.FunctionComboBox.ItemHeight = 30;
            this.FunctionComboBox.Location = new System.Drawing.Point(171, 67);
            this.FunctionComboBox.Name = "FunctionComboBox";
            this.FunctionComboBox.Size = new System.Drawing.Size(305, 36);
            this.FunctionComboBox.TabIndex = 31;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(437, 48);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(311, 36);
            this.textBox14.TabIndex = 32;
            this.textBox14.Text = "Custom TCP Command";
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(17, 73);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(114, 30);
            this.textBox15.TabIndex = 33;
            this.textBox15.Text = "Function:";
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(17, 115);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(134, 30);
            this.textBox16.TabIndex = 34;
            this.textBox16.Text = "PLC Address:";
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(17, 157);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(148, 30);
            this.textBox17.TabIndex = 35;
            this.textBox17.Text = "Value to send:";
            // 
            // guna2GradientPanel3
            // 
            this.guna2GradientPanel3.BorderColor = System.Drawing.Color.Black;
            this.guna2GradientPanel3.BorderRadius = 10;
            this.guna2GradientPanel3.Controls.Add(this.CmmdSend);
            this.guna2GradientPanel3.Controls.Add(this.StrtAddrInp);
            this.guna2GradientPanel3.Controls.Add(this.AddrValSend);
            this.guna2GradientPanel3.Controls.Add(this.textBox16);
            this.guna2GradientPanel3.Controls.Add(this.textBox17);
            this.guna2GradientPanel3.Controls.Add(this.FunctionComboBox);
            this.guna2GradientPanel3.Controls.Add(this.textBox15);
            this.guna2GradientPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.guna2GradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.guna2GradientPanel3.Location = new System.Drawing.Point(420, 38);
            this.guna2GradientPanel3.Name = "guna2GradientPanel3";
            this.guna2GradientPanel3.Size = new System.Drawing.Size(520, 216);
            this.guna2GradientPanel3.TabIndex = 37;
            // 
            // CmmdSend
            // 
            this.CmmdSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.CmmdSend.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.CmmdSend.BorderRadius = 5;
            this.CmmdSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CmmdSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CmmdSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CmmdSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CmmdSend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(176)))), ((int)(((byte)(65)))));
            this.CmmdSend.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmmdSend.ForeColor = System.Drawing.Color.Black;
            this.CmmdSend.Location = new System.Drawing.Point(394, 114);
            this.CmmdSend.Name = "CmmdSend";
            this.CmmdSend.Size = new System.Drawing.Size(110, 73);
            this.CmmdSend.TabIndex = 38;
            this.CmmdSend.Text = "Send";
            this.CmmdSend.Click += new System.EventHandler(this.CmmdSend_Click);
            // 
            // StrtAddrInp
            // 
            this.StrtAddrInp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StrtAddrInp.DefaultText = "";
            this.StrtAddrInp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StrtAddrInp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StrtAddrInp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StrtAddrInp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StrtAddrInp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.StrtAddrInp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StrtAddrInp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrtAddrInp.ForeColor = System.Drawing.Color.Black;
            this.StrtAddrInp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StrtAddrInp.Location = new System.Drawing.Point(171, 109);
            this.StrtAddrInp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StrtAddrInp.MaxLength = 4;
            this.StrtAddrInp.Name = "StrtAddrInp";
            this.StrtAddrInp.PasswordChar = '\0';
            this.StrtAddrInp.PlaceholderForeColor = System.Drawing.Color.Black;
            this.StrtAddrInp.PlaceholderText = "";
            this.StrtAddrInp.SelectedText = "";
            this.StrtAddrInp.Size = new System.Drawing.Size(200, 36);
            this.StrtAddrInp.TabIndex = 40;
            // 
            // AddrValSend
            // 
            this.AddrValSend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddrValSend.DefaultText = "";
            this.AddrValSend.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddrValSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddrValSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddrValSend.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddrValSend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.AddrValSend.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddrValSend.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddrValSend.ForeColor = System.Drawing.Color.Black;
            this.AddrValSend.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddrValSend.Location = new System.Drawing.Point(171, 151);
            this.AddrValSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddrValSend.MaxLength = 4;
            this.AddrValSend.Name = "AddrValSend";
            this.AddrValSend.PasswordChar = '\0';
            this.AddrValSend.PlaceholderForeColor = System.Drawing.Color.Black;
            this.AddrValSend.PlaceholderText = "";
            this.AddrValSend.SelectedText = "";
            this.AddrValSend.Size = new System.Drawing.Size(200, 36);
            this.AddrValSend.TabIndex = 39;
            // 
            // OutputPanel
            // 
            this.OutputPanel.BorderColor = System.Drawing.Color.Transparent;
            this.OutputPanel.BorderRadius = 10;
            this.OutputPanel.BorderThickness = 2;
            this.OutputPanel.Controls.Add(this.ClearButton);
            this.OutputPanel.Controls.Add(this.ModbusOutput);
            this.OutputPanel.Controls.Add(this.guna2TextBox6);
            this.OutputPanel.FillColor = System.Drawing.Color.White;
            this.OutputPanel.FillColor2 = System.Drawing.Color.White;
            this.OutputPanel.Location = new System.Drawing.Point(420, 271);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(520, 441);
            this.OutputPanel.TabIndex = 70;
            // 
            // ModbusOutput
            // 
            this.ModbusOutput.AutoScroll = true;
            this.ModbusOutput.BackColor = System.Drawing.Color.White;
            this.ModbusOutput.BorderColor = System.Drawing.Color.Silver;
            this.ModbusOutput.BorderThickness = 0;
            this.ModbusOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ModbusOutput.DefaultText = "";
            this.ModbusOutput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ModbusOutput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ModbusOutput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ModbusOutput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ModbusOutput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ModbusOutput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModbusOutput.ForeColor = System.Drawing.Color.Black;
            this.ModbusOutput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ModbusOutput.Location = new System.Drawing.Point(14, 52);
            this.ModbusOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ModbusOutput.MaxLength = 60000;
            this.ModbusOutput.Multiline = true;
            this.ModbusOutput.Name = "ModbusOutput";
            this.ModbusOutput.PasswordChar = '\0';
            this.ModbusOutput.PlaceholderForeColor = System.Drawing.Color.Black;
            this.ModbusOutput.PlaceholderText = "";
            this.ModbusOutput.ReadOnly = true;
            this.ModbusOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ModbusOutput.SelectedText = "";
            this.ModbusOutput.Size = new System.Drawing.Size(490, 338);
            this.ModbusOutput.TabIndex = 71;
            // 
            // guna2TextBox6
            // 
            this.guna2TextBox6.BackColor = System.Drawing.Color.White;
            this.guna2TextBox6.BorderColor = System.Drawing.Color.Silver;
            this.guna2TextBox6.BorderRadius = 5;
            this.guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox6.DefaultText = "Output Window";
            this.guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox6.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Location = new System.Drawing.Point(171, 20);
            this.guna2TextBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox6.MaxLength = 4;
            this.guna2TextBox6.Name = "guna2TextBox6";
            this.guna2TextBox6.PasswordChar = '\0';
            this.guna2TextBox6.PlaceholderForeColor = System.Drawing.Color.Black;
            this.guna2TextBox6.PlaceholderText = "";
            this.guna2TextBox6.ReadOnly = true;
            this.guna2TextBox6.SelectedText = "";
            this.guna2TextBox6.Size = new System.Drawing.Size(175, 24);
            this.guna2TextBox6.TabIndex = 70;
            this.guna2TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.White;
            this.ClearButton.BorderColor = System.Drawing.Color.White;
            this.ClearButton.BorderRadius = 5;
            this.ClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClearButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(250)))), ((int)(((byte)(110)))));
            this.ClearButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.Black;
            this.ClearButton.Location = new System.Drawing.Point(205, 397);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(110, 36);
            this.ClearButton.TabIndex = 71;
            this.ClearButton.Text = "Clear";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // UC_Modbus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.OutputPanel);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.guna2GradientPanel3);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "UC_Modbus";
            this.Size = new System.Drawing.Size(1258, 743);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            this.guna2GradientPanel3.ResumeLayout(false);
            this.guna2GradientPanel3.PerformLayout();
            this.OutputPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button TCPConnect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ModStateText;
        private Guna.UI2.WinForms.Guna2Button PowerButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private Guna.UI2.WinForms.Guna2Button MUX0Button;
        private Guna.UI2.WinForms.Guna2Button MUX1Button;
        private Guna.UI2.WinForms.Guna2Button MUX2Button;
        private Guna.UI2.WinForms.Guna2Button MUX3Button;
        private Guna.UI2.WinForms.Guna2Button MUX4Button;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private Guna.UI2.WinForms.Guna2Button DIN1Button;
        private Guna.UI2.WinForms.Guna2Button DIN2Button;
        private Guna.UI2.WinForms.Guna2Button ILIMButton;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private Guna.UI2.WinForms.Guna2Button VReadButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2ComboBox FunctionComboBox;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private Guna.UI2.WinForms.Guna2TextBox AddrValSend;
        private Guna.UI2.WinForms.Guna2TextBox StrtAddrInp;
        private Guna.UI2.WinForms.Guna2Button CmmdSend;
        private Guna.UI2.WinForms.Guna2GradientPanel OutputPanel;
        private Guna.UI2.WinForms.Guna2TextBox ModbusOutput;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox6;
        private Guna.UI2.WinForms.Guna2Button MCMButton;
        private System.Windows.Forms.TextBox textBox19;
        private Guna.UI2.WinForms.Guna2Button ClearButton;
    }
}
