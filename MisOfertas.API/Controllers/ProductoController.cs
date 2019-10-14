using MisOfertas.CapaDatos.JModels;
using MisOfertas.CapaDatos.Models;
using MisOfertas.CapaNegocio.Casos_de_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MisOfertas.API.Controllers
{
    public class ProductoController : ApiController
    {
        MainCasosNegocio negocio;

        public ProductoController()
        {
            negocio = new MainCasosNegocio();
        }


        public IEnumerable<ProductoModel> Get()
        {
            return negocio.Producto.ToListModel();
        }

        public IHttpActionResult Post([FromBody]ProductoModel producto)
        {
            var response = negocio.Producto.Create(producto);
            if (response.IsSuccess)
            {
                return Ok(response.Message);
            }

            return BadRequest(response.Message);
        }

        public IHttpActionResult Delete(int id)
        {
            var response = negocio.Producto.Delete(id);
            if (response.IsSuccess)
            {
                return Ok(response.Message);
            }

            return BadRequest(response.Message);
        }


    }
}
