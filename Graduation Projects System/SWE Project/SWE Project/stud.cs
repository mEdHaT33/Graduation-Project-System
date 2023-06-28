using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace SWE_Project
{
    public partial class stud : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn = new OracleConnection();
        public static stud log2;
        public stud()
        {
            InitializeComponent();
            log2 = this;
        }

        private void stud_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();


            string constr = "User Id=scott;Password=tiger;Data Source=orcl";
            string cmdstr = "select GRADES from TEACHERJOB where STUD_ID = :id ";
            OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("n", s_id.Text);
            adapter.SelectCommand.Parameters.Add("n", s_id.Text);
            adapter.SelectCommand.Parameters.Add("n", s_id.Text);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            grade_GridView.DataSource = ds.Tables[0];
            //cmd.Connection = conn;
            //cmd.CommandText = "insert into STUD_PROJECT values (:PROJECT_NAME,:STUD_ID,:STUDENT_NAME)";
            //cmd.Parameters.Add("p_name", p_name.Text);
            //cmd.Parameters.Add("s_id", s_id.Text);
            //cmd.Parameters.Add("s_name", s_name.Text);
            //int r = cmd.ExecuteNonQuery();
            //if (r != -1)
            //{

            //    MessageBox.Show("New project is Uploaded");
            //    p_name.Text = "";
            //    s_name.Text = "";
            //    s_id.Text = "";
            //}
        }

        private void Show_G_Click(object sender, EventArgs e)
        {
            string constr = "User Id=scott;Password=tiger;Data Source=orcl";
            string cmdstr = "select GRADES from TEACHERJOB where STUD_ID = :id ";
            OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("n", s_id.Text);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            grade_GridView.DataSource = ds.Tables[0];

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gradde_Click(object sender, EventArgs e)
        {

        }

        private void p_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void s_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void s_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void g_TextChanged(object sender, EventArgs e)
        {

        }

        private void gr(object sender, EventArgs e)
        {

        }

        private void grade_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grd_Click(object sender, EventArgs e)
        {

        }
    }
}
