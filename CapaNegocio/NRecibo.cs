using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NRecibo
    {
        public static DataTable MostrarDetalleRecibo(int id_Recibo)
        {
            DataTable Response = DRecibo.MostrarDetalleRecibo(id_Recibo);
            return Response;
        }

        public static bool AgregarDetalleRecibo(int id_Recibo, int id_Paciente, int id_Examen, SqlMoney Importe)
        {
            string Response = DRecibo.AgregarDetalleRecibo(id_Recibo, id_Paciente, id_Examen, Importe).Select()[0][0].ToString();
            return Response == "1" ? true : false;
        }

        public static bool ModificarDetalleRecibo(int id_Detalle, int id_Recibo, int id_Examen, SqlMoney Importe)
        {
            string Response = DRecibo.ModificarDetalleRecibo(id_Detalle, id_Recibo, id_Examen, Importe).Select()[0][0].ToString();
            return Response == "1" ? true : false;
        }

        public static bool EliminarDetalleRecibo(int id_Detalle)
        {
            string Response = DRecibo.BorrarDetalleRecibo(id_Detalle).Select()[0][0].ToString();
            return Response == "1" ? true : false;
        }
    }
}
