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
        public int IdUsuario{ get; set; }
        public string Rut{ get; set; }
        public string Nombre{ get; set; }
        public string Apellido{ get; set; }
        public string Correo{ get; set; }
        public string Contrasena{ get; set; }
        public string RespuestaSecreta { get; set; }
        public int Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }



        public int IdTipoUsuario { get; set; }
        public TipoUsuario TipoUsuario { get; set; }


    }
}
