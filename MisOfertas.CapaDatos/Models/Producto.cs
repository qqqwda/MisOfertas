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
        public int IdProducto{ get; set; }
        public string Descripcion{ get; set; }
        public int CompraMinima { get; set; }
        public int CompraMaxima { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int Valor { get; set; }
        public double Descuento { get; set; }
        public int Stock{ get; set; }



        public EncargadoVentas EncargadoVentas { get; set; }

        public Local Local { get; set; }

        public Categoria Categoria { get; set; }

        


    }
}
