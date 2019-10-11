using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MisOfertas.CapaDatos.Models;
using MisOfertas.CapaNegocio.Casos_de_Negocio;

namespace MisOfertas.API.Controllers
{
    public class EmpresaController : ApiController
    {
        MainCasosNegocio Negocio;

        public EmpresaController()
        {
            Negocio = new MainCasosNegocio();
        }

        public IEnumerable<Empresa> Get()
        {
            return Negocio.Empresa.ToList();
        }

        public IHttpActionResult Post([FromBody]Empresa empresa)
        {
            var response = Negocio.Empresa.Create(empresa);
            if (response.IsSuccess)
            {
                return Ok(response.Message);
            }

            return BadRequest(response.Message);
        }

        public IHttpActionResult Delete(int id)
        {
            var response = Negocio.Empresa.Delete(id);
            if (response.IsSuccess)
            {
                return Ok(response.Message);
            }

            return BadRequest(response.Message);
        }
    }
}
