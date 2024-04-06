using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DRecibo
    {
        public static DataTable MostrarDetalleRecibo(int id_Recibo)
        {
            SqlDataReader Resultado;
            DataTable Responce = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_MostrarDetalleRecibo", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@id_Recibo", SqlDbType.Int).Value = id_Recibo;
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

        public static DataTable AgregarDetalleRecibo(int id_Recibo, int id_Paciente, int id_Examen)
        {
            SqlDataReader Resultado;
            DataTable Responce = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_AgregarDetalleRecibo", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@id_Recibo", SqlDbType.Int).Value = id_Recibo;
                Comando.Parameters.Add("@id_Paciente", SqlDbType.Int).Value = id_Paciente;
                Comando.Parameters.Add("@id_Examen", SqlDbType.Int).Value = id_Examen;
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

        public static DataTable ModificarDetalleRecibo(int id_Detalle, int id_Recibo, int id_Examen, SqlMoney Importe)
        {
            SqlDataReader Resultado;
            DataTable Responce = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_ModificarDetalleRecibo", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@id_Detalle", SqlDbType.Int).Value = id_Detalle;
                Comando.Parameters.Add("@id_Recibo", SqlDbType.Int).Value = id_Recibo;
                Comando.Parameters.Add("@id_Examen", SqlDbType.Int).Value = id_Examen;
                Comando.Parameters.Add("@Importe", SqlDbType.Money).Value = Importe;
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

        public static DataTable BorrarDetalleRecibo(int id_Recibo)
        {
            SqlDataReader Resultado;
            DataTable Responce = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_EliminarDetalleRecibo", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id", SqlDbType.Int).Value = id_Recibo;
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

        public static DataTable GuardarDetalleRecibo(int id_Recibo)
        {
            SqlDataReader Resultado;
            DataTable Responce = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_GuardarDetalleRecibo", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@id_Recibo", SqlDbType.Int).Value = id_Recibo;
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

        public static DataTable MostrarRecibo(int id_Recibo)
        {
            SqlDataReader Resultado;
            DataTable Responce = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_MostrarRecibo", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@id_Recibo", SqlDbType.Int).Value = id_Recibo;
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

        public static DataTable MostrarImporteRecibo(int id_Recibo)
        {
            SqlDataReader Resultado;
            DataTable Responce = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_MostrarImporteRecibo", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@id_Recibo", SqlDbType.Int).Value = id_Recibo;
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
