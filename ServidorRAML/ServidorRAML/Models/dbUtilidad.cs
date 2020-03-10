using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ServidorRAML.Models
{
    public class dbUtilidad
    {
        private SqlConnection con;
        public dbUtilidad()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFileName=|DataDirectory|\\MTIS.mdf; Integrated Security=True";
        }

        public bool checkRestKey(string restkey)
        {
            bool allOk = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM restkey WHERE restkey = '" + restkey + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                allOk = true;
            }

            dr.Close();
            con.Close();

            return allOk;
        }
    }
}