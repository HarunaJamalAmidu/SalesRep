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
                    string query = "INSERT INTO `employeedata`(`lastName`, `givenName`, `phoneNumber`, `gender`, `email`, `birthDate`, `role`, `password`)VALUES ('" + SurNameBox.Text + "','" + GivenNameBox.Text + "','" + PhoneNoBox.Text + "', '" + GenderBox.Text + "', '" + EmailBox.Text + "', '" + BDaybox.Text.ToString() + "', '" + RoleBox.Text + "', '" + passwordBox.Text + "')";
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
            MiddleBox.Text = "";

        }

        private void EmployeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.EmployeeDataGridView.Rows[e.RowIndex];
                MiddleBox.Text    = row.Cells[0].Value.ToString();
                SurNameBox.Text   = row.Cells[1].Value.ToString();
                GivenNameBox.Text = row.Cells[2].Value.ToString();
                PhoneNoBox.Text   = row.Cells[3].Value.ToString();
                GenderBox.Text    = row.Cells[4].Value.ToString();
                EmailBox.Text     = row.Cells[5].Value.ToString();
                BDaybox.Text      = row.Cells[6].Value.ToString();
                RoleBox.Text      = row.Cells[7].Value.ToString();
                passwordBox.Text  = row.Cells[8].Value.ToString();
            }
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

        private void UpdateBtn_Click(object sender, EventArgs e)
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
                    string query = " UPDATE `employeedata` SET `lastName`='"+ SurNameBox.Text + "',`givenName`='" + GivenNameBox.Text + "',`phoneNumber`='" + PhoneNoBox.Text + "',`gender`='" + GenderBox.Text + "',`email`='" + EmailBox.Text + "',`birthDate`='" + BDaybox.Text + "',`role`='" + RoleBox.Text + "',`password`='" + passwordBox.Text + "' WHERE `employeeId`='" + MiddleBox.Text + "'";
                    command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("SUCCESSFUL");
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

                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM employeedata WHERE 1", connection);
                    DataTable dt = new DataTable();
                    mySqlDataAdapter.Fill(dt);

                    EmployeeDataGridView.DataSource = dt;
                }
            }
        }
    }
}
