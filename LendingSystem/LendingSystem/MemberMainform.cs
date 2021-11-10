using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using C1.Win.C1FlexGrid;
using System.IO;

namespace LendingSystem
{
    public partial class MemberMainForm : Form
    {
        Member member;

       // MySqlConnection con;
       // MySqlCommand cmd;
      //  string query;

        public MemberMainForm()
        {
            InitializeComponent();

            member = new Member();
        }

        
        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);
        }

       private void MemberMainForm_Load(object sender, EventArgs e)
        {
            loadData();

        }
        
        public void loadData()
        {
            member.find(flx, txtlname.Text, txtfname.Text);
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Box.QBox("Are you sure you want to delete this data?"))
            {
                long id = Convert.ToInt64(flx[flx.RowSel, "member_id"]);
                member.delete(id);
                Box.InfoBox("User deleted successfully.");
               
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MembersAddEdit frm = new MembersAddEdit(this);
            frm.id = Convert.ToInt64(flx[flx.RowSel, "member_id"]);
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Box.QBox("Are you sure you want to delete this data?"))
            {
                long id = Convert.ToInt64(flx[flx.RowSel, "member_id"]);
                string path = Application.StartupPath + "/" + "img/" + id.ToString() + "_" + Convert.ToString(flx[flx.RowSel, "avatar_path"]) + ".jpeg";
                //Box.InfoBox(path);
                member.delete(id);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                Box.InfoBox("User deleted successfully.");
                loadData();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            MembersAddEdit frm = new MembersAddEdit(this);
            frm.id = 0;
            frm.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void viewMemberProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportMemberProfileForm frm = new ReportMemberProfileForm();
            frm.ShowDialog();
        }
    }
}
