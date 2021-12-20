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

        Loan loan;


        public long id;
        public long member_id;

        ApplyLoanMainForm _frm;

        decimal months_days, interest_value, principal_amount, interest, interest_amount, total_amount;

        public ApplyLoanAddEdit(ApplyLoanMainForm _frm)
        {
            InitializeComponent();
            this._frm = _frm;
            loan = new Loan();
        }

        private void btnBrowseMember_Click(object sender, EventArgs e)
        {
            ApplyLoanBrowseMember frm = new ApplyLoanBrowseMember(this);
            frm.ShowDialog();
        }




        void loadDailyToFlxGrid()
        {
            flx.Rows.Count = flx.Rows.Fixed;
            for(int row = 1; row <= numDayMonth.Value; row++)
            {
                flx.Rows.Add();
                //var addedDateTime = DateTime.Now.AddDays(row);
                var addedDateTime = dtLoan.Value.AddDays(row);
                flx[row, "date_month"] = addedDateTime;
                flx[row, "amountPaid"] = 0.00;
                flx[row, "amountToPay"] = interest_amount;
                flx[row, "balance"] = (double)interest_amount - Convert.ToDouble(flx[row, "amountPaid"]);
            }
           
        }

        void loadMonthlyToFlxGrid()
        {
            if(id > 0)
            {
                //update
                for (int row = 0; row < this.flx.Rows.Count - 1; row++)
                {
                    var addedDateTime = dtLoan.Value.AddMonths(row + 1);
                    flx[row + 1, "date_month"] = addedDateTime;
                    flx[row + 1, "amountToPay"] = interest_amount;
                    //flx[row, "amountPaid"] = 0.00;
                    flx[row, "balance"] = (double)interest_amount - Convert.ToDouble(flx[row, "amountPaid"]);
                }
            }
            else
            {
                //insert
                flx.Rows.Count = flx.Rows.Fixed;
                for (int row = 1; row <= numDayMonth.Value; row++)
                {
                    flx.Rows.Add();
                    //var addedDateTime = DateTime.Now.AddMonths(row);
                    var addedDateTime = dtLoan.Value.AddMonths(row);
                    flx[row, "date_month"] = addedDateTime;
                    flx[row, "amountToPay"] = interest_amount;
                    flx[row, "amountPaid"] = 0.00;
                    flx[row, "balance"] = (double)interest_amount - Convert.ToDouble(flx[row, "amountPaid"]);
                }
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

                if (this.cmbLoanType.Text == "DAILY")
                {
                    loadDailyToFlxGrid();
                }

                if (this.cmbLoanType.Text == "MONTHLY")
                {
                    loadMonthlyToFlxGrid();
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
            principal_amount = numAmountToLoan.Value;
            interest = numInterest.Value;
            months_days = numDayMonth.Value;

            interest_value = principal_amount * (interest / 100); //0.02 //100 for 5000, interest value from percentage

            total_amount = Decimal.Round(principal_amount + (interest_value * months_days), 2); //total amount with interest
            interest_amount = total_amount / months_days; //monthly or daily interest amount


            lblTotalAmount.Text = String.Format("{0:n}", total_amount); //total amount with interest
            lblInterestAmount.Text = String.Format("{0:n}", interest_value * months_days); //total interest
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLoanTitle.Text))
            {
                Box.WarnBox("Please input loan title.");
                return;
            }

            if(this.flx.Rows.Count < 2)
            {
                Box.WarnBox("No record(s) found.");
                return;
            }

            if(member_id < 1)
            {
                Box.WarnBox("Please select a member.");
                return;
            }

            //re compute again before saving
            //btnCompute_Click(null, null);
            
            if(Box.QBox("Please make sure you setup the loan properly, you cannot update the record anymore. Do you want to continue?"))
            {
                save();
                _frm.loadData();
            }
        }


        void save()
        {
            if (id > 0)
            {
                loan.member_id = this.member_id;
                loan.loan_title = this.txtLoanTitle.Text;
                loan.loan_type = this.cmbLoanType.Text;
                loan.interest = (double)this.numInterest.Value;
                loan.interest_amount = (double)(this.interest_value * months_days);
                loan.no_days_month = (int)this.numDayMonth.Value;
                loan.amount_to_loan = (double)this.principal_amount;
                loan.total_amount = (double)this.total_amount;
                loan.loan_date = dtLoan.Value;

                loan.update(this.flx, id);
                Box.InfoBox("Loan successfully updated.");
            }
            else
            {
                loan.member_id = this.member_id;
                loan.loan_title = this.txtLoanTitle.Text;
                loan.loan_type = this.cmbLoanType.Text;
                loan.interest = (double)this.numInterest.Value;
                loan.interest_amount = (double)(this.interest_value * months_days);
                loan.no_days_month = (int)this.numDayMonth.Value;
                loan.amount_to_loan = (double)this.principal_amount;
                loan.total_amount = (double)this.total_amount;
                loan.loan_date = dtLoan.Value;

                loan.save(this.flx);
                id = loan.loan_id;
                this.txtReference.Text = loan.loan_id.ToString("00000000");
                Box.InfoBox("Loan successfully saved.");
            }
        }

        
        void debug()
        {

            btnBrowseMember_Click(null, null);
            txtLoanTitle.Text = "TEST ONLY (FOR DEBUGGING)";
            cmbLoanType.Text = "MONTHLY";
            numInterest.Value = 2;
            numDayMonth.Value = 5;
            numAmountToLoan.Value = 5000;
            btnCompute_Click(null, null);
        }
        


        private void txtLoanTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F10)
            {
                debug();
            }
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
            try
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


                if (dt.Rows.Count > 0)
                {
                    this.txtReference.Text = Convert.ToInt64(dt.Rows[0]["loan_id"]).ToString("00000000");
                    this.member_id = Convert.ToInt64(dt.Rows[0]["member_id"]);
                    this.txtLoanTitle.Text = Convert.ToString(dt.Rows[0]["loan_title"]);
                    this.txtlname.Text = Convert.ToString(dt.Rows[0]["lname"]);
                    this.txtfname.Text = Convert.ToString(dt.Rows[0]["fname"]);
                    this.txtmname.Text = Convert.ToString(dt.Rows[0]["mname"]);
                    this.cmbLoanType.Text = Convert.ToString(dt.Rows[0]["loan_type"]);
                    this.numInterest.Value = Convert.ToInt32(dt.Rows[0]["interest"]);
                    this.numDayMonth.Value = Convert.ToInt32(dt.Rows[0]["no_days_month"]);
                    this.numAmountToLoan.Value = Convert.ToDecimal(dt.Rows[0]["amount_to_loan"]);
                    this.dtLoan.Value = Convert.ToDateTime(dt.Rows[0]["loan_date"]);
                    //compute
                    this.compute();
                    
                    flx.Rows.Count = flx.Rows.Fixed;
                    int monthDay = Convert.ToInt32(dt.Rows[0]["no_days_month"]);
                    for (int row = 1; row <= monthDay; row++)
                    {
                        flx.Rows.Add();
                        flx[row, "loan_detail_id"] = Convert.ToInt64(dt.Rows[row - 1]["loan_detail_id"]);
                        flx[row, "date_month"] = Convert.ToString(dt.Rows[row - 1]["date_month"]);
                        flx[row, "amountToPay"] = Convert.ToString(dt.Rows[row - 1]["amount_to_pay"]);
                        flx[row, "amountPaid"] = Convert.ToDouble(dt.Rows[row - 1]["amount_paid"]);
                        flx[row, "balance"] = Convert.ToDouble(dt.Rows[row - 1]["balance"]) - Convert.ToDouble(flx[row, "amountPaid"]);

                        //flx[row, "date_month"] = addedDateTime;
                        //flx[row, "amountToPay"] = amtToPay;
                    }

                }
            }
            catch (Exception err)
            {

                Box.ErrBox(err.Message);
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
            this.dtLoan.Enabled = false;
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
            this.dtLoan.Enabled = true;

        }
    }
}
