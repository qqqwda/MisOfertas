using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos.Models
{
    public class Opinion
    {
        [Key]
        public int IdOpinion { get; set; }
        public double Valoracion { get; set; }


        public Usuario Usuario { get; set; }


        public string Imagen { get; set; }
        public DateTime FechaPublicacion { get; set; }




        public Producto Producto { get; set; }
    }
}
