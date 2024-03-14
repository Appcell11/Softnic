using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
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
    }
}
