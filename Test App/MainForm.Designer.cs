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
            this.SidePanel = new System.Windows.Forms.Panel();
            this.JotBoxTab = new Guna.UI2.WinForms.Guna2Button();
            this.CANBusTab = new Guna.UI2.WinForms.Guna2Button();
            this.ModbusPLCTab = new Guna.UI2.WinForms.Guna2Button();
            this.HomeTab = new Guna.UI2.WinForms.Guna2Button();
            this.MidPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MaximizeButton = new Guna.UI2.WinForms.Guna2Button();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.SidePanel.Controls.Add(this.JotBoxTab);
            this.SidePanel.Controls.Add(this.CANBusTab);
            this.SidePanel.Controls.Add(this.ModbusPLCTab);
            this.SidePanel.Controls.Add(this.HomeTab);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 49);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(224, 751);
            this.SidePanel.TabIndex = 1;
            // 
            // JotBoxTab
            // 
            this.JotBoxTab.BorderColor = System.Drawing.Color.Transparent;
            this.JotBoxTab.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.JotBoxTab.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(224)))), ((int)(((byte)(170)))));
            this.JotBoxTab.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.JotBoxTab.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.JotBoxTab.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.JotBoxTab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.JotBoxTab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.JotBoxTab.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.JotBoxTab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JotBoxTab.ForeColor = System.Drawing.Color.White;
            this.JotBoxTab.Location = new System.Drawing.Point(3, 259);
            this.JotBoxTab.Name = "JotBoxTab";
            this.JotBoxTab.Size = new System.Drawing.Size(252, 54);
            this.JotBoxTab.TabIndex = 5;
            this.JotBoxTab.TabStop = false;
            this.JotBoxTab.Text = "JOT BOX";
            this.JotBoxTab.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.JotBoxTab.Click += new System.EventHandler(this.JotBoxTab_Click);
            // 
            // CANBusTab
            // 
            this.CANBusTab.BorderColor = System.Drawing.Color.Transparent;
            this.CANBusTab.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CANBusTab.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(224)))), ((int)(((byte)(170)))));
            this.CANBusTab.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.CANBusTab.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CANBusTab.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CANBusTab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CANBusTab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CANBusTab.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.CANBusTab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANBusTab.ForeColor = System.Drawing.Color.White;
            this.CANBusTab.Location = new System.Drawing.Point(3, 199);
            this.CANBusTab.Name = "CANBusTab";
            this.CANBusTab.Size = new System.Drawing.Size(252, 54);
            this.CANBusTab.TabIndex = 4;
            this.CANBusTab.TabStop = false;
            this.CANBusTab.Text = "CAN BUS";
            this.CANBusTab.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CANBusTab.Click += new System.EventHandler(this.CANBusTab_Click);
            // 
            // ModbusPLCTab
            // 
            this.ModbusPLCTab.BorderColor = System.Drawing.Color.Transparent;
            this.ModbusPLCTab.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ModbusPLCTab.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(224)))), ((int)(((byte)(170)))));
            this.ModbusPLCTab.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ModbusPLCTab.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ModbusPLCTab.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ModbusPLCTab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ModbusPLCTab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ModbusPLCTab.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ModbusPLCTab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModbusPLCTab.ForeColor = System.Drawing.Color.White;
            this.ModbusPLCTab.Location = new System.Drawing.Point(3, 139);
            this.ModbusPLCTab.Name = "ModbusPLCTab";
            this.ModbusPLCTab.Size = new System.Drawing.Size(252, 54);
            this.ModbusPLCTab.TabIndex = 3;
            this.ModbusPLCTab.TabStop = false;
            this.ModbusPLCTab.Text = "Modbus PLC";
            this.ModbusPLCTab.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ModbusPLCTab.Click += new System.EventHandler(this.ModbusPLCTab_Click);
            // 
            // HomeTab
            // 
            this.HomeTab.BorderColor = System.Drawing.Color.Transparent;
            this.HomeTab.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.HomeTab.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(224)))), ((int)(((byte)(170)))));
            this.HomeTab.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.HomeTab.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HomeTab.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HomeTab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HomeTab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HomeTab.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.HomeTab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTab.ForeColor = System.Drawing.Color.White;
            this.HomeTab.Location = new System.Drawing.Point(3, 79);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Size = new System.Drawing.Size(252, 54);
            this.HomeTab.TabIndex = 2;
            this.HomeTab.Text = "Home";
            this.HomeTab.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomeTab.Click += new System.EventHandler(this.HomeTab_Click);
            // 
            // MidPanel
            // 
            this.MidPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.MidPanel.Location = new System.Drawing.Point(223, 49);
            this.MidPanel.Name = "MidPanel";
            this.MidPanel.Size = new System.Drawing.Size(1260, 751);
            this.MidPanel.TabIndex = 5;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.TopPanel.Controls.Add(this.MaximizeButton);
            this.TopPanel.Controls.Add(this.MinimizeButton);
            this.TopPanel.Controls.Add(this.MainPanel);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.ExitButton);
            this.TopPanel.Location = new System.Drawing.Point(0, -220);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1483, 269);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MaximizeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MaximizeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MaximizeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MaximizeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.MaximizeButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeButton.ForeColor = System.Drawing.Color.LightGray;
            this.MaximizeButton.Location = new System.Drawing.Point(1385, 226);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(40, 40);
            this.MaximizeButton.TabIndex = 4;
            this.MaximizeButton.TabStop = false;
            this.MaximizeButton.Text = "O";
            this.MaximizeButton.Click += new System.EventHandler(this.MaxButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MinimizeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MinimizeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MinimizeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MinimizeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.MinimizeButton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.LightGray;
            this.MinimizeButton.Location = new System.Drawing.Point(1339, 226);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(40, 40);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.TextOffset = new System.Drawing.Point(0, -4);
            this.MinimizeButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(223, 275);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1257, 644);
            this.MainPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(3, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "A not very useful Test App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitButton
            // 
            this.ExitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.ExitButton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.LightGray;
            this.ExitButton.Location = new System.Drawing.Point(1431, 226);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(40, 40);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.TabStop = false;
            this.ExitButton.Text = "x";
            this.ExitButton.TextOffset = new System.Drawing.Point(0, -4);
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.TopPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1483, 49);
            this.panel1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(1483, 800);
            this.Controls.Add(this.MidPanel);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.SidePanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SidePanel;
        private Guna.UI2.WinForms.Guna2Button HomeTab;
        private Guna.UI2.WinForms.Guna2Button ModbusPLCTab;
        private Guna.UI2.WinForms.Guna2Button CANBusTab;
        private System.Windows.Forms.Panel MidPanel;
        private System.Windows.Forms.Panel TopPanel;
        private Guna.UI2.WinForms.Guna2Button MaximizeButton;
        private Guna.UI2.WinForms.Guna2Button MinimizeButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button ExitButton;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button JotBoxTab;
    }
}

