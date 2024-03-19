using CapaDatos;
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
        public static List<string> Perfiles()
        {
            var result = new List<string>();
            var Login = new DLogin();

            foreach (var item in Login.LogIn().Select())
            {
                result.Add(item[0].ToString());
            }

            return result;
        }

        public static string ValidarAcceso(string nombre, string contraseña)
        {
            var Access = new DLogin();
            string ResultAccess = Access.ValidarCredenciales(nombre, contraseña).Select()[0][0].ToString();
            return ResultAccess;
        }

        public static void AñadirPerfilUsuario(string Nombre, string Contraseña, int Rol)
        {
            string ContraseñaEncriptada = Encriptar.GetSHA256(Contraseña);
            DLogin.AñadirPerfilUsuario(Nombre, ContraseñaEncriptada, Rol);
        }
    }
}
