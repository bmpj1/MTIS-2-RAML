using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ServidorRAML.Models
{
    public class dbSeguridad
    {
        private SqlConnection con;
        private dbUtilidad util;
        public dbSeguridad()
        {
            con = new SqlConnection();
            util = new dbUtilidad();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFileName=|DataDirectory|\\MTIS.mdf; Integrated Security=True";
        }


        public bool asignarPermiso(string DNI, string Sala, string restkey)
        {
            bool allOk = false;
            
            if (util.checkRestKey(restkey))
            { 
               con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO seguridad (sala, DNI) values(@Sala, @DNI)", con);

                cmd.Parameters.AddWithValue("@Sala", Sala);
                cmd.Parameters.AddWithValue("@DNI", DNI);

                int rowAffected = cmd.ExecuteNonQuery();
                con.Close();
                allOk = true;
            }
            return allOk;
        }

        public bool validarUsuario(string DNI, string sala, string restkey)
        {
            bool found = false;
            if (util.checkRestKey(restkey))
            {
                con.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM seguridad WHERE DNI ='" + DNI + "' AND sala ='" + sala + "'", con);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    found = true;
                }
                dr.Close();
                con.Close();
            }

            return found;
        }

        public bool eliminarPermiso(string DNI, string sala, string restkey)
        {
            bool allOk = false;
            if (util.checkRestKey(restkey))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM seguridad WHERE DNI = @DNI AND sala = @Sala", con);

                cmd.Parameters.AddWithValue("@DNI", DNI);
                cmd.Parameters.AddWithValue("@Sala", sala);

                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                if(rowsAffected > 0)
                    allOk = true;
            }
            return allOk;
        }

        public List<string> obtenerNiveles(string DNI, string restkey)
        {
            List<string> lista = new List<string>();

            if (util.checkRestKey(restkey))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT sala FROM seguridad WHERE DNI ='" + DNI + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(dr.GetString(0));
                }
                dr.Close();
                con.Close();
            }

            return lista;
        }
    }
}