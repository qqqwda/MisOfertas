using System.ComponentModel.DataAnnotations;

namespace MisOfertas.CapaDatos
{
    public class UserType
    {
        [Key]
        public int IdUserType { get; set; }
        public string Description { get; set; }
    }
}
