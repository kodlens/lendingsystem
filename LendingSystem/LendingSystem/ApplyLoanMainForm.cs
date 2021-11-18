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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxAmountToPay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD

        private void ApplyLoanMainForm_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            int months_days, roi, amt, interest, ins;



            amt = Convert.ToInt32(numericUpDown1.Value);
            interest = Convert.ToInt32(numericUpDown2.Value);
            months_days = Convert.ToInt32(textBox4.Text);


            roi = amt / interest;
            ins = amt / months_days + roi;

            txtboxAmountToPay.Text = ins.ToString();
        }
=======
>>>>>>> 2a86e57656e225285c6059a8f3530efd8883e651
    }
}
