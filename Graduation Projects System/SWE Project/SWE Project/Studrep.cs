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
    public partial class Studrep : Form
    {
        stud_Project st;
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn = new OracleConnection();
        public Studrep()
        {
            InitializeComponent();
        }

        private void Show_Report_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = st;
        }

        private void Studrep_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            st = new stud_Project();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
