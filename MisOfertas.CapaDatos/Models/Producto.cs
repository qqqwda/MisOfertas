using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        public decimal PrecioNormal { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Stock { get; set; }
        public string Color { get; set; }

        public Empresa Empresa { get; set; }
        public Categoria Categoria { get; set; }
    }
}
