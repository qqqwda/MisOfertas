using MisOfertas.API.Models;
using MisOfertas.CapaDatos.JModels;
using MisOfertas.CapaDatos.Models;
using MisOfertas.CapaNegocio.Casos_de_Negocio;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MisOfertas.API.Controllers
{
    public class EmpresaController : ApiController
    {
        NEmpresa Negocio;
        LocalDataContext Db;

        public EmpresaController()
        {
            Negocio = new NEmpresa();
            Db = new LocalDataContext();
        }

        public IEnumerable<Empresa> Get()
        {
            return Db.Empresas.ToList();
        }

        public IHttpActionResult Post([FromBody]EmpresaModel empresa)
        {
            var response = Negocio.Create(empresa);
            if (response.IsSuccess)
            {
                return Ok(response.Message);
            }

            return BadRequest(response.Message);
        }

        public IHttpActionResult Delete(int id)
        {
            var response = Negocio.Delete(id);
            if (response.IsSuccess)
            {
                return Ok(response.Message);
            }

            return BadRequest(response.Message);
        }

        public IHttpActionResult Put(int id, [FromBody] EmpresaModel empresa)
        {
            var response = Negocio.Update(id, empresa);
            if (response.IsSuccess)
            {
                return Ok(response.Message);
            }

            return BadRequest(response.Message);
        }
    }
}
