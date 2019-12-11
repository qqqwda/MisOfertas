using System;

namespace MisOfertas.CapaDatos.JModels
{
    public class ComentarioModel
    {
        public string Comentario { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string NombreCompleto { get; set; }
        public string Imagen { get; set; }
        public int IdProducto { get; set; }


    }
}
