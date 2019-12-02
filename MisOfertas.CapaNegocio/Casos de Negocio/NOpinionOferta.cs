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
                Bd.Database.ExecuteSqlCommand(string.Format($"INSERT INTO Ofertas(Comentario, Imagen, FechaPublicacion, Usuario_IdUsuario, Oferta_IdOferta) VALUES({opinion.Comentario},{opinion.Imagen},{opinion.FechaPublicacion},{opinion.IdUsuario},{opinion.IdOferta})"));
                Bd.SaveChanges();
                return new Response<OpinionOferta> { Answer = null, IsSuccess = true, Message = "Comentario agregado correctamente" };
            }
            catch (Exception)
            {

                return new Response<OpinionOferta> { Answer = null, IsSuccess = false, Message = "Error al cargar comentario" };
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
