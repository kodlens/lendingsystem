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
    public partial class PayLoanBrowseLoanForm : Form
    {
        PayLoanForm _frm;
        Loan loan;


        public PayLoanBrowseLoanForm(PayLoanForm _frm)
        {
            InitializeComponent();
            this._frm = _frm;
            loan = new Loan();
        }

        void loadData()
        {
            loan.find(this.flx, "", this.txtlname.Text, this.txtfname.Text);
        }

        private void PayLoanBrowseLoanForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void txtlname_KeyDown(object sender, KeyEventArgs e)
        {
            loadData();
        }
        private void txtfname_KeyDown(object sender, KeyEventArgs e)
        {
            loadData();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(this.flx.Rows.Count > 1)
            {
                _frm.txtReference.Text = Convert.ToString(flx[flx.RowSel, "loan_id"]);
                this.Close();
            }
            else
            {
                Box.WarnBox("No data selected.");
            }
        }
    }
}
