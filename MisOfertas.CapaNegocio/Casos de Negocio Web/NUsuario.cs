using MisOfertas.CapaDatos;
using MisOfertas.CapaDatos.JModels;
using MisOfertas.CapaDatos.Models;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

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
                var objUsuario = Bd.Usuarios.FirstOrDefault(u => u.Correo == user.Email);

                if (objUsuario != null)
                {
                    if (user.Password == Desencriptar(objUsuario.Password))
                    {
                        return new Response<Usuario> { Answer = objUsuario, IsSuccess = true, Message = "Bienvenido " + objUsuario.Nombre };
                    }
                    else
                    {
                        return new Response<Usuario>
                        {
                            Answer = null,
                            IsSuccess = false,
                            Message = "Usuario y contraseña incorrecta"
                        };
                    }
                }
                else
                {
                    return new Response<Usuario>
                    {
                        Answer = null,
                        IsSuccess = false,
                        Message = "Fallo al tratar de loguearse, verifique su correo y contraseña"
                    };
                }
                /*   user.Password = Desencriptar(user.Password);*/ // DESENCRIPTAR LA CONTRA EN LA BASE DE DATOS PARA INICIAR SESION
                                                                    //
                                                                    //REVISAR EL DESENCRIPTAR NO ME LOGEA

                //var response = Bd.Usuarios.FirstOrDefault(u => u.Correo == user.Email && u.Password == user.Password);


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

        public Usuario Traer(string correo)
        {

            return Bd.Usuarios.Where(x => x.Correo == correo).FirstOrDefault();
        }

        public Response<UsuarioModel> Registrar(UsuarioModel usuario)
        {
            try
            {
                if (!Helper.EmailHelper.IsValidEmail(usuario.Correo))
                {
                    return new Response<UsuarioModel> { Answer = null, Message = "Correo no válido" };
                }
                if (string.IsNullOrEmpty(usuario.Telefono.ToString()) || string.IsNullOrEmpty(usuario.Apellido) || string.IsNullOrEmpty(usuario.Nombre) || string.IsNullOrEmpty(usuario.Comuna) || string.IsNullOrEmpty(usuario.FechaNacimiento.ToString()))
                {
                    return new Response<UsuarioModel> { Answer = null, Message = "Porfavor, complete todos los campos" };
                }
                if (string.IsNullOrEmpty(usuario.Rut))
                {
                    return new Response<UsuarioModel> { Answer = null, Message = "Ingrese campo rut" };
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
                    Message = "Error: " + ex.Message.ToString()
                };
            }
        }


        public string Desencriptar(string textoEncriptado) //DESENCRIPTAR LA CONTRASEÑA DEL LOGIN/DEL NEGOCIO WEB 
        {


            string key = "mikey";

            byte[] keyArray;
            //convierte el texto en una secuencia de bytes
            byte[] Array_a_Descifrar =
            Convert.FromBase64String(textoEncriptado);

            //se llama a las clases que tienen los algoritmos
            //de encriptación se le aplica hashing
            //algoritmo MD5
            MD5CryptoServiceProvider hashmd5 =
            new MD5CryptoServiceProvider();

            keyArray = hashmd5.ComputeHash(
            UTF8Encoding.UTF8.GetBytes(key));

            hashmd5.Clear();

            TripleDESCryptoServiceProvider tdes =
            new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform =
            tdes.CreateDecryptor();

            byte[] resultArray =
            cTransform.TransformFinalBlock(Array_a_Descifrar,
            0, Array_a_Descifrar.Length);

            tdes.Clear();
            //se regresa en forma de cadena
            return UTF8Encoding.UTF8.GetString(resultArray);
        }


    }
}
