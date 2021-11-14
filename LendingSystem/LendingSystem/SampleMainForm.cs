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
    public partial class SampleMainForm : Form
    {

        Sample sample;


        public SampleMainForm()
        {
            InitializeComponent();

            sample = new Sample();
        }


        public void loadData()
        {
            sample.all(flx, searchLname.Text, searchFname.Text);
        }


        private void SampleMainForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SampleAddEdit frm = new SampleAddEdit(this);
            frm.id = 0;
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SampleAddEdit frm = new SampleAddEdit(this);
            frm.id = Convert.ToInt32(flx[flx.RowSel, "sample_id"]);
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(Box.QBox("Are you sure you want to delete this row?"))
            {
                int id = Convert.ToInt32(flx[flx.RowSel, "sample_id"]);
                sample.delete(id);
                Box.InfoBox("Successfully deleted");
                loadData();
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
