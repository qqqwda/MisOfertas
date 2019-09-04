using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos
{
    public class UserType
    {
        [Key]
        public int IdUserType { get; set; }
        public string Description { get; set; }
    }
}
