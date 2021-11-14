using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C1.Win.C1FlexGrid;


using MySql.Data.MySqlClient;



namespace LendingSystem
{
    class Sample
    {

        public Sample()
        {

        }



        MySqlConnection con;
        MySqlCommand cmd;
        string query;


        public string lname { set; get; }
        public string fname { set; get; }
        public string mname { set; get; }
        public string sex { set; get; }





        public int save() //i
        {
            int i = 0;
            con = Connection.con();
            con.Open();
            query = "INSERT INTO samples SET lname=?lname, fname=?fname, mname=?mname, sex=?sex";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?lname", this.lname);
            cmd.Parameters.AddWithValue("?fname", this.fname);
            cmd.Parameters.AddWithValue("?mname", this.mname);
            cmd.Parameters.AddWithValue("?sex", this.sex);
            i = cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            con.Dispose();

            return i;
        }

        public int edit(int id)
        {
            int i = 0;
            con = Connection.con();
            con.Open();
            query = "UPDATE samples SET lname=?lname, fname=?fname, mname=?mname, sex=?sex WHERE sample_id = ?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?lname", this.lname);
            cmd.Parameters.AddWithValue("?fname", this.fname);
            cmd.Parameters.AddWithValue("?mname", this.mname);
            cmd.Parameters.AddWithValue("?sex", this.sex);
            cmd.Parameters.AddWithValue("?id", id);

            i = cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            con.Dispose();

            return i;
        }


        public int delete(int id)
        {
            int i = 0;
            con = Connection.con();
            con.Open();
            query = "DELETE FROM samples WHERE sample_id = ?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?id", id);
            i = cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            con.Dispose();

            return i;
        }


        public void all(C1FlexGrid flx, string slname, string sfname)
        {
            con = Connection.con();
            con.Open();
            query = "SELECT * FROM samples WHERE lname LIKE ?lname AND fname LIKE ?fname";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?lname", slname + "%");
            cmd.Parameters.AddWithValue("?fname", sfname + "%");
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


        public void getData(int id)
        {
            con = Connection.con();
            con.Open();
            query = "SELECT * FROM samples WHERE sample_id = ?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?id", id);
            DataTable dt = new DataTable();
            MySqlDataAdapter adtpr = new MySqlDataAdapter(cmd);
            adtpr.Fill(dt);
            adtpr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            if(dt.Rows.Count > 0)
            {
                this.lname = Convert.ToString(dt.Rows[0]["lname"]);
                this.fname = Convert.ToString(dt.Rows[0]["fname"]);
                this.mname = Convert.ToString(dt.Rows[0]["mname"]);
                this.sex = Convert.ToString(dt.Rows[0]["sex"]);

            }

        }


    }
}
