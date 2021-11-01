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




        public void all(C1FlexGrid flx)
        {
            con = Connection.con();
            con.Open();
            query = "select * from users";
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


    }
}
