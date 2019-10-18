using MisOfertas.CapaDatos;
using MisOfertas.CapaDatos.JModels;
using MisOfertas.CapaDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaNegocio.Casos_de_Negocio_Web
{
    public class NUsuario
    {
        CommonContext Bd;
        public NUsuario()
        {
            Bd = new CommonContext();
        }

        public Response<Usuario> Login(UserLoginRequest user)
        {
            try
            {
                 var response = Bd.Usuarios.FirstOrDefault(u => u.Correo == user.Email && u.Password == user.Password);
                if(response != null)
                {
                    return new Response<Usuario> { Answer = response, IsSuccess = true, Message = "Bienvenido "+response.Nombre };
                }
                return new Response<Usuario>
                {
                    Answer = null,
                    IsSuccess = false,
                    Message = "Fallo al tratar de loguearse, verifique su correo y contraseña"
                };
            }
            catch (Exception ex)
            {

                return new Response<Usuario>
                {
                    Answer = null,
                    IsSuccess = false,
                    Message = "Error: " + ex.Message
                };
            }
        }

        public Response<UsuarioModel> Registrar(UsuarioModel usuario)
        {
            try
            {
                if (!Helper.EmailHelper.IsValidEmail(usuario.Correo))
                {
                    return new Response<UsuarioModel> { Answer=null, Message="Correo no válido"};
                }
                if (string.IsNullOrEmpty(usuario.Telefono.ToString()) ||string.IsNullOrEmpty(usuario.Apellido) || string.IsNullOrEmpty(usuario.Nombre) || string.IsNullOrEmpty(usuario.Comuna) || string.IsNullOrEmpty(usuario.FechaNacimiento.ToString()))
                {
                    return new Response<UsuarioModel> { Answer = null, Message = "Porfavor, complete todos los campos" };
                }
                if (string.IsNullOrEmpty(usuario.Rut))
                {
                    return new Response<UsuarioModel> { Answer=null, Message="Ingrese campo rut" };
                }

                usuario.IdTipoUsuario = 1;
                usuario.Puntos = 0;
                usuario.IdEmpresa = 0;
              
                Bd.Database.ExecuteSqlCommand("INSERT INTO Usuarios(Rut, Nombre, Apellido, Correo, Telefono, FechaNacimiento, TipoUsuario_IdTipoUsuario, Password, Suscrito, Puntos, Empresa_IdEmpresa, Comuna) VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})"
               , usuario.Rut, usuario.Nombre, usuario.Apellido, usuario.Correo, usuario.Telefono, usuario.FechaNacimiento, usuario.IdTipoUsuario, usuario.Password, usuario.Suscrito, usuario.Puntos, usuario.IdEmpresa, usuario.Comuna);
                Bd.SaveChanges();

                return new Response<UsuarioModel>
                {
                    Answer = usuario,
                    IsSuccess = true,
                    Message = "Cuenta creada con éxito"
                };

            }
            catch (Exception ex)
            {
                return new Response<UsuarioModel>
                {
                    Answer = null,
                    IsSuccess = false,
                    Message = "Error: "+ex.Message.ToString()
                };
            }
        }
    }
}
