using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DClientes
    {
        public static DataTable AñadirCliente(string PrimerNombre, string SegundoNombre, string PrimerApellido, string SegundoApellido, DateTime Nacimiento, int Sexo, string cedula)
        {
            SqlDataReader Resultado;
            DataTable Responce = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_AgregarCliente", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@PrimerNombre", SqlDbType.VarChar).Value = PrimerNombre;
                Comando.Parameters.Add("@SegundoNombre", SqlDbType.VarChar).Value = SegundoNombre;
                Comando.Parameters.Add("@PrimerApellido", SqlDbType.VarChar).Value = PrimerApellido;
                Comando.Parameters.Add("@SegundoApellido", SqlDbType.VarChar).Value = SegundoApellido;
                Comando.Parameters.Add("@id_Sexo", SqlDbType.Int).Value = Sexo;
                Comando.Parameters.Add("@Nacimiento", SqlDbType.DateTime).Value = Nacimiento;
                Comando.Parameters.Add("@NumeroCedula", SqlDbType.VarChar).Value = cedula;
                sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                Responce.Load(Resultado);
                return Responce;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

            return Responce;
        }

        public static DataTable ModificarCliente(int id, string PrimerNombre, string SegundoNombre, string PrimerApellido, string SegundoApellido, DateTime Nacimiento, int Sexo, string cedula)
        {
            SqlDataReader Resultado;
            DataTable Responce = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_ModificarCliente", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_Paciente", SqlDbType.Int).Value = id;
                Comando.Parameters.Add("@PrimerNombre", SqlDbType.VarChar).Value = PrimerNombre;
                Comando.Parameters.Add("@SegundoNombre", SqlDbType.VarChar).Value = SegundoNombre;
                Comando.Parameters.Add("@PrimerApellido", SqlDbType.VarChar).Value = PrimerApellido;
                Comando.Parameters.Add("@SegundoApellido", SqlDbType.VarChar).Value = SegundoApellido;
                Comando.Parameters.Add("@id_Sexo", SqlDbType.Int).Value = Sexo;
                Comando.Parameters.Add("@NumeroCedula", SqlDbType.VarChar).Value = cedula;
                Comando.Parameters.Add("@Nacimiento", SqlDbType.Date).Value = Nacimiento;
                sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                Responce.Load(Resultado);
                return Responce;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

            return Responce;
        }

        public static DataTable EliminarCliente(int Id)
        {
            SqlDataReader Resultado;
            DataTable Responce = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_EliminarCliente", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                Responce.Load(Resultado);
                return Responce;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

            return Responce; ;
        }

        public static DataTable BuscarCliente(string ValorBuscar)
        {
            SqlDataReader Resultado;
            DataTable Responce = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_BuscarCliente", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@ValorBuscar", SqlDbType.VarChar).Value = ValorBuscar;
                sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                Responce.Load(Resultado);
                return Responce;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

            return Responce;
        }

    }
}
