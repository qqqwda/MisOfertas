using MisOfertas.CapaDatos;
using MisOfertas.CapaDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaNegocio.Casos_de_Negocio
{
    public class NOferta : IMaintanable<Oferta>
    {
        CommonContext Bd;
        public NOferta()
        {
            Bd = new CommonContext();
        }
        public Response<Oferta> Create(Oferta obj)
        {
            throw new NotImplementedException();
        }

        public Response<Oferta> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Oferta> ToList()
        {
            throw new NotImplementedException();
        }

        
        public Response<Oferta> Update(int id, Oferta obj)
        {
            throw new NotImplementedException();
        }
    }
}
