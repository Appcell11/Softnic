using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
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
            DLogin.LoginOffline.ForEach(x =>
            {
                result.Add(x.Nombre);
            });

            return result;
        }

        public static bool ValidarAcceso(string nombre, string contraseña)
        {
            bool Acceso = false;
            DLogin.LoginOffline.ForEach(login => { 
                if (login.Nombre == nombre && login.Contrasena == contraseña) {
                    Acceso = true;
                }
            });

            return Acceso;
        }
    }
}
