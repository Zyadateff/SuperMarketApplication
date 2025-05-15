namespace SuperMarketDBAPP1
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnSave = new Button();
            textBox5Address = new TextBox();
            textBox4Phone = new TextBox();
            textBox3Pass = new TextBox();
            textBox2Email = new TextBox();
            textBoxName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageProducts = new TabPage();
            btnProductPerCustomer = new Button();
            btnNotBought = new Button();
            btnMostBought = new Button();
            btnShowAllProducts = new Button();
            btnShowLowStock = new Button();
            btnReset = new Button();
            label29 = new Label();
            txtPID = new TextBox();
            txtPSearch = new TextBox();
            btnSearchProduct = new Button();
            btnRestock = new Button();
            btnDeleteProduct = new Button();
            btnEditProduct = new Button();
            btnAddProduct = new Button();
            txtPsupplier = new TextBox();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            txtPcategory = new TextBox();
            txtPminThres = new TextBox();
            txtPquantity = new TextBox();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            txtPprice = new TextBox();
            txtPdesc = new TextBox();
            txtPname = new TextBox();
            dgvProducts = new DataGridView();
            tabPage3 = new TabPage();
            label30 = new Label();
            dataGridViewOrders = new DataGridView();
            tabPagefreqCustomers = new TabPage();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            txtAmount = new TextBox();
            label8 = new Label();
            txtCode = new TextBox();
            label7 = new Label();
            txtCID = new TextBox();
            btnAddVoucher = new Button();
            dgvFreqCustomers = new DataGridView();
            tabPage4 = new TabPage();
            button1 = new Button();
            btnResetCutomers = new Button();
            btnInactive = new Button();
            txtCIDDel = new TextBox();
            label21 = new Label();
            txtCName = new TextBox();
            label20 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label16 = new Label();
            label18 = new Label();
            txtVAmount = new TextBox();
            label19 = new Label();
            txtVCode = new TextBox();
            btnAddV = new Button();
            btnViewFreqCustomers = new Button();
            btnAdd = new Button();
            dgvCustomers = new DataGridView();
            txtCAddress = new TextBox();
            label17 = new Label();
            txtCPhone = new TextBox();
            label15 = new Label();
            txtCPass = new TextBox();
            label14 = new Label();
            txtCEmail = new TextBox();
            label13 = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            txtCustomerID = new TextBox();
            label12 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            tabPagefreqCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFreqCustomers).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPageProducts);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPagefreqCustomers);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, -3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1258, 714);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightSeaGreen;
            tabPage1.Controls.Add(btnSave);
            tabPage1.Controls.Add(textBox5Address);
            tabPage1.Controls.Add(textBox4Phone);
            tabPage1.Controls.Add(textBox3Pass);
            tabPage1.Controls.Add(textBox2Email);
            tabPage1.Controls.Add(textBoxName);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.ForeColor = Color.LightSlateGray;
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1250, 678);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Customer";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSeaGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(631, 425);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 44);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // textBox5Address
            // 
            textBox5Address.Location = new Point(548, 357);
            textBox5Address.Name = "textBox5Address";
            textBox5Address.Size = new Size(302, 32);
            textBox5Address.TabIndex = 11;
            // 
            // textBox4Phone
            // 
            textBox4Phone.Location = new Point(548, 310);
            textBox4Phone.Name = "textBox4Phone";
            textBox4Phone.Size = new Size(302, 32);
            textBox4Phone.TabIndex = 10;
            // 
            // textBox3Pass
            // 
            textBox3Pass.Location = new Point(548, 266);
            textBox3Pass.Name = "textBox3Pass";
            textBox3Pass.Size = new Size(302, 32);
            textBox3Pass.TabIndex = 9;
            // 
            // textBox2Email
            // 
            textBox2Email.Location = new Point(548, 218);
            textBox2Email.Name = "textBox2Email";
            textBox2Email.Size = new Size(302, 32);
            textBox2Email.TabIndex = 8;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(548, 169);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(302, 32);
            textBoxName.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(410, 357);
            label6.Name = "label6";
            label6.Size = new Size(88, 23);
            label6.TabIndex = 5;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(410, 310);
            label5.Name = "label5";
            label5.Size = new Size(72, 23);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(410, 266);
            label4.Name = "label4";
            label4.Size = new Size(103, 23);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(410, 218);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(410, 172);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(448, 76);
            label1.Name = "label1";
            label1.Size = new Size(301, 33);
            label1.TabIndex = 0;
            label1.Text = "Add a New Customer";
            // 
            // tabPageProducts
            // 
            tabPageProducts.BackColor = Color.LightSeaGreen;
            tabPageProducts.Controls.Add(btnProductPerCustomer);
            tabPageProducts.Controls.Add(btnNotBought);
            tabPageProducts.Controls.Add(btnMostBought);
            tabPageProducts.Controls.Add(btnShowAllProducts);
            tabPageProducts.Controls.Add(btnShowLowStock);
            tabPageProducts.Controls.Add(btnReset);
            tabPageProducts.Controls.Add(label29);
            tabPageProducts.Controls.Add(txtPID);
            tabPageProducts.Controls.Add(txtPSearch);
            tabPageProducts.Controls.Add(btnSearchProduct);
            tabPageProducts.Controls.Add(btnRestock);
            tabPageProducts.Controls.Add(btnDeleteProduct);
            tabPageProducts.Controls.Add(btnEditProduct);
            tabPageProducts.Controls.Add(btnAddProduct);
            tabPageProducts.Controls.Add(txtPsupplier);
            tabPageProducts.Controls.Add(label26);
            tabPageProducts.Controls.Add(label27);
            tabPageProducts.Controls.Add(label28);
            tabPageProducts.Controls.Add(txtPcategory);
            tabPageProducts.Controls.Add(txtPminThres);
            tabPageProducts.Controls.Add(txtPquantity);
            tabPageProducts.Controls.Add(label25);
            tabPageProducts.Controls.Add(label24);
            tabPageProducts.Controls.Add(label23);
            tabPageProducts.Controls.Add(label22);
            tabPageProducts.Controls.Add(txtPprice);
            tabPageProducts.Controls.Add(txtPdesc);
            tabPageProducts.Controls.Add(txtPname);
            tabPageProducts.Controls.Add(dgvProducts);
            tabPageProducts.Location = new Point(4, 29);
            tabPageProducts.Name = "tabPageProducts";
            tabPageProducts.Padding = new Padding(3);
            tabPageProducts.Size = new Size(1250, 681);
            tabPageProducts.TabIndex = 1;
            tabPageProducts.Text = "Products";
            // 
            // btnProductPerCustomer
            // 
            btnProductPerCustomer.BackColor = Color.LightSeaGreen;
            btnProductPerCustomer.CausesValidation = false;
            btnProductPerCustomer.ForeColor = Color.White;
            btnProductPerCustomer.Location = new Point(633, 535);
            btnProductPerCustomer.Name = "btnProductPerCustomer";
            btnProductPerCustomer.Size = new Size(290, 46);
            btnProductPerCustomer.TabIndex = 28;
            btnProductPerCustomer.Text = "Products Per Customer";
            btnProductPerCustomer.UseVisualStyleBackColor = false;
            btnProductPerCustomer.Click += btnProductPerCustomer_Click;
            // 
            // btnNotBought
            // 
            btnNotBought.BackColor = Color.LightSeaGreen;
            btnNotBought.CausesValidation = false;
            btnNotBought.ForeColor = Color.White;
            btnNotBought.Location = new Point(929, 535);
            btnNotBought.Name = "btnNotBought";
            btnNotBought.Size = new Size(290, 46);
            btnNotBought.TabIndex = 27;
            btnNotBought.Text = "Not Bought This Month";
            btnNotBought.UseVisualStyleBackColor = false;
            btnNotBought.Click += btnNotBought_Click;
            // 
            // btnMostBought
            // 
            btnMostBought.BackColor = Color.LightSeaGreen;
            btnMostBought.CausesValidation = false;
            btnMostBought.ForeColor = Color.White;
            btnMostBought.Location = new Point(811, 466);
            btnMostBought.Name = "btnMostBought";
            btnMostBought.Size = new Size(201, 46);
            btnMostBought.TabIndex = 26;
            btnMostBought.Text = "Most Bought";
            btnMostBought.UseVisualStyleBackColor = false;
            btnMostBought.Click += btnMostBought_Click;
            // 
            // btnShowAllProducts
            // 
            btnShowAllProducts.BackColor = Color.LightSeaGreen;
            btnShowAllProducts.CausesValidation = false;
            btnShowAllProducts.ForeColor = Color.White;
            btnShowAllProducts.Location = new Point(633, 587);
            btnShowAllProducts.Name = "btnShowAllProducts";
            btnShowAllProducts.Size = new Size(290, 46);
            btnShowAllProducts.TabIndex = 25;
            btnShowAllProducts.Text = "Show All Products";
            btnShowAllProducts.UseVisualStyleBackColor = false;
            btnShowAllProducts.Click += btnShowAllProducts_Click;
            // 
            // btnShowLowStock
            // 
            btnShowLowStock.BackColor = Color.LightSeaGreen;
            btnShowLowStock.CausesValidation = false;
            btnShowLowStock.ForeColor = Color.White;
            btnShowLowStock.Location = new Point(929, 587);
            btnShowLowStock.Name = "btnShowLowStock";
            btnShowLowStock.Size = new Size(290, 46);
            btnShowLowStock.TabIndex = 24;
            btnShowLowStock.Text = "Low Stock Products";
            btnShowLowStock.UseVisualStyleBackColor = false;
            btnShowLowStock.Click += btnShowLowStock_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.LightSeaGreen;
            btnReset.CausesValidation = false;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(1138, 337);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(97, 38);
            btnReset.TabIndex = 23;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.ForeColor = Color.White;
            label29.Location = new Point(10, 603);
            label29.Name = "label29";
            label29.Size = new Size(113, 23);
            label29.TabIndex = 22;
            label29.Text = "Product ID";
            // 
            // txtPID
            // 
            txtPID.Location = new Point(200, 596);
            txtPID.Name = "txtPID";
            txtPID.Size = new Size(235, 32);
            txtPID.TabIndex = 21;
            // 
            // txtPSearch
            // 
            txtPSearch.Location = new Point(919, 287);
            txtPSearch.Name = "txtPSearch";
            txtPSearch.Size = new Size(310, 32);
            txtPSearch.TabIndex = 20;
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.BackColor = Color.LightSeaGreen;
            btnSearchProduct.CausesValidation = false;
            btnSearchProduct.ForeColor = Color.White;
            btnSearchProduct.Location = new Point(790, 286);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(123, 38);
            btnSearchProduct.TabIndex = 19;
            btnSearchProduct.Text = "Search";
            btnSearchProduct.UseVisualStyleBackColor = false;
            btnSearchProduct.Click += btnSearchProduct_Click;
            // 
            // btnRestock
            // 
            btnRestock.BackColor = Color.LightSeaGreen;
            btnRestock.CausesValidation = false;
            btnRestock.ForeColor = Color.White;
            btnRestock.Location = new Point(461, 535);
            btnRestock.Name = "btnRestock";
            btnRestock.Size = new Size(128, 46);
            btnRestock.TabIndex = 18;
            btnRestock.Text = "Restock";
            btnRestock.UseVisualStyleBackColor = false;
            btnRestock.Click += btnRestock_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.LightSeaGreen;
            btnDeleteProduct.CausesValidation = false;
            btnDeleteProduct.ForeColor = Color.White;
            btnDeleteProduct.Location = new Point(461, 587);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(128, 46);
            btnDeleteProduct.TabIndex = 17;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.BackColor = Color.LightSeaGreen;
            btnEditProduct.CausesValidation = false;
            btnEditProduct.ForeColor = Color.White;
            btnEditProduct.Location = new Point(461, 343);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(128, 46);
            btnEditProduct.TabIndex = 16;
            btnEditProduct.Text = "Edit";
            btnEditProduct.UseVisualStyleBackColor = false;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.LightSeaGreen;
            btnAddProduct.CausesValidation = false;
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(461, 291);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(128, 46);
            btnAddProduct.TabIndex = 15;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // txtPsupplier
            // 
            txtPsupplier.Location = new Point(200, 508);
            txtPsupplier.Name = "txtPsupplier";
            txtPsupplier.Size = new Size(235, 32);
            txtPsupplier.TabIndex = 14;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.ForeColor = Color.White;
            label26.Location = new Point(8, 511);
            label26.Name = "label26";
            label26.Size = new Size(113, 23);
            label26.TabIndex = 13;
            label26.Text = "Supplier ID";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.ForeColor = Color.White;
            label27.Location = new Point(8, 466);
            label27.Name = "label27";
            label27.Size = new Size(129, 23);
            label27.TabIndex = 12;
            label27.Text = "Category ID";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.ForeColor = Color.White;
            label28.Location = new Point(8, 423);
            label28.Name = "label28";
            label28.Size = new Size(139, 23);
            label28.TabIndex = 11;
            label28.Text = "Min Threshold";
            // 
            // txtPcategory
            // 
            txtPcategory.Location = new Point(200, 463);
            txtPcategory.Name = "txtPcategory";
            txtPcategory.Size = new Size(235, 32);
            txtPcategory.TabIndex = 10;
            // 
            // txtPminThres
            // 
            txtPminThres.Location = new Point(200, 420);
            txtPminThres.Name = "txtPminThres";
            txtPminThres.Size = new Size(235, 32);
            txtPminThres.TabIndex = 9;
            // 
            // txtPquantity
            // 
            txtPquantity.Location = new Point(200, 551);
            txtPquantity.Name = "txtPquantity";
            txtPquantity.Size = new Size(235, 32);
            txtPquantity.TabIndex = 8;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.ForeColor = Color.White;
            label25.Location = new Point(8, 555);
            label25.Name = "label25";
            label25.Size = new Size(93, 23);
            label25.TabIndex = 7;
            label25.Text = "Quantity";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.ForeColor = Color.White;
            label24.Location = new Point(8, 380);
            label24.Name = "label24";
            label24.Size = new Size(57, 23);
            label24.TabIndex = 6;
            label24.Text = "Price";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = Color.White;
            label23.Location = new Point(8, 337);
            label23.Name = "label23";
            label23.Size = new Size(117, 23);
            label23.TabIndex = 5;
            label23.Text = "Description";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.White;
            label22.Location = new Point(8, 294);
            label22.Name = "label22";
            label22.Size = new Size(154, 23);
            label22.TabIndex = 4;
            label22.Text = "Product Name";
            // 
            // txtPprice
            // 
            txtPprice.Location = new Point(200, 377);
            txtPprice.Name = "txtPprice";
            txtPprice.Size = new Size(235, 32);
            txtPprice.TabIndex = 3;
            // 
            // txtPdesc
            // 
            txtPdesc.Location = new Point(200, 334);
            txtPdesc.Name = "txtPdesc";
            txtPdesc.Size = new Size(235, 32);
            txtPdesc.TabIndex = 2;
            // 
            // txtPname
            // 
            txtPname.Location = new Point(200, 291);
            txtPname.Name = "txtPname";
            txtPname.Size = new Size(235, 32);
            txtPname.TabIndex = 1;
            // 
            // dgvProducts
            // 
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(1, 2);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(1234, 264);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.LightSeaGreen;
            tabPage3.Controls.Add(label30);
            tabPage3.Controls.Add(dataGridViewOrders);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1250, 681);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Orders";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Century Gothic", 20F);
            label30.ForeColor = Color.White;
            label30.Location = new Point(461, 26);
            label30.Name = "label30";
            label30.Size = new Size(219, 40);
            label30.TabIndex = 1;
            label30.Text = "Track Orders";
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.BackgroundColor = Color.White;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(51, 105);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 62;
            dataGridViewOrders.Size = new Size(1142, 533);
            dataGridViewOrders.TabIndex = 0;
            // 
            // tabPagefreqCustomers
            // 
            tabPagefreqCustomers.BackColor = Color.White;
            tabPagefreqCustomers.Controls.Add(label11);
            tabPagefreqCustomers.Controls.Add(dateTimePicker1);
            tabPagefreqCustomers.Controls.Add(label10);
            tabPagefreqCustomers.Controls.Add(label9);
            tabPagefreqCustomers.Controls.Add(txtAmount);
            tabPagefreqCustomers.Controls.Add(label8);
            tabPagefreqCustomers.Controls.Add(txtCode);
            tabPagefreqCustomers.Controls.Add(label7);
            tabPagefreqCustomers.Controls.Add(txtCID);
            tabPagefreqCustomers.Controls.Add(btnAddVoucher);
            tabPagefreqCustomers.Controls.Add(dgvFreqCustomers);
            tabPagefreqCustomers.ForeColor = Color.Cornsilk;
            tabPagefreqCustomers.Location = new Point(4, 29);
            tabPagefreqCustomers.Name = "tabPagefreqCustomers";
            tabPagefreqCustomers.Padding = new Padding(3);
            tabPagefreqCustomers.Size = new Size(1250, 681);
            tabPagefreqCustomers.TabIndex = 3;
            tabPagefreqCustomers.Text = "Frequent Customers";
            tabPagefreqCustomers.Click += tabPagefreqCustomers_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.LightSeaGreen;
            label11.Location = new Point(92, 31);
            label11.Name = "label11";
            label11.Size = new Size(163, 23);
            label11.TabIndex = 11;
            label11.Text = "Add a Voucher";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(186, 210);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(261, 32);
            dateTimePicker1.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.LightSeaGreen;
            label10.Location = new Point(3, 210);
            label10.Name = "label10";
            label10.Size = new Size(120, 23);
            label10.TabIndex = 9;
            label10.Text = "Expiry Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.LightSeaGreen;
            label9.Location = new Point(3, 167);
            label9.Name = "label9";
            label9.Size = new Size(88, 23);
            label9.TabIndex = 7;
            label9.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(186, 167);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(261, 32);
            txtAmount.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.LightSeaGreen;
            label8.Location = new Point(3, 124);
            label8.Name = "label8";
            label8.Size = new Size(156, 23);
            label8.TabIndex = 5;
            label8.Text = "Voucher Code";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(186, 124);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(261, 32);
            txtCode.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.LightSeaGreen;
            label7.Location = new Point(3, 81);
            label7.Name = "label7";
            label7.Size = new Size(130, 23);
            label7.TabIndex = 3;
            label7.Text = "Customer ID";
            // 
            // txtCID
            // 
            txtCID.Location = new Point(186, 74);
            txtCID.Name = "txtCID";
            txtCID.Size = new Size(261, 32);
            txtCID.TabIndex = 2;
            // 
            // btnAddVoucher
            // 
            btnAddVoucher.BackColor = Color.LightSeaGreen;
            btnAddVoucher.FlatAppearance.BorderSize = 0;
            btnAddVoucher.FlatStyle = FlatStyle.Flat;
            btnAddVoucher.ForeColor = Color.White;
            btnAddVoucher.Location = new Point(82, 273);
            btnAddVoucher.Name = "btnAddVoucher";
            btnAddVoucher.Size = new Size(193, 57);
            btnAddVoucher.TabIndex = 1;
            btnAddVoucher.Text = "Add Voucher";
            btnAddVoucher.UseVisualStyleBackColor = false;
            btnAddVoucher.Click += btnAddVoucher_Click;
            // 
            // dgvFreqCustomers
            // 
            dgvFreqCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFreqCustomers.Location = new Point(453, 31);
            dgvFreqCustomers.Name = "dgvFreqCustomers";
            dgvFreqCustomers.RowHeadersWidth = 62;
            dgvFreqCustomers.Size = new Size(797, 494);
            dgvFreqCustomers.TabIndex = 0;
            dgvFreqCustomers.CellContentClick += dgvFreqCustomers_CellContentClick;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.LightSeaGreen;
            tabPage4.Controls.Add(button1);
            tabPage4.Controls.Add(btnResetCutomers);
            tabPage4.Controls.Add(btnInactive);
            tabPage4.Controls.Add(txtCIDDel);
            tabPage4.Controls.Add(label21);
            tabPage4.Controls.Add(txtCName);
            tabPage4.Controls.Add(label20);
            tabPage4.Controls.Add(dateTimePicker2);
            tabPage4.Controls.Add(label16);
            tabPage4.Controls.Add(label18);
            tabPage4.Controls.Add(txtVAmount);
            tabPage4.Controls.Add(label19);
            tabPage4.Controls.Add(txtVCode);
            tabPage4.Controls.Add(btnAddV);
            tabPage4.Controls.Add(btnViewFreqCustomers);
            tabPage4.Controls.Add(btnAdd);
            tabPage4.Controls.Add(dgvCustomers);
            tabPage4.Controls.Add(txtCAddress);
            tabPage4.Controls.Add(label17);
            tabPage4.Controls.Add(txtCPhone);
            tabPage4.Controls.Add(label15);
            tabPage4.Controls.Add(txtCPass);
            tabPage4.Controls.Add(label14);
            tabPage4.Controls.Add(txtCEmail);
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(btnDelete);
            tabPage4.Controls.Add(btnEdit);
            tabPage4.Controls.Add(txtCustomerID);
            tabPage4.Controls.Add(label12);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1250, 681);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "Customers";
            tabPage4.Click += tabPage4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(481, 535);
            button1.Name = "button1";
            button1.Size = new Size(288, 43);
            button1.TabIndex = 30;
            button1.Text = "Top Selling Category";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnResetCutomers
            // 
            btnResetCutomers.BackColor = Color.LightSeaGreen;
            btnResetCutomers.CausesValidation = false;
            btnResetCutomers.ForeColor = Color.White;
            btnResetCutomers.Location = new Point(431, 331);
            btnResetCutomers.Name = "btnResetCutomers";
            btnResetCutomers.Size = new Size(97, 43);
            btnResetCutomers.TabIndex = 29;
            btnResetCutomers.Text = "Reset";
            btnResetCutomers.UseVisualStyleBackColor = false;
            btnResetCutomers.Click += btnResetCutomers_Click;
            // 
            // btnInactive
            // 
            btnInactive.BackColor = Color.LightSeaGreen;
            btnInactive.FlatStyle = FlatStyle.Flat;
            btnInactive.ForeColor = Color.White;
            btnInactive.Location = new Point(481, 596);
            btnInactive.Name = "btnInactive";
            btnInactive.Size = new Size(288, 43);
            btnInactive.TabIndex = 28;
            btnInactive.Text = "Inactive Over a Year";
            btnInactive.UseVisualStyleBackColor = false;
            btnInactive.Click += btnInactive_Click;
            // 
            // txtCIDDel
            // 
            txtCIDDel.Location = new Point(972, 330);
            txtCIDDel.Name = "txtCIDDel";
            txtCIDDel.Size = new Size(270, 32);
            txtCIDDel.TabIndex = 27;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = Color.White;
            label21.Location = new Point(781, 337);
            label21.Name = "label21";
            label21.Size = new Size(130, 23);
            label21.TabIndex = 26;
            label21.Text = "Customer ID";
            // 
            // txtCName
            // 
            txtCName.Location = new Point(972, 383);
            txtCName.Name = "txtCName";
            txtCName.Size = new Size(270, 32);
            txtCName.TabIndex = 25;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.White;
            label20.Location = new Point(781, 383);
            label20.Name = "label20";
            label20.Size = new Size(71, 23);
            label20.TabIndex = 24;
            label20.Text = "Name";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(199, 536);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(270, 32);
            dateTimePicker2.TabIndex = 23;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.White;
            label16.Location = new Point(8, 551);
            label16.Name = "label16";
            label16.Size = new Size(120, 23);
            label16.TabIndex = 22;
            label16.Text = "Expiry Date";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.White;
            label18.Location = new Point(8, 504);
            label18.Name = "label18";
            label18.Size = new Size(88, 23);
            label18.TabIndex = 21;
            label18.Text = "Amount";
            // 
            // txtVAmount
            // 
            txtVAmount.Location = new Point(199, 493);
            txtVAmount.Name = "txtVAmount";
            txtVAmount.Size = new Size(270, 32);
            txtVAmount.TabIndex = 20;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.White;
            label19.Location = new Point(3, 461);
            label19.Name = "label19";
            label19.Size = new Size(156, 23);
            label19.TabIndex = 19;
            label19.Text = "Voucher Code";
            // 
            // txtVCode
            // 
            txtVCode.Location = new Point(199, 450);
            txtVCode.Name = "txtVCode";
            txtVCode.Size = new Size(270, 32);
            txtVCode.TabIndex = 18;
            // 
            // btnAddV
            // 
            btnAddV.BackColor = Color.LightSeaGreen;
            btnAddV.FlatStyle = FlatStyle.Flat;
            btnAddV.ForeColor = Color.White;
            btnAddV.Location = new Point(225, 596);
            btnAddV.Name = "btnAddV";
            btnAddV.Size = new Size(210, 43);
            btnAddV.TabIndex = 17;
            btnAddV.Text = "Add a Voucher";
            btnAddV.UseVisualStyleBackColor = false;
            btnAddV.Click += btnAddV_Click;
            // 
            // btnViewFreqCustomers
            // 
            btnViewFreqCustomers.BackColor = Color.LightSeaGreen;
            btnViewFreqCustomers.FlatStyle = FlatStyle.Flat;
            btnViewFreqCustomers.ForeColor = Color.White;
            btnViewFreqCustomers.Location = new Point(8, 331);
            btnViewFreqCustomers.Name = "btnViewFreqCustomers";
            btnViewFreqCustomers.Size = new Size(405, 43);
            btnViewFreqCustomers.TabIndex = 16;
            btnViewFreqCustomers.Text = "Most Frequent Customers";
            btnViewFreqCustomers.UseVisualStyleBackColor = false;
            btnViewFreqCustomers.Click += btnViewFreqCustomers_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightSeaGreen;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(813, 605);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(-4, 0);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 62;
            dgvCustomers.Size = new Size(1254, 318);
            dgvCustomers.TabIndex = 14;
            dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
            // 
            // txtCAddress
            // 
            txtCAddress.Location = new Point(972, 556);
            txtCAddress.Name = "txtCAddress";
            txtCAddress.Size = new Size(270, 32);
            txtCAddress.TabIndex = 13;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.White;
            label17.Location = new Point(781, 556);
            label17.Name = "label17";
            label17.Size = new Size(88, 23);
            label17.TabIndex = 12;
            label17.Text = "Address";
            // 
            // txtCPhone
            // 
            txtCPhone.Location = new Point(972, 513);
            txtCPhone.Name = "txtCPhone";
            txtCPhone.Size = new Size(270, 32);
            txtCPhone.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.White;
            label15.Location = new Point(781, 513);
            label15.Name = "label15";
            label15.Size = new Size(72, 23);
            label15.TabIndex = 8;
            label15.Text = "Phone";
            // 
            // txtCPass
            // 
            txtCPass.Location = new Point(972, 469);
            txtCPass.Name = "txtCPass";
            txtCPass.Size = new Size(270, 32);
            txtCPass.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.White;
            label14.Location = new Point(781, 473);
            label14.Name = "label14";
            label14.Size = new Size(103, 23);
            label14.TabIndex = 6;
            label14.Text = "Password";
            // 
            // txtCEmail
            // 
            txtCEmail.Location = new Point(972, 426);
            txtCEmail.Name = "txtCEmail";
            txtCEmail.Size = new Size(270, 32);
            txtCEmail.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(781, 430);
            label13.Name = "label13";
            label13.Size = new Size(62, 23);
            label13.TabIndex = 4;
            label13.Text = "Email";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightSeaGreen;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1125, 605);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightSeaGreen;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(962, 605);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(199, 407);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(270, 32);
            txtCustomerID.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(6, 414);
            label12.Name = "label12";
            label12.Size = new Size(130, 23);
            label12.TabIndex = 0;
            label12.Text = "Customer ID";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1258, 712);
            Controls.Add(tabControl1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPageProducts.ResumeLayout(false);
            tabPageProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            tabPagefreqCustomers.ResumeLayout(false);
            tabPagefreqCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFreqCustomers).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPageProducts;
        private TabPage tabPage3;
        private TextBox textBox5Address;
        private TextBox textBox4Phone;
        private TextBox textBox3Pass;
        private TextBox textBox2Email;
        private TextBox textBoxName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private DataGridView dataGridViewOrders;
        private TabPage tabPagefreqCustomers;
        private DataGridView dgvFreqCustomers;
        private Button btnAddVoucher;
        private Label label7;
        private TextBox txtCID;
        private Label label9;
        private TextBox txtAmount;
        private Label label8;
        private TextBox txtCode;
        private Label label10;
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private TabPage tabPage4;
        private Button btnDelete;
        private Button btnEdit;
        private TextBox txtCustomerID;
        private Label label12;
        private TextBox txtCPhone;
        private Label label15;
        private TextBox txtCPass;
        private Label label14;
        private TextBox txtCEmail;
        private Label label13;
        private Button btnAdd;
        private DataGridView dgvCustomers;
        private TextBox txtCAddress;
        private Label label17;
        private TextBox txtCName;
        private Label label20;
        private DateTimePicker dateTimePicker2;
        private Label label16;
        private Label label18;
        private TextBox txtVAmount;
        private Label label19;
        private TextBox txtVCode;
        private Button btnAddV;
        private Button btnViewFreqCustomers;
        private TextBox txtCIDDel;
        private Label label21;
        private Label label26;
        private Label label27;
        private Label label28;
        private TextBox txtPcategory;
        private TextBox txtPminThres;
        private TextBox txtPquantity;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private TextBox txtPprice;
        private TextBox txtPdesc;
        private TextBox txtPname;
        private DataGridView dgvProducts;
        private TextBox txtPSearch;
        private Button btnSearchProduct;
        private Button btnRestock;
        private Button btnDeleteProduct;
        private Button btnEditProduct;
        private Button btnAddProduct;
        private TextBox txtPsupplier;
        private Label label29;
        private TextBox txtPID;
        private Button btnReset;
        private Button btnShowLowStock;
        private Button btnShowAllProducts;
        private Button btnMostBought;
        private Button btnNotBought;
        private Button btnInactive;
        private Button btnResetCutomers;
        private Button button1;
        private Button btnProductPerCustomer;
        private Label label30;
    }
}