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
        ApplyLoanMainForm _frm;

        Member member;


        public ApplyLoanBrowseMember(ApplyLoanMainForm _frm)
        {
            InitializeComponent();

            this._frm = _frm;
            member = new Member();
        }

        private void ApplyLoanBrowseMember_Load(object sender, EventArgs e)
        {
            member.find(flx, "", "");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _frm.member_id = Convert.ToInt64(flx[flx.RowSel, "member_id"]);
            _frm.txtlname.Text = Convert.ToString(flx[flx.RowSel, "lname"]);
            _frm.txtfname.Text = Convert.ToString(flx[flx.RowSel, "fname"]);
            _frm.txtmname.Text = Convert.ToString(flx[flx.RowSel, "mname"]);

            this.Close();
        }
    }
}
