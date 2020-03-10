using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
namespace ServidorRAML.Models
{
    public class dbEmpleado
    {
        private SqlConnection con;
        private dbUtilidad util;
        public dbEmpleado()
        {
            con = new SqlConnection();
            util = new dbUtilidad();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFileName=|DataDirectory|\\MTIS.mdf; Integrated Security=True";
        }
        
        public bool nuevoEmpleado(Empleado.Models.Empleado emp, string restkey)
        {
            bool allOk = false;
            if (util.checkRestKey(restkey))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into empleado (DNI, Nombre, Apellidos, Direccion, Poblacion, Telefono, Email, Nacimiento, NSS, IBAN) values(@DNI, @Nombre, @Apellidos, @Direccion, @Poblacion, @Telefono, @Email, @Nacimiento, @NSS, @IBAN)", con);

                DateTime nacimiento = DateTime.Parse(emp.Nacimiento);
                cmd.Parameters.AddWithValue("@DNI", emp.DNI);
                cmd.Parameters.AddWithValue("@Nombre", emp.Nombre);
                cmd.Parameters.AddWithValue("@Apellidos", emp.Apellidos);
                cmd.Parameters.AddWithValue("@Direccion", emp.Direccion);
                cmd.Parameters.AddWithValue("@Poblacion", emp.Poblacion);
                cmd.Parameters.AddWithValue("@Telefono", emp.Telefono);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@Nacimiento", nacimiento);
                cmd.Parameters.AddWithValue("@NSS", emp.NSS);
                cmd.Parameters.AddWithValue("@IBAN", emp.IBAN);

                cmd.ExecuteNonQuery();
                con.Close();
                allOk = true;
            }
            return allOk;
        }

        public bool ModificarEmpleado(Empleado.Models.Empleado emp, string restkey)
        {
            bool allOk = false;
            if (util.checkRestKey(restkey))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE empleado SET Nombre = @Nombre, Apellidos = @Apellidos, Direccion = @Direccion, Poblacion = @Poblacion, Telefono = @Telefono, Email = @Email, Nacimiento = @Nacimiento, NSS = @NSS, IBAN = @IBAN WHERE DNI = '" + emp.DNI + "'", con);
                DateTime nacimiento = DateTime.Parse(emp.Nacimiento);

                cmd.Parameters.AddWithValue("@Nombre", emp.Nombre);
                cmd.Parameters.AddWithValue("@Apellidos", emp.Apellidos);
                cmd.Parameters.AddWithValue("@Direccion", emp.Direccion);
                cmd.Parameters.AddWithValue("@Poblacion", emp.Poblacion);
                cmd.Parameters.AddWithValue("@Telefono", emp.Telefono);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@Nacimiento", nacimiento);
                cmd.Parameters.AddWithValue("@NSS", emp.NSS);
                cmd.Parameters.AddWithValue("@IBAN", emp.IBAN);

                cmd.ExecuteNonQuery();
                con.Close();
                allOk = true;
            }
            return allOk;
        }

        public bool BorrarEmpleado(string DNI, string restkey)
        {
            bool allOk = false;
            if (util.checkRestKey(restkey))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM empleado WHERE DNI = @DNI", con);
                cmd.Parameters.AddWithValue("@DNI", DNI);
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                if(rowsAffected > 0)
                    allOk = true;
            }
            return allOk;
        }
        
        public Empleado.Models.Empleado ConsultarEmpleado(string DNI, string restkey)
        {
            Empleado.Models.Empleado empleado = null;
            
            if (util.checkRestKey(restkey))
            {
                con.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Empleado WHERE DNI ='" + DNI + "'", con);
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {
                    empleado = new Empleado.Models.Empleado();

                    empleado.DNI = dr["DNI"].ToString();
                    empleado.Nombre = dr["Nombre"].ToString();
                    empleado.Apellidos = dr["Apellidos"].ToString();
                    empleado.Telefono = dr["Telefono"].ToString();
                    empleado.Direccion = dr["Direccion"].ToString();
                    empleado.Poblacion = dr["Poblacion"].ToString();
                    empleado.Email = dr["Email"].ToString();
                    empleado.Nacimiento = dr["Nacimiento"].ToString();
                    empleado.NSS = dr["NSS"].ToString();
                    empleado.IBAN = dr["IBAN"].ToString();
                }
                dr.Close();
                con.Close();
            }

            return empleado;
        }

        
    }
}