using MySql.Data.MySqlClient;
using System.Data;
using Microsoft.VisualBasic;

namespace SalesRep
{
    public partial class EMPLOYEES : Form
    {
        public static string connectionString = "server=localhost;database=salesrep;Port=3307;uid=root; pwd=\"\";";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        public EMPLOYEES()
        {
            InitializeComponent();
            //SQL CONNECTION
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM employeedata WHERE 1", connection);
            DataTable dt = new DataTable();
            mySqlDataAdapter.Fill(dt);

            EmployeeDataGridView.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                if (SurNameBox.Text == "" & GivenNameBox.Text == "" & PhoneNoBox.Text == "" & GenderBox.Text == "" & EmailBox.Text == "" & BDaybox.Text == "" & RoleBox.Text == "" & passwordBox.Text == "")
                {
                    MessageBox.Show("Please fill out all fields");
                }
                else
                {
                    string query = "INSERT INTO `employeedata`(`lastName`, `givenName`, `phoneNumber`, `gender`, `email`, `birthDate`, `role`, `password`)VALUES ('" + SurNameBox.Text + "','" + GivenNameBox.Text + "','" + PhoneNoBox.Text + "', '" + GenderBox.Text + "', '" + EmailBox.Text + "', '" + BDaybox.Text + "', '" + RoleBox.Text + "', '" + passwordBox.Text + "')";
                    command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("SUCCESFUL");
                    connection.Close();
                    SurNameBox.Text = String.Empty;
                    GivenNameBox.Text = String.Empty;
                    PhoneNoBox.Text = String.Empty;
                    GenderBox.Text = String.Empty;
                    EmailBox.Text = String.Empty;
                    BDaybox.Text = String.Empty;
                    RoleBox.Text = String.Empty;
                    passwordBox.Text = String.Empty;
                    SurNameBox.Focus();
                }

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM employeedata WHERE 1", connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);
                EmployeeDataGridView.DataSource = dt;
            }
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products prods = new();
            prods.Show();
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

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            SurNameBox.Text = "";
            GivenNameBox.Text = "";
            PhoneNoBox.Text = "";
            GenderBox.Text = "";
            EmailBox.Text = "";
            BDaybox.Text = "";
            RoleBox.Text = "";
            passwordBox.Text = "";

        }

        private void EmployeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                                   
                    if (MiddleBox != null)
                    {
                        string query = "DELETE FROM employeedata WHERE employeeId = '" + MiddleBox.Text + "';";
                        command = new MySqlCommand(query, connection);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("SUCCESFULL");
                    connection.Close();
                   
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM employeedata WHERE 1", connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);
                EmployeeDataGridView.DataSource = dt;
            }
        }
    }
}
