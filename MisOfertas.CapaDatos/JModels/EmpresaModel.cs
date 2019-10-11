using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos.JModels
{
    public class EmpresaModel
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Comuna { get; set; }
        public string Region { get; set; }
        public string Rut { get; set; }
        public string Actividad { get; set; }
    }
}
