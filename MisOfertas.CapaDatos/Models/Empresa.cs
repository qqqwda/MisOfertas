using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos.Models
{
    public class Empresa
    {
        [Key]
        public int IdEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Comuna { get; set; }
        public string Region { get; set; }
        public string Rut { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
        public virtual ICollection<Local> Locales { get; set; }
    }
}
