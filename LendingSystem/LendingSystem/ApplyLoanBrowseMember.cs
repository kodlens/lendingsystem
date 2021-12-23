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
    
    public partial class ApplyLoanBrowseMember : Form
    {
        ApplyLoanAddEdit _frm;

        Member member;


        public ApplyLoanBrowseMember(ApplyLoanAddEdit _frm)
        {
            InitializeComponent();

            this._frm = _frm;
            member = new Member();
        }

        private void ApplyLoanBrowseMember_Load(object sender, EventArgs e)
        {
            member.findActive(flx, this.txtlname.Text, this.txtfname.Text);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(this.flx.Rows.Count > 1)
            {
                _frm.member_id = Convert.ToInt64(flx[flx.RowSel, "member_id"]);
                _frm.txtlname.Text = Convert.ToString(flx[flx.RowSel, "lname"]);
                _frm.txtfname.Text = Convert.ToString(flx[flx.RowSel, "fname"]);
                _frm.txtmname.Text = Convert.ToString(flx[flx.RowSel, "mname"]);

                this.Close();
            }
            else
            {
                Box.WarnBox("No data selected.");
            }
         
        }

        private void flx_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSelect_Click(null, null);
            }
        }
    }
}
