using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesRep;

namespace SalesRep
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            PasswordBox.Text = "";
            EmailBox.Text = "";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SmartToll1._0.Admin hs = new();
            hs.Show();
        }
    }
}
