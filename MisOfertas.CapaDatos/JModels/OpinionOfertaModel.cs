using System;

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
