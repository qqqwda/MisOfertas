using System;

namespace MisOfertas.CapaDatos.JModels
{
    public class OfertaModel
    {
        public int IdOferta { get; set; }
        public string Descripcion { get; set; }
        public int CompraMin { get; set; }
        public int CompraMax { get; set; }
        public DateTime FechaDisponibilidad { get; set; }
        public decimal Valor { get; set; }
        public decimal PorcentajeDescuento { get; set; }

        public int IdProducto { get; set; }
        public int IdUsuario { get; set; }

    }
}
