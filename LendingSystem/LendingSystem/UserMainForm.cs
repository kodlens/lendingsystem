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
    public partial class UserMainForm : Form
    {
        User user;

        public UserMainForm()
        {
            InitializeComponent();

            user = new User();
        }

        private void SampleForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            user.all(flx);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UserAddEdit frm = new UserAddEdit(this);
            frm.id = 0;
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UserAddEdit frm = new UserAddEdit(this);
            frm.id = Convert.ToInt64(flx[flx.RowSel, "user_id"]);
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(Box.QBox("Are you sure you want to delete this data?"))
            {
                long id = Convert.ToInt64(flx[flx.RowSel, "user_id"]);
                user.delete(id);
                Box.InfoBox("User deleted successfully.");
                loadData();
            }
        }

        private void modifyUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordMainForm frm = new ChangePasswordMainForm();
            frm.ShowDialog();
        }

        private void flx_Click(object sender, EventArgs e)
        {

        }
    }
}
