﻿namespace Test_App.UserControls
{
    partial class UC_Home
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ArbiLabel = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeciValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.HexValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.GetDeciButton = new Guna.UI2.WinForms.Guna2Button();
            this.GetHexButton = new Guna.UI2.WinForms.Guna2Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.SerialOutput = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.InputText = new Guna.UI2.WinForms.Guna2TextBox();
            this.IntValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.BitConverterButton = new Guna.UI2.WinForms.Guna2Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.OutputPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.guna2GradientPanel3.SuspendLayout();
            this.guna2GradientPanel4.SuspendLayout();
            this.OutputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderRadius = 10;
            this.guna2GradientPanel1.BorderThickness = 2;
            this.guna2GradientPanel1.Controls.Add(this.textBox12);
            this.guna2GradientPanel1.Controls.Add(this.GetHexButton);
            this.guna2GradientPanel1.Controls.Add(this.GetDeciButton);
            this.guna2GradientPanel1.Controls.Add(this.HexValue);
            this.guna2GradientPanel1.Controls.Add(this.DeciValue);
            this.guna2GradientPanel1.Controls.Add(this.textBox1);
            this.guna2GradientPanel1.Controls.Add(this.ArbiLabel);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(178)))), ((int)(((byte)(122)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(178)))), ((int)(((byte)(122)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(24, 24);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(388, 228);
            this.guna2GradientPanel1.TabIndex = 71;
            // 
            // ArbiLabel
            // 
            this.ArbiLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(178)))), ((int)(((byte)(122)))));
            this.ArbiLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ArbiLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArbiLabel.Location = new System.Drawing.Point(30, 103);
            this.ArbiLabel.Name = "ArbiLabel";
            this.ArbiLabel.ReadOnly = true;
            this.ArbiLabel.Size = new System.Drawing.Size(99, 22);
            this.ArbiLabel.TabIndex = 36;
            this.ArbiLabel.Text = "Hex value:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(178)))), ((int)(((byte)(122)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(30, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(109, 22);
            this.textBox1.TabIndex = 37;
            this.textBox1.Text = "Decimal Value:";
            // 
            // DeciValue
            // 
            this.DeciValue.BackColor = System.Drawing.Color.White;
            this.DeciValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DeciValue.DefaultText = "";
            this.DeciValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DeciValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DeciValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DeciValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DeciValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DeciValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeciValue.ForeColor = System.Drawing.Color.Black;
            this.DeciValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DeciValue.Location = new System.Drawing.Point(145, 66);
            this.DeciValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeciValue.MaxLength = 16;
            this.DeciValue.Name = "DeciValue";
            this.DeciValue.PasswordChar = '\0';
            this.DeciValue.PlaceholderForeColor = System.Drawing.Color.Black;
            this.DeciValue.PlaceholderText = "";
            this.DeciValue.SelectedText = "";
            this.DeciValue.Size = new System.Drawing.Size(175, 24);
            this.DeciValue.TabIndex = 73;
            // 
            // HexValue
            // 
            this.HexValue.BackColor = System.Drawing.Color.White;
            this.HexValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HexValue.DefaultText = "";
            this.HexValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.HexValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.HexValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HexValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HexValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HexValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexValue.ForeColor = System.Drawing.Color.Black;
            this.HexValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HexValue.Location = new System.Drawing.Point(145, 103);
            this.HexValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HexValue.MaxLength = 16;
            this.HexValue.Name = "HexValue";
            this.HexValue.PasswordChar = '\0';
            this.HexValue.PlaceholderForeColor = System.Drawing.Color.Black;
            this.HexValue.PlaceholderText = "";
            this.HexValue.SelectedText = "";
            this.HexValue.Size = new System.Drawing.Size(175, 24);
            this.HexValue.TabIndex = 72;
            // 
            // GetDeciButton
            // 
            this.GetDeciButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(178)))), ((int)(((byte)(122)))));
            this.GetDeciButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.GetDeciButton.BorderRadius = 5;
            this.GetDeciButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GetDeciButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GetDeciButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GetDeciButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GetDeciButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(155)))), ((int)(((byte)(211)))));
            this.GetDeciButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetDeciButton.ForeColor = System.Drawing.Color.Black;
            this.GetDeciButton.Location = new System.Drawing.Point(30, 153);
            this.GetDeciButton.Name = "GetDeciButton";
            this.GetDeciButton.Size = new System.Drawing.Size(152, 40);
            this.GetDeciButton.TabIndex = 72;
            this.GetDeciButton.Text = "Get Decimal";
            this.GetDeciButton.Click += new System.EventHandler(this.GetDeciButton_Click);
            this.GetDeciButton.MouseLeave += new System.EventHandler(this.GetDeciButton_MouseLeave);
            this.GetDeciButton.MouseHover += new System.EventHandler(this.GetDeciButton_MouseHover);
            // 
            // GetHexButton
            // 
            this.GetHexButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(178)))), ((int)(((byte)(122)))));
            this.GetHexButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.GetHexButton.BorderRadius = 5;
            this.GetHexButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GetHexButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GetHexButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GetHexButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GetHexButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.GetHexButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetHexButton.ForeColor = System.Drawing.Color.Black;
            this.GetHexButton.Location = new System.Drawing.Point(202, 153);
            this.GetHexButton.Name = "GetHexButton";
            this.GetHexButton.Size = new System.Drawing.Size(152, 40);
            this.GetHexButton.TabIndex = 74;
            this.GetHexButton.Text = "Get Hex";
            this.GetHexButton.Click += new System.EventHandler(this.GetHexButton_Click);
            this.GetHexButton.MouseLeave += new System.EventHandler(this.GetHexButton_MouseLeave);
            this.GetHexButton.MouseHover += new System.EventHandler(this.GetHexButton_MouseHover);
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(178)))), ((int)(((byte)(122)))));
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(29, 26);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(336, 22);
            this.textBox12.TabIndex = 72;
            this.textBox12.Text = "Technically Useless Hex Converter";
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel2.BorderColor = System.Drawing.Color.White;
            this.guna2GradientPanel2.BorderRadius = 10;
            this.guna2GradientPanel2.BorderThickness = 1;
            this.guna2GradientPanel2.Controls.Add(this.guna2TextBox6);
            this.guna2GradientPanel2.Controls.Add(this.SerialOutput);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.guna2GradientPanel2.Location = new System.Drawing.Point(24, 275);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(520, 441);
            this.guna2GradientPanel2.TabIndex = 72;
            // 
            // SerialOutput
            // 
            this.SerialOutput.AutoScroll = true;
            this.SerialOutput.BackColor = System.Drawing.Color.Transparent;
            this.SerialOutput.BorderColor = System.Drawing.Color.Transparent;
            this.SerialOutput.BorderThickness = 0;
            this.SerialOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SerialOutput.DefaultText = "";
            this.SerialOutput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SerialOutput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SerialOutput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SerialOutput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SerialOutput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.SerialOutput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SerialOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialOutput.ForeColor = System.Drawing.Color.Black;
            this.SerialOutput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SerialOutput.Location = new System.Drawing.Point(14, 52);
            this.SerialOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialOutput.MaxLength = 60000;
            this.SerialOutput.Multiline = true;
            this.SerialOutput.Name = "SerialOutput";
            this.SerialOutput.PasswordChar = '\0';
            this.SerialOutput.PlaceholderForeColor = System.Drawing.Color.Black;
            this.SerialOutput.PlaceholderText = "";
            this.SerialOutput.SelectedText = "";
            this.SerialOutput.Size = new System.Drawing.Size(492, 353);
            this.SerialOutput.TabIndex = 71;
            this.SerialOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SerialOutput_KeyPress);
            // 
            // guna2TextBox6
            // 
            this.guna2TextBox6.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox6.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox6.BorderRadius = 5;
            this.guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox6.DefaultText = "Serial Port";
            this.guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox6.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Location = new System.Drawing.Point(172, 20);
            this.guna2TextBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox6.MaxLength = 4;
            this.guna2TextBox6.Name = "guna2TextBox6";
            this.guna2TextBox6.PasswordChar = '\0';
            this.guna2TextBox6.PlaceholderForeColor = System.Drawing.Color.Black;
            this.guna2TextBox6.PlaceholderText = "";
            this.guna2TextBox6.ReadOnly = true;
            this.guna2TextBox6.SelectedText = "";
            this.guna2TextBox6.Size = new System.Drawing.Size(175, 24);
            this.guna2TextBox6.TabIndex = 72;
            this.guna2TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2GradientPanel3
            // 
            this.guna2GradientPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel3.BorderRadius = 10;
            this.guna2GradientPanel3.BorderThickness = 2;
            this.guna2GradientPanel3.Controls.Add(this.textBox2);
            this.guna2GradientPanel3.Controls.Add(this.BitConverterButton);
            this.guna2GradientPanel3.Controls.Add(this.IntValue);
            this.guna2GradientPanel3.Controls.Add(this.InputText);
            this.guna2GradientPanel3.Controls.Add(this.textBox3);
            this.guna2GradientPanel3.Controls.Add(this.textBox4);
            this.guna2GradientPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(247)))), ((int)(((byte)(156)))));
            this.guna2GradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(247)))), ((int)(((byte)(156)))));
            this.guna2GradientPanel3.Location = new System.Drawing.Point(433, 24);
            this.guna2GradientPanel3.Name = "guna2GradientPanel3";
            this.guna2GradientPanel3.Size = new System.Drawing.Size(388, 228);
            this.guna2GradientPanel3.TabIndex = 73;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(247)))), ((int)(((byte)(156)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(38, 101);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(99, 22);
            this.textBox4.TabIndex = 36;
            this.textBox4.Text = "Int value:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(247)))), ((int)(((byte)(156)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(38, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(109, 22);
            this.textBox3.TabIndex = 37;
            this.textBox3.Text = "4 byte input:";
            // 
            // InputText
            // 
            this.InputText.BackColor = System.Drawing.Color.White;
            this.InputText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputText.DefaultText = "";
            this.InputText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputText.ForeColor = System.Drawing.Color.Black;
            this.InputText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputText.Location = new System.Drawing.Point(153, 64);
            this.InputText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputText.MaxLength = 16;
            this.InputText.Name = "InputText";
            this.InputText.PasswordChar = '\0';
            this.InputText.PlaceholderForeColor = System.Drawing.Color.Black;
            this.InputText.PlaceholderText = "";
            this.InputText.SelectedText = "";
            this.InputText.Size = new System.Drawing.Size(175, 24);
            this.InputText.TabIndex = 73;
            // 
            // IntValue
            // 
            this.IntValue.BackColor = System.Drawing.Color.White;
            this.IntValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IntValue.DefaultText = "";
            this.IntValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IntValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IntValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IntValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IntValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IntValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntValue.ForeColor = System.Drawing.Color.Black;
            this.IntValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IntValue.Location = new System.Drawing.Point(153, 103);
            this.IntValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IntValue.MaxLength = 16;
            this.IntValue.Name = "IntValue";
            this.IntValue.PasswordChar = '\0';
            this.IntValue.PlaceholderForeColor = System.Drawing.Color.Black;
            this.IntValue.PlaceholderText = "";
            this.IntValue.ReadOnly = true;
            this.IntValue.SelectedText = "";
            this.IntValue.Size = new System.Drawing.Size(175, 24);
            this.IntValue.TabIndex = 72;
            // 
            // BitConverterButton
            // 
            this.BitConverterButton.BackColor = System.Drawing.Color.Transparent;
            this.BitConverterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.BitConverterButton.BorderRadius = 5;
            this.BitConverterButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BitConverterButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BitConverterButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BitConverterButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BitConverterButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(152)))));
            this.BitConverterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BitConverterButton.ForeColor = System.Drawing.Color.Black;
            this.BitConverterButton.Location = new System.Drawing.Point(122, 153);
            this.BitConverterButton.Name = "BitConverterButton";
            this.BitConverterButton.Size = new System.Drawing.Size(152, 40);
            this.BitConverterButton.TabIndex = 74;
            this.BitConverterButton.Text = "Convert";
            this.BitConverterButton.Click += new System.EventHandler(this.BitConverterButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(247)))), ((int)(((byte)(156)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(28, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(168, 22);
            this.textBox2.TabIndex = 72;
            this.textBox2.Text = "4 Byte Bit Converter";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2GradientPanel4
            // 
            this.guna2GradientPanel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel4.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel4.BorderRadius = 10;
            this.guna2GradientPanel4.BorderThickness = 2;
            this.guna2GradientPanel4.Controls.Add(this.textBox5);
            this.guna2GradientPanel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel4.Location = new System.Drawing.Point(840, 24);
            this.guna2GradientPanel4.Name = "guna2GradientPanel4";
            this.guna2GradientPanel4.Size = new System.Drawing.Size(388, 228);
            this.guna2GradientPanel4.TabIndex = 74;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(125, 96);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(133, 28);
            this.textBox5.TabIndex = 38;
            this.textBox5.Text = "Hello World!";
            // 
            // OutputPanel
            // 
            this.OutputPanel.BackColor = System.Drawing.Color.Transparent;
            this.OutputPanel.BorderColor = System.Drawing.Color.Transparent;
            this.OutputPanel.BorderRadius = 10;
            this.OutputPanel.BorderThickness = 2;
            this.OutputPanel.Controls.Add(this.guna2GradientPanel4);
            this.OutputPanel.Controls.Add(this.guna2GradientPanel3);
            this.OutputPanel.Controls.Add(this.guna2GradientPanel2);
            this.OutputPanel.Controls.Add(this.guna2GradientPanel1);
            this.OutputPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.OutputPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.OutputPanel.Location = new System.Drawing.Point(0, 0);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(1258, 743);
            this.OutputPanel.TabIndex = 70;
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.OutputPanel);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(1260, 745);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel3.ResumeLayout(false);
            this.guna2GradientPanel3.PerformLayout();
            this.guna2GradientPanel4.ResumeLayout(false);
            this.guna2GradientPanel4.PerformLayout();
            this.OutputPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.TextBox textBox12;
        private Guna.UI2.WinForms.Guna2Button GetHexButton;
        private Guna.UI2.WinForms.Guna2Button GetDeciButton;
        private Guna.UI2.WinForms.Guna2TextBox HexValue;
        private Guna.UI2.WinForms.Guna2TextBox DeciValue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ArbiLabel;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox6;
        private Guna.UI2.WinForms.Guna2TextBox SerialOutput;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private System.Windows.Forms.TextBox textBox2;
        private Guna.UI2.WinForms.Guna2Button BitConverterButton;
        private Guna.UI2.WinForms.Guna2TextBox IntValue;
        private Guna.UI2.WinForms.Guna2TextBox InputText;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel4;
        private System.Windows.Forms.TextBox textBox5;
        private Guna.UI2.WinForms.Guna2GradientPanel OutputPanel;
    }
}
