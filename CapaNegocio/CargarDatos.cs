using CapaDatos;
using CapaEntidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class CargarDatos
    {
        public static List<Examenes> cargarInformacionExamenes()
        {
            var list = new List<Examenes>();
            foreach (var item in ExecSP.Exec("sp_MostrarExamenes").Select())
            {
                list.Add(
                    new Examenes(int.Parse(item[0].ToString()), item[1].ToString(), SqlMoney.Parse(item[2].ToString()), item[3].ToString())
                    );
            }
            return list;
        }

        public static List<Clientes> CargarDatosClientes()
        {
            var list = new List<Clientes>();
            foreach (var item in ExecSP.Exec("sp_MostrarClientes").Select())
            {
                list.Add(
                    new Clientes(int.Parse(item[0].ToString()), item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString(), item[5].ToString(), DateTime.Parse(item[6].ToString()), item[7].ToString())
                    );
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

        public static DataTable CargarInfoDataGrid(string SP)
        {
            return ExecSP.Exec(SP);
        }
    }
}
