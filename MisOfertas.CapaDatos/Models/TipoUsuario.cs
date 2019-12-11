using System.ComponentModel.DataAnnotations;

namespace MisOfertas.CapaDatos.Models
{
    public class TipoUsuario
    {
        [Key]
        public int IdTipoUsuario { get; set; }
        public string Descripcion { get; set; }
    }
}
