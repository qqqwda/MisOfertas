using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos.JModels
{
    public class ValoracionModel
    {
        public double Evaluacion { get; set; }
        public int IdUsuario { get; set; }
        public int IdOferta { get; set; }
    }
}
