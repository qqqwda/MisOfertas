﻿using MisOfertas.CapaDatos;
using MisOfertas.CapaDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaNegocio.Casos_de_Negocio
{
    public class NUsuario : IMaintanable<Usuario>
    {

        CommonContext Bd;
        public NUsuario()
        {
            Bd = new CommonContext();
        }
        public Response<Usuario> Create(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public Response<Usuario> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ToList()
        {
            throw new NotImplementedException();
        }
        

        public Response<Usuario> Update(int id, Usuario obj)
        {
            throw new NotImplementedException();
        }
    }
}
