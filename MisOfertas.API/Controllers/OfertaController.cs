using MisOfertas.CapaDatos.JModels;
using MisOfertas.CapaNegocio.Casos_de_Negocio;
using System.Collections.Generic;
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

        public IEnumerable<OfertaHelper> Get()
        {
            return negocio.Oferta.ToListModel();
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


        public IHttpActionResult Delete(int id)
        {
            var response = negocio.Oferta.Delete(id);
            if (response.IsSuccess)
            {
                return Ok(response.Message);
            }

            return BadRequest(response.Message);
        }

        public IHttpActionResult Put(int id, [FromBody] OfertaModel oferta)
        {
            var response = negocio.Oferta.UpdateModel(id, oferta);
            if (response.IsSuccess)
            {
                return Ok(response.Message);
            }

            return BadRequest(response.Message);
        }


    }

}
