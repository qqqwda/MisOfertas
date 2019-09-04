using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos
{
    public class User
    {
       [Key]
      public int IdUser { get; set; }
      public string Email { get; set; }
      public string Password { get; set; }
      public string Rut { get; set; }
      public int IdUserType { get; set; }

        //  [ForeignKey("IdUserType")]
        //public UserType UserType { get; set; }
    }
}
