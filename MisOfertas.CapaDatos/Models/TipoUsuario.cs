using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos.Models
{
    public class TipoUsuario
    {
        [Key]
        public int IdTipoUsuario { get; set; }
        public string Descripcion { get; set; }
    }
}
