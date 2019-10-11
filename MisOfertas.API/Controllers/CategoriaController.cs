using MisOfertas.API.Models;
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
    public class CategoriaController : ApiController
    {

        MainCasosNegocio Negocio;
        LocalDataContext Db;

        public CategoriaController()
        {
            Negocio = new MainCasosNegocio();
            Db = new LocalDataContext();
        }

        public IEnumerable<Categoria> Get()
        {
            return Db.Categorias.ToList();
        }
    }
}
