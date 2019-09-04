using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos
{
    public class UserLoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int IdUserType { get; set; }
    }
}
