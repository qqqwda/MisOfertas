using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MisOfertas.CapaDatos.Models
{
    public class Empresa
    {
        [Key]
        public int IdEmpresa { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Comuna { get; set; }
        public string Region { get; set; }
        public string Rut { get; set; }
        public string Actividad { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
        public virtual ICollection<Local> Locales { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
