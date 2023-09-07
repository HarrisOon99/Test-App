namespace Test_App.UserControls
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
            this.OutputPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.GetHexButton = new Guna.UI2.WinForms.Guna2Button();
            this.GetDeciButton = new Guna.UI2.WinForms.Guna2Button();
            this.HexValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.DeciValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ArbiLabel = new System.Windows.Forms.TextBox();
            this.OutputPanel.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputPanel
            // 
            this.OutputPanel.BorderColor = System.Drawing.Color.Transparent;
            this.OutputPanel.BorderRadius = 10;
            this.OutputPanel.BorderThickness = 2;
            this.OutputPanel.Controls.Add(this.guna2GradientPanel1);
            this.OutputPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.OutputPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.OutputPanel.Location = new System.Drawing.Point(18, 23);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(1217, 705);
            this.OutputPanel.TabIndex = 70;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
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
            this.guna2GradientPanel1.Size = new System.Drawing.Size(392, 281);
            this.guna2GradientPanel1.TabIndex = 71;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(178)))), ((int)(((byte)(122)))));
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(29, 26);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(336, 30);
            this.textBox12.TabIndex = 72;
            this.textBox12.Text = "Technically Useless Hex Converter";
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
            this.GetHexButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetHexButton.ForeColor = System.Drawing.Color.Black;
            this.GetHexButton.Location = new System.Drawing.Point(201, 202);
            this.GetHexButton.Name = "GetHexButton";
            this.GetHexButton.Size = new System.Drawing.Size(152, 40);
            this.GetHexButton.TabIndex = 74;
            this.GetHexButton.Text = "Get Hex";
            this.GetHexButton.Click += new System.EventHandler(this.GetHexButton_Click);
            this.GetHexButton.MouseLeave += new System.EventHandler(this.GetHexButton_MouseLeave);
            this.GetHexButton.MouseHover += new System.EventHandler(this.GetHexButton_MouseHover);
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
            this.GetDeciButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetDeciButton.ForeColor = System.Drawing.Color.Black;
            this.GetDeciButton.Location = new System.Drawing.Point(29, 202);
            this.GetDeciButton.Name = "GetDeciButton";
            this.GetDeciButton.Size = new System.Drawing.Size(152, 40);
            this.GetDeciButton.TabIndex = 72;
            this.GetDeciButton.Text = "Get Decimal";
            this.GetDeciButton.Click += new System.EventHandler(this.GetDeciButton_Click);
            this.GetDeciButton.MouseLeave += new System.EventHandler(this.GetDeciButton_MouseLeave);
            this.GetDeciButton.MouseHover += new System.EventHandler(this.GetDeciButton_MouseHover);
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
            this.HexValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexValue.ForeColor = System.Drawing.Color.Black;
            this.HexValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HexValue.Location = new System.Drawing.Point(178, 137);
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
            this.DeciValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeciValue.ForeColor = System.Drawing.Color.Black;
            this.DeciValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DeciValue.Location = new System.Drawing.Point(178, 89);
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(178)))), ((int)(((byte)(122)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(40, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(132, 26);
            this.textBox1.TabIndex = 37;
            this.textBox1.Text = "Decimal Value:";
            // 
            // ArbiLabel
            // 
            this.ArbiLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(178)))), ((int)(((byte)(122)))));
            this.ArbiLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ArbiLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArbiLabel.Location = new System.Drawing.Point(40, 135);
            this.ArbiLabel.Name = "ArbiLabel";
            this.ArbiLabel.ReadOnly = true;
            this.ArbiLabel.Size = new System.Drawing.Size(99, 26);
            this.ArbiLabel.TabIndex = 36;
            this.ArbiLabel.Text = "Hex value:";
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.Controls.Add(this.OutputPanel);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(1260, 745);
            this.OutputPanel.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel OutputPanel;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ArbiLabel;
        private Guna.UI2.WinForms.Guna2TextBox HexValue;
        private Guna.UI2.WinForms.Guna2TextBox DeciValue;
        private Guna.UI2.WinForms.Guna2Button GetHexButton;
        private Guna.UI2.WinForms.Guna2Button GetDeciButton;
        private System.Windows.Forms.TextBox textBox12;
    }
}
