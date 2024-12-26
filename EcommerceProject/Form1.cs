using Microsoft.Data.SqlClient;
using System.Data;

namespace EcommerceProject
{
    public partial class Ecommerce : Form
    {
        SqlConnection conn;

        string connectionString = "Server=.;Database=Ecommerce;Trusted_Connection=True;TrustServerCertificate=True;";

        public Ecommerce()
        {
            InitializeComponent();
        }
        private void FillCompoBox()
        {
            try
            {
                string query = "select categoryID,Name from Category";
                SqlCommand obj = new SqlCommand(query, conn);

                SqlDataReader reader = obj.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "categoryID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Ecommerce_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            FillCompoBox();
            LoadProductsIntoGrid();
        }
        public void LoadProductsIntoGrid()
        {
            try
            {
                string query = "SELECT * FROM Product";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "INSERT INTO Product (Pname, Price, Prand, Color, Weight, Stock ,categoryID) " +
                               "VALUES (@Name, @Price, @Brand, @Color, @Weight, @Stock ,@categoryID)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@Brand", txtPrand.Text);
                    cmd.Parameters.AddWithValue("@Color", txtColor.Text);
                    cmd.Parameters.AddWithValue("@categoryID", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@Weight", Convert.ToDecimal(txtWeight.Text));
                    cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text));

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product saved successfully.");
                        LoadProductsIntoGrid();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save product.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Ecommerce_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
