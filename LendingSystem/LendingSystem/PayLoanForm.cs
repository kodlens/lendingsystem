using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LendingSystem
{
    public partial class PayLoanForm : Form
    {
        PayLoan loan;

        public PayLoanForm()
        {
            InitializeComponent();

            loan = new PayLoan();
        }

        long member_id;
        double principal_amount = 0, total_amount = 0;


        private void txtReference_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                getData();
            }
        }

        void getData()
        {
            loan.getData(this.flx, Convert.ToInt64(txtReference.Text));
           
            member_id = loan.member_id;
            txtfname.Text = loan.fname;
            txtlname.Text = loan.lname;
            txtmname.Text = loan.mname;
            this.cmbLoanType.Text = loan.loan_type;
            this.txtLoanTitle.Text = loan.loan_title;
            this.numInterest.Value = (decimal)loan.interest;
            this.numDayMonth.Value = loan.no_days_month;
            this.numAmountToLoan.Value = (decimal)loan.amount_to_loan;
            principal_amount = loan.amount_to_loan;


            this.lblInterestAmount.Text = String.Format("{0:n}",loan.interest_amount);

            this.lblTotalAmount.Text = String.Format("{0:n}", loan.total_amount);
            total_amount = loan.total_amount;
           
        }

        private void flx_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (e.Col == 4)
            {
                double amountToPay = Convert.ToDouble(flx[flx.RowSel, "amountToPay"]);
                double amountPaid = Convert.ToDouble(flx[flx.RowSel, "amountPaid"]);

                flx[e.Row, 5] = (amountToPay - amountPaid) > 0 ? amountToPay - amountPaid : 0;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                update();
                Box.InfoBox("Record successfully updated.");
            }
            catch (Exception er)
            {
                Box.ErrBox(er.Message);
            }
            
        }

        void update()
        {
            loan.member_id = this.member_id; //member who loan
            loan.loan_title = this.txtLoanTitle.Text; //title of the loan
            loan.loan_type = this.cmbLoanType.Text; //type of loan, daily or monthly
            loan.interest = (double)this.numInterest.Value; //interest in percent
            
            loan.interest_amount = ((double)numInterest.Value/100) * (double)numAmountToLoan.Value; //the interest value 
            loan.no_days_month = (int)this.numDayMonth.Value; //no of days or month, duration of loan
            loan.amount_to_loan = this.principal_amount; //principal amount or the amount to loan
            loan.total_amount = this.total_amount; //total amount w/ interest
            loan.update(this.flx, Convert.ToInt64(txtReference.Text));
        }

        
    }
}
