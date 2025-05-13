namespace SuperMarketApp
{
    partial class ProductAdmin
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
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnX = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(181, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(1126, 670);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = Color.LightSeaGreen;
            button1.Location = new Point(23, 117);
            button1.Name = "button1";
            button1.Size = new Size(138, 55);
            button1.TabIndex = 1;
            button1.Text = "Supplier";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F);
            button2.ForeColor = Color.LightSeaGreen;
            button2.Location = new Point(23, 178);
            button2.Name = "button2";
            button2.Size = new Size(138, 55);
            button2.TabIndex = 2;
            button2.Text = "Category";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14F);
            button3.ForeColor = Color.LightSeaGreen;
            button3.Location = new Point(23, 248);
            button3.Name = "button3";
            button3.Size = new Size(138, 55);
            button3.TabIndex = 3;
            button3.Text = "Orders";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnX
            // 
            btnX.FlatAppearance.BorderSize = 0;
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.Font = new Font("Segoe UI", 14F);
            btnX.ForeColor = Color.LightSeaGreen;
            btnX.Location = new Point(1255, -5);
            btnX.Name = "btnX";
            btnX.Size = new Size(52, 49);
            btnX.TabIndex = 4;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = true;
            btnX.Click += btnX_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(412, 19);
            label1.Name = "label1";
            label1.Size = new Size(233, 38);
            label1.TabIndex = 3;
            label1.Text = "Manage Products";
            // 
            // ProductAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 718);
            Controls.Add(btnX);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnX;
        private Label label1;
    }
}