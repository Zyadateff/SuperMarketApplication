using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SuperMarketDBAPP1
{
    public partial class Login : Form
    {
        static string sql = "Data Source=DESKTOP-V936GVE;Initial Catalog=SupermarketDatabase;Integrated Security=True;Encrypt=False";

        SqlConnection con = new SqlConnection(sql);
        public Login()
        {
            InitializeComponent();
        }

        // removed the btn
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string role = comboBox1.SelectedItem?.ToString();
            string username = txtName.Text;
            string password = txtPass.Text;

            if (string.IsNullOrEmpty(role) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "";
            if (role == "Admin")
                query = "SELECT COUNT(*) FROM Admin WHERE Name = @username AND Password = @password";
            else if (role == "Customer")
                query = "SELECT COUNT(*) FROM Customer WHERE Name = @username AND Password = @password";
            else
            {
                MessageBox.Show("Invalid role selected.");
                return;
            }

            using (SqlConnection con = new SqlConnection(sql))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                con.Open();
                int result = (int)cmd.ExecuteScalar();
                con.Close();

                if (result > 0)
                {
                    MessageBox.Show("Login successful!");

                    if (role == "Admin")
                    {
                        AdminDashboard adminForm = new AdminDashboard();
                        adminForm.Show();
                    }
                    else
                    {
                        //MainCustomer customerForm = new MainCustomer();
                        //customerForm.Show();
                    }

                    this.Hide(); // hide login form
                }
                else
                {
                    MessageBox.Show("Invalid credentials.");
                }
            }
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            this.Hide(); 
            signUpForm.ShowDialog();
            this.Show(); // show login again after signup closes
        }
    }
}
