using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace SuperMarketDBAPP1
{
    public partial class AdminDashboard : Form
    {
        //static string sql = "Data Source=DESKTOP-V936GVE;Initial Catalog=SupermarketDatabase;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        static String sql = "Data Source=MARO25;Initial Catalog=SupermarketDatabase;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public AdminDashboard()
        {
            InitializeComponent();
        }


        //phone label
        private void label5_Click(object sender, EventArgs e)
        {

        }

        //======================================
        // Products tab
        private void LoadAllProducts()
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = "SELECT * FROM Product";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
        }

        private void LoadLowStockProducts()
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = "SELECT * FROM Product WHERE StockQuantity < MinStockThreshold";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
        }



        //======================================



        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = textBoxName.Text.Trim();
            string password = textBox3Pass.Text.Trim();
            string email = textBox2Email.Text.Trim();
            string address = textBox5Address.Text.Trim();
            string phone = textBox4Phone.Text.Trim();


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(sql))
                {
                    conn.Open();

                    string query = @"INSERT INTO Customer (Name, Email, Password, Address, Phone)
                          VALUES (@Username, @Email, @Password, @Address, @Phone)";





                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"{username} registered successfully!");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void OrdersPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadOrders()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(sql))
                {
                    conn.Open();
                    string query = "SELECT * FROM [Order]";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewOrders.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load orders: " + ex.Message);
            }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage3)
            {
                LoadOrders();
            }

            if (tabControl1.SelectedTab == tabPagefreqCustomers)
            {
                LoadFrequentCustomers();
            }

            // Check if the selected tab is the Products tab
            if (tabControl1.SelectedTab == tabPageProducts)
            {
                LoadAllProducts();
            }

        }

        private void LoadFrequentCustomers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(sql))
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    c.Customer_id,
                    c.Name,
                    c.Email,
                    COUNT(o.Order_id) AS NumberOfOrders
                FROM 
                    Customer c
                LEFT JOIN 
                    [Order] o ON c.Customer_id = o.Customer_id
                GROUP BY 
                    c.Customer_id, c.Name, c.Email
                ORDER BY 
                    NumberOfOrders DESC;";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvFreqCustomers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load frequent customers: " + ex.Message);
            }
        }

        private void dgvFreqCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCID.Text = dgvFreqCustomers.Rows[e.RowIndex].Cells["Customer_id"].Value.ToString();
            }
        }

        private void btnAddVoucher_Click(object sender, EventArgs e)
        {
            // Read values from inputs
            string customerIdText = txtCID.Text.Trim();
            string amountText = txtAmount.Text.Trim();
            string code = txtCode.Text.Trim();
            DateTime expiryDate = dateTimePicker1.Value;

            // Basic validation
            if (string.IsNullOrEmpty(customerIdText) || string.IsNullOrEmpty(amountText) || string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(customerIdText, out int customerId))
            {
                MessageBox.Show("Customer ID must be a valid number.");
                return;
            }

            if (!decimal.TryParse(amountText, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Amount must be a valid positive number.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(sql))
                {
                    conn.Open();

                    string insertQuery = @"
                INSERT INTO Voucher (CustomerId, VoucherCode, Amount, ExpiryDate, Status)
                VALUES (@CustomerId, @VoucherCode, @Amount, @ExpiryDate, 'Active')";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);
                        cmd.Parameters.AddWithValue("@VoucherCode", code);
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.Parameters.AddWithValue("@ExpiryDate", expiryDate);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Voucher added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add voucher.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tabPagefreqCustomers_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadAllCustomers()
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = "SELECT * FROM Customer";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvCustomers.DataSource = dt;
            }
        }
        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            LoadAllCustomers();
        }

        private void btnViewFreqCustomers_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = @"
                    SELECT 
                    c.Customer_id,
                    c.Name,
                    c.Email,
                    COUNT(o.Order_id) AS NumberOfOrders
                    FROM 
                        Customer c
                    INNER JOIN 
                        [Order] o ON c.Customer_id = o.Customer_id
                    GROUP BY 
                        c.Customer_id, c.Name, c.Email
                    ORDER BY 
                        NumberOfOrders DESC;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvCustomers.DataSource = dt;
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtCIDDel.Text))
            {
                MessageBox.Show("Please enter a Customer ID to delete.", "Missing ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int customerId;
            if (!int.TryParse(txtCIDDel.Text, out customerId))
            {
                MessageBox.Show("Invalid Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this customer and all related data?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            using (SqlConnection conn = new SqlConnection(sql))
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // 1. Delete OrderItems
                    string deleteOrderItemsQuery = @"
                DELETE FROM OrderItem 
                WHERE Order_id IN (SELECT Order_id FROM [Order] WHERE Customer_id = @Id)";
                    using (SqlCommand cmd = new SqlCommand(deleteOrderItemsQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Id", customerId);
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Delete Orders
                    string deleteOrdersQuery = "DELETE FROM [Order] WHERE Customer_id = @Id";
                    using (SqlCommand cmd = new SqlCommand(deleteOrdersQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Id", customerId);
                        cmd.ExecuteNonQuery();
                    }

                    // 3. Delete Customer
                    string deleteCustomerQuery = "DELETE FROM Customer WHERE Customer_id = @Id";
                    using (SqlCommand cmd = new SqlCommand(deleteCustomerQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Id", customerId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Customer not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            transaction.Rollback();
                            return;
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Customer and all related data deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllCustomers();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message, "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = "INSERT INTO Customer (Name, Email, Phone, Password, Address) VALUES (@Name, @Email, @Phone, @Password, @Address)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", txtCName.Text);
                cmd.Parameters.AddWithValue("@Email", txtCEmail.Text);
                cmd.Parameters.AddWithValue("@Phone", txtCPhone.Text);
                cmd.Parameters.AddWithValue("@Password", txtCPass.Text);
                cmd.Parameters.AddWithValue("@Address", txtCAddress.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadAllCustomers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(sql))
                {
                    string query = "UPDATE Customer SET Name=@Name, Email=@Email, Phone=@Phone, Password=@Password, Address=@Address WHERE Customer_id=@Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", txtCName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtCEmail.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtCPhone.Text);
                    cmd.Parameters.AddWithValue("@Password", txtCPass.Text);
                    cmd.Parameters.AddWithValue("@Address", txtCAddress.Text);
                    cmd.Parameters.AddWithValue("@Id", txtCustomerID.Text);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                        MessageBox.Show("No customer found with that ID.");
                    else
                        MessageBox.Show("Customer updated successfully.");
                }

                LoadAllCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAddV_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtCustomerID.Text) ||
                string.IsNullOrWhiteSpace(txtVCode.Text) ||
                string.IsNullOrWhiteSpace(txtVAmount.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            // Parse and validate inputs
            if (!int.TryParse(txtCustomerID.Text, out int customerId))
            {
                MessageBox.Show("Customer ID must be a valid number.");
                return;
            }

            if (!decimal.TryParse(txtVAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Amount must be a valid positive number.");
                return;
            }

            string vCode = txtVCode.Text.Trim();
            DateTime expiryDate = dateTimePicker2.Value;


            using (SqlConnection conn = new SqlConnection(sql))
            {
                try
                {
                    conn.Open();

                    string query = @"
                INSERT INTO Voucher (CustomerId, VoucherCode, Amount, ExpiryDate, Status)
                VALUES (@CustomerId, @VoucherCode, @Amount, @ExpiryDate, 'Active')";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);
                        cmd.Parameters.AddWithValue("@VoucherCode", vCode);
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.Parameters.AddWithValue("@ExpiryDate", expiryDate);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                            MessageBox.Show("Voucher added successfully.");
                        else
                            MessageBox.Show("Failed to add voucher.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = @"INSERT INTO Product (P_Name, Description, Price, Quantity, StockQuantity, MinStockThreshold, Category_id, Supplier_id) 
                         VALUES (@Name, @Desc, @Price, @Qty, @Stock, @Min, @CatId, @SupId)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", txtPname.Text);
                cmd.Parameters.AddWithValue("@Desc", txtPdesc.Text);
                if (string.IsNullOrWhiteSpace(txtPprice.Text))
                {
                    MessageBox.Show("Please enter a valid price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal price;
                if (!decimal.TryParse(txtPprice.Text, out price))
                {
                    MessageBox.Show("Invalid format for price. Please enter a numeric value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPprice.Text));
                cmd.Parameters.AddWithValue("@Qty", Convert.ToInt32(txtPquantity.Text));
                cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtPquantity.Text));
                cmd.Parameters.AddWithValue("@Min", Convert.ToInt32(txtPminThres.Text));
                cmd.Parameters.AddWithValue("@CatId", Convert.ToInt32(txtPcategory.Text));
                cmd.Parameters.AddWithValue("@SupId", Convert.ToInt32(txtPsupplier.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadAllProducts();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                int productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["Product_id"].Value);

                using (SqlConnection conn = new SqlConnection(sql))
                {
                    string query = @"UPDATE Product SET P_Name=@Name, Description=@Desc, Price=@Price, Quantity=@Qty, 
                             StockQuantity=@Stock, MinStockThreshold=@Min, Category_id=@CatId, Supplier_id=@SupId 
                             WHERE Product_id=@Id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", txtPname.Text);
                    cmd.Parameters.AddWithValue("@Desc", txtPdesc.Text);
                    cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPprice.Text));
                    cmd.Parameters.AddWithValue("@Qty", Convert.ToInt32(txtPquantity.Text));
                    cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtPquantity.Text));
                    cmd.Parameters.AddWithValue("@Min", Convert.ToInt32(txtPminThres.Text));
                    cmd.Parameters.AddWithValue("@CatId", Convert.ToInt32(txtPcategory.Text));
                    cmd.Parameters.AddWithValue("@SupId", Convert.ToInt32(txtPsupplier.Text));
                    cmd.Parameters.AddWithValue("@Id", productId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadAllProducts();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int productId = -1;

            // Try getting ID from txtPID
            if (!string.IsNullOrWhiteSpace(txtPID.Text))
            {
                if (!int.TryParse(txtPID.Text, out productId))
                {
                    MessageBox.Show("Invalid Product ID. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (dgvProducts.CurrentRow != null)
            {
                // Try getting ID from selected row if textbox is empty
                productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["Product_id"].Value);
            }
            else
            {
                MessageBox.Show("Please select a product or enter a valid Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm delete
            var confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(sql))
                    {
                        string query = "DELETE FROM Product WHERE Product_id = @Id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Id", productId);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAllProducts();
                            txtPID.Clear(); // optional: clear textbox
                        }
                        else
                        {
                            MessageBox.Show("No product found with the given ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error deleting product:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string keyword = txtPSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a product name to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = "SELECT * FROM Product WHERE P_Name LIKE @Keyword";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No products found matching your search.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    dgvProducts.DataSource = dt;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                int productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["Product_id"].Value);
                int restockAmount = Convert.ToInt32(txtPquantity.Text);

                using (SqlConnection conn = new SqlConnection(sql))
                {
                    string query = "UPDATE Product SET StockQuantity = StockQuantity + @Amount WHERE Product_id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Amount", restockAmount);
                    cmd.Parameters.AddWithValue("@Id", productId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadAllProducts();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPSearch.Clear();
            LoadAllProducts();
        }

        private void btnShowLowStock_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = "SELECT * FROM Product WHERE StockQuantity < MinStockThreshold";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvProducts.DataSource = table;
            }
        }

        private void btnShowAllProducts_Click(object sender, EventArgs e)
        {
            LoadAllProducts();

        }

        private void btnMostBought_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = @"
            SELECT TOP 1 
                P.*, 
                SUM(OI.Quantity) AS TotalSold
            FROM 
                Product P
            JOIN 
                OrderItem OI ON P.Product_id = OI.Product_id
            GROUP BY 
                P.Product_id, P.P_Name, P.Description, P.Price, P.Quantity, 
                P.StockQuantity, P.MinStockThreshold, P.Category_id, P.Supplier_id
            ORDER BY 
                TotalSold DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvProducts.DataSource = table;
            }
        }

        private void btnNotBought_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = @"
            SELECT * 
            FROM Product 
            WHERE Product_id NOT IN (
                SELECT DISTINCT OI.Product_id
                FROM OrderItem OI
                JOIN [Order] O ON O.Order_id = OI.Order_id
                WHERE MONTH(O.Order_Date) = MONTH(GETDATE())
                  AND YEAR(O.Order_Date) = YEAR(GETDATE())
            )";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvProducts.DataSource = table;
            }
        }

        private void btnInactive_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = @"
            SELECT * 
            FROM Customer
            WHERE Customer_id NOT IN (
                SELECT DISTINCT Customer_id
                FROM [Order]
                WHERE Order_Date >= DATEADD(YEAR, -1, GETDATE())
            )";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvCustomers.DataSource = table;
            }
        }

        private void btnResetCutomers_Click(object sender, EventArgs e)
        {
            LoadAllCustomers();
        }


        // top selling category
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = @"
            SELECT c.Category_name, SUM(oi.Quantity * oi.U_Price) AS TotalSales
            FROM OrderItem oi
            JOIN Product p ON oi.Product_id = p.Product_id
            JOIN Category c ON p.Category_id = c.Category_id
            GROUP BY c.Category_name";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                Dictionary<string, decimal> categorySales = new Dictionary<string, decimal>();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string category = reader["Category_name"].ToString();
                        decimal sales = Convert.ToDecimal(reader["TotalSales"]);
                        categorySales[category] = sales;
                    }
                }

                if (categorySales.Count == 0)
                {
                    MessageBox.Show("No sales data available.");
                    return;
                }

                // Now compare
                string topCategory = categorySales.OrderByDescending(x => x.Value).First().Key;
                decimal topSales = categorySales[topCategory];

                string message = $" The supermarket is selling more **{topCategory}** products!\n\nTotal Sales: {topSales:C2}";
                MessageBox.Show(message, "Sales Comparison", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadProductsWithCustomerCount()
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = @"
            SELECT 
                p.Product_id,
                p.P_Name,
                p.Description,
                p.Price,
                p.Quantity,
                p.StockQuantity,
                p.MinStockThreshold,
                p.Category_id,
                p.Supplier_id,
                COUNT(DISTINCT o.Customer_id) AS NumberOfCustomers
            FROM Product p
            LEFT JOIN OrderItem oi ON p.Product_id = oi.Product_id
            LEFT JOIN [Order] o ON oi.Order_id = o.Order_id
            GROUP BY 
                p.Product_id,
                p.P_Name,
                p.Description,
                p.Price,
                p.Quantity,
                p.StockQuantity,
                p.MinStockThreshold,
                p.Category_id,
                p.Supplier_id
        ";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvProducts.DataSource = dt;
            }
        }

        private void btnProductPerCustomer_Click(object sender, EventArgs e)
        {
            LoadProductsWithCustomerCount();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
