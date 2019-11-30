using MisOfertas.CapaDatos;
using MisOfertas.CapaNegocio.Casos_de_Negocio_Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MisOfertas.API.Controllers
{
    public class UsuarioLoginController : ApiController
    {
        NUsuario negocio;
        public UsuarioLoginController()
        {
            negocio = new NUsuario();

        }

        public IHttpActionResult Post([FromBody]UserLoginRequest usuario)
        {
            var response = negocio.Login(usuario);
            if (response.IsSuccess)
            {
                return Ok(response.Message);
            }

            return BadRequest(response.Message);
        }
    }
}
