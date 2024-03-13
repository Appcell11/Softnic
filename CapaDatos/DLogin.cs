using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DLogin
    {
        public DataTable LogIn()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_ObtenerPerfiles", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }

        public bool ValidarCredenciales(string NombreUsuario, string Contrasena)
        {
            SqlDataReader Resultado;
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_ValidarAcceso", sqlcon);
                Comando.Parameters.Add(new SqlParameter("@NombreUsuario", NombreUsuario));
                Comando.Parameters.Add(new SqlParameter("@Contrasena", Contrasena));
                Comando.CommandType = CommandType.StoredProcedure;
                sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                return Resultado.GetBoolean(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }

        public static List<Login> LoginOffline = new List<Login>()
         {
             new Login() {IdLogin = 1, Nombre = "Admin", Contrasena = "Admin", LoginEstado = 1}
         };
        
    }
}
