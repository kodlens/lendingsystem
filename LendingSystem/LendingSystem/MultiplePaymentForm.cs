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



namespace LendingSystem
{

    public partial class MultiplePaymentForm : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;



        public MultiplePaymentForm()
        {
            InitializeComponent();
        }


        public void loadData()
        {

            this.flx.Rows.Count = this.flx.Rows.Fixed;
            //query = @"SELECT
            //    a.loan_id, b.loan_detail_id, a.member_id, a.loan_title,
            //    a.loan_type, a.interest, a.interest_amount, a.no_days_month,
            //    a.amount_to_loan, a.total_amount, a.loan_date, b.date_month,
            //    b.amount_paid, b.amount_to_pay, b.balance, a.member_id,
            //    c.lname, c.fname, c.mname,
            //    (
	           //     SELECT  loans.total_amount - SUM(amount_paid) FROM loan_details
	           //     JOIN loans ON loan_details.loan_id = loans.loan_id
	           //     WHERE loan_details.loan_id = a.loan_id
            //    ) AS 'total_balance'
            //    FROM loans a
            //    JOIN loan_details b ON a.loan_id = b.loan_id
            //    JOIN members c ON a.member_id = c.member_id
            //    WHERE b.date_month = CURDATE() AND a.is_close = 0 
            //    AND c.lname LIKE ?lname AND fname LIKE ?fname ORDER BY c.lname ASC;";

            con = Connection.con();
            con.Open();
            query = "proc_members_to_pay";
            cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("?vdate", dtDate.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?vlname", txtlname.Text);
            cmd.Parameters.AddWithValue("?vfname", txtfname.Text);
            DataTable dt = new DataTable();
            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
            adptr.Fill(dt);
            adptr.Dispose();
            cmd.Dispose();

            con.Close();
            con.Dispose();

            int rowSize = dt.Rows.Count; //inspired by ROMANA 
            string lname = "", fname = "", mname = "";

            if (rowSize > 0)
            {
                for(int row = 0; row < rowSize; row++)
                {
                    this.flx.Rows.Add();
                    this.flx[row + 1, "loan_detail_id"] = Convert.ToInt64(dt.Rows[row]["loan_detail_id"]);
                    fname = Convert.ToString(dt.Rows[row]["fname"]);
                    lname = Convert.ToString(dt.Rows[row]["lname"]);
                    mname = Convert.ToString(dt.Rows[row]["mname"]);

                    this.flx[row+1, "fullname"] = lname + ", " + fname + " " + mname;
                    this.flx[row+1, "date_payment"] = Convert.ToDateTime(dt.Rows[row]["date_month"]);
                    this.flx[row + 1, "loan_type"] = Convert.ToString(dt.Rows[row]["loan_type"]);
                    this.flx[row + 1, "amount_to_pay"] = Convert.ToDouble(dt.Rows[row]["amount_to_pay"]);
                    this.flx[row + 1, "amountPaid"] = Convert.ToDouble(dt.Rows[row]["amount_paid"]); ;
                    this.flx[row + 1, "total_balance"] = Convert.ToDouble(dt.Rows[row]["total_balance"]);
                }
            }
           
        }

        private void MultiplePaymentForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
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

        private void txtlname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            updateRecord();
            try
            {
                if (this.flx.Rows.Count > 1)
                {
                    
                    Box.InfoBox("Record successfully updated.");
                }
            }
            catch (Exception er) { 
            
                Box.ErrBox(er.Message);
            }
            
        }

        void updateRecord()
        {
            con = Connection.con();
            con.Open();
            query = "UPDATE loan_details SET amount_paid = ?amtpaid WHERE loan_detail_id = ?id";
            cmd = new MySqlCommand(query, con);
            long id = 0;
            int rowSize = this.flx.Rows.Count;
            for(int row = 0; row < rowSize - 1; row++)
            {
                id = Convert.ToInt64(this.flx[row + 1, "loan_detail_id"]);
                cmd.Parameters.AddWithValue("?amtpaid", Convert.ToDouble(this.flx[row + 1, "amountPaid"]));
                cmd.Parameters.AddWithValue("?id", id);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }

            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        private void dtDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    loadData();
                }
            }
            catch (Exception err)
            {
                Box.ErrBox(err.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ToPayListForm))
                {
                    form.Activate();
                    return;
                }
            }

            ToPayListForm frm = new ToPayListForm();
            frm.ndate = dtDate.Value.ToString("yyyy-MM-dd");
            frm.Show();
        }
    }
}
