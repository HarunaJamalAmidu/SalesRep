using MySql.Data.MySqlClient;
using SmartToll1._0;
using System.Data;

namespace SalesRep
{
    public partial class Login : Form
    {
        public static string connectionString = "server=localhost;database=salesrep;Port=3307;uid=root; pwd=\"\";";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        public Login()
        {
            InitializeComponent();

        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            PasswordBox.Text = "";
            EmailBox.Text = "";
            RoleBox.Text = "";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string UserEmail, userPassword, roleChecker;
            UserEmail = EmailBox.Text;
            userPassword = PasswordBox.Text;
            roleChecker = RoleBox.Text.ToUpper();

            try
            {
                string query = "SELECT `email`, `role`, `password` FROM employeedata WHERE  email = '" + EmailBox.Text + "' AND role = '" + RoleBox.Text + "' AND password = '" + PasswordBox.Text + "'";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    UserEmail = EmailBox.Text;
                    userPassword = PasswordBox.Text;
                    roleChecker = RoleBox.Text.ToUpper();
                    
                    if (roleChecker == "ADMIN")
                    {
                        this.Hide();
                        ManInTheMiddle mitm = new();
                        mitm.Show();
                    }
                    
                    if (roleChecker == "USER")
                    {
                        this.Hide();
                        Sales user = new();
                        user.Show();
                    }
                }

                else
                {
                    MessageBox.Show("Please enter a valid Email or password");
                    EmailBox.Clear();
                    PasswordBox.Clear();
                    RoleBox.Clear();
                    EmailBox.Focus();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }



        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }

    //private void RadioButton1_CheckedChanged(object sender, EventArgs e)
    //{

    //}
}
