using MisOfertas.API.Models;
using MisOfertas.CapaDatos;
using MisOfertas.CapaNegocio;
using System.Collections.Generic;
using System.Web.Http;

namespace MisOfertas.API.Controllers
{
    public class UsersController : ApiController
    {
        LocalDataContext db;
        UserManager manager;

        public UsersController()
        {
            manager = new UserManager();
            db = new LocalDataContext();
        }

        public IEnumerable<User> Get()
        {
            return manager.ToList();
        }

        public IHttpActionResult Post([FromBody]User user)
        {
            var response = manager.Create(user);
            if (response.IsSuccess)
            {
                return Ok(response.Message);
            }

            return BadRequest(response.Message);
        }

        public IHttpActionResult Delete(int id)
        {
            var response = manager.Delete(id);
            if (response.IsSuccess)
            {
                return Ok(response.Message);
            }

            return BadRequest(response.Message);
        }


    }
}