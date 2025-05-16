
namespace SuperMarketDBAPP1
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            tabPage3 = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanelCartProducts = new FlowLayoutPanel();
            label31 = new Label();
            panel20 = new Panel();
            lblTotalPrice = new Label();
            label2 = new Label();
            flowLayoutPanelVouchers = new FlowLayoutPanel();
            button1 = new Button();
            label15 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel19 = new Panel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label13 = new Label();
            DeleteBtn = new Button();
            saveBtn = new Button();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            label14 = new Label();
            shoptab = new TabPage();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            flowLayoutPanelProducts = new FlowLayoutPanel();
            txtSerch = new TextBox();
            tabPage3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel20.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel19.SuspendLayout();
            shoptab.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(flowLayoutPanel1);
            tabPage3.Controls.Add(label31);
            tabPage3.Controls.Add(panel20);
            tabPage3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(5);
            tabPage3.Size = new Size(1002, 565);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Your Cart";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(flowLayoutPanelCartProducts);
            flowLayoutPanel1.Location = new Point(7, 52);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(763, 507);
            flowLayoutPanel1.TabIndex = 26;
            // 
            // flowLayoutPanelCartProducts
            // 
            flowLayoutPanelCartProducts.AutoScroll = true;
            flowLayoutPanelCartProducts.Location = new Point(2, 2);
            flowLayoutPanelCartProducts.Margin = new Padding(2);
            flowLayoutPanelCartProducts.Name = "flowLayoutPanelCartProducts";
            flowLayoutPanelCartProducts.Size = new Size(763, 507);
            flowLayoutPanelCartProducts.TabIndex = 27;
            flowLayoutPanelCartProducts.Paint += flowLayoutPanelCartProducts_Paint;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(316, 8);
            label31.Name = "label31";
            label31.Size = new Size(171, 40);
            label31.TabIndex = 25;
            label31.Text = "Your Cart";
            // 
            // panel20
            // 
            panel20.BackColor = SystemColors.Control;
            panel20.Controls.Add(lblTotalPrice);
            panel20.Controls.Add(label2);
            panel20.Controls.Add(flowLayoutPanelVouchers);
            panel20.Controls.Add(button1);
            panel20.Controls.Add(label15);
            panel20.Location = new Point(776, 6);
            panel20.Name = "panel20";
            panel20.Size = new Size(220, 553);
            panel20.TabIndex = 0;
            panel20.Paint += panel20_Paint;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(74, 463);
            lblTotalPrice.Margin = new Padding(2, 0, 2, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(70, 23);
            lblTotalPrice.TabIndex = 28;
            lblTotalPrice.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            label2.Location = new Point(47, 450);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 27;
            // 
            // flowLayoutPanelVouchers
            // 
            flowLayoutPanelVouchers.Location = new Point(2, 48);
            flowLayoutPanelVouchers.Margin = new Padding(2);
            flowLayoutPanelVouchers.Name = "flowLayoutPanelVouchers";
            flowLayoutPanelVouchers.Size = new Size(222, 399);
            flowLayoutPanelVouchers.TabIndex = 26;
            // 
            // button1
            // 
            button1.Location = new Point(20, 489);
            button1.Name = "button1";
            button1.Size = new Size(183, 51);
            button1.TabIndex = 25;
            button1.Text = "Buy";
            button1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(35, 5);
            label15.Name = "label15";
            label15.Size = new Size(154, 37);
            label15.TabIndex = 0;
            label15.Text = "Vouchers";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(shoptab);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1010, 598);
            tabControl1.TabIndex = 0;
            tabControl1.Tag = "";
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel19);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(5);
            tabPage1.Size = new Size(1002, 565);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Profile Page";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // panel19
            // 
            panel19.BackColor = Color.LightSeaGreen;
            panel19.Controls.Add(label12);
            panel19.Controls.Add(label11);
            panel19.Controls.Add(label10);
            panel19.Controls.Add(label9);
            panel19.Controls.Add(label13);
            panel19.Controls.Add(DeleteBtn);
            panel19.Controls.Add(saveBtn);
            panel19.Controls.Add(txtPhone);
            panel19.Controls.Add(txtAddress);
            panel19.Controls.Add(txtPassword);
            panel19.Controls.Add(txtEmail);
            panel19.Controls.Add(txtName);
            panel19.Controls.Add(label14);
            panel19.Dock = DockStyle.Fill;
            panel19.Location = new Point(5, 5);
            panel19.Name = "panel19";
            panel19.Size = new Size(992, 555);
            panel19.TabIndex = 0;
            panel19.Paint += panel19_Paint;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(274, 408);
            label12.Name = "label12";
            label12.Size = new Size(71, 23);
            label12.TabIndex = 19;
            label12.Text = "Phone";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(274, 335);
            label11.Name = "label11";
            label11.Size = new Size(88, 23);
            label11.TabIndex = 19;
            label11.Text = "Address";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(274, 261);
            label10.Name = "label10";
            label10.Size = new Size(100, 23);
            label10.TabIndex = 19;
            label10.Text = "Password";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(272, 185);
            label9.Name = "label9";
            label9.Size = new Size(70, 23);
            label9.TabIndex = 19;
            label9.Text = "E-mail";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(270, 112);
            label13.Name = "label13";
            label13.Size = new Size(70, 23);
            label13.TabIndex = 19;
            label13.Text = "Name";
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.LightSeaGreen;
            DeleteBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.ForeColor = SystemColors.Control;
            DeleteBtn.Location = new Point(568, 479);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(94, 33);
            DeleteBtn.TabIndex = 14;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += saveBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.LightSeaGreen;
            saveBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = SystemColors.Control;
            saveBtn.Location = new Point(351, 479);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 33);
            saveBtn.TabIndex = 14;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 14F);
            txtPhone.Location = new Point(272, 434);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(452, 39);
            txtPhone.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 14F);
            txtAddress.Location = new Point(272, 359);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(452, 39);
            txtAddress.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14F);
            txtPassword.Location = new Point(272, 284);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(452, 39);
            txtPassword.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(272, 211);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(452, 39);
            txtEmail.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 14F);
            txtName.Location = new Point(270, 138);
            txtName.Name = "txtName";
            txtName.Size = new Size(454, 39);
            txtName.TabIndex = 9;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(351, 19);
            label14.Name = "label14";
            label14.Size = new Size(311, 59);
            label14.TabIndex = 8;
            label14.Text = "Profile Page";
            // 
            // shoptab
            // 
            shoptab.Controls.Add(btnSearch);
            shoptab.Controls.Add(txtSearch);
            shoptab.Controls.Add(label1);
            shoptab.Controls.Add(flowLayoutPanelProducts);
            shoptab.Location = new Point(4, 29);
            shoptab.Margin = new Padding(2);
            shoptab.Name = "shoptab";
            shoptab.Padding = new Padding(2);
            shoptab.Size = new Size(1002, 565);
            shoptab.TabIndex = 3;
            shoptab.Text = "Shop";
            shoptab.UseVisualStyleBackColor = true;
            shoptab.Click += shoptab_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(833, 19);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(64, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button2_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(627, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 32);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(324, 40);
            label1.TabIndex = 2;
            label1.Text = "Products Available";
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.AutoScroll = true;
            flowLayoutPanelProducts.Location = new Point(13, 53);
            flowLayoutPanelProducts.Margin = new Padding(2);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Size = new Size(987, 512);
            flowLayoutPanelProducts.TabIndex = 0;
            flowLayoutPanelProducts.TabIndexChanged += flowLayoutPanelProducts_TabIndexChanged;
            flowLayoutPanelProducts.Paint += flowLayoutPanel1_Paint;
            flowLayoutPanelProducts.Enter += flowLayoutPanelProducts_Enter;
            // 
            // txtSerch
            // 
            txtSerch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSerch.Location = new Point(622, 17);
            txtSerch.Name = "txtSerch";
            txtSerch.Size = new Size(220, 32);
            txtSerch.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1034, 622);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            shoptab.ResumeLayout(false);
            shoptab.PerformLayout();
            ResumeLayout(false);
        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TabPage tabPage3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel19;
        private Button button1;
        private Panel panel20;
        private Label label15;
        private Label label13;
        private Button saveBtn;
        private TextBox txtName;
        private Label label14;
        private Label label31;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TabPage shoptab;
        private FlowLayoutPanel flowLayoutPanelProducts;
        private Button DeleteBtn;
        private Label label1;
        private TextBox txtSerch;
        private TextBox txtSearch;
        private Button btnSearch;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanelCartProducts;
        private FlowLayoutPanel flowLayoutPanelVouchers;
        private Label label2;
        private Label lblTotalPrice;
    }
}