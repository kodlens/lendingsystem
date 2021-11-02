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
        public UserMainForm()
        {
            InitializeComponent();
        }

        private void SampleForm_Load(object sender, EventArgs e)
        {
            new User().all(this.flx);
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
    }
}
