using MisOfertas.CapaDatos.JModels;
using MisOfertas.CapaDatos.Models;
using MisOfertas.CapaNegocio.Casos_de_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

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
                ofertaproducto.NombreCategoria = item.Producto.Categoria.Descripcion;
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
            var listaOfertas = ofertas.ToList().Where(o => o.IdOferta == id).ToList();
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

        public static void PostImageAsync(byte[] imagen, string url, string fileName, string id)
        {
            HttpClient httpClient = new HttpClient();
            MultipartFormDataContent form = new MultipartFormDataContent();

            form.Add(new ByteArrayContent(imagen, 0, imagen.Length), fileName, fileName);
            // HttpResponseMessage response = httpClient.PutAsync("PostUrl"+id, form);

            //response.EnsureSuccessStatusCode();
            //httpClient.Dispose();
            //string sd = response.Content.ReadAsStringAsync().Result;

        }

        public static void UploadMultipart(byte[] file, string filename, string contentType, string url, string id)
        {
            var webClient = new WebClient();
            string boundary = "------------------------" + DateTime.Now.Ticks.ToString("x");
            webClient.Headers.Add("Content-Type", "multipart/form-data; boundary=" + boundary);
            var fileData = webClient.Encoding.GetString(file);
            var package = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"file\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n{3}\r\n--{0}--\r\n", boundary, filename, contentType, fileData);

            var nfile = webClient.Encoding.GetBytes(package);

            byte[] resp = webClient.UploadData(url + id, "PUT", nfile);
        }

        public static OfertasModel ToOfertasModel()
        {
            NOferta negocio = new NOferta();
            OfertasModel ofertas = new OfertasModel();

            ofertas.ofertas = new List<OfertaHelper>();

            var negocioOfertas = negocio.ToList();

            foreach (var item in negocioOfertas)
            {

                OfertaHelper oferta = new OfertaHelper();
                oferta.CompraMax = item.CompraMax;
                oferta.CompraMin = item.CompraMin;
                oferta.Descripcion = item.Descripcion;
                oferta.FechaDisponibilidad = item.FechaDisponibilidad;
                oferta.IdOferta = item.IdOferta;
                oferta.IdUsuario = item.Usuario.IdUsuario;
                oferta.PorcentajeDescuento = item.PorcentajeDescuento;
                oferta.Valor = item.Valor;

                ProductoModel Producto = new ProductoModel();

                Producto.Descripcion = item.Producto.Descripcion;
                Producto.FechaVencimiento = item.Producto.FechaVencimiento;
                Producto.IdCategoria = item.Producto.Categoria.IdCategoria;
                Producto.IdEmpresa = item.Producto.Empresa.IdEmpresa;
                Producto.IdProducto = item.Producto.IdProducto;
                Producto.Imagen = item.Producto.Imagen;
                Producto.Marca = item.Producto.Marca;
                Producto.Modelo = item.Producto.Modelo;
                Producto.Nombre = item.Producto.Nombre;
                Producto.PrecioNormal = item.Producto.PrecioNormal;
                Producto.Stock = item.Producto.Stock;
                Producto.Temporada = item.Producto.Temporada;

                oferta.Producto = Producto;

                ofertas.ofertas.Add(oferta);

            }

            return ofertas;

        }

        public static List<CategoriaPuntuacionModel> ToCategoriaPuntuacion(List<Categoria> categorias)
        {
            List<CategoriaPuntuacionModel> categoriaPuntuacion = new List<CategoriaPuntuacionModel>();
            NValoracion nValoracion = new NValoracion();



            foreach (var item in categorias)
            {
                CategoriaPuntuacionModel model = new CategoriaPuntuacionModel();

                model.Descripcion = item.Descripcion;
                model.IdCategoria = item.IdCategoria;
                model.Imagen = item.Imagen;
                var valoraciones = nValoracion.ToList().Where(v => v.Oferta.Producto.Categoria.IdCategoria == item.IdCategoria);
                int count = 0;
                int sumaVal = 0;
                foreach (var valoracion in valoraciones)
                {

                    sumaVal = sumaVal + int.Parse(valoracion.Evaluacion.ToString());
                    count++;
                }
                try
                {

                    var result = ((double)sumaVal / (double)count);


                    model.PromedioPuntuacion = "Valoración promedio: " + result.ToString();
                }
                catch (Exception)
                {

                    model.PromedioPuntuacion = "Valoración promedio: 0";
                }


                categoriaPuntuacion.Add(model);
            }


            return categoriaPuntuacion;
        }


    }





}
