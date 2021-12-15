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
                this.member_id = Convert.ToInt64(dt.Rows[0]["member_id"]);
                this.fname = Convert.ToString(dt.Rows[0]["fname"]);
                this.mname = Convert.ToString(dt.Rows[0]["mname"]);
                this.lname = Convert.ToString(dt.Rows[0]["lname"]);
                this.loan_title = Convert.ToString(dt.Rows[0]["loan_title"]);
                this.loan_type = Convert.ToString(dt.Rows[0]["loan_type"]);
                this.interest = Convert.ToDouble(dt.Rows[0]["interest"]);
                this.interest_amount = Convert.ToDouble(dt.Rows[0]["interest_amount"]);
                this.no_days_month = Convert.ToInt32(dt.Rows[0]["no_days_month"]);
                this.amount_to_loan = Convert.ToDouble(dt.Rows[0]["amount_to_loan"]);
                this.total_amount = Convert.ToDouble(dt.Rows[0]["total_amount"]);


                flx.Rows.Count = flx.Rows.Fixed;
                int monthDay = Convert.ToInt32(dt.Rows[0]["no_days_month"]);
                for (int row = 1; row <= monthDay; row++)
                {
                    flx.Rows.Add();
                    flx[row, "loan_detail_id"] = Convert.ToInt64(dt.Rows[row - 1]["loan_detail_id"]);
                    flx[row, "date_month"] = Convert.ToString(dt.Rows[row - 1]["date_month"]);
                    flx[row, "amountToPay"] = Convert.ToString(dt.Rows[row - 1]["amount_to_pay"]);
                    flx[row, "amountPaid"] = Convert.ToDouble(dt.Rows[row - 1]["amount_paid"]);
                    flx[row, "balance"] = Convert.ToDouble(dt.Rows[row - 1]["balance"]);
                }
                
            }



        }

    }
}
