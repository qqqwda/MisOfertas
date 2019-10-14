using MisOfertas.CapaDatos;
using MisOfertas.CapaDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaNegocio.Casos_de_Negocio
{
    public class NValoracion : IMaintanable<Valoracion>
    {
        CommonContext Bd;
        public NValoracion()
        {
            Bd = new CommonContext();
        }

        public Response<Valoracion> Create(Valoracion obj)
        {
            throw new NotImplementedException();
        }

        public Response<Valoracion> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Valoracion> ToList()
        {
            throw new NotImplementedException();
        }

        public Response<Valoracion> Update(int id, Valoracion obj)
        {
            throw new NotImplementedException();
        }
    }
}
