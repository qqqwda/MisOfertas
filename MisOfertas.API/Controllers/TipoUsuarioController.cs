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
    public class TipoUsuarioController : ApiController
    {

        NTipoUsuario negocio;
        public TipoUsuarioController()
        {
            negocio = new NTipoUsuario();
        }
        public IEnumerable<TipoUsuario> Get()
        {
            return negocio.ToList();
        }
    }
}
