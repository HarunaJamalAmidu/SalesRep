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
    }
}
