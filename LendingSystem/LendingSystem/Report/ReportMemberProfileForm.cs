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
    public partial class ReportMemberProfileForm : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;


        public long id;

        public ReportMemberProfileForm()
        {
            InitializeComponent();
        }

        private void ReportMemberProfileForm_Load(object sender, EventArgs e)
        {
            
            //rpt.SetDataSource();
        }

        void loadReport()
        {
            con = Connection.con();
            con.Open();
            query = "select * from members where member_id = ?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?id", id);
            DataTable dt = new DataTable();
            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
            adptr.Fill(dt);

            adptr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            ReportMemberProfileRpt rpt = new ReportMemberProfileRpt();
            rpt.SetDataSource(dt);
        }
    }
}
