using MisOfertas.CapaDatos;
using MisOfertas.CapaDatos.JModels;
using MisOfertas.CapaDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaNegocio.Casos_de_Negocio
{
    public class NEmpresa : IMaintanable<Empresa>
    {
        CommonContext Bd;
        public NEmpresa()
        {
            this.Bd = new CommonContext();
        }
        public Response<Empresa> Create(EmpresaModel empresa)
        {
            if (string.IsNullOrEmpty(empresa.Actividad))
            {
                return new Response<Empresa> { Answer = null, IsSuccess = false, Message = "Campo 'actividad' vacio" };
            }
            if (string.IsNullOrEmpty(empresa.Comuna))
            {
                return new Response<Empresa> { Answer = null, IsSuccess = false, Message = "Campo 'comuna' vacio" };
            }
            if (string.IsNullOrEmpty(empresa.Direccion))
            {
                return new Response<Empresa> { Answer = null, IsSuccess = false, Message = "Campo 'dirección' vacio" };
            }
            if (string.IsNullOrEmpty(empresa.Nombre))
            {
                return new Response<Empresa> { Answer = null, IsSuccess = false, Message = "Campo 'nombre' vacio" };
            }
            if (string.IsNullOrEmpty(empresa.Region))
            {
                return new Response<Empresa> { Answer = null, IsSuccess = false, Message = "Campo 'región' vacio" };
            }
            if (string.IsNullOrEmpty(empresa.Rut))
            {
                return new Response<Empresa> { Answer = null, IsSuccess = false, Message = "Campo 'rut' vacio" };
            }
            if (string.IsNullOrEmpty(empresa.Telefono.ToString()))
            {
                return new Response<Empresa> { Answer = null, IsSuccess = false, Message = "Campo 'empresa' vacio" };
            }

            Empresa empresaModel = new Empresa
            {
                Actividad = empresa.Actividad,
                Comuna = empresa.Comuna,
                Direccion = empresa.Direccion,
                Locales = null,
                Usuarios = null,
                Telefono = empresa.Telefono,
                Nombre = empresa.Nombre,
                Productos = null,
                Region = empresa.Region,
                Rut = empresa.Rut
            };
            this.Bd.Empresas.Add(empresaModel);
            this.Bd.SaveChanges();

            return new Response<Empresa> { Answer = empresaModel, IsSuccess = true, Message = "Empresa creada correctamente" };
           

        }

        public Response<Empresa> Create(Empresa obj)
        {
            throw new NotImplementedException();
        }

        public Response<Empresa> Delete(int id)
        {
            try
            {
                var empresa = this.Bd.Empresas.FirstOrDefault(e => e.IdEmpresa == id);
                this.Bd.Empresas.Remove(empresa);
                return new Response<Empresa> { IsSuccess= true, Answer = empresa, Message="Empresa eliminada"};
            }
            catch (Exception)
            {
                return new Response<Empresa> { IsSuccess = false, Answer = null, Message = "Empresa no pudo ser eliminada" };
            }
            
        }

        public List<Empresa> ToList()
        {
            try
            {
                return this.Bd.Empresas.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Response<Empresa> Update(int id)
        {
            return new Response<Empresa> { IsSuccess = false, Message = "" };
        }
    }
}
