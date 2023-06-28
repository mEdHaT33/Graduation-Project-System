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
   
    public partial class login : Form
    {
        public static login log;
        
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn = new OracleConnection();
     
        public login()
        {
            InitializeComponent();
            log = this;
          
        }
        private void Signup(object sender, EventArgs e)
        {
            Signup form = new Signup();
            form.Show();
            this.Close();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select STUD_ID from STUDENTS";
            cmd.CommandType = CommandType.Text;

          
        }

        private void Login(object sender, EventArgs e)
        {
            int x = 0;
            if (x == 0)
            {
                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandText = "select USERNAME,PASS from STUDENTS where PASS= '" + pass.Text + "' and USERNAME= '" + user_name.Text + "'";
                c.CommandType = CommandType.Text;
                c.Parameters.Add(":user_n", user_name.Text);
                c.Parameters.Add(":pass", pass.Text);
                OracleDataReader dr = c.ExecuteReader();
                if (dr.Read())
                {

                    stud form = new stud();
                    form.Show();
                    this.Close();

                }

                else
                {
                    x = 1;
                }
                dr.Close();
            }
            //---------------------------------------------------------------------
            if (x == 1)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select USERNAME,PASS from TEACHER where PASS= '" + pass.Text + "' and USERNAME= '" + user_name.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(":user_n", user_name.Text);
                cmd.Parameters.Add(":pass", pass.Text);
                OracleDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {

                    TA form = new TA();
                    form.Show();
                    this.Close();

                }

                else
                {
                    MessageBox.Show("error");
                }
                r.Close();
            }
        }
      
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Username(object sender, EventArgs e)
        {

        }

        private void Password(object sender, EventArgs e)
        {

        }
    }
}
