using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos.JModels
{
    public class ProductoModel
    {
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
        public int IdEmpresa { get; set; }
        public int IdCategoria { get; set; }
        
    }
}
