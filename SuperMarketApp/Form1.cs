using Microsoft.Data.SqlClient;
using System.Data;



namespace SuperMarketApp
{
    public partial class Form1 : Form
    {
        static string sql = "Data Source=DESKTOP-V936GVE;Initial Catalog=SupermarketDatabase;Integrated Security=True;Encrypt=False";

        SqlConnection con = new SqlConnection(sql);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = loadCustomerTable();

        }

        public DataTable loadCustomerTable()
        {
            DataTable dt = new DataTable();
            string qry = "SELECT * FROM Customer";
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;



        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // You can put your logic here.
            MessageBox.Show($"You clicked cell at row {e.RowIndex}, column {e.ColumnIndex}");
        }

        // login btn
        private void button1_Click(object sender, EventArgs e)
        {
            string role = comboBox1.SelectedItem?.ToString();
            string username = txtName.Text;
            string password = txtPassword.Text;

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
                        MainAdmin adminForm = new MainAdmin();
                        adminForm.Show();
                    }
                    else
                    {
                        MainCustomer customerForm = new MainCustomer();
                        customerForm.Show();
                    }

                    this.Hide(); // hide login form
                }
                else
                {
                    MessageBox.Show("Invalid credentials.");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Sign up btn
        private void button2_Click(object sender, EventArgs e)
        {
            // open the form for sign up
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
