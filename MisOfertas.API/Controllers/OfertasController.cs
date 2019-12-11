using MisOfertas.CapaDatos.JModels;
using MisOfertas.CapaNegocio.Casos_de_Negocio_Web.Helper;
using System.Web.Http;

namespace MisOfertas.API.Controllers
{
    public class OfertasController : ApiController
    {
        public OfertasModel Get()
        {
            return Helper.ToOfertasModel();
        }
    }
}
