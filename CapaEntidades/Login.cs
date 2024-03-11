using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Login
    {
        public int IdLogin {get; set;}
        public string Nombre { get; set;}
        public string Contrasena { get; set; }

        public int LoginEstado { get; set;}
    }
}
