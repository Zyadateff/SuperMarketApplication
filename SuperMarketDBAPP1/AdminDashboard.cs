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
    }
}
