using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos.JModels
{
    public class OfertaHelper
    {
        public int IdOferta { get; set; }
        public string Descripcion { get; set; }
        public int CompraMin { get; set; }
        public int CompraMax { get; set; }
        public DateTime FechaDisponibilidad { get; set; }
        public decimal Valor { get; set; }
        public decimal PorcentajeDescuento { get; set; }

        public virtual ProductoModel Producto { get; set; }
        public int IdUsuario { get; set; }
    }
}
