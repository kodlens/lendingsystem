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
    public partial class MembersAddEdit : Form
    {
        Member member;
        public long id;

        public MembersAddEdit()
        {
            InitializeComponent();

            member = new Member();
        }


        void save()
        {
            member.lname = txtlname.Text;
            member.fname = txtlname.Text;
            member.mname = txtmname.Text;
            member.sex = cmbSex.Text;
            member.bdate = dtBdate.Value.ToString("yyyy-MM-dd");
            member.email = txtemail.Text;
            member.contact_no = txtcontact_no.Text;
            member.store_name = txtstore_name.Text;
            member.store_address = txtstore_add.Text;
            member.province = cmbProvince.Text;
            member.city = cmbCity.Text;
            member.barangay = cmbBarangay.Text;
            member.street = txtStreet.Text;
            
            if(member.save() > 0)
            {
                Box.InfoBox("Member successfully saved!");
            }
        }

        void update()
        {
            member.lname = txtlname.Text;
            member.fname = txtlname.Text;
            member.mname = txtmname.Text;
            member.sex = cmbSex.Text;
            member.bdate = dtBdate.Value.ToString("yyyy-MM-dd");
            member.email = txtemail.Text;
            member.contact_no = txtcontact_no.Text;
            member.store_name = txtstore_name.Text;
            member.store_address = txtstore_add.Text;
            member.province = cmbProvince.Text;
            member.city = cmbCity.Text;
            member.barangay = cmbBarangay.Text;
            member.street = txtStreet.Text;

            if (member.update(id) > 0)
            {
                Box.InfoBox("Member successfully updated!");
            }
        }

        void debug()
        {
            //for debugging purpose
            txtlname.Text = "AMPARADO";
            txtfname.Text = "ETIENNE";
            txtmname.Text = "";
            cmbSex.Text = "MALE";
            dtBdate.Text = "1988-08-08";
            txtemail.Text = "etienne@gmail.com";
            txtcontact_no.Text = "09167789585";
            txtstore_name.Text = "SAMPLE STORE";
            txtstore_add.Text = "SAMPLE ADDRESS MALORO TANGUB CITY";

            cmbProvince.Text = "MISAMIS OCCIDENTAL";
            cmbCity.Text = "TANGUB CITY";
            cmbBarangay.Text = "MALORO";
            txtStreet.Text = "P-BOUGAINVILLA STREET";

            txtref1.Text = "REF 1 SAMPLE";
            txtref1_contact.Text = "0916454621";

            txtref2.Text = "REF 2 SAMPLE";
            txtref2_contact.Text = "09161235687";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtlname.Text))
            {
                txtlname.Focus();
                Box.WarnBox("Please input lastname.");
                return;
            }
            if (String.IsNullOrEmpty(txtlname.Text))
            {
                txtlname.Focus();
                Box.WarnBox("Please input lastname.");
                return;
            }
            

        }


        //for debugging purpose only
        private void btnDebug_Click(object sender, EventArgs e)
        {
            debug();
        }

        private void MembersAddEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
