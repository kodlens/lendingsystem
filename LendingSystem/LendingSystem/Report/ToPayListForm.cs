using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LendingSystem.Report;

namespace LendingSystem
{
    public partial class ToPayListForm : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        public string ndate;

        public ToPayListForm()
        {
            InitializeComponent();
        }

        void loadData()
        {
            con = Connection.con();
            con.Open();
            query = "proc_members_to_pay";
            cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("?vdate", ndate);
            cmd.Parameters.AddWithValue("?vlname", "");
            cmd.Parameters.AddWithValue("?vfname", "");
            DataTable dt = new DataTable();
            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
            adptr.Fill(dt);
            adptr.Dispose();
            cmd.Dispose();

            con.Close();
            con.Dispose();

            ToPayListReport rpt = new ToPayListReport();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;

        }

        private void ToPayListForm_Load(object sender, EventArgs e)
        {
            try
            {
                loadData();
            }
            catch (Exception err)
            {
                Box.ErrBox(err.Message);
            }
        }
    }
}
