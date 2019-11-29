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
    public class NOferta : IMaintanable<Oferta>
    {
        CommonContext Bd;
        public NOferta()
        {
            Bd = new CommonContext();
        }
        public Response<Oferta> Create(OfertaModel oferta)
        {

            if (string.IsNullOrEmpty(oferta.Descripcion))
            {
                return new Response<Oferta> { Answer = null, IsSuccess = false, Message = "Descripcion vacía" };
            }
            if (string.IsNullOrEmpty(oferta.FechaDisponibilidad.ToString()))
            {
                return new Response<Oferta> { Answer = null, IsSuccess = false, Message = "Ingrese fecha" };
            }
            if (string.IsNullOrEmpty(oferta.PorcentajeDescuento.ToString()) || oferta.PorcentajeDescuento < 100)
            {
                return new Response<Oferta> { Answer = null, IsSuccess = false, Message = "Ingrese descuento" };
            }
            if (oferta.Valor <= 0)
            {
                return new Response<Oferta> { Answer = null, IsSuccess = false, Message = "Valor debe ser mayor a 0" };
            }

            Bd.Database.ExecuteSqlCommand("INSERT INTO Ofertas(Descripcion, CompraMin, CompraMax, FechaDisponibilidad, Valor, PorcentajeDescuento, Producto_IdProducto, Usuario_IdUsuario) VALUES ({0},{1},{2},{3},{4},{5},{6},{7})",
               oferta.Descripcion, oferta.CompraMin, oferta.CompraMax, oferta.FechaDisponibilidad, oferta.Valor, oferta.PorcentajeDescuento, oferta.IdProducto, oferta.IdUsuario);
            Bd.SaveChanges();

            return new Response<Oferta>
            {
                Answer = null, IsSuccess = true, Message = "Oferta creada"
            };
        }

        public Response<Oferta> Create(Oferta obj)
        {
            throw new NotImplementedException();
        }

        public Response<Oferta> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Oferta> ToList()
        {
            return Bd.Ofertas.ToList();
        }

        public Response<Oferta> Update(int id, Oferta obj)
        {
            throw new NotImplementedException();
        }
        public Oferta Traer(int id)
        {
            return Bd.Ofertas.Where(x => x.IdOferta == id).FirstOrDefault();
        }

        public bool Update(Oferta obj)
        {
            var guardado = false;
            Bd.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            var i = Bd.SaveChanges();
            guardado = i > 0;
            return guardado;
        }

    }

        
    
}
