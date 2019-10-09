using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
