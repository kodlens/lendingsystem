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


        void upsert()
        {
            
            user.username = txtUsername.Text;
            user.password = txtPassword.Text;
            user.lname = txtlname.Text;
            user.fname = txtfname.Text;
            user.mname = txtmname.Text;
            user.sex = cmbSex.Text;
            user.role = cmbRole.Text;


            //if id is greater than zero, update mode, else insert mode
            if (id > 0)
            {
                if (user.update(id) > 0)
                {
                    Box.InfoBox("User successfully updated.");
                }
            }
            else
            {
                if (user.save() > 0)
                {
                    Box.InfoBox("User successfully saved.");
                }
            }

            _frm.loadData();
            this.Close();
           
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

            if(id < 1)
            {
                //if insert mode
                if (String.IsNullOrEmpty(txtPassword.Text))
                {
                    txtPassword.Focus();
                    Box.WarnBox("Please input password.");
                    return;
                }

                if (txtPassword.Text != txtRPassword.Text)
                {
                    txtPassword.Focus();
                    Box.WarnBox("Password not match.");
                    return;
                }
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

            if (id > 0)
            {
                //update mode
                if (user.isExistUsername(id, txtUsername.Text.Trim()))
                {
                    Box.WarnBox("Username already exist.");
                    txtUsername.Focus();
                    return;
                }
            }
            else
            {
                //insert mode
                if (user.isExistUsername(txtUsername.Text.Trim()))
                {
                    Box.WarnBox("Username already exist.");
                    txtUsername.Focus();
                    return;
                }
            }
            


            //update or insert
            upsert();
        }

        private void UserAddEdit_Load(object sender, EventArgs e)
        {
            //detect if update mode or insert mode
            if(id > 0)
            {
                setData();
                txtPassword.Enabled = false;
                txtRPassword.Enabled = false;
            }

        }

        void setData()
        {
            user.getData(id);
            txtUsername.Text = user.username;
            txtlname.Text = user.lname;
            txtfname.Text = user.fname;
            txtmname.Text = user.mname;
            cmbSex.Text = user.sex;
            cmbRole.Text = user.role;
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

        private void cmbSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
