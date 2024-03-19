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

        public DataTable ValidarCredenciales(string NombreUsuario, string Contrasena)
        {
            SqlDataReader Resultado;
            DataTable Responce = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_ValidarAcceso", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@NombreUsuario", SqlDbType.VarChar).Value = NombreUsuario;
                Comando.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = Contrasena;
                sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                Responce.Load(Resultado);
                return Responce;
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

        public static void AñadirPerfilUsuario(string NombreUsuario, string Contrasena, int Rol)
        {
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_AgregarPerfil", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = NombreUsuario;
                Comando.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = Contrasena;
                Comando.Parameters.Add("@Rol", SqlDbType.Int).Value = Rol;
                sqlcon.Open();
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
    }
}
