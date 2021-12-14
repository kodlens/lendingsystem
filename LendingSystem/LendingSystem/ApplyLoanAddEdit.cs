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
    public partial class ApplyLoanAddEdit : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;


        public long id;
        public long member_id;

        ApplyLoanMainForm _frm;

        decimal months_days, roi, amt, interest, ins, insAmount;

        public ApplyLoanAddEdit(ApplyLoanMainForm _frm)
        {
            InitializeComponent();
            this._frm = _frm;
        }

        private void btnBrowseMember_Click(object sender, EventArgs e)
        {
            ApplyLoanBrowseMember frm = new ApplyLoanBrowseMember(this);
            frm.ShowDialog();
        }




        void loadDailyToFlxGrid(decimal amtToPay)
        {
            flx.Rows.Count = flx.Rows.Fixed;
            for(int row = 1; row <= numDayMonth.Value; row++)
            {
                flx.Rows.Add();
                var addedDateTime = DateTime.Now.AddDays(row);
                flx[row, "date_month"] = addedDateTime;
                flx[row, "amountPaid"] = 0.00;
                flx[row, "amountToPay"] = amtToPay;
                flx[row, "balance"] = amtToPay;
            }
           
        }

        void loadMonthlyToFlxGrid(decimal amtToPay)
        {
            flx.Rows.Count = flx.Rows.Fixed;
            for (int row = 1; row <= numDayMonth.Value; row++)
            {
                flx.Rows.Add();
                var addedDateTime = DateTime.Now.AddMonths(row);
                flx[row, "date_month"] = addedDateTime;
                flx[row, "amountToPay"] = amtToPay;
                flx[row, "amountPaid"] = 0.00;
                flx[row, "balance"] = amtToPay;
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            //compute
            try
            {
                if (String.IsNullOrEmpty(this.cmbLoanType.Text))
                {
                    Box.WarnBox("Please select loan type.");
                    return;
                }

                if (numInterest.Value < 1)
                {
                    Box.WarnBox("Please input interest.");
                    return;
                }

                if (numDayMonth.Value < 1)
                {
                    Box.WarnBox("Please input no of day or month.");
                    return;
                }


                compute();

                lblAmountToPay.Text = String.Format("{0:n}", ins);

                if (this.cmbLoanType.Text == "DAILY")
                {
                    loadDailyToFlxGrid(ins);
                }

                if (this.cmbLoanType.Text == "MONTHLY")
                {
                    loadMonthlyToFlxGrid(ins);
                }

            }
            catch (Exception er)
            {
                Box.ErrBox(er.Message);
                //throw;
            }
        }

        void compute()
        {
            amt = numAmountToLoan.Value;
            interest = numInterest.Value;
            months_days = numDayMonth.Value;
            roi = amt / interest;
            ins = amt / months_days + roi;
            ins = Decimal.Round(ins, 2);
            lblAmountToPay.Text = String.Format("{0:n}", ins);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLoanTitle.Text))
            {
                Box.WarnBox("Please input loan title.");
                return;
            }

            if(member_id < 1)
            {
                Box.WarnBox("Please select a member.");
                return;
            }

            if(id > 0)
            {
                update();
                Box.InfoBox("Loan successfully updated.");
            }
            else
            {
                save();
                Box.InfoBox("Loan successfully saved.");
            }

            _frm.loadData();
        }


        void save()
        {
            //here na nako gebutang.. getapulan nako buhat class hahaha
            con = Connection.con();
            con.Open();
            query = "INSERT INTO loans SET member_id=?mid, loan_title = ?ltitle, loan_type=?ltype, interest=?interest, no_days_month=?ndm, amount_to_loan=?atl;" +
                "select last_insert_id();";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?mid", member_id);
            cmd.Parameters.AddWithValue("?ltitle", txtLoanTitle.Text);
            cmd.Parameters.AddWithValue("?ltype", cmbLoanType.Text);
            cmd.Parameters.AddWithValue("?interest", numInterest.Value);
            cmd.Parameters.AddWithValue("?ndm", numDayMonth.Value);
            cmd.Parameters.AddWithValue("?atl", numAmountToLoan.Value);
            id = Convert.ToInt64(cmd.ExecuteScalar());
            txtReference.Text = id.ToString("00000000");
            cmd.Dispose();

            query = "INSERT INTO loan_details SET loan_id=?lid, date_month=?dmonth, amount_to_pay=?atopay, amount_paid=?apaid, balance=?bal;" +
                "select last_insert_id();";
            cmd = new MySqlCommand(query, con);
            for(int row = 1; row < flx.Rows.Count; row++)
            {
                cmd.Parameters.AddWithValue("?lid", id);
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

        void update()
        {
            con = Connection.con();
            con.Open();
            query = @"UPDATE loans SET member_id=?mid, loan_title = ?ltitle, loan_type=?ltype, interest=?interest, no_days_month=?ndm, amount_to_loan=?atl WHERE loan_id=?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?mid", member_id);
            cmd.Parameters.AddWithValue("?ltitle", txtLoanTitle.Text);
            cmd.Parameters.AddWithValue("?ltype", cmbLoanType.Text);
            cmd.Parameters.AddWithValue("?interest", numInterest.Value);
            cmd.Parameters.AddWithValue("?ndm", numDayMonth.Value);
            cmd.Parameters.AddWithValue("?atl", numAmountToLoan.Value);
            cmd.Parameters.AddWithValue("?id", this.id);
            cmd.ExecuteNonQuery();
            cmd.Dispose();


            query = @"UPDATE loan_details SET loan_id=?lid, date_month=?dmonth, amount_to_pay=?atopay, amount_paid=?apaid, balance=?bal WHERE loan_detail_id=?id";
            cmd = new MySqlCommand(query, con);
            for (int row = 1; row < flx.Rows.Count; row++)
            {
                cmd.Parameters.AddWithValue("?lid", id);
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

        private void btnDebug_Click(object sender, EventArgs e)
        {
            txtLoanTitle.Text = "TEST ONLY";
            cmbLoanType.Text = "MONTHLY";
            numInterest.Value = 10;
            numDayMonth.Value = 5;
            numAmountToLoan.Value = 5000;

            btnCompute_Click(sender, e);
        }

        private void flx_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if(e.Col == 4)
            {
                double amountToPay = Convert.ToDouble(flx[flx.RowSel, "amountToPay"]);
                double amountPaid = Convert.ToDouble(flx[flx.RowSel, "amountPaid"]);
                
                flx[e.Row, 5] = (amountToPay - amountPaid) > 0 ? amountToPay - amountPaid : 0;
            }
        }

     

        void getData()
        {
            con = Connection.con();
            con.Open();
            query = @"SELECT * FROM loans a join loan_details b on a.loan_id = b.loan_id 
                    join members c on a.member_id = c.member_id WHERE a.loan_id = ?lid";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?lid", this.id);
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
                this.txtLoanTitle.Text = Convert.ToString(dt.Rows[0]["loan_title"]);
                this.txtlname.Text = Convert.ToString(dt.Rows[0]["lname"]);
                this.txtfname.Text = Convert.ToString(dt.Rows[0]["fname"]);
                this.txtfname.Text = Convert.ToString(dt.Rows[0]["mname"]);
                this.cmbLoanType.Text = Convert.ToString(dt.Rows[0]["loan_type"]);
                this.numInterest.Value = Convert.ToInt32(dt.Rows[0]["interest"]);
                this.numDayMonth.Value = Convert.ToInt32(dt.Rows[0]["no_days_month"]);
                this.numAmountToLoan.Value = Convert.ToDecimal(dt.Rows[0]["amount_to_loan"]);

                //compute
                this.compute();

                flx.Rows.Count = flx.Rows.Fixed;
                int monthDay = Convert.ToInt32(dt.Rows[0]["no_days_month"]);
                for (int row = 1; row <= monthDay; row++)
                {
                    flx.Rows.Add();
                    flx[row, "loan_detail_id"] = Convert.ToInt64(dt.Rows[row-1]["loan_detail_id"]);
                    flx[row, "date_month"] = Convert.ToString(dt.Rows[row - 1]["date_month"]);
                    flx[row, "amountToPay"] = Convert.ToString(dt.Rows[row - 1]["amount_to_pay"]);
                    flx[row, "amountPaid"] = Convert.ToDouble(dt.Rows[row - 1]["amount_paid"]);
                    flx[row, "balance"] = Convert.ToDouble(dt.Rows[row - 1]["balance"]);

                    //flx[row, "date_month"] = addedDateTime;
                    //flx[row, "amountToPay"] = amtToPay;
                }

            }
        }

        private void ApplyLoanAddEdit_Load(object sender, EventArgs e)
        {
            if(id > 0)
            {
                getData();
                disableFields();
            }
        }

        void disableFields()
        {
            this.numInterest.ReadOnly = true;
            this.numDayMonth.ReadOnly = true;
            this.numAmountToLoan.ReadOnly = true;
            this.txtLoanTitle.ReadOnly = true;
            this.cmbLoanType.Enabled = false;
            this.btnCompute.Enabled = false;
            this.btnBrowseMember.Enabled = false;
        }
        void enableFields()
        {
            this.numInterest.ReadOnly = false;
            this.numDayMonth.ReadOnly = false;
            this.numAmountToLoan.ReadOnly = false;
            this.txtLoanTitle.ReadOnly = false;
            this.cmbLoanType.Enabled = true;
            this.btnCompute.Enabled = true;
            this.btnBrowseMember.Enabled = true;

        }
    }
}
