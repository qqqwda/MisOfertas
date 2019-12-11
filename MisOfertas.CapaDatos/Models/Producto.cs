using System;
using System.ComponentModel.DataAnnotations;

namespace MisOfertas.CapaDatos.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioNormal { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Stock { get; set; }
        public string Imagen { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Temporada { get; set; }


        public virtual Empresa Empresa { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
