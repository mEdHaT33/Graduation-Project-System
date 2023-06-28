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
    public partial class Report : Form
    {
        TAreport tr;
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn = new OracleConnection();
        public Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tr_viewer.ReportSource = tr;
        }

        private void Report_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            tr = new TAreport();
        }

        private void tr_viewer_Load(object sender, EventArgs e)
        {

        }
    }
}
