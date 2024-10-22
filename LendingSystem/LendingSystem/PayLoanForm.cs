﻿using System;
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

            
        }

        long member_id = 0;
        double principal_amount = 0, total_amount = 0;


        private void txtReference_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    getData();

                }
               
                catch (FormatException)
                {
                    Box.ErrBox("Inputted reference number is invallid. Please check your input.");
                }
                catch (Exception err)
                {

                    //throw;
                    Box.ErrBox(err.Message);
                }
            }

            if(e.KeyCode == Keys.F1)
            {
                PayLoanBrowseLoanForm frm = new PayLoanBrowseLoanForm(this);
                frm.ShowDialog();
            }
        }

        void getData()
        {
            loan = new PayLoan();

            if(loan.getData(this.flx, Convert.ToInt64(txtReference.Text)) > 0)
            {
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


                this.lblInterestAmount.Text = String.Format("{0:n}", loan.interest_amount);

                this.lblTotalAmount.Text = String.Format("{0:n}", loan.total_amount);
                total_amount = loan.total_amount;


                this.flx.Focus();
            }
            else
            {
                Box.WarnBox("No data found.");
                clear();
                loan = null;
            }
            
           
            

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
                if(this.flx.Rows.Count < 2)
                {
                    Box.WarnBox("No record(s) found.");
                    return;
                }

                update();
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

            //clear things
            Box.InfoBox("Record successfully updated.");
            clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void PayLoanForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                update();
            }
        }

        private void flx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                update();
            }

            
        }

        private void PayLoanForm_Load(object sender, EventArgs e)
        {
            //Whatever is going to happen, i know it will turn out good.
            //this.flx.item
        }

        void clear()
        {
            this.flx.Rows.Count = flx.Rows.Fixed;
            this.txtReference.Text = "";
            this.txtLoanTitle.Text = "";
            this.cmbLoanType.SelectedIndex = -1;
            this.numInterest.Value = 0;
            this.numDayMonth.Value = 0;
            this.numAmountToLoan.Value = 0;
            this.lblInterestAmount.Text = "0.00";
            this.lblTotalAmount.Text = "0.00";

            this.member_id = 0;
            this.txtlname.Text = "";
            this.txtfname.Text = "";
            this.txtmname.Text = "";

            loan = null;

            this.txtReference.Focus();
        }

        
    }
}
