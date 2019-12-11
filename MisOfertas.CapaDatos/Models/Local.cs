using System.ComponentModel.DataAnnotations;

namespace MisOfertas.CapaDatos.Models
{
    public class Local
    {
        [Key]
        public int IdLocal { get; set; }
        public string Direccion { get; set; }
        public string Descripcion { get; set; }

        public Empresa Empresa { get; set; }
    }
}
