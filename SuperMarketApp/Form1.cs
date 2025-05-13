using Microsoft.Data.SqlClient;
using System.Data;



namespace SuperMarketApp
{
    public partial class Form1 : Form
    {
        static string sql = "Data Source=DESKTOP-V936GVE;Initial Catalog=SupermarketDB;Integrated Security=True;Encrypt=False";

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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Sign up btn
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
