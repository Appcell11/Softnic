using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Examenes
    {
        public int id_Examen { get; set; }
        public string Nombre { get; set; }
        public SqlMoney Precio { get; set; }
        public string Estado { get; set;}

        public Examenes(int Id, string Nombre, SqlMoney Precio, string Estado)
        {
            this.id_Examen = Id;
            this.Nombre = Nombre;
            this.Precio = Precio;
            this.Estado = Estado;
        }
    }
}
