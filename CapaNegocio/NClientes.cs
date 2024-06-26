﻿using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NClientes
    {
        public static bool AñadirCliente(string PrimerNombre, string SegundoNombre, string PrimerApellido, string SegundoApellido, DateTime Nacimiento, int Sexo, string cedula)
        {
            string Response = DClientes.AñadirCliente(PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Nacimiento, Sexo, cedula).Select()[0][0].ToString();
            return Response == "1" ? true : false;

        }

        public static bool ModificarCliente(int Id, string PrimerNombre, string SegundoNombre, string PrimerApellido, string SegundoApellido, DateTime Nacimiento, int Sexo, string cedula)
        {
            string Response = DClientes.ModificarCliente(Id, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Nacimiento, Sexo, cedula).Select()[0][0].ToString();
            return Response == "1";

        }

        public static bool EliminarCliente(int Id)
        {
            string Response = DClientes.EliminarCliente(Id).Select()[0][0].ToString();
            return Response == "1" ? true : false;
        }

        public static DataTable BuscarClientes(string ValorBuscar)
        {
            return DClientes.BuscarCliente(ValorBuscar.Trim());
        }
    }
}
