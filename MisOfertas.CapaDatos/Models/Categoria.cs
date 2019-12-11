using System.ComponentModel.DataAnnotations;

namespace MisOfertas.CapaDatos.Models
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }

    }
}
