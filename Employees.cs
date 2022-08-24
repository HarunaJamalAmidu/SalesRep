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
        public static string connectionString = "server=localhost;database=inventory_system;uid=root; pwd=\"\";";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        public Employees()
        {
            InitializeComponent();
            //using (MySqlConnection connection = new MySqlConnection(connectionString)) 
            // { 
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM attendant WHERE 1", connection);
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
            GenderComboBox.SelectedIndex = 0;
            EmailBox.Text = "";
            
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
                    string query = "INSERT INTO attendant`(`fullname, username, passwd, dob, gender, phone, address, `admin_id`) VALUES ('" + fullnameTxt.Text + "','" + usernameTxt.Text + "','" + passwordTxt.Text + "', '" + dobTxt.Text + "', '" + genderTxt.Text + "', '" + phoneTxt.Text + "', '" + addressTxt.Text + "', '" + adminIdText.Text + "' )";
                    command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Attendant Added Succesfully");
                    connection.Close();
                    fullnameTxt.Text = String.Empty;
                    usernameTxt.Text = String.Empty;
                    passwordTxt.Text = String.Empty;
                    dobTxt.Text = String.Empty;
                    genderTxt.Text = String.Empty;
                    phoneTxt.Text = String.Empty;
                    addressTxt.Text = String.Empty;
                    adminIdText.Text = String.Empty;

                    fullnameTxt.Focus();
                }


                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM attendant WHERE 1", connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);

                attendantsDataGrid.DataSource = dt;
            }
        }
    }
}
