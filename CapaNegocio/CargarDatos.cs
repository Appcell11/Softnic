using CapaDatos;
using CapaEntidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class CargarDatos
    {
        public static DataTable cargarInformacionExamenes()
        {
            return ExecSP.Exec("sp_MostrarExamenes");
        }

        public static List<string> CargarDatosClientes()
        {
            var list = new List<string>();
            foreach (var item in ExecSP.Exec("sp_MostrarClientes").Select())
            {
                list.Add(item[0]+ " " + item[1].ToString() + " " + item[3]);
            }
            return list;
        }

        public static List<string> CargarDatosCmb(string sp, int col)
        {
            var list = new List<string>();
            foreach (var item in ExecSP.Exec(sp).Select())
            {
                list.Add(item[col].ToString());
            }
            return list;
        }

        public static DataTable CargarPerfiles()
        {
            return ExecSP.Exec("sp_MostrarPerfiles");
        }

        public static DataTable CargarInfoRecibo(int idPaciente)
        {
           return ExecSP.CargarInfoRecibo(idPaciente);
        }
    }
}
