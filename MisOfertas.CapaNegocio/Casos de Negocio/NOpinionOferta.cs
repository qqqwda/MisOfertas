using MisOfertas.CapaDatos;
using MisOfertas.CapaDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaNegocio.Casos_de_Negocio
{
    public class NOpinionOferta : IMaintanable<OpinionOferta>
    {
        CommonContext Bd;
        public NOpinionOferta()
        {
            Bd = new CommonContext();
        }
        public Response<OpinionOferta> Create(OpinionOferta obj)
        {
            throw new NotImplementedException();
        }

        public Response<OpinionOferta> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<OpinionOferta> ToList()
        {
            throw new NotImplementedException();
        }

        public Response<OpinionOferta> Update(int id, OpinionOferta obj)
        {
            throw new NotImplementedException();
        }
    }
}
