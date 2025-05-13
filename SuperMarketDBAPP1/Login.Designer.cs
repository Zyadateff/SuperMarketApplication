namespace SuperMarketDBAPP1
{
    partial class Login
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            SuspendLayout();
            // 
            // CircleButton1
            // 
            CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CircleButton1.FillColor = Color.LightSeaGreen;
            CircleButton1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CircleButton1.ForeColor = Color.White;
            CircleButton1.Location = new Point(-283, -8);
            CircleButton1.Name = "CircleButton1";
            CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            CircleButton1.Size = new Size(618, 581);
            CircleButton1.TabIndex = 0;
            CircleButton1.Text = "                                         Supermarket System";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 560);
            Controls.Add(CircleButton1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton CircleButton1;
    }
}