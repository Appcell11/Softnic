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

            //Login.LogIn().ForEach(x =>
            //{
            //    result.Add(x.Nombre);
            //});

            return result;
        }

        public static bool ValidarAcceso(string nombre, string contraseña)
        {
            bool Acceso = false;
            //DLogin.LoginOffline.ForEach(login => { 
            //    if (login.Nombre == nombre && login.Contrasena == contraseña) {
            //        Acceso = true;
            //    }
            //});

            var Access = new DLogin();

            string ResultAccess = Access.ValidarCredenciales(nombre, contraseña).Select()[0][0].ToString();
            if (ResultAccess == "0")
            {
                Acceso = false;
            }
            else if (ResultAccess == "1") 
            {
                Acceso = true;
            }

            return Acceso;
        }
    }
}
