using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace SalesRep
{
    public partial class Products : Form
    {
        public static string connectionString = "server=localhost;database=salesrep;Port=3307;uid=root; pwd=\"\";";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        public Products()
        {
            InitializeComponent();
            //SQL CONNECTION
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM products WHERE 1", connection);
            DataTable dt = new DataTable();
            mySqlDataAdapter.Fill(dt);

            ProductsDataGridView.DataSource = dt;


        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EMPLOYEES emps = new();
            emps.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddProdBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                if (ProductNameBox.Text == "" & ProductQuantityBox.Text == "" & ReorderLevelBox.Text == "" & CostPriceBox.Text == "" & SellingPriceBox.Text == "" & ExpiryDateBox.Text == "")
                {
                    MessageBox.Show("Please fill out all fields");
                }
                else
                {
                    string query = "INSERT INTO `products`(`productName`, `productQuantity`, `unitCostPrice`, `unitSellingPrice`, `reorderLevel`, `expiryDate`)VALUES ('" + ProductNameBox.Text + "','" + ProductQuantityBox.Text + "','" + ReorderLevelBox.Text + "', '" + CostPriceBox.Text + "', '" + SellingPriceBox.Text + "', '" + ExpiryDateBox.Text + "')";
                    command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("SUCCESSFUL");
                    connection.Close();
                    ProductNameBox.Text = String.Empty;
                    ProductQuantityBox.Text = String.Empty;
                    ReorderLevelBox.Text = String.Empty;
                    CostPriceBox.Text = String.Empty;
                    SellingPriceBox.Text = String.Empty;
                    ExpiryDateBox.Text = String.Empty;
                    
                    ProductNameBox.Focus();
                }


                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM products WHERE 1", connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);

                ProductsDataGridView.DataSource = dt;
            }
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            ProductNameBox.Text = "";
            ProductQuantityBox.Text = "";
            ReorderLevelBox.Text = "";
            CostPriceBox.Text = "";
            SellingPriceBox.Text = "";
            ExpiryDateBox.Text = "";
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                if (ProductNameBox.Text == "" & ProductQuantityBox.Text == "" & ReorderLevelBox.Text == "" & CostPriceBox.Text == "" & SellingPriceBox.Text == "" & ExpiryDateBox.Text == "")
                {
                    MessageBox.Show("Please fill out all fields");
                }
                else
                {
                    string query = "UPDATE `products` SET `productName`= '" + ProductNameBox.Text + "',`productQuantity`= '" + ProductQuantityBox.Text + "',`unitCostPrice`= '" + CostPriceBox.Text + "',`unitSellingPrice`= '" + SellingPriceBox.Text + "',`reorderLevel`= '" + ReorderLevelBox.Text + "',`expiryDate`= '" + ExpiryDateBox.Text + "' WHERE 1";
                    command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("SUCCESSFUL");
                    connection.Close();
                    ProductNameBox.Text = String.Empty;
                    ProductQuantityBox.Text = String.Empty;
                    ReorderLevelBox.Text = String.Empty;
                    CostPriceBox.Text = String.Empty;
                    SellingPriceBox.Text = String.Empty;
                    ExpiryDateBox.Text = String.Empty;
                    
                    ProductNameBox.Focus();
                }
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login logins = new();
            logins.Show();
        }

        private void transBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction transs = new();
            transs.Show();
        }

        private void Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ManInTheMiddle mitm = new();
            mitm.Show();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();

                if (MiddleBox != null)
                {
                    string query = "DELETE FROM products WHERE productId = '" + MiddleBox.Text + "';";
                    command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("SUCCESFULL");
                connection.Close();

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM products WHERE 1", connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);
                ProductsDataGridView.DataSource = dt;
            }
        }
    }
}
