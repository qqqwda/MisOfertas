using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos.Models
{
    public class ConcurrenciaUsuario
    {
        [Key]
        public int IdConcurrenciaUsuario { get; set; }



        public Usuario Usuario { get; set; }



        public Categoria Categoria { get; set; }



        public int Concurrencia { get; set; }
    }
}
