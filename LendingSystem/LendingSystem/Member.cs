using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C1.Win.C1FlexGrid;
using MySql.Data.MySqlClient;


namespace LendingSystem.Class
{
    class Member
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;


        public string lname { set; get; }
        public string fname { set; get; }
        public string mname { set; get; }
        public string sex { set; get; }
        public string bdate { set; get; }
        public string email { set; get; }
        public string contact_no { set; get; }
        public string store_name { set; get; }
        public string store_address { set; get; }
        public string province { set; get; }
        public string city { set; get; }
        public string barangay { set; get; }
        public string street { set; get; }
        public byte is_active { set; get; }




        public void find(C1FlexGrid flx, string kLname)
        {
            con = Connection.con();
            con.Open();
            query = "SELECT * FROM members WHERE lname LIKE ?lname";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?lname", kLname + "%");
            DataTable dt = new DataTable();
            MySqlDataAdapter adtpr = new MySqlDataAdapter(cmd);
            adtpr.Fill(dt);
            adtpr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            flx.AutoGenerateColumns = false;
            flx.DataSource = dt;
        }


        public int save()
        {
            int i = 0;
            con = Connection.con();
            con.Open();
            query = @"INSERT INTO members SET lname=?lname, fname=?fname, mname=?mname, sex=?sex, bdate=?bdate, email=?email, 
                        contact_no=?contact, store_name=?storename, store_address=?storeadd, province=?prov, city=?city, barangay=?brgy, street=?st, is_active=isactive";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?lname", this.lname);
            cmd.Parameters.AddWithValue("?fname", this.fname);
            cmd.Parameters.AddWithValue("?mname", this.mname);
            cmd.Parameters.AddWithValue("?sex", this.sex);
            cmd.Parameters.AddWithValue("?bdate", this.bdate);
            cmd.Parameters.AddWithValue("?email", this.email);
            cmd.Parameters.AddWithValue("?contact_no", this.contact_no);
            cmd.Parameters.AddWithValue("?storename", this.store_name);
            cmd.Parameters.AddWithValue("?storeadd", this.store_address);
            cmd.Parameters.AddWithValue("?prov", this.store_address);
            cmd.Parameters.AddWithValue("?city", this.store_address);
            cmd.Parameters.AddWithValue("?brgy", this.store_address);
            cmd.Parameters.AddWithValue("?street", this.store_address);
            cmd.Parameters.AddWithValue("?is_active", this.is_active);
            i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            return i;
        }


        public int update(long id)
        {
            int i = 0;
            con = Connection.con();
            con.Open();
            query = @"UPDATE members SET lname=?lname, fname=?fname, mname=?mname, sex=?sex, bdate=?bdate, email=?email, 
                        contact_no=?contact, store_name=?storename, store_address=?storeadd, province=?prov, city=?city, barangay=?brgy, street=?st, is_active=isactive WHERE member_id = ?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?lname", this.lname);
            cmd.Parameters.AddWithValue("?fname", this.fname);
            cmd.Parameters.AddWithValue("?mname", this.mname);
            cmd.Parameters.AddWithValue("?sex", this.sex);
            cmd.Parameters.AddWithValue("?bdate", this.bdate);
            cmd.Parameters.AddWithValue("?email", this.email);
            cmd.Parameters.AddWithValue("?contact_no", this.contact_no);
            cmd.Parameters.AddWithValue("?storename", this.store_name);
            cmd.Parameters.AddWithValue("?storeadd", this.store_address);
            cmd.Parameters.AddWithValue("?prov", this.store_address);
            cmd.Parameters.AddWithValue("?city", this.store_address);
            cmd.Parameters.AddWithValue("?brgy", this.store_address);
            cmd.Parameters.AddWithValue("?street", this.store_address);
            cmd.Parameters.AddWithValue("?is_active", this.is_active);
            cmd.Parameters.AddWithValue("?id", id);

            i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            return i;
        }



        public int delete(long id)
        {
            int i = 0;
            con = Connection.con();
            con.Open();
            query = @"DELETE FROM members WHERE member_id = ?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?id", id);

            i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            return i;
        }



    }
}
