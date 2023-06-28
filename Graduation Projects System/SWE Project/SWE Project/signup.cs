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
    public partial class Signup : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn=new OracleConnection();
        public static Signup log;
        public Signup()
        {
            InitializeComponent();
            log = this;
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select STUD_ID from STUDENTS";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               
            }
            dr.Close();


        }
        private void signup_Click(object sender, EventArgs e)
        {
            if (stud_chick.Checked == true)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into STUDENTS values (:STUD_ID,:USERNAME,:PASS)";
                   cmd.Parameters.Add("STUD_ID", ID.Text);
                cmd.Parameters.Add("USERNAME", username.Text);
                cmd.Parameters.Add("PASS", Pass.Text);
             
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {

                    MessageBox.Show("New Student is added");
                }
            }
            else if(TA_check.Checked == true)
            {

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into TAINFO values (:TAID,:TANAME,:TAPASS)";
                cmd.Parameters.Add("ID", ID.Text);
                cmd.Parameters.Add("USERNAME", username.Text);
                cmd.Parameters.Add("PASS", Pass.Text);
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {

                    MessageBox.Show("New TA is added");
                }

            }
            else
                MessageBox.Show("Please, check Student or Teacher");


        }
                
               
        private void Student_chick(object sender, EventArgs e)
        {

        }

        private void Teacher_chick(object sender, EventArgs e)
        {

        }

        private void Username_txt(object sender, EventArgs e)
        {

        }

        private void pass_txt(object sender, EventArgs e)
        {

        }

        private void ID_txt(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
