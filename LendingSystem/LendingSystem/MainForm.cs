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
    public partial class MainForm : Form
    {

        LoginForm _frm;

        public MainForm(LoginForm _frm)
        {
            InitializeComponent();
            this._frm = _frm;

        }

        private void toolStripButtonMembers_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(MemberMainForm))
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = new MemberMainForm();
            frm.Show();
        }

        private void toolStripButtonUsers_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(UserMainForm))
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = new UserMainForm();
            frm.Show();
        }

        private void toolStripButtonLogout_Click(object sender, EventArgs e)
        {
            if(Box.QBox("Are you sure you want to logout?"))
            {
                this.Close();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frm.textBoxusername.Text = "";
            _frm.textBoxpass.Text = "";
            _frm.Show();
        }

        private void toolStripButtonLoan_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ApplyLoanMainForm))
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = new ApplyLoanMainForm();
            frm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(PayLoanForm))
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = new PayLoanForm();
            frm.Show();
        }

        private void toolStripButtonMultiplePayLoan_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(MultiplePaymentForm))
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = new MultiplePaymentForm();
            frm.Show();
        }
    }
}
