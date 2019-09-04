using MisOfertas.API.Models;
using MisOfertas.CapaDatos;
using MisOfertas.CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MisOfertas.API.Controllers
{
    public class UserLoginController : ApiController
    {
        SessionManager sessionManager;
        UserManager manager;

        public UserLoginController()
        {
            manager = new UserManager();
            sessionManager = new SessionManager();
        }

        public IHttpActionResult Post([FromBody]UserLoginRequest user)
        {
            var response = sessionManager.Login(user);

            if (response.IsSuccess)
            {
                return Ok(response);
            }

            return Ok(response);
        }

        public IHttpActionResult Delete(string nombre)
        {
            var response = manager.Delete(nombre);
            if (response.IsSuccess)
            {
                return Ok(response.Message);
            }

            return BadRequest(response.Message);
        }



    }
}
