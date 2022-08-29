using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using SalesRep;
using System.Data;

namespace SmartToll1._0
{
    public partial class Sales : Form
    {
        public static string connectionString = "server=localhost;database=salesrep;Port=3307;uid=root; pwd=\"\";";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        DataTable Salestable = new DataTable();
        
        
        public Sales()
        {
            InitializeComponent();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();

                string query = "select productName,unitSellingPrice from products where productName like '" + SearchBox.Text + "%'";
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);

                QueryGridView.DataSource = dt;
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login logins = new();
            logins.Show();
        }

        private void QueryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.QueryGridView.Rows[e.RowIndex];
                NameBox.Text = row.Cells[0].Value.ToString();
                AmountLabel.Text = row.Cells[1].Value.ToString();
               
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //float TotalSum = 0;
            if (QuantityBox.Text == "")
                MessageBox.Show("ENTER THE NUMBER OF PRODUCTS");
            
            else
            {
                CartGrid.Columns[0].HeaderText = "PRODUCT NAME";
                CartGrid.Columns[1].HeaderText = "QUANTITY";
                CartGrid.Columns[2].HeaderText = "PRICE";
                String ProductName = NameBox.Text;
                int quantity = Convert.ToInt32(QuantityBox.Text);
                double price = 10.5; //UnitSellingPrice;
                //TotalSum = price * quantity;
                CartGrid.Rows.Add(ProductName, quantity,price);
                CartGrid.DataSource = Salestable;

            }
           
        }
    }
}
