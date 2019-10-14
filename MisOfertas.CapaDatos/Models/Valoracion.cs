using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos.Models
{
    public class Valoracion
    {
        [Key]
        public int IdValoracin { get; set; }
        public double Evaluacion { get; set; }
        public virtual Usuario Usuario { get; set; }

    }
}
