using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
        public int Telefono { get; set; }
        public string Comuna { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Suscrito { get; set; }
        public int Puntos { get; set; }


        public virtual TipoUsuario TipoUsuario { get; set;  }
        public Empresa Empresa { get; set; }
        public virtual ICollection<Oferta> Ofertas { get; set; }
    }
}
