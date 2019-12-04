using MisOfertas.CapaDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos.JModels
{
    public class CategoriaPuntuacionModel
    {
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public string PromedioPuntuacion { get; set; }
    }
}
