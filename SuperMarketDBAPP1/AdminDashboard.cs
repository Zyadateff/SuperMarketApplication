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
        static String sql = "Data Source=DESKTOP-V936GVE;Initial Catalog=SupermarketDatabase;Integrated Security=True;Encrypt=False";

        public AdminDashboard()
        {
            InitializeComponent();
        }


        //phone label
        private void label5_Click(object sender, EventArgs e)
        {

        }

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
    }
}
