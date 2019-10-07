using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos.Models
{
    public class ConcurrenciaCategoria
    {
        [Key]
        public int IdConcurrenciaCategoria { get; set; }


        public Categoria Categoria { get; set; }


        public int Concurrencia { get; set; }

    }
}
