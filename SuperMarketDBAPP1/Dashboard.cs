using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SuperMarketDBAPP1
{
    public partial class Dashboard : Form
    {
        // Connection string to your SQL Server
        static string sql = "Data Source=MARO25;Initial Catalog=SupermarketDatabase;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public Dashboard()
        {
            InitializeComponent();

            // Attach Load event
            this.Load += Dashboard_Load;

            // Enable Save button when any text changes
            txtName.TextChanged += EnableSaveButton;
            txtEmail.TextChanged += EnableSaveButton;
            txtAddress.TextChanged += EnableSaveButton;
            txtPhone.TextChanged += EnableSaveButton;
            txtPassword.TextChanged += EnableSaveButton;

            // Save button click event
            saveBtn.Click += BtnSave_Click;
            saveBtn.Enabled = false; // Disabled by default
        }

        // Load the first customer record into the textboxes
        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Customer";

                using (SqlConnection con = new SqlConnection(sql))
                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        txtName.Text = dt.Rows[0]["Name"].ToString();
                        txtEmail.Text = dt.Rows[0]["Email"].ToString();
                        txtAddress.Text = dt.Rows[0]["Address"].ToString();
                        txtPhone.Text = dt.Rows[0]["Phone"].ToString();
                        txtPassword.Text = dt.Rows[0]["Password"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message);
            }
        }

        // Enable the Save button when any field is edited
        private void EnableSaveButton(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;
        }

        // Update the customer record using Email as the unique identifier
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required to update the record.");
                return;
            }

            try
            {
                string query = @"UPDATE Customer 
                                 SET Name = @Name, Address = @Address, 
                                     Phone = @Phone, Password = @Password
                                 WHERE Email = @Email";

                using (SqlConnection con = new SqlConnection(sql))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer data updated successfully.");
                        saveBtn.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("No matching customer found with that email.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
        }
    }
}
