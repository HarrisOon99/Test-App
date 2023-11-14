namespace Test_App
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MidPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new Guna.UI2.WinForms.Guna2Button();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2Button();
            this.MaximizeButton = new Guna.UI2.WinForms.Guna2Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.JotBoxTab = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CANBusTab = new Guna.UI2.WinForms.Guna2Button();
            this.ModbusPLCTab = new Guna.UI2.WinForms.Guna2Button();
            this.HomeTab = new Guna.UI2.WinForms.Guna2Button();
            this.TopPanel.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MidPanel
            // 
            this.MidPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MidPanel.BackColor = System.Drawing.Color.Transparent;
            this.MidPanel.Location = new System.Drawing.Point(224, 55);
            this.MidPanel.Name = "MidPanel";
            this.MidPanel.Size = new System.Drawing.Size(1259, 745);
            this.MidPanel.TabIndex = 5;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitButton.FillColor = System.Drawing.Color.Transparent;
            this.ExitButton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.LightGray;
            this.ExitButton.Location = new System.Drawing.Point(1208, 9);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(40, 40);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.TabStop = false;
            this.ExitButton.Text = "x";
            this.ExitButton.TextOffset = new System.Drawing.Point(0, -4);
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MinimizeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MinimizeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MinimizeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MinimizeButton.FillColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.LightGray;
            this.MinimizeButton.Location = new System.Drawing.Point(1116, 9);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(40, 40);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Text = "v";
            this.MinimizeButton.TextOffset = new System.Drawing.Point(0, -4);
            this.MinimizeButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MaximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MaximizeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MaximizeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MaximizeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MaximizeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MaximizeButton.FillColor = System.Drawing.Color.Transparent;
            this.MaximizeButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeButton.ForeColor = System.Drawing.Color.LightGray;
            this.MaximizeButton.Location = new System.Drawing.Point(1162, 9);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(40, 40);
            this.MaximizeButton.TabIndex = 4;
            this.MaximizeButton.TabStop = false;
            this.MaximizeButton.Text = "O";
            this.MaximizeButton.Click += new System.EventHandler(this.MaxButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanel.Controls.Add(this.MaximizeButton);
            this.TopPanel.Controls.Add(this.MinimizeButton);
            this.TopPanel.Controls.Add(this.MainPanel);
            this.TopPanel.Controls.Add(this.ExitButton);
            this.TopPanel.Location = new System.Drawing.Point(224, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1259, 59);
            this.TopPanel.TabIndex = 5;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(223, 284);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1257, 635);
            this.MainPanel.TabIndex = 2;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.JotBoxTab);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.CANBusTab);
            this.guna2GradientPanel1.Controls.Add(this.ModbusPLCTab);
            this.guna2GradientPanel1.Controls.Add(this.HomeTab);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(18)))), ((int)(((byte)(153)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(49)))), ((int)(((byte)(170)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(223, 800);
            this.guna2GradientPanel1.TabIndex = 5;
            // 
            // JotBoxTab
            // 
            this.JotBoxTab.BackColor = System.Drawing.Color.Transparent;
            this.JotBoxTab.BorderColor = System.Drawing.Color.Transparent;
            this.JotBoxTab.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.JotBoxTab.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.JotBoxTab.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.JotBoxTab.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.JotBoxTab.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.JotBoxTab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.JotBoxTab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.JotBoxTab.FillColor = System.Drawing.Color.Transparent;
            this.JotBoxTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JotBoxTab.ForeColor = System.Drawing.Color.White;
            this.JotBoxTab.Location = new System.Drawing.Point(3, 327);
            this.JotBoxTab.Name = "JotBoxTab";
            this.JotBoxTab.Size = new System.Drawing.Size(252, 54);
            this.JotBoxTab.TabIndex = 10;
            this.JotBoxTab.TabStop = false;
            this.JotBoxTab.Text = "JOT BOX";
            this.JotBoxTab.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.JotBoxTab.Click += new System.EventHandler(this.JotBoxTab_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 59);
            this.label1.TabIndex = 6;
            this.label1.Text = "Harris\' Test App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CANBusTab
            // 
            this.CANBusTab.BackColor = System.Drawing.Color.Transparent;
            this.CANBusTab.BorderColor = System.Drawing.Color.Transparent;
            this.CANBusTab.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CANBusTab.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.CANBusTab.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.CANBusTab.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CANBusTab.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CANBusTab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CANBusTab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CANBusTab.FillColor = System.Drawing.Color.Transparent;
            this.CANBusTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANBusTab.ForeColor = System.Drawing.Color.White;
            this.CANBusTab.Location = new System.Drawing.Point(3, 267);
            this.CANBusTab.Name = "CANBusTab";
            this.CANBusTab.Size = new System.Drawing.Size(252, 54);
            this.CANBusTab.TabIndex = 9;
            this.CANBusTab.TabStop = false;
            this.CANBusTab.Text = "CAN BUS";
            this.CANBusTab.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CANBusTab.Click += new System.EventHandler(this.CANBusTab_Click);
            // 
            // ModbusPLCTab
            // 
            this.ModbusPLCTab.BackColor = System.Drawing.Color.Transparent;
            this.ModbusPLCTab.BorderColor = System.Drawing.Color.Transparent;
            this.ModbusPLCTab.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ModbusPLCTab.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.ModbusPLCTab.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ModbusPLCTab.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ModbusPLCTab.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ModbusPLCTab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ModbusPLCTab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ModbusPLCTab.FillColor = System.Drawing.Color.Transparent;
            this.ModbusPLCTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModbusPLCTab.ForeColor = System.Drawing.Color.White;
            this.ModbusPLCTab.Location = new System.Drawing.Point(3, 207);
            this.ModbusPLCTab.Name = "ModbusPLCTab";
            this.ModbusPLCTab.Size = new System.Drawing.Size(252, 54);
            this.ModbusPLCTab.TabIndex = 8;
            this.ModbusPLCTab.TabStop = false;
            this.ModbusPLCTab.Text = "Modbus PLC";
            this.ModbusPLCTab.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ModbusPLCTab.Click += new System.EventHandler(this.ModbusPLCTab_Click);
            // 
            // HomeTab
            // 
            this.HomeTab.BackColor = System.Drawing.Color.Transparent;
            this.HomeTab.BorderColor = System.Drawing.Color.Transparent;
            this.HomeTab.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.HomeTab.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.HomeTab.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.HomeTab.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HomeTab.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HomeTab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HomeTab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HomeTab.FillColor = System.Drawing.Color.Transparent;
            this.HomeTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTab.ForeColor = System.Drawing.Color.White;
            this.HomeTab.Location = new System.Drawing.Point(3, 147);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Size = new System.Drawing.Size(252, 54);
            this.HomeTab.TabIndex = 7;
            this.HomeTab.Text = "Home";
            this.HomeTab.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomeTab.Click += new System.EventHandler(this.HomeTab_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1483, 800);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.MidPanel);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopPanel.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MidPanel;
        private Guna.UI2.WinForms.Guna2Button MaximizeButton;
        private Guna.UI2.WinForms.Guna2Button ExitButton;
        private Guna.UI2.WinForms.Guna2Button MinimizeButton;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel MainPanel;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button JotBoxTab;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button CANBusTab;
        private Guna.UI2.WinForms.Guna2Button ModbusPLCTab;
        private Guna.UI2.WinForms.Guna2Button HomeTab;
    }
}

