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

namespace Programming_Grifindo
{
    public partial class Salary : Form
    {
       

        SqlConnection con = new SqlConnection("Data Source=MSI\\SQLEXPRESS01;Initial Catalog=Grifindotoys;Integrated Security=True;Encrypt=False");
      

        public Salary()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            this.Hide();
            db.Show();
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            loadelement();
            getempdata();
            GetsettingData();
            Calculate();
            con.Open();
            string insert = "Insert into Salary Values('" + salid + "', '"+ salbegindate +"' , '"+ salenddate +"', '"+ noOfleaves +"', '"+ othours +"', '"+ nopay +"', '"+ basepay +"', '"+ grosspay +"')";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadGrid();

            txtnoleaves.Clear();
            txtOThours.Clear();
            txtnopay.Clear();
            txtbasep.Clear();
            txtgross.Clear();
            txtempid.Clear();
            txtsalid.Focus();   
        }

        int salid, noOfleaves, othours, nopay, basepay, grosspay, empID, dbmonthsal, dballow, dbotrate;
        DateTime salbegindate, salenddate;

        private void loadelement()
        {
            salid = int.Parse(txtsalid.Text);
            salbegindate = datebegin.Value.Date;
            salenddate = dateend.Value.Date;
            noOfleaves = int.Parse(txtnoleaves.Text);
            othours = int.Parse(txtOThours.Text);
            empID = int.Parse(txtempid.Text);
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        int salarycircle;
        DateTime begind, endd;

        private void GetsettingData()
        {
            con.Open();
            string Query = "Select * from Settings Where Setting_ID = '"+1+"'";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                salarycircle = int.Parse(reader["Sal_cycle_date_range"].ToString().Trim());
                begind = DateTime.Parse(reader["Cycle_bdate"].ToString().Trim());
                endd = DateTime.Parse(reader["Cycle_edate"].ToString().Trim());
            }
            con.Close();
        }

        //Loads Employee data into salary
        private void getempdata()
        {
            
                con.Open();
                string Query = "Select * from Employee Where Employee_ID = '" + empID +"'";
                SqlCommand cmd = new SqlCommand(Query,con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dbmonthsal = int.Parse(reader["Monthly_sal"].ToString().Trim());
                    dballow = int.Parse(reader["Allowence"].ToString().Trim());
                    dbotrate = int.Parse(reader["OT_Rate"].ToString().Trim());
                }
                con.Close();
        }
        int ot;
        private void Calculate()
        {
            ot = othours * dbotrate;
            basepay = dbmonthsal + dballow + ot;
            nopay = (basepay / salarycircle) * noOfleaves;
            grosspay = basepay - nopay;

            txtbasep.Text = basepay.ToString();
            txtgross.Text = grosspay.ToString();
            
            
        }

        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtOThours_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void saldatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void LoadGrid()
        {
            con.Open();
            string querry = "select * from Salary";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            saldatagrid.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

    }
}
