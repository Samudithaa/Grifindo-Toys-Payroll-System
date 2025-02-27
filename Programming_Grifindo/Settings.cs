using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Grifindo
{
    public partial class Settings : Form
    {
        SqlConnection con = new SqlConnection("Data Source=MSI\\SQLEXPRESS01;Initial Catalog=Grifindotoys;Integrated Security=True;Encrypt=False");
        int settID, noOfleaves, salcycledaternge;
        DateTime cyclebegindate, cycleenddate;

        public Settings()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            this.Hide();
            db.Show();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            LoadElement();
            con.Open();
            string insert = "Insert into Settings Values('" + settID + "', '" + noOfleaves + "' , '" + salcycledaternge + "', '" + cyclebegindate + "', '"+cycleenddate+"') ";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadGrid();
            txtsetid.Clear();
            txtsaldrange.Clear();
            txtsetid.Focus();
        }

        private void LoadElement()
        {
            settID = int.Parse(txtsetid.Text);
            noOfleaves = int.Parse(txtleaves.Text);
            salcycledaternge = int.Parse(txtsaldrange.Text);
            cyclebegindate = txtcyclebegindate.Value.Date;
            cycleenddate = txtcycleenddate.Value.Date;
        }

        private void LoadGrid()
        {
            con.Open();
            string querry = "select * from Settings";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }
    }
}
