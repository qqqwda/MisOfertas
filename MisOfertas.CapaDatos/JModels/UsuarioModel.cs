using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos.JModels
{
    public class UsuarioModel
    {
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



        public int IdTipoUsuario { get; set; }
        public int IdEmpresa { get; set; }
    }
}
