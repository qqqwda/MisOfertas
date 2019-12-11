using System;
using System.ComponentModel.DataAnnotations;

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


        public virtual TipoUsuario TipoUsuario { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
