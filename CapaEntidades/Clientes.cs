using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Clientes
    {
        public int id_Cliente { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string NumeroCedula { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        
        public Clientes(int id_Cliente, string PrimerNombre, string SegundoNombre, string PrimerApellido, string SegundoApellido, string NumeroCedula, DateTime FechaNacimiento, string Sexo)
        {
            this.id_Cliente = id_Cliente;
            this.PrimerNombre = PrimerNombre;
            this.SegundoNombre = SegundoNombre;
            this.PrimerApellido = PrimerApellido;
            this.SegundoApellido = SegundoApellido;
            this.NumeroCedula = NumeroCedula;
            this.FechaNacimiento = FechaNacimiento;
            this.Sexo = Sexo;
        }
    }
}
