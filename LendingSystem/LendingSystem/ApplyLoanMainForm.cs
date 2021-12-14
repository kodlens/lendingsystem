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
        Loan loan;

      
        public ApplyLoanMainForm()
        {
            InitializeComponent();

            loan = new Loan();
        }

        private void ApplyLoanMainForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            loan.find(flx, "", "");
        }

        private void btnApplyLoan_Click(object sender, EventArgs e)
        {
            ApplyLoanAddEdit frm = new ApplyLoanAddEdit(this);
            frm.id = 0;
            frm.ShowDialog();
        }

        private void btnUpdateLoan_Click(object sender, EventArgs e)
        {
            if(this.flx.Rows.Count > 1)
            {
                ApplyLoanAddEdit frm = new ApplyLoanAddEdit(this);
                frm.id = Convert.ToInt64(flx[flx.RowSel, "loan_id"]);
                frm.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(this.flx.Rows.Count > 1)
            {
                if(Box.QBox("Are you sure you want to delete this record?"))
                {
                    long id = Convert.ToInt64(flx[flx.RowSel, "loan_id"]);
                    loan.delete(id);
                    loadData();
                }
            }
        }

        private void deleteLoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelete_Click(null, null);
        }

        private void updateLoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnUpdateLoan_Click(null, null);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
