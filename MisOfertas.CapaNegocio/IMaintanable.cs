using MisOfertas.CapaDatos;
using System.Collections.Generic;

namespace MisOfertas.CapaNegocio
{
    interface IMaintanable<T>
    {
        Response<T> Create(T obj);
        List<T> ToList();

        Response<T> Update(int id, T obj);

        Response<T> Delete(int id);



    }
}
