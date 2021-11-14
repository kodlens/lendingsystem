using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using C1.Win.C1FlexGrid;
using System.Data;

namespace LendingSystem
{
    class User
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;


        public string username { set; get; }
        public string lname { set; get; }
        public string fname { set; get; }
        public string mname { set; get; }
        public string sex { set; get; }
        public string password { set; get; }
        public string role { set; get; }


        public void all(C1FlexGrid flx)
        {
            con = Connection.con();
            con.Open();
            query = "SELECT * FROM users";
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


        //check if username is exist (use in update mode only)
        public bool isExistUsername(long id, string u)
        {
            con = Connection.con();
            con.Open();
            query = "SELECT * FROM users WHERE username=?uname AND user_id != ?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?uname", u);
            cmd.Parameters.AddWithValue("?id", id);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            bool flag = false;
            flag = dr.Read();
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return flag;
        }

        //check if username is exist
        public bool isExistUsername(string u)
        {
            con = Connection.con();
            con.Open();
            query = "SELECT * FROM users WHERE username=?uname ";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?uname", u);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            bool flag = false;
            flag = dr.Read();
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return flag;
        }

        public int save()
        {
            int i = 0;
            con = Connection.con();
            con.Open();
            query = @"INSERT INTO users SET username=?username, password=?pwd,lname=?lname, fname=?fname, mname=?mname, sex=?sex, role=?role";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?username", this.username);
            cmd.Parameters.AddWithValue("?pwd", this.password);
            cmd.Parameters.AddWithValue("?lname", this.lname);
            cmd.Parameters.AddWithValue("?fname", this.fname);
            cmd.Parameters.AddWithValue("?mname", this.mname);
            cmd.Parameters.AddWithValue("?sex", this.sex);
            cmd.Parameters.AddWithValue("?role", this.role);
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
            query = @"UPDATE users SET username=?uname, lname=?lname, fname=?fname, mname=?mname, sex=?sex, role=?role
                    WHERE user_id=?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?uname", this.username);
            cmd.Parameters.AddWithValue("?lname", this.lname);
            cmd.Parameters.AddWithValue("?fname", this.fname);
            cmd.Parameters.AddWithValue("?mname", this.mname);
            cmd.Parameters.AddWithValue("?sex", this.sex);
            cmd.Parameters.AddWithValue("?role", this.role);
            cmd.Parameters.AddWithValue("?id", id);
            i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            return i;
        }


        public int changePassword(long id, string p)
        {

            int i = 0;
            con = Connection.con();
            con.Open();
            query = @"UPDATE users SET password=?pwd
                    WHERE user_id=?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?pwd", p);
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
            query = @"DELETE FROM users WHERE user_id = ?id";
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
            query = @"SELECT * FROM users WHERE user_id = ?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?id", id);
            DataTable dt = new DataTable();
            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
            adptr.Fill(dt);
            adptr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();


            if(dt.Rows.Count > 0)
            {
                this.username = Convert.ToString(dt.Rows[0]["username"]);
                this.lname = Convert.ToString(dt.Rows[0]["lname"]);
                this.fname = Convert.ToString(dt.Rows[0]["fname"]);
                this.mname = Convert.ToString(dt.Rows[0]["mname"]);
                this.sex = Convert.ToString(dt.Rows[0]["sex"]);
                this.role = Convert.ToString(dt.Rows[0]["role"]);

            }
        }

    }
}
