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
            if (string.IsNullOrEmpty(oferta.PorcentajeDescuento.ToString()) || oferta.PorcentajeDescuento > 100)
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
            try
            {
                try
                {
                    var oferta = this.Bd.Ofertas.FirstOrDefault(e => e.IdOferta == id);
                    this.Bd.Ofertas.Remove(oferta);
                    this.Bd.SaveChanges();
                    return new Response<Oferta> { IsSuccess = true, Answer = oferta, Message = "oferta eliminada" };
                }
                catch (Exception)
                {
                    return new Response<Oferta> { IsSuccess = false, Answer = null, Message = "oferta no pudo ser eliminada" };
                }
            }
            catch (Exception)
            {

                return new Response<Oferta> { IsSuccess = false, Answer = null, Message = "Error" };
            }
        }

        public List<Oferta> ToList()
        {
            return Bd.Ofertas.ToList();
        }

        public Response<Oferta> Update(int id, Oferta oferta)
        {
            try
            {
                var of = Bd.Ofertas.First(e => e.IdOferta == id);

                of.CompraMax = oferta.CompraMax;
                of.CompraMin = oferta.CompraMin;
                of.Descripcion = oferta.Descripcion;
                of.FechaDisponibilidad = oferta.FechaDisponibilidad;
                of.IdOferta = oferta.IdOferta;
                of.PorcentajeDescuento = oferta.PorcentajeDescuento;
                of.Valor = of.Valor;
                //Bd.Database.ExecuteSqlCommand();


                Bd.SaveChanges();

                return new Response<Oferta> { IsSuccess = true, Answer = oferta, Message = "Error" };
            }
            catch (Exception)
            {

                return new Response<Oferta> { IsSuccess = false, Answer = null, Message = "Error" };
            }

        }

        public Response<OfertaModel> UpdateModel(int id, OfertaModel oferta)
        {
            try
            {
                var of = Bd.Ofertas.First(e => e.IdOferta == id);

                of.CompraMax = oferta.CompraMax;
                of.CompraMin = oferta.CompraMin;
                of.Descripcion = oferta.Descripcion;
                of.FechaDisponibilidad = oferta.FechaDisponibilidad;
                of.PorcentajeDescuento = oferta.PorcentajeDescuento;
                of.Valor = oferta.Valor;
                
                Bd.Database.ExecuteSqlCommand(string.Format("UPDATE Ofertas SET Producto_IdProducto ={0}",oferta.IdProducto));
                
                Bd.SaveChanges();

                return new Response<OfertaModel> { IsSuccess = true, Answer = oferta, Message = "Error" };
            }
            catch (Exception)
            {

                return new Response<OfertaModel> { IsSuccess = false, Answer = null, Message = "Error" };
            }

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
