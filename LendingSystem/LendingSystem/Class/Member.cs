using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C1.Win.C1FlexGrid;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LendingSystem
{
    class Member
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        public long member_id { set; get; }
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

        public string avatar_path {set;get;}

        public void find(C1FlexGrid flx, string vlname, string vfname)
        {
            con = Connection.con();
            con.Open();
            query = "SELECT * FROM members WHERE lname LIKE ?lname and fname LIKE ?fname";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?lname", vlname + "%");
            cmd.Parameters.AddWithValue("?fname", vfname + "%");
            DataTable dt = new DataTable();
            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
            adptr.Fill(dt);
            adptr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            flx.AutoGenerateColumns = false;
            flx.DataSource = dt;
        }


        //public void find(C1FlexGrid flx, string kLname)
        //{
        //    con = Connection.con();
        //    con.Open();
        //    query = "SELECT * FROM members WHERE lname LIKE ?lname";
        //    cmd = new MySqlCommand(query, con);
        //    cmd.Parameters.AddWithValue("?lname", kLname + "%");
        //    DataTable dt = new DataTable();
        //    MySqlDataAdapter adtpr = new MySqlDataAdapter(cmd);
        //    adtpr.Fill(dt);
        //    adtpr.Dispose();
        //    cmd.Dispose();
        //    con.Close();
        //    con.Dispose();

        //    flx.AutoGenerateColumns = false;
        //    flx.DataSource = dt;
        //}




        public void emje(C1FlexGrid flx)
        {
            con = Connection.con();
            con.Open();

            query = "SELECT * FROM members";
            cmd = new MySqlCommand(query, con);

            DataTable dt = new DataTable();
            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);

            adptr.Fill(dt);

            adptr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();


            flx.AutoGenerateColumns = false;
            flx.DataSource = dt;
        }

        public long save()
        {
            long i = 0;
            con = Connection.con();
            con.Open();
            query = @"INSERT INTO members SET lname=?lname, fname=?fname, mname=?mname, sex=?sex, bdate=?bdate, email=?email, contact_no=?contact_no, store_name=?store_name, store_address=?store_address, province=?province, city=?city, barangay=?barangay, street=?street, is_active=?is_active, avatar_path=?apath; SELECT LAST_INSERT_ID();";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?lname", this.lname);
            cmd.Parameters.AddWithValue("?fname", this.fname);
            cmd.Parameters.AddWithValue("?mname", this.mname);
            cmd.Parameters.AddWithValue("?sex", this.sex);
            cmd.Parameters.AddWithValue("?bdate", this.bdate);
            cmd.Parameters.AddWithValue("?email", this.email);
            cmd.Parameters.AddWithValue("?contact_no", this.contact_no);
            cmd.Parameters.AddWithValue("?store_name", this.store_name);
            cmd.Parameters.AddWithValue("?store_address", this.store_address);
            cmd.Parameters.AddWithValue("?province", this.province);
            cmd.Parameters.AddWithValue("?city", this.city);
            cmd.Parameters.AddWithValue("?barangay", this.barangay);
            cmd.Parameters.AddWithValue("?street", this.street);
            cmd.Parameters.AddWithValue("?is_active", this.is_active);
            cmd.Parameters.AddWithValue("?apath", this.lname + "_" + this.fname);
            //i = cmd.ExecuteNonQuery();
            i = Convert.ToInt64(cmd.ExecuteScalar());
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
                        contact_no=?contact_no, store_name=?store_name, store_address=?store_address, province=?province, city=?city, barangay=?barangay, street=?street, is_active=is_active, avatar_path=?apath WHERE member_id = ?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?lname", this.lname);
            cmd.Parameters.AddWithValue("?fname", this.fname);
            cmd.Parameters.AddWithValue("?mname", this.mname);
            cmd.Parameters.AddWithValue("?sex", this.sex);
            cmd.Parameters.AddWithValue("?bdate", this.bdate);
            cmd.Parameters.AddWithValue("?email", this.email);
            cmd.Parameters.AddWithValue("?contact_no", this.contact_no);
            cmd.Parameters.AddWithValue("?store_name", this.store_name);
            cmd.Parameters.AddWithValue("?store_address", this.store_address);
            cmd.Parameters.AddWithValue("?province", this.province);
            cmd.Parameters.AddWithValue("?city", this.city);
            cmd.Parameters.AddWithValue("?barangay", this.barangay);
            cmd.Parameters.AddWithValue("?street", this.street);
            cmd.Parameters.AddWithValue("?is_active", this.is_active);
            cmd.Parameters.AddWithValue("?apath", this.lname + "_" + this.fname);
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

        public void getData(long id)
        {
            con = Connection.con();
            con.Open();
            query = "SELECT * FROM members where member_id=?";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?id", id);
            DataTable dt = new DataTable();
            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
            adptr.Fill(dt);
            adptr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            if(dt.Rows.Count>0)
            {

                this.lname = Convert.ToString(dt.Rows[0]["lname"]);
                this.fname = Convert.ToString(dt.Rows[0]["fname"]);
                this.mname = Convert.ToString(dt.Rows[0]["mname"]);
                this.sex = Convert.ToString(dt.Rows[0]["sex"]);
                this.bdate = Convert.ToString(dt.Rows[0]["bdate"]);
                this.email = Convert.ToString(dt.Rows[0]["email"]);
                this.contact_no = Convert.ToString(dt.Rows[0]["contact_no"]);
                this.store_name = Convert.ToString(dt.Rows[0]["store_name"]);
                this.store_address = Convert.ToString(dt.Rows[0]["store_address"]);
                this.province = Convert.ToString(dt.Rows[0]["province"]);
                this.city = Convert.ToString(dt.Rows[0]["city"]);
                this.barangay = Convert.ToString(dt.Rows[0]["barangay"]);
                this.street = Convert.ToString(dt.Rows[0]["street"]);
                this.avatar_path = Convert.ToString(dt.Rows[0]["avatar_path"]);

            }

        }


    }
}
