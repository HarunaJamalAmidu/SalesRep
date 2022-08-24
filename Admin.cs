using MySql.Data.MySqlClient;
using SalesRep;
using System.Data;

namespace SmartToll1._0
{
    public partial class Admin : Form
    {
        public static string connectionString = "server=localhost;database=salesrep;Port=3307;uid=root; pwd=\"\";";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        public Admin()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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
            Products prods = new();
            prods.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SurNameBox.Text = "";
            GivenNameBox.Text = "";
            PhoneNoBox.Text = "";
            EmailBox.Text = "";
            BDaybox.Text = "";
            RoleBox.Text = "";

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

        private void ReportsGenPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
