using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace Programming_Grifindo
{
    public partial class Employee : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS01;Initial Catalog=Grifindotoys;Integrated Security=True;Encrypt=False");
        int id, monthsal, allow, otr;
        string name;

        private void btninsert_Click(object sender, EventArgs e)
        {
            LoadElement();
            conn.Open();
            string insert = "Insert into Employee(Employee_ID,Name,Monthly_sal,Allowence,OT_Rate) values ('" + id + "', '" + name + "', '" + monthsal + "', '" + allow + "', '" + otr + "')";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Add");
            conn.Close();
            LoadGrid();
            MessageBox.Show("Employee added successfully!");
            txtempid.Clear();
            txtname.Clear();
            txtmonsal.Clear();
            txtallow.Clear();
            txtot.Clear();
            txtempid.Focus();
        }

        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindotoysDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.grifindotoysDataSet.Employee);

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            LoadElement();
            conn.Open();
            string update = "update Employee set Name='" + name + "', Monthly_sal='" + monthsal + "', Allowence='" + allow + "',OT_Rate='" + otr + "' where Employee_ID= '" + id + "'";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update");
            conn.Close();
            LoadGrid();
            MessageBox.Show("Employee updated successfully!");
            txtempid.Clear();
            txtname.Clear();
            txtmonsal.Clear();
            txtallow.Clear();
            txtot.Clear();
            txtempid.Focus();
        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            id = int.Parse(txtempid.Text);
            conn.Open();
            string delete = "delete from Employee where Employee_ID= '" + id + "'";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete");
            conn.Close();
            LoadGrid();
            MessageBox.Show("Employee deleted successfully!");
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void empdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadElement()
        {
            id = int.Parse(txtempid.Text);
            name = txtname.Text;
            monthsal = int.Parse(txtmonsal.Text);
            allow = int.Parse(txtallow.Text);
            otr = int.Parse(txtot.Text);
        }

        private void LoadGrid()
        {
            conn.Open();
            string querry = "select * from Employee";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            empdatagrid.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            this.Hide();
            db.Show();
        }
    }
}

