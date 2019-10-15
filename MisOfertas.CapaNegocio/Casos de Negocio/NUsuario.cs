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
    public class NUsuario : IMaintanable<Usuario>
    {

        CommonContext Bd;
        public NUsuario()
        {
            Bd = new CommonContext();
        }
        public Response<Usuario> Create(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.Rut))
            {

            }
            if (string.IsNullOrEmpty(usuario.Apellido))
            {
                return new Response<Usuario> { Answer = null, IsSuccess = false, Message = "Campo 'apellido' vacío" };
            }
            if (string.IsNullOrEmpty(usuario.Comuna))
            {
                return new Response<Usuario> { Answer = null, IsSuccess = false, Message = "Campo 'comuna' vacío" };
            }
            if (string.IsNullOrEmpty(usuario.Correo))
            {
                return new Response<Usuario> { Answer = null, IsSuccess = false, Message = "Campo 'correo' vacío" };
            }
            if (string.IsNullOrEmpty(usuario.Correo))
            {
                return new Response<Usuario> { Answer = null, IsSuccess = false, Message = "Campo 'correo' vacío" };
            }

            return new Response<Usuario> { Answer = null, IsSuccess = false, Message = "Campo apellido vacío" };

        }



        public Response<Usuario> Create(UsuarioModel usuario)
        {
            if (string.IsNullOrEmpty(usuario.Telefono.ToString()))
            {
                return new Response<Usuario> { Answer = null, IsSuccess = false, Message = "Campo 'telefono' vacío" };
            }
            if (string.IsNullOrEmpty(usuario.Apellido))
            {
                return new Response<Usuario> { Answer = null, IsSuccess = false, Message = "Campo 'apellido' vacío" };
            }
            if (string.IsNullOrEmpty(usuario.Comuna))
            {
                return new Response<Usuario> { Answer = null, IsSuccess = false, Message = "Campo 'comuna' vacío" };
            }
            if (string.IsNullOrEmpty(usuario.Correo))
            {
                return new Response<Usuario> { Answer = null, IsSuccess = false, Message = "Campo 'correo' vacío" };
            }
            if (string.IsNullOrEmpty(usuario.Correo))
            {
                return new Response<Usuario> { Answer = null, IsSuccess = false, Message = "Campo 'correo' vacío" };
            }
            if (string.IsNullOrEmpty(usuario.Nombre))
            {
                return new Response<Usuario> { Answer = null, IsSuccess = false, Message = "Campo 'nombre' vacío" };
            }
            if (string.IsNullOrEmpty(usuario.FechaNacimiento.ToString()))
            {
                return new Response<Usuario> { Answer = null, IsSuccess = false, Message = "Campo 'Fecha nacimiento' vacío" };
            }
            if (string.IsNullOrEmpty(usuario.Password))
            {
                return new Response<Usuario> { Answer = null, IsSuccess = false, Message = "Campo 'usuario' vacío" };
            }
            if (usuario.IdEmpresa <=0)
            {
                return new Response<Usuario> { Answer = null, IsSuccess = false, Message = "Campo 'empresa' vacío" };
            }
            if (usuario.IdTipoUsuario <=0)
            {
                return new Response<Usuario> { Answer = null, IsSuccess = false, Message = "Campo 'tipo usuario' vacío" };
            }
            Bd.Database.ExecuteSqlCommand("INSERT INTO Usuarios(Rut, Nombre, Apellido, Correo, Telefono, FechaNacimiento, TipoUsuario_IdTipoUsuario, Password, Suscrito, Puntos, Empresa_IdEmpresa, Comuna) VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})"
                ,usuario.Rut, usuario.Nombre, usuario.Apellido, usuario.Correo, usuario.Telefono, usuario.FechaNacimiento, usuario.IdTipoUsuario, usuario.Password, usuario.Suscrito, usuario.Puntos, usuario.IdEmpresa, usuario.Comuna);
            Bd.SaveChanges();
            return new Response<Usuario> { Answer = null, IsSuccess = true, Message = "Usuario creado correctamente" };


        }


        public Response<Usuario> Delete(int id)
        {
            try
            {
                var usuario = Bd.Usuarios.First(c => c.IdUsuario.Equals(id));

                if (usuario != null)
                {
                    Bd.Usuarios.Remove(usuario);
                    Bd.SaveChanges();

                    return new Response<Usuario> { Answer = usuario, IsSuccess = true, Message = "Usuario eliminado" };
                }
                else
                {
                    return new Response<Usuario> { Answer = null, IsSuccess = false, Message = "No se pudo eliminar, usuario no existe" };
                }
            }
            catch (Exception ex)
            {

                return new Response<Usuario> { Answer = null, IsSuccess = false, Message = "No se pudo eliminar :" + ex.ToString() };
            }
        }

        public List<Usuario> ToList()
        {
            return Bd.Usuarios.ToList();
        }
        

        public Response<Usuario> Update(int id, Usuario obj)
        {
            throw new NotImplementedException();
        }
    }
}
