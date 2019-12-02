using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos.JModels
{
    public class OpinionOfertaModel
    {
        public string Comentario { get; set; }
        public string Imagen { get; set; }
        public DateTime FechaPublicacion { get; set; }

        public int IdUsuario { get; set; }
        public int IdOferta { get; set; }
    }
}
