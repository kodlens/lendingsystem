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

        protected MySqlCommand cmd;
        protected MySqlConnection con;
        protected string query;

        public long member_id { set; get; }
        public string loan_title { set; get; }
        public string loan_type { set; get; }

        public double interest { set; get; }
        public double interest_amount { set; get; }
        public int no_days_month { set; get; }
        public double amount_to_loan { set; get; }
        public double total_amount { set; get; }
        public DateTime loan_date { set; get; }

        //child
        public long loan_id { set; get; }
        public DateTime date_month { set; get; }
        public double amount_to_pay { set; get; }
        public double amount_paid { set; get; }
        public double balance { set; get; }



        public void find(C1FlexGrid flx,string lid, string lname, string fname)
        {
            con = Connection.con();
            con.Open();
            query = @"SELECT *, (amount_to_loan + (interest_amount * no_days_month)) - (SELECT SUM(amount_paid) FROM loan_details WHERE loan_details.loan_id = a.loan_id) AS balance
                    FROM loans a join members b on a.member_id = b.member_id WHERE a.loan_id LIKE ?lid AND b.lname LIKE ?lname and b.fname LIKE ?fname 
                    ORDER BY loan_id desc";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?lid", lid + "%");
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


        public void save(C1FlexGrid flx)
        {
           
            con = Connection.con();
            con.Open();
            query = "INSERT INTO loans SET member_id=?mid, loan_title = ?ltitle, loan_type=?ltype, interest=?interest, interest_amount=?insamt, no_days_month=?ndm, amount_to_loan=?atl, total_amount=?tamt, loan_date=?ldate, created_at=now();" +
                "select last_insert_id();";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?mid", member_id);
            cmd.Parameters.AddWithValue("?ltitle", this.loan_title);
            cmd.Parameters.AddWithValue("?ltype", this.loan_type);
            cmd.Parameters.AddWithValue("?interest", this.interest);
            cmd.Parameters.AddWithValue("?insamt", this.interest_amount);
            cmd.Parameters.AddWithValue("?ndm", this.no_days_month);
            cmd.Parameters.AddWithValue("?atl", this.amount_to_loan);
            cmd.Parameters.AddWithValue("?tamt", this.total_amount);
            cmd.Parameters.AddWithValue("?ldate", this.loan_date.ToString("yyyy-MM-dd"));
            this.loan_id = Convert.ToInt64(cmd.ExecuteScalar());
           
            cmd.Dispose();

            query = "INSERT INTO loan_details SET loan_id=?lid, date_month=?dmonth, amount_to_pay=?atopay, amount_paid=?apaid, balance=?bal;" +
                "select last_insert_id();";
            cmd = new MySqlCommand(query, con);
            for (int row = 1; row < flx.Rows.Count; row++)
            {
                cmd.Parameters.AddWithValue("?lid", this.loan_id);
                cmd.Parameters.AddWithValue("?dmonth", Convert.ToDateTime(flx[row, "date_month"]));
                cmd.Parameters.AddWithValue("?atopay", Convert.ToDouble(flx[row, "amountToPay"]));
                cmd.Parameters.AddWithValue("?apaid", Convert.ToDouble(flx[row, "amountPaid"]));
                cmd.Parameters.AddWithValue("?bal", Convert.ToString(flx[row, "balance"]));
                long loan_detail_id = Convert.ToInt64(cmd.ExecuteScalar());
                flx[row, "loan_detail_id"] = loan_detail_id;
                cmd.Parameters.Clear();
            }

            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        public void update(C1FlexGrid flx, long param_id)
        {
            con = Connection.con();
            con.Open();
            query = @"UPDATE loans SET member_id=?mid, loan_title = ?ltitle, loan_type=?ltype, interest=?interest, interest_amount=?insamt, no_days_month=?ndm, amount_to_loan=?atl, total_amount=?tamt, loan_date=?ldate WHERE loan_id=?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?mid", this.member_id);
            cmd.Parameters.AddWithValue("?ltitle", this.loan_title);
            cmd.Parameters.AddWithValue("?ltype", this.loan_type);
            cmd.Parameters.AddWithValue("?interest", this.interest);
            cmd.Parameters.AddWithValue("?insamt", this.interest_amount);
            cmd.Parameters.AddWithValue("?ndm", this.no_days_month);
            cmd.Parameters.AddWithValue("?atl", this.amount_to_loan);
            cmd.Parameters.AddWithValue("?tamt", this.total_amount);
            cmd.Parameters.AddWithValue("?ldate", this.loan_date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?id", param_id);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            query = @"UPDATE loan_details SET loan_id=?lid, date_month=?dmonth, amount_to_pay=?atopay, amount_paid=?apaid, balance=?bal WHERE loan_detail_id=?id";
            cmd = new MySqlCommand(query, con);
            for (int row = 1; row < flx.Rows.Count; row++)
            {
                cmd.Parameters.AddWithValue("?lid", param_id);
                cmd.Parameters.AddWithValue("?dmonth", Convert.ToDateTime(flx[row, "date_month"]));
                cmd.Parameters.AddWithValue("?atopay", Convert.ToDouble(flx[row, "amountToPay"]));
                cmd.Parameters.AddWithValue("?apaid", Convert.ToDouble(flx[row, "amountPaid"]));
                cmd.Parameters.AddWithValue("?bal", Convert.ToString(flx[row, "balance"]));
                cmd.Parameters.AddWithValue("?id", Convert.ToString(flx[row, "loan_detail_id"]));
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }

            con.Close();
            con.Dispose();

        }

        public void closeLoan(long id)
        {
            con = Connection.con();
            con.Open();
            query = "UPDATE loans SET is_close = 1 WHERE loan_id=?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?id", id);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }
        public void openLoan(long id)
        {
            con = Connection.con();
            con.Open();
            query = "UPDATE loans SET is_close = 0 WHERE loan_id=?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?id", id);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
