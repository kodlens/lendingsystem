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
    public partial class ChangePasswordMainForm : Form
    {

        User user;

        public long id;
        public ChangePasswordMainForm()
        {
            InitializeComponent();
            user = new User();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                Box.WarnBox("Please input password.");
                txtPassword.Focus();
                return;
            }

            if (txtPassword.Text != txtRPassword.Text)
            {
                Box.WarnBox("Password not match.");
                txtPassword.Focus();
                return;
            }

            if(user.changePassword(id, this.txtPassword.Text) > 0)
            {
                Box.InfoBox("Password successfully changed.");
                this.Close();
            }

        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPassword.Checked)
            {
                txtPassword.PasswordChar = (char)0;
                txtRPassword.PasswordChar = (char)0;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtRPassword.PasswordChar = '*';
            }
        }
    }
}
