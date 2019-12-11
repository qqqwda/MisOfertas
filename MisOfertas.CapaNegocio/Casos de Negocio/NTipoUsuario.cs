using MisOfertas.CapaDatos;
using MisOfertas.CapaDatos.Models;
using System.Collections.Generic;
using System.Linq;

namespace MisOfertas.CapaNegocio.Casos_de_Negocio
{
    public class NTipoUsuario
    {
        CommonContext Bd;

        public NTipoUsuario()
        {
            Bd = new CommonContext();
        }

        public IEnumerable<TipoUsuario> ToList()
        {
            return Bd.TipoUsuarios.ToList();
        }
    }
}
