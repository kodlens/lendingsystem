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
    public partial class LoginForm : Form
    {

        Login login;
        public LoginForm()
        {
            InitializeComponent();
            //instantiate the class
            login = new Login();

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            

            //use the method under the class Login
            if (login.auth(this.textBoxusername.Text, this.textBoxpass.Text))
            {
                MainForm frm = new MainForm(this); //using this class so that we can hide the form and recall during logout
                this.textBoxusername.Text = "";
                this.textBoxpass.Text = "";
                frm.Show();
                this.Hide();
            }
            else
            {
                Box.ErrBox("Username and Password error!");
            }

           

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

