using MisOfertas.CapaDatos;
using MisOfertas.CapaDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaNegocio.Casos_de_Negocio
{
    public class NLocal : IMaintanable<Local>
    {
        CommonContext Bd;
        public NLocal()
        {
            Bd = new CommonContext();
        }
        public Response<Local> Create(Local local)
        {
            if (string.IsNullOrEmpty(local.Descripcion))
            {
                return new Response<Local> { Answer = null, Message = "Campo 'descripción' vacio" };
            }
            if (string.IsNullOrEmpty(local.Direccion))
            {
                return new Response<Local> { Answer = null, Message = "Campo 'Direccion' vacio" };
            }
            if (string.IsNullOrEmpty(local.Empresa.ToString()))
            {
                return new Response<Local> { Answer = null, Message = "Local debe ir ligado a 'Empresa'" };
            }

            Bd.Locales.Add(local);
            Bd.SaveChanges();

            return new Response<Local> { Answer = local, Message = "Local creado", IsSuccess=true };
        }

        public Response<Local> Delete(int id)
        {
            try
            {
                var local = this.Bd.Locales.FirstOrDefault(l => l.IdLocal == id);
                this.Bd.Locales.Remove(local);
                this.Bd.SaveChanges();

                return new Response<Local>
                {
                    Answer = local,
                    IsSuccess = true,
                    Message = "Local creado"
                };
               
            }
            catch (Exception)
            {
                return new Response<Local>
                {
                    Answer = null,
                    IsSuccess = false,
                    Message = "Local no creado"
                };
            }
        }

        public List<Local> ToList()
        {
            try
            {
                return Bd.Locales.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }
        

        public Response<Local> Update(int id, Local obj)
        {
            throw new NotImplementedException();
        }
    }
}
