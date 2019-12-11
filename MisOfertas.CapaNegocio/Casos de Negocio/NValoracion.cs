using MisOfertas.CapaDatos;
using MisOfertas.CapaDatos.JModels;
using MisOfertas.CapaDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MisOfertas.CapaNegocio.Casos_de_Negocio
{
    public class NValoracion : IMaintanable<Valoracion>
    {
        CommonContext Bd;
        public NValoracion()
        {
            Bd = new CommonContext();
        }

        public Response<Valoracion> Create(Valoracion obj)
        {
            throw new NotImplementedException();
        }
        public Response<Valoracion> Create(ValoracionModel valoracion)
        {
            try
            {
                Bd.Database.ExecuteSqlCommand($"INSERT INTO Valoracions (Evaluacion, Usuario_IdUsuario, Oferta_IdOferta) VALUES ('{valoracion.Evaluacion}','{valoracion.IdUsuario}','{valoracion.IdOferta}')");
                Bd.SaveChanges();
                return new Response<Valoracion> { IsSuccess = false, Answer = null, Message = "Valoracion creada" };
            }
            catch (Exception ex)
            {
                return new Response<Valoracion> { IsSuccess = false, Answer = null, Message = $"{ex.Message}" };

                throw;
            }

        }

        public Response<Valoracion> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Valoracion> ToList()
        {
            return Bd.Valoraciones.ToList();
        }

        public Response<Valoracion> Update(int id, Valoracion obj)
        {
            throw new NotImplementedException();
        }
    }
}
