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
    public partial class UserAddEdit : Form
    {

        public long id;

        UserMainForm _frm;
        User user;


        public UserAddEdit(UserMainForm _frm)
        {
            InitializeComponent();
            this._frm = _frm;

            user = new User();
        }


        void save()
        {
            user.username = txtUsername.Text;
            user.password = txtPassword.Text;
            user.lname = txtlname.Text;
            user.fname = txtfname.Text;
            user.mname = txtmname.Text;
            user.sex = cmbSex.Text;
            user.role = cmbRole.Text;

            if(user.save() > 0)
            {
                Box.InfoBox("User successfully saved.");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //filters
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.Focus();
                Box.WarnBox("Please input username.");
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus();
                Box.WarnBox("Please input password.");
                return;
            }
            if(txtPassword.Text != txtRPassword.Text)
            {
                txtPassword.Focus();
                Box.WarnBox("Password not match.");
                return;
            }
            if (String.IsNullOrEmpty(txtlname.Text))
            {
                txtlname.Focus();
                Box.WarnBox("Please input Lastname.");
                return;
            }
            if (String.IsNullOrEmpty(txtfname.Text))
            {
                txtfname.Focus();
                Box.WarnBox("Please input firstname.");
                return;
            }

            save();
        }
    }
}
