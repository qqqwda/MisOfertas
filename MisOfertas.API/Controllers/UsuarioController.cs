using MisOfertas.CapaDatos.JModels;
using MisOfertas.CapaDatos.Models;
using MisOfertas.CapaNegocio.Casos_de_Negocio;
using System.Collections.Generic;
using System.Web.Http;

namespace MisOfertas.API.Controllers
{
    public class UsuarioController : ApiController
    {
        MainCasosNegocio negocio;
        public UsuarioController()
        {
            negocio = new MainCasosNegocio();
        }


        public IEnumerable<Usuario> Get()
        {
            return negocio.Usuario.ToList();
        }

        public IHttpActionResult Post([FromBody]UsuarioModel usuario)
        {
            var response = negocio.Usuario.Create(usuario);
            if (response.IsSuccess)
            {
                return Ok(response.Message);
            }

            return BadRequest(response.Message);
        }

        public IHttpActionResult Delete(int id)
        {
            var response = negocio.Usuario.Delete(id);
            if (response.IsSuccess)
            {
                return Ok(response.Message);
            }

            return BadRequest(response.Message);
        }

        public IHttpActionResult Put(int id, [FromBody] UsuarioModel usuario)
        {
            var response = negocio.Usuario.Update(id, usuario);
            if (response.IsSuccess)
            {
                return Ok(response.Message);
            }

            return BadRequest(response.Message);
        }

    }
}
