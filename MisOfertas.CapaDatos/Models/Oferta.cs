using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos.Models
{
    public class Oferta
    {
        [Key]
        public int IdOferta { get; set; }
        public string Descripcion { get; set; }
        public int CompraMin { get; set; }
        public int CompraMax { get; set; }
        public DateTime FechaDisponibilidad { get; set; }
        public decimal Valor { get; set; }
        public decimal PorcentajeDescuento { get; set; }

        public Producto Producto { get; set; }
        public virtual ICollection<OpinionOferta> OpinionOfertas { get; set; }
        public virtual Usuario Usuario { get; set; }


    }
}
