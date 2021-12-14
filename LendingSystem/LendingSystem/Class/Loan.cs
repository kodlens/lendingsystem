using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C1.Win.C1FlexGrid;
using MySql.Data.MySqlClient;

namespace LendingSystem
{
    class Loan
    {

        MySqlCommand cmd;
        MySqlConnection con;
        string query;

        public long member_id { set; get; }
        public string loan_title { set; get; }
        public string loan_type { set; get; }

        public double interest { set; get; }
        public double no_days_month { set; get; }
        public double amount_to_loan { set; get; }

        //child
        public long loan_id { set; get; }
        public DateTime date_month { set; get; }
        public double amount_to_pay { set; get; }
        public double amount_paid { set; get; }
        public double balance { set; get; }



        public void find(C1FlexGrid flx, string lname, string fname)
        {
            con = Connection.con();
            con.Open();
            query = @"SELECT *, amount_to_loan - (SELECT SUM(amount_paid) FROM loan_details WHERE loan_details.loan_id = a.loan_id) AS balance
                    FROM loans a join members b on a.member_id = b.member_id WHERE b.lname LIKE ?lname and b.fname LIKE ?fname 
                    ORDER BY loan_id desc";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?lname", lname + "%");
            cmd.Parameters.AddWithValue("?fname", fname + "%");
            DataTable dt = new DataTable();
            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
            adptr.Fill(dt);
            adptr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            flx.AutoGenerateColumns = false;
            flx.DataSource = dt;
        }

        public int delete(long id)
        {
            int i = 0;
            con = Connection.con();
            con.Open();
            query = "DELETE FROM loans WHERE loan_id=?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?id", id);
            i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return i;
        }
    }
}
