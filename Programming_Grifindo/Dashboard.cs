using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Grifindo
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnemp_Click(object sender, EventArgs e)
        {
            Employee newform = new Employee();
            this.Hide();
            newform.Show();
        }

        private void btnsal_Click(object sender, EventArgs e)
        {
            Salary sal = new Salary();
            this.Hide();
            sal.Show();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            Settings sett = new Settings();
            this.Hide();
            sett.Show();
        }
    }
}
