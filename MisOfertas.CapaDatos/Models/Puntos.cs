using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos.Models
{
    public class Puntos
    {
        [Key]
        public int IdPuntos{ get; set; }



        public Usuario Usuario{ get; set; }



        public int CantidadPuntos{ get; set; }
    }
}
