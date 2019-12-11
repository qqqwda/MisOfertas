using System.ComponentModel.DataAnnotations;

namespace MisOfertas.CapaDatos.Models
{
    public class Valoracion
    {
        [Key]
        public int IdValoracin { get; set; }
        public double Evaluacion { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Oferta Oferta { get; set; }

    }
}
