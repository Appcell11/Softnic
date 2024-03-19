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
        public static List<string> CargarDatosExamenes()
        {
            var list = new List<string>();
            foreach(var item in ExecSP.Exec("sp_MostrarExamenes").Select())
            {
                list.Add(item[1].ToString());
            }
            return list;
        }

        public static DataTable cargarInformacionExamenes()
        {
            return ExecSP.Exec("sp_MostrarExamenes");
        }

        public static List<string> CargarDatosClientes()
        {
            var list = new List<string>();
            foreach (var item in ExecSP.Exec("sp_MostrarClientes").Select())
            {
                list.Add(item[1].ToString() + " " + item[3]);
            }
            return list;
        }

        public static List<string> CargarDatosDescuentos()
        {
            var list = new List<string>();
            foreach (var item in ExecSP.Exec("sp_MostrarDescuentos").Select())
            {
                list.Add(item[1].ToString());
            }
            return list;
        }
    }
}
