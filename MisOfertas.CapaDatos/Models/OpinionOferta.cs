using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
