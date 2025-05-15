using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SuperMarketDBAPP1
{
    public partial class Dashboard : Form
    {
        static String sql = "Data Source=MARO25;Initial Catalog=SupermarketDatabase;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        //static string sql = "Data Source=DESKTOP-V936GVE;Initial Catalog=SupermarketDatabase;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        private int _customerId;
        public Dashboard(int customerId)

        {

            InitializeComponent();
            _customerId = customerId;
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

            // Delete button click event
            DeleteBtn.Click += DeleteBtn_Click; // delete account

        }

        // Load the first customer record into the textboxes
        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                int customerId = Session.CurrentCustomerId;

                string query = "SELECT * FROM Customer WHERE Customer_id = @id";

                using (SqlConnection con = new SqlConnection(sql))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", customerId);

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtName.Text = reader["Name"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            txtAddress.Text = reader["Address"].ToString();
                            txtPhone.Text = reader["Phone"].ToString();
                            txtPassword.Text = reader["Password"].ToString(); // Optional: hide or mask
                        }
                        else
                        {
                            MessageBox.Show("Customer record not found.");
                        }
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

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void LoadProducts()
        {
            flowLayoutPanelProducts.Controls.Clear(); // Clear old items
           // MessageBox.Show("Loaded!"); // Test line
            string query = "SELECT P_Name, Description, Price FROM Product";

            using (SqlConnection con = new SqlConnection(sql))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Panel card = new Panel();
                    card.Size = new Size(200, 200);
                    card.BorderStyle = BorderStyle.FixedSingle;
                    card.Margin = new Padding(10);

                    Label nameLabel = new Label();
                    nameLabel.Text = reader["P_Name"].ToString();
                    nameLabel.Font = new Font("Century Gothic", 10, FontStyle.Bold);
                    nameLabel.Location = new Point(10, 10);
                    nameLabel.AutoSize = true;

                    Label priceLabel = new Label();
                    priceLabel.Text = "$" + Convert.ToDecimal(reader["Price"]).ToString("F2");
                    priceLabel.Font = new Font("Century Gothic", 9);
                    priceLabel.Location = new Point(10, 40);
                    priceLabel.AutoSize = true;

                    Label descLabel = new Label();
                    descLabel.Text = reader["Description"].ToString();
                    descLabel.Font = new Font("Century Gothic", 8);
                    descLabel.Location = new Point(10, 70);
                    descLabel.Size = new Size(180, 100);


                    Button addToCartBtn = new Button();
                    addToCartBtn.Text = "Add to Cart";
                    addToCartBtn.BackColor = Color.LightSeaGreen;
                    addToCartBtn.ForeColor = Color.White;
                    addToCartBtn.FlatStyle = FlatStyle.Flat;
                    addToCartBtn.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                    addToCartBtn.Size = new Size(150, 30);
                    addToCartBtn.Location = new Point(40, 170); // Adjust as needed
                    addToCartBtn.Tag = reader["P_Name"].ToString();
                    addToCartBtn.Click += (s, ev) =>
                    {
                        string productName = (string)((Button)s).Tag;
                        MessageBox.Show($"{productName} added to cart!");
                    };

                    card.Controls.Add(nameLabel);
                    card.Controls.Add(priceLabel);
                    card.Controls.Add(descLabel);
                    card.Controls.Add(addToCartBtn);

                    flowLayoutPanelProducts.Controls.Add(card);
                }

                reader.Close();
            }
        }



        //Delete button

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete your account? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                int customerId = Session.CurrentCustomerId;
                string query = "DELETE FROM Customer WHERE Customer_id = @id";

                using (SqlConnection con = new SqlConnection(sql))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", customerId);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account deleted successfully.");

                        // Optionally return to login screen or close app
                        Application.Restart(); // or navigate to Login form
                    }
                    else
                    {
                        MessageBox.Show("No matching account found to delete.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting account: " + ex.Message);
            }
        }




        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanelProducts_Enter(object sender, EventArgs e)
        {
            //LoadProducts();
        }

        private void flowLayoutPanelProducts_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void shoptab_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == shoptab)
                {
                    LoadProducts();
                }
        }
    }
}
