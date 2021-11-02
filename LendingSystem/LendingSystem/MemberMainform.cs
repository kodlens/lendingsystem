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
    public partial class MemberMainform : Form
    {
        public MemberMainform()
        {
            InitializeComponent();
        }

        private void MemberMainform_Load(object sender, EventArgs e)
        {

        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MembersAddEdit frm = new MembersAddEdit();
            frm.ShowDialog();
        }
    }
}
