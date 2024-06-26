﻿using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NLogin
    {

        public static string ValidarAcceso(string nombre, string contraseña)
        {
            var Access = new DLogin();
            string contraseñaEncriptada = Encriptar.GetSHA256(contraseña);
            string ResultAccess = "0";
            try
            {
                ResultAccess = Access.ValidarCredenciales(nombre, contraseñaEncriptada).Select()[0][0].ToString();
            }
            catch
            {
                ResultAccess = "Error";
            }
            return ResultAccess;
        }

        public static bool AñadirPerfilUsuario(string Nombre, string Contraseña, int Rol)
        {
            string ContraseñaEncriptada = Encriptar.GetSHA256(Contraseña);
            string Response = DLogin.AñadirPerfilUsuario(Nombre, ContraseñaEncriptada, Rol).Select()[0][0].ToString();
            return Response == "1" ? true : false;

        }

        public static bool ModificarPerfilUsuario(int Id, string Nombre, string Contraseña, int Rol)
        {
            string ContraseñaEncriptada = Encriptar.GetSHA256(Contraseña);
            string Response = DLogin.ModificarPerfilUsuario(Id, Nombre, ContraseñaEncriptada, Rol).Select()[0][0].ToString();
            return Response == "1" ? true : false;

        }

        public static bool EliminarPerfilUsuario(int Id)
        {
            string Response = DLogin.EliminarPerfilUsuario(Id).Select()[0][0].ToString();
            return Response == "1" ? true : false;
        }
    }
}
