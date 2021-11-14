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
    public partial class MemberMainForm : Form
    {

        Member m;

        public MemberMainForm()
        {
            InitializeComponent();

            m = new Member();
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MembersAddEdit frm = new MembersAddEdit();
            frm.ShowDialog();
        }

        private void MemberMainForm_Load(object sender, EventArgs e)
        {
            m.emje(flx);
        }
    }
}
