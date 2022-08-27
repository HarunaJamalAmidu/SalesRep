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
    public partial class ManInTheMiddle : Form
    {
        public ManInTheMiddle()
        {
            InitializeComponent();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login logins = new();
            logins.Show();
        }

        private void ProceedBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EMPLOYEES emps = new();
            emps.Show();
        }
    }
}
