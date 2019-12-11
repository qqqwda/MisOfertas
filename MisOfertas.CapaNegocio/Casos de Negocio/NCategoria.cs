using MisOfertas.CapaDatos;
using MisOfertas.CapaDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MisOfertas.CapaNegocio.Casos_de_Negocio
{
    public class NCategoria : IMaintanable<Categoria>
    {
        CommonContext Bd;
        public NCategoria()
        {
            Bd = new CommonContext();
        }


        public Response<Categoria> Create(Categoria obj)
        {

            throw new NotImplementedException();
        }

        public Response<Categoria> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> ToList()
        {

            return Bd.Categorias.ToList();

        }



        public Response<Categoria> Update(int id, Categoria obj)
        {
            throw new NotImplementedException();
        }
    }
}
