using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesRep
{
    public partial class Transaction : Form
    {
        public static string connectionString = "server=localhost;database=salesrep;Port=3307;uid=root; pwd=\"\";";
        public static MySqlConnection connection = new MySqlConnection(connectionString);

        public Transaction()
        {
            InitializeComponent();
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products prods = new();
            prods.Show();
        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EMPLOYEES emps = new();
            emps.Show();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login logins = new();
            logins.Show();
        }

        private void Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ManInTheMiddle mitm = new();
            mitm.Show();
        }

        private void UpTabBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
               
                    string query = "select * from transactionhistory where 1";
                    command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();                    
                    connection.Close();

                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    mySqlDataAdapter.Fill(dt);
                    TransDataGridView.DataSource = dt;
            }
        }
    }
}
