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
    public partial class ApplyLoanMainForm : Form
    {
   
        public ApplyLoanMainForm()
        {
            InitializeComponent();

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
                flx[row, "amountToPay"] = amtToPay;
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


                decimal months_days, roi, amt, interest, ins;
                amt = numAmountToLoan.Value;
                interest = numInterest.Value;
                months_days = numDayMonth.Value;
                roi = amt / interest;
                ins = amt / months_days + roi;

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

        
    }
}
