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
    public partial class SampleAddEdit : Form
    {

        public int id;

        Sample sample = new Sample();

        SampleMainForm _frm;

        public SampleAddEdit(SampleMainForm _frm) //constructor
        {
            InitializeComponent();

            this._frm = _frm;
           
        }

        private void SampleAddEdit_Load(object sender, EventArgs e)
        {
            if(id > 0)
            {
                getData();
            }

           
        }

        void getData()
        {
            sample.getData(id);

            txtlname.Text = sample.lname;
            txtfname.Text = sample.fname;
            txtmname.Text = sample.mname;
            cmbsex.Text = sample.sex;
        }

        void save()
        {
            sample.lname = txtlname.Text;
            sample.fname = txtfname.Text;
            sample.mname = txtmname.Text;
            sample.sex = cmbsex.Text;

            if (id > 0)
            {
                //edit mode
                if (sample.edit(id) > 0)
                {
                    Box.InfoBox("Successfully updated.");
                }
            }
            else
            {
                //insert mode

                if(sample.save() > 0)
                {
                    Box.InfoBox("Successfully saved.");
                }
            }

            _frm.loadData();
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //filter
            if (String.IsNullOrEmpty(txtlname.Text))
            {
                txtlname.Focus();
                Box.WarnBox("Please input lastname.");
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
