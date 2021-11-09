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

namespace LendingSystem
{

    public partial class MembersAddEdit : Form
    {

        MySqlCommand cmd;
        MySqlConnection con;

        NAddress address;
      
     

        MemberMainForm _frm;
        Member member;
        public long id;

       



        public MembersAddEdit(MemberMainForm _frm)
        {
            InitializeComponent();
            this._frm = _frm;
            member = new Member();

            address = new NAddress();
          
           
        }



        void save()
        {
            member.lname = txtlname.Text;
            member.fname = txtfname.Text;
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
            

            long i = member.save();
            if (i > 0)
            {
                saveImage(i);
                Box.InfoBox("Member successfully saved!");

            }
        }

        void update()
        {
            member.lname = txtlname.Text;
            member.fname = txtfname.Text;
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
            //filters
            if (String.IsNullOrEmpty(txtlname.Text))
            {
                txtlname.Focus();
                Box.WarnBox("Please input Lastname.");
                return;
            }

            if (String.IsNullOrEmpty(txtfname.Text))
            {
                txtfname.Focus();
                Box.WarnBox("Please input Firstname.");
                return;
            }

            if (String.IsNullOrEmpty(cmbSex.Text))
            {
                cmbSex.Focus();
                Box.WarnBox("Select Gender.");
                return;
            }
            if (String.IsNullOrEmpty(dtBdate.Text))
            {
                dtBdate.Focus();
                Box.WarnBox("Please input Birthdate.");
                return;
            }
            if (String.IsNullOrEmpty(txtemail.Text))
            {
                txtemail.Focus();
                Box.WarnBox("Please input Email.");
                return;
            }
            if (String.IsNullOrEmpty(txtcontact_no.Text))
            {
                txtcontact_no.Focus();
                Box.WarnBox("Please input Contact No.");
                return;
            }
            if (String.IsNullOrEmpty(txtstore_name.Text))
            {
                txtstore_name.Focus();
                Box.WarnBox("Please input Store Name.");
                return;
            }
            if (String.IsNullOrEmpty(txtstore_add.Text))
            {
                txtstore_add.Focus();
                Box.WarnBox("Please input Store Address.");
                return;
            }
            if (String.IsNullOrEmpty(cmbProvince.Text))
            {
                cmbProvince.Focus();
                Box.WarnBox("Please input Province.");
                return;
            }
            if (String.IsNullOrEmpty(cmbCity.Text))
            {
                cmbCity.Focus();
                Box.WarnBox("Please input City.");
                return;
            }
            if (String.IsNullOrEmpty(cmbBarangay.Text))
            {
                cmbBarangay.Focus();
                Box.WarnBox("Please input Barangay.");
                return;
            }
            if (String.IsNullOrEmpty(txtStreet.Text))
            {
                txtStreet.Focus();
                Box.WarnBox("Please input Street.");
                return;
            }
            if (String.IsNullOrEmpty(txtref1.Text))
            {
                txtref1.Focus();
                Box.WarnBox("Please input Reference.");
                return;
            }
            if (String.IsNullOrEmpty(txtref2.Text))
            {
                txtref2.Focus();
                Box.WarnBox("Please input Reference.");
                return;
            }

            if (String.IsNullOrEmpty(txtref1_contact.Text))
            {
                txtref1.Focus();
                Box.WarnBox("Please input Reference 1 Contact Information.");
                return;
            }
            if (String.IsNullOrEmpty(txtref2_contact.Text))
            {
                txtref2_contact.Focus();
                Box.WarnBox("Please input Reference 2 Contact Information.");
                return;
            }


            //if id is greater than zero, update mode, else insert mode
            if (id > 0)
            {
                update();
            }
            else
            {
                save();
            }

            _frm.loadData();
            this.Close();
        }



        //for debugging purpose only
        private void btnDebug_Click(object sender, EventArgs e)
        {
            debug();
        }

        private void MembersAddEdit_Load(object sender, EventArgs e)
        {
            //load data from database to combobox
            con = Connection.con();
            con.Open();
         address.fillCmbProvince(con, cmbProvince);
           
            con.Close();
            con.Dispose();

           

            if (id > 0)
            {
                getData();
            }
        }

        void getData()
        {
            member.getData(id);
            txtlname.Text = member.lname;
            txtfname.Text = member.fname;
            txtmname.Text = member.mname;
            cmbSex.Text = member.sex;
            //  dtBdate.Text = member.bdate;
            txtemail.Text = member.email;
            txtcontact_no.Text = member.contact_no;
            txtstore_name.Text = member.store_name;
            txtstore_add.Text = member.store_address;
            cmbProvince.Text = member.province;
            cmbCity.Text = member.city;
            cmbBarangay.Text = member.barangay;
            txtStreet.Text = member.street;
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                address.barangays(this.cmbProvince.Text, this.cmbCity.Text, cmbBarangay);
            }
            catch (Exception er)
            {

                Box.ErrBox(er.Message);
            }
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                address.cities(this.cmbProvince.Text, cmbCity);
            }
            catch (Exception er)
            {

                Box.ErrBox(er.Message);
            }
        }

       

        void saveImage(long i)
        {
            Image img;
            img = pictureBox1.Image;

            string dir = Application.StartupPath;
            string nFilename = txtlname.Text + "_" + txtfname.Text;
            img.Save(dir + "\\img\\" + i.ToString() + "_" + nFilename + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //img.Save(@"F:\test\" + nFilename + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            TakePicMainForm frm = new TakePicMainForm(this);
            frm.ShowDialog();
        }
    }
}      
       


    



