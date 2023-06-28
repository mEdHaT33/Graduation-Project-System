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
    public partial class mainform : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn = new OracleConnection();
        public mainform()
        {
            InitializeComponent();
        }

        private void signupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Signup x = new Signup();
            x.Show();
        }

        private void tAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TA x = new TA();
            x.Show();
            
        }


        private void report1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           Report x = new Report();
            x.Show();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            //conn = new OracleConnection(ordb);
            //conn.Open();

            //OracleCommand cmd = new OracleCommand();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stud x = new stud();
            x.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login x = new login();
            x.Show();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Studrep x = new Studrep();
            x.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
