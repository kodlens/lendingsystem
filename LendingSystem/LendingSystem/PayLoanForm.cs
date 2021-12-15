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

        private void txtReference_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                getData();
            }
        }

        void getData()
        {
            loan.getData(null, Convert.ToInt64(txtReference.Text));
            txtfname.Text = loan.fname;
            txtlname.Text = loan.lname;
            txtmname.Text = loan.mname;
            this.cmbLoanType.Text = loan.loan_type;

        }
    }
}
