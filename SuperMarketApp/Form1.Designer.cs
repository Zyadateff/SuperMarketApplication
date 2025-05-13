namespace SuperMarketApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtName = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label3 = new Label();
            btnlogin = new Button();
            btnSignup = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 206);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(365, 206);
            txtName.Name = "txtName";
            txtName.Size = new Size(278, 31);
            txtName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(365, 266);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(278, 31);
            txtPassword.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 269);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Customer" });
            comboBox1.Location = new Point(365, 143);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(278, 33);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "Select Role";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(421, 485);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(3, 2);
            guna2HtmlLabel1.TabIndex = 7;
            guna2HtmlLabel1.Text = null;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 485);
            label3.Name = "label3";
            label3.Size = new Size(202, 25);
            label3.TabIndex = 8;
            label3.Text = "Don't have an account ?";
            label3.Click += label3_Click;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(413, 340);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(157, 54);
            btnlogin.TabIndex = 0;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += button1_Click;
            // 
            // btnSignup
            // 
            btnSignup.Location = new Point(541, 470);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(153, 55);
            btnSignup.TabIndex = 9;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 73);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 10;
            label4.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 582);
            Controls.Add(label4);
            Controls.Add(btnSignup);
            Controls.Add(label3);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(comboBox1);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(btnlogin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtName;
        private TextBox txtPassword;
        private Label label2;
        private ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label label3;
        private Button btnlogin;
        private Button btnSignup;
        private Label label4;
    }
}
