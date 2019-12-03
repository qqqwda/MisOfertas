using MisOfertas.CapaDatos.JModels;
using MisOfertas.CapaDatos.Models;
using MisOfertas.CapaNegocio.Casos_de_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaNegocio.Casos_de_Negocio_Web.Helper
{
    public class Helper
    {
        public static List<OfertaProductoModel> OfertasProductos(int id)
        {
            NOferta ofertas = new NOferta();
            var listaOfertas = ofertas.ToList().Where(o => o.Producto.Categoria.IdCategoria == id).ToList();
            List<OfertaProductoModel> ofertaProductos = new List<OfertaProductoModel>();
            foreach (var item in listaOfertas)
            {
                OfertaProductoModel ofertaproducto = new OfertaProductoModel();
                ofertaproducto.CompraMax = item.CompraMax;
                ofertaproducto.CompraMin = item.CompraMin;
                ofertaproducto.Descripcion = item.Descripcion;
                ofertaproducto.DescripcionProducto = item.Producto.Descripcion;
                ofertaproducto.FechaDisponibilidad = item.FechaDisponibilidad;
                ofertaproducto.FechaVencimiento = item.Producto.FechaVencimiento;
                ofertaproducto.IdOferta = item.IdOferta;
                ofertaproducto.IdProducto = item.Producto.IdProducto;
                ofertaproducto.Imagen = item.Producto.Imagen;
                ofertaproducto.Marca = item.Producto.Marca;
                ofertaproducto.Modelo = item.Producto.Modelo;
                ofertaproducto.Nombre = item.Producto.Nombre;
                ofertaproducto.PorcentajeDescuento = item.PorcentajeDescuento;
                ofertaproducto.PrecioNormal = item.Producto.PrecioNormal;
                ofertaproducto.Stock = item.Producto.Stock;
                ofertaproducto.Temporada = item.Producto.Temporada;
                ofertaproducto.Valor = item.Valor;
                ofertaproducto.IdCategoria = item.Producto.Categoria.IdCategoria;
                ofertaproducto.IdEmpresa = item.Producto.Empresa.IdEmpresa;
                ofertaproducto.NombreCategoria=item.Producto.Categoria.Descripcion;
                ofertaproducto.NombreEmpresa = item.Producto.Empresa.Nombre;


                ofertaProductos.Add(ofertaproducto);

            }

            return ofertaProductos;
        }

        public static List<ComentarioModel> ComentariosOferta(int id)
        {
            NOferta ofertas = new NOferta();
            var listaComentarios = ofertas.ToList().FirstOrDefault(o => o.IdOferta == id).OpinionOfertas;
            List<ComentarioModel> comentarios = new List<ComentarioModel>();
            foreach (var item in listaComentarios)
            {
                ComentarioModel comentario = new ComentarioModel();

                comentario.Comentario = item.Comentario;
                comentario.FechaPublicacion = item.FechaPublicacion;
                comentario.IdProducto = item.Oferta.Producto.IdProducto;
                comentario.Imagen = item.Imagen;
                comentario.NombreCompleto = item.Usuario.Nombre + " " + item.Usuario.Apellido;
                comentarios.Add(comentario);

            }

            return comentarios;
        }

        


        public static List<OfertaProductoModel> OfertasProductosSegunOferta(int id)
        {
            NOferta ofertas = new NOferta();
            var listaOfertas = ofertas.ToList().Where(o =>o.IdOferta == id).ToList();
            List<OfertaProductoModel> ofertaProductos = new List<OfertaProductoModel>();
            foreach (var item in listaOfertas)
            {
                OfertaProductoModel ofertaproducto = new OfertaProductoModel();
                ofertaproducto.CompraMax = item.CompraMax;
                ofertaproducto.CompraMin = item.CompraMin;
                ofertaproducto.Descripcion = item.Descripcion;
                ofertaproducto.DescripcionProducto = item.Producto.Descripcion;
                ofertaproducto.FechaDisponibilidad = item.FechaDisponibilidad;
                ofertaproducto.FechaVencimiento = item.Producto.FechaVencimiento;
                ofertaproducto.IdOferta = item.IdOferta;
                ofertaproducto.IdProducto = item.Producto.IdProducto;
                ofertaproducto.Imagen = item.Producto.Imagen;
                ofertaproducto.Marca = item.Producto.Marca;
                ofertaproducto.Modelo = item.Producto.Modelo;
                ofertaproducto.Nombre = item.Producto.Nombre;
                ofertaproducto.PorcentajeDescuento = item.PorcentajeDescuento;
                ofertaproducto.PrecioNormal = item.Producto.PrecioNormal;
                ofertaproducto.Stock = item.Producto.Stock;
                ofertaproducto.Temporada = item.Producto.Temporada;
                ofertaproducto.Valor = item.Valor;
                ofertaproducto.IdCategoria = item.Producto.Categoria.IdCategoria;
                ofertaproducto.IdEmpresa = item.Producto.Empresa.IdEmpresa;
                ofertaproducto.NombreCategoria = item.Producto.Categoria.Descripcion;
                ofertaproducto.NombreEmpresa = item.Producto.Empresa.Nombre;


                ofertaProductos.Add(ofertaproducto);

            }

            return ofertaProductos;
        }


    }
}
