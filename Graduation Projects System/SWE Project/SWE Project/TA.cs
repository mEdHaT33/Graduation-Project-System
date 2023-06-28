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
    public partial class TA : Form
    {
        OracleDataAdapter adabter;
        OracleCommandBuilder builder;
        DataSet dataset;

        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn = new OracleConnection();
        public static TA log;
        public TA()
        {
            InitializeComponent();
            log = this;
        }
        private void TA_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
        }
        private void update_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update TEACHERJOB set req=:req "; 
            cmd.Parameters.Add("req", Req.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show("req is uploaded");
            }
        }
        private void insert_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into TEACHERJOB values (:STUD_ID,:GRADES,:REQ)";
            cmd.Parameters.Add("grade", gradee.Text);
            cmd.Parameters.Add("sid", comboBox1.SelectedItem.ToString());
            cmd.Parameters.Add("req", Req.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show("Grade inserted..");
            }

        }
        private void stud_info(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "STUDINFO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("info", OracleDbType.RefCursor,ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
             
            }
            dr.Close();
        }
        private void TA_names_Click(object sender, EventArgs e)
        {
            string constr = "User Id=scott;Password=tiger;Data Source=orcl";
            string cmdstr = "select TANAME,TAID from TAINFO ";
            OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, constr);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            tanames.DataSource = ds.Tables[0];
        }
        
        private void Savee(object sender, EventArgs e)
        {
          
            OracleCommandBuilder builder = new OracleCommandBuilder(adabter);
            tanames.DataSource = dataset.Tables[0];
           

        }









        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void req(object sender, EventArgs e)
        {

        }

        private void project_name(object sender, EventArgs e)
        {

        }

        private void project_name_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void studinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void gradee_TextChanged(object sender, EventArgs e)
        {

        }

        private void Grade_Click(object sender, EventArgs e)
        {

        }

       

        private void tanames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
