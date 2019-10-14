using MisOfertas.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaNegocio
{
    interface IMaintanable<T>
    {
        Response<T> Create(T obj);
        List<T> ToList();

        Response<T> Update(int id, T obj);

        Response<T> Delete (int id);



    }
}
