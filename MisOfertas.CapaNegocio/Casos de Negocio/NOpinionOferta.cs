using MisOfertas.CapaDatos;
using MisOfertas.CapaDatos.JModels;
using MisOfertas.CapaDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaNegocio.Casos_de_Negocio
{
    public class NOpinionOferta : IMaintanable<OpinionOferta>
    {
        CommonContext Bd;
        public NOpinionOferta()
        {
            Bd = new CommonContext();
        }
        public Response<OpinionOferta> Create(OpinionOfertaModel opinion)
        {
            try
            {
                Bd.Database.ExecuteSqlCommand(string.Format("INSERT INTO OpinionOfertas (Comentario, Imagen, Usuario_IdUsuario, Oferta_IdOferta, FechaPublicacion) VALUES('{0}','{1}','{2}','{3}','{4}')", opinion.Comentario, opinion.Imagen, opinion.IdUsuario, opinion.IdOferta, "2011-11-11"));
                Bd.SaveChanges();

                Bd.OpinionOfertas.OrderByDescending(o => o.IdOpinionOferta).First().FechaPublicacion = opinion.FechaPublicacion;
                Bd.SaveChanges();
                var puntosActuales = Bd.Usuarios.FirstOrDefault(u => u.IdUsuario == opinion.IdUsuario).Puntos;
                Bd.Usuarios.FirstOrDefault(u => u.IdUsuario == opinion.IdUsuario).Puntos = puntosActuales + 5;
                Bd.SaveChanges();
                return new Response<OpinionOferta> { Answer = null, IsSuccess = true, Message = "Comentario agregado correctamente" };
            }
            catch (Exception ex)
            {

                return new Response<OpinionOferta> { Answer = null, IsSuccess = false, Message = "Error al cargar comentario: "+ex.Message };
            }
            
        }

        public Response<OpinionOferta> Create(OpinionOferta obj)
        {
            throw new NotImplementedException();
        }

        public Response<OpinionOferta> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<OpinionOferta> ToList()
        {
            throw new NotImplementedException();
        }

        public Response<OpinionOferta> Update(int id, OpinionOferta obj)
        {
            throw new NotImplementedException();
        }
    }
}
