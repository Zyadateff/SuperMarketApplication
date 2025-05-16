namespace SuperMarketDBAPP1
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            panel1 = new Panel();
            CategoryDGV = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            TxtCategoryDescription = new TextBox();
            lblDesc = new Label();
            txtCategoryName = new TextBox();
            lblName = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            btnSuppliers = new Button();
            btnProducts = new Button();
            btnSelling = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(CategoryDGV);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(TxtCategoryDescription);
            panel1.Controls.Add(lblDesc);
            panel1.Controls.Add(txtCategoryName);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(161, 60);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1085, 640);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // CategoryDGV
            // 
            CategoryDGV.BackgroundColor = Color.White;
            CategoryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryDGV.Location = new Point(385, 80);
            CategoryDGV.Margin = new Padding(2);
            CategoryDGV.Name = "CategoryDGV";
            CategoryDGV.RowHeadersWidth = 62;
            CategoryDGV.Size = new Size(698, 558);
            CategoryDGV.TabIndex = 16;
            CategoryDGV.CellContentClick += CategoryDGV_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.LightSeaGreen;
            btnDelete.Location = new Point(258, 164);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 40);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.LightSeaGreen;
            btnUpdate.Location = new Point(138, 164);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 40);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.LightSeaGreen;
            btnAdd.Location = new Point(19, 164);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 40);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // TxtCategoryDescription
            // 
            TxtCategoryDescription.Location = new Point(152, 118);
            TxtCategoryDescription.Margin = new Padding(2);
            TxtCategoryDescription.Name = "TxtCategoryDescription";
            TxtCategoryDescription.Size = new Size(226, 31);
            TxtCategoryDescription.TabIndex = 12;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesc.ForeColor = Color.White;
            lblDesc.Location = new Point(2, 119);
            lblDesc.Margin = new Padding(2, 0, 2, 0);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(142, 28);
            lblDesc.TabIndex = 11;
            lblDesc.Text = "Description";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(152, 80);
            txtCategoryName.Margin = new Padding(2);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(226, 31);
            txtCategoryName.TabIndex = 10;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(2, 82);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(84, 28);
            lblName.TabIndex = 9;
            lblName.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(336, 9);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(326, 38);
            label3.TabIndex = 6;
            label3.Text = "Manage Categories";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(338, -19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(333, 38);
            label1.TabIndex = 5;
            label1.Text = "Supermarket System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(498, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(333, 38);
            label2.TabIndex = 4;
            label2.Text = "Supermarket System";
            // 
            // btnSuppliers
            // 
            btnSuppliers.FlatAppearance.BorderSize = 0;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSuppliers.ForeColor = Color.LightSeaGreen;
            btnSuppliers.Location = new Point(12, 140);
            btnSuppliers.Margin = new Padding(2);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(142, 51);
            btnSuppliers.TabIndex = 5;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProducts.ForeColor = Color.LightSeaGreen;
            btnProducts.Location = new Point(12, 198);
            btnProducts.Margin = new Padding(2);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(142, 51);
            btnProducts.TabIndex = 6;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnSelling
            // 
            btnSelling.FlatAppearance.BorderSize = 0;
            btnSelling.FlatStyle = FlatStyle.Flat;
            btnSelling.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelling.ForeColor = Color.LightSeaGreen;
            btnSelling.Location = new Point(12, 254);
            btnSelling.Margin = new Padding(2);
            btnSelling.Name = "btnSelling";
            btnSelling.Size = new Size(142, 51);
            btnSelling.TabIndex = 7;
            btnSelling.Text = "Selling";
            btnSelling.UseVisualStyleBackColor = true;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1258, 712);
            Controls.Add(btnSelling);
            Controls.Add(btnProducts);
            Controls.Add(btnSuppliers);
            Controls.Add(label2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "CategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button btnSuppliers;
        private Button btnProducts;
        private Button btnSelling;
        private Button btnAdd;
        private TextBox TxtCategoryDescription;
        private Label lblDesc;
        private TextBox txtCategoryName;
        private Label lblName;
        private DataGridView CategoryDGV;
        private Button btnDelete;
        private Button btnUpdate;
    }
}