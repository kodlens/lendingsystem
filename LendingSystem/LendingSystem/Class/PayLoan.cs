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
    class PayLoan : Loan
    {

        public string fname { set; get; }
        public string mname { set; get; }
        public string lname { set; get; }


        public void getData(C1FlexGrid flx, long id)
        {
            con = Connection.con();
            con.Open();
            query = @"SELECT * FROM loans a join loan_details b on a.loan_id = b.loan_id join members c on a.member_id = c.member_id WHERE a.loan_id = ?lid";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?lid", id);
            DataTable dt = new DataTable();
            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
            adptr.Fill(dt);
            adptr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();


            if(dt.Rows.Count > 0)
            {
                this.fname = Convert.ToString(dt.Rows[0]["fname"]);
                this.mname = Convert.ToString(dt.Rows[0]["mname"]);
                this.lname = Convert.ToString(dt.Rows[0]["lname"]);
                this.loan_title = Convert.ToString(dt.Rows[0]["loan_title"]);
                this.loan_type = Convert.ToString(dt.Rows[0]["loan_type"]);
                this.interest = Convert.ToDouble(dt.Rows[0]["interes"]);
                this.interest_amount = Convert.ToDouble(dt.Rows[0]["interest_amount"]);
                this.no_days_month = Convert.ToInt32(dt.Rows[0]["no_days_month"]);
                this.amount_to_loan = Convert.ToDouble(dt.Rows[0]["amount_to_loan"]);


            }
        }

    }
}
