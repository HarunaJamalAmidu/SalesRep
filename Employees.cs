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
    public partial class Employees : Form
    {
        public static string connectionString = "server=localhost;database=salesrep;uid=root; pwd=\"\";";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        public Employees()
        {
            InitializeComponent();
            //using (MySqlConnection connection = new MySqlConnection(connectionString)) 
            // { 
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM employeedata WHERE 1", connection);
            DataTable dt = new DataTable();
            mySqlDataAdapter.Fill(dt);

            EmployeedataGridView.DataSource = dt;
            //  }
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            SurNameBox.Text= "";
            GivenNameBox.Text = "";
            PhoneNoBox.Text = "";
            EmailBox.Text = "";
            BDaybox.Text = "";
            RoleBox2.Text = "";


        }

        private void AddEmpBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                if (SurNameBox.Text == "" & GivenNameBox.Text == "" & PhoneNoBox.Text == "" & GenderBox.Text == "" & EmailBox.Text == "" & BDaybox.Text == "" & RoleBox.Text == "")
                {
                    MessageBox.Show("Please fill out all fields");
                }
                else
                {
                    string query = "INSERT INTO `employeedata`(`lastName`, `givenName`, `phoneNumber`, `gender`, `email`, `birthDate`, `role`, `password`)VALUES ('" + SurNameBox.Text + "','" + GivenNameBox.Text + "','" + PhoneNoBox.Text + "', '" + GenderBox.Text + "', '" + EmailBox.Text + "', '" + BDaybox.Text + "', '" + RoleBox.Text + "', '" + passwordBox.Text + "')";
                    command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Attendant Added Succesfully");
                    connection.Close();
                    SurNameBox.Text = String.Empty;
                    GivenNameBox.Text = String.Empty;
                    PhoneNoBox.Text = String.Empty;
                    GenderBox.Text = String.Empty;
                    EmailBox.Text = String.Empty;
                    BDaybox.Text = String.Empty;
                    RoleBox.Text = String.Empty;

                    SurNameBox.Focus();
                }


                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM employeedata WHERE 1", connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);

                EmployeedataGridView.DataSource = dt;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employees emps = new();
            emps.Show();
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products prod = new();
            prod.Show();
        }
    }
}
