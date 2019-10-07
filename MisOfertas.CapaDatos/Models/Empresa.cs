using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos.Models
{
    public class Empresa
    {
        [Key]
        public int IdEmpresa { get; set; }
        public string Rut { get; set; }
        public string Logo { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public int Numero { get; set; }
    }
}
