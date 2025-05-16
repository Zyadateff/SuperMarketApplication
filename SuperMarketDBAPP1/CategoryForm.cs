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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        static string sql = "Data Source=DESKTOP-V936GVE;Initial Catalog=SupermarketDatabase;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        SqlConnection con = new SqlConnection(sql);

        private void populate()
        {
            using (SqlConnection con = new SqlConnection(sql))
            {
                con.Open();
                string query = "select * from Category";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                CategoryDGV.DataSource = ds.Tables[0];
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
                {
                    MessageBox.Show("Please enter a valid category name.");
                    return;
                }

                using (SqlConnection con = new SqlConnection(sql))
                {
                    con.Open();
                    string query = "INSERT INTO Category (Category_name, Description) VALUES (@Name, @Description)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtCategoryName.Text);
                        cmd.Parameters.AddWithValue("@Description", TxtCategoryDescription.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Category Added Successfully");
                    populate();
                    txtCategoryName.Text = "";
                    TxtCategoryDescription.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CategoryDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoryName.Text = CategoryDGV.SelectedRows[0].Cells[1].Value.ToString();
            TxtCategoryDescription.Text = CategoryDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
