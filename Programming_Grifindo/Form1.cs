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
    public partial class Form1 : Form
    {
        string us, pw;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            us = txtus.Text;
            pw = txtpw.Text;

            if (us == "admin" && pw == "123")
            {
                MessageBox.Show("Login Success!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Dashboard newform = new Dashboard();
                this.Hide();
                newform.Show();
            }

            else
            {
                MessageBox.Show("Login Fail!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtus.Clear();
                txtpw.Clear();
                txtus.Focus();
            }
        }
    }
}
