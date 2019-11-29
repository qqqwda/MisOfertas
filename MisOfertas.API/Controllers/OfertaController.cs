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
    public class OfertaController : ApiController
    {
        MainCasosNegocio negocio;
        public OfertaController()
        {
            negocio = new MainCasosNegocio();
        }

        public IEnumerable<Oferta> Get()
        {
            return negocio.Oferta.ToList();
        }


        public IHttpActionResult Post([FromBody]OfertaModel oferta)
        {
            var response = negocio.Oferta.Create(oferta);

            if (response.IsSuccess)
            {
                return Ok(response);
            }
            return BadRequest(response.Message);
        }

        
    }

}
