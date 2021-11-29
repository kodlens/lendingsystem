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
            loan.find(flx, "", "");
        }
    }
}
