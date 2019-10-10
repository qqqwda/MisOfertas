using MisOfertas.CapaDatos;
using MisOfertas.CapaDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaNegocio.Casos_de_Negocio
{
    class NEmpresa : IMaintanable<Empresa>
    {
        public NEmpresa()
        {

        }
        public Response<Empresa> Create(Empresa obj)
        {
            throw new NotImplementedException();
        }

        public Response<Empresa> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Empresa> ToList()
        {
            throw new NotImplementedException();
        }

        public Response<Empresa> Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
