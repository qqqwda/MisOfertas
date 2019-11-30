using MisOfertas.CapaDatos;
using MisOfertas.CapaDatos.JModels;
using MisOfertas.CapaDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            if (string.IsNullOrEmpty(usuario.Password))
            {
                return new Response<Usuario> { Answer = null, IsSuccess = false, Message = "Campo 'usuario' vacío" };
            }



            usuario.Password = Encriptar(usuario.Password); //encriptar contra en la base de datos


            //UsuarioModel us = new UsuarioModel();
            // var resultado = us.Create(usuario);


            usuario.Puntos = 0;
            // para q se cree en valores cero para NUEVOS USUARIO CLIENTE

            Bd.Database.ExecuteSqlCommand("INSERT INTO Usuarios(Rut, Nombre, Apellido, Correo, Telefono, FechaNacimiento, TipoUsuario_IdTipoUsuario, Password, Suscrito, Puntos, Empresa_IdEmpresa, Comuna) VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})"
               , usuario.Rut, usuario.Nombre, usuario.Apellido, usuario.Correo, usuario.Telefono, usuario.FechaNacimiento, 3, usuario.Password, usuario.Suscrito, usuario.Puntos, null, usuario.Comuna);
            Bd.SaveChanges();

            return new Response<Usuario> { Answer = null, IsSuccess = true, Message = "Usuario Creado Correctamente" };
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
            //if (string.IsNullOrEmpty(usuario.FechaNacimiento.ToString()))
            //{
            //    return new Response<Usuario> { Answer = null, IsSuccess = false, Message = "Campo 'Fecha nacimiento' vacío" };
            //}
            if (string.IsNullOrEmpty(usuario.Password))
            {
                return new Response<Usuario> { Answer = null, IsSuccess = false, Message = "Campo 'usuario' vacío" };
            }
            if (usuario.IdEmpresa <= 0)
            {
                return new Response<Usuario> { Answer = null, IsSuccess = false, Message = "Campo 'empresa' vacío" };
            }
            if (usuario.IdTipoUsuario <= 0)
            {
                return new Response<Usuario> { Answer = null, IsSuccess = false, Message = "Campo 'tipo usuario' vacío" };
            }

            string pwEncriptada = Encriptar(usuario.Password);
      
            Bd.Database.ExecuteSqlCommand("INSERT INTO Usuarios(Rut, Nombre, Apellido, Correo, Telefono, FechaNacimiento, TipoUsuario_IdTipoUsuario, Password, Suscrito, Puntos, Empresa_IdEmpresa, Comuna) VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})"
                , usuario.Rut, usuario.Nombre, usuario.Apellido, usuario.Correo, usuario.Telefono, usuario.FechaNacimiento, usuario.IdTipoUsuario, pwEncriptada, usuario.Suscrito, usuario.Puntos, usuario.IdEmpresa, usuario.Comuna);
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


        public Response<Usuario> Update(int id, UsuarioModel usuario)
        {

            if (string.IsNullOrEmpty(usuario.Rut))
            {
                return new Response<Usuario> { IsSuccess = false, Answer = null, Message = "El Rut no puede estar vacio" };
            }

            if (string.IsNullOrEmpty(usuario.Nombre))
            {
                return new Response<Usuario> { IsSuccess = false, Answer = null, Message = "El Nombre no puede estar vacio" };
            }

            if (string.IsNullOrEmpty(usuario.Apellido))
            {
                return new Response<Usuario> { IsSuccess = false, Answer = null, Message = "El Apellido no puede estar vacio" };
            }

            if (string.IsNullOrEmpty(usuario.Correo))
            {
                return new Response<Usuario> { IsSuccess = false, Answer = null, Message = "El Correo no puede estar vacio" };
            }

            if (string.IsNullOrEmpty(usuario.Correo))
            {
                return new Response<Usuario> { IsSuccess = false, Answer = null, Message = "El Apellido no puede estar vacio" };
            }

            if (string.IsNullOrEmpty(usuario.Telefono.ToString()))
            {
                return new Response<Usuario> { IsSuccess = false, Answer = null, Message = "El Telefono no puede estar vacio" };
            }

            if (string.IsNullOrEmpty(usuario.Password))
            {
                return new Response<Usuario> { IsSuccess = false, Answer = null, Message = "La Password no puede estar vacio" };
            }


            if (usuario.IdEmpresa == 0)
            {
                return new Response<Usuario> { IsSuccess = false, Answer = null, Message = "No pertenece a empresa" };
            }

            string pwEncriptada = Encriptar(usuario.Password);

            Bd.Database.ExecuteSqlCommand(string.Format("UPDATE Usuarios SET Rut = '{0}', Nombre = '{1}', Apellido = '{2}',  Correo = '{3}', Telefono = '{4}', FechaNacimiento = '{5}', TipoUsuario_IdTipoUsuario = '{6}', Password = '{7}', Comuna = '{8}', Suscrito = '{9}', Puntos = '{10}', Empresa_IdEmpresa = '{11}' WHERE IdUsuario = '{12}'",
                                                         usuario.Rut, usuario.Nombre, usuario.Apellido, usuario.Correo, usuario.Telefono, usuario.FechaNacimiento, usuario.IdTipoUsuario, pwEncriptada, usuario.Comuna, usuario.Suscrito, usuario.Puntos, usuario.IdEmpresa, id));
            Bd.SaveChanges();

            return new Response<Usuario> { IsSuccess = true, Answer = null, Message = "Producto actualizado" };

        }



        public string Encriptar(string texto)
        {

            string key = "mikey";


            //arreglo de bytes donde guardaremos la llave
            byte[] keyArray;
            //arreglo de bytes donde guardaremos el texto
            //que vamos a encriptar
            byte[] Arreglo_a_Cifrar =
            UTF8Encoding.UTF8.GetBytes(texto);

            //se utilizan las clases de encriptación
            //provistas por el Framework
            //Algoritmo MD5
            MD5CryptoServiceProvider hashmd5 =
            new MD5CryptoServiceProvider();
            //se guarda la llave para que se le realice
            //hashing
            keyArray = hashmd5.ComputeHash(
            UTF8Encoding.UTF8.GetBytes(key));

            hashmd5.Clear();

            //Algoritmo 3DAS
            TripleDESCryptoServiceProvider tdes =
            new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            //se empieza con la transformación de la cadena
            ICryptoTransform cTransform =
            tdes.CreateEncryptor();

            //arreglo de bytes donde se guarda la
            //cadena cifrada
            byte[] ArrayResultado =
            cTransform.TransformFinalBlock(Arreglo_a_Cifrar,
            0, Arreglo_a_Cifrar.Length);

            tdes.Clear();

            //se regresa el resultado en forma de una cadena
            return Convert.ToBase64String(ArrayResultado,
            0, ArrayResultado.Length);
        }

        public Response<Usuario> Update(int id, Usuario obj)
        {
            throw new NotImplementedException();
        }
    }
}
