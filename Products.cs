using SmartToll1._0;

namespace SalesRep
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin hs = new();
            hs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employees emps = new();
            emps.Show();
        }
    }
}
