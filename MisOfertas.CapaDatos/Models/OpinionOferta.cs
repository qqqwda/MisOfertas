using System;
using System.ComponentModel.DataAnnotations;

namespace MisOfertas.CapaDatos.Models
{
    public class OpinionOferta
    {
        [Key]
        public int IdOpinionOferta { get; set; }
        public string Comentario { get; set; }
        public string Imagen { get; set; }
        public DateTime FechaPublicacion { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Oferta Oferta { get; set; }

    }

}
