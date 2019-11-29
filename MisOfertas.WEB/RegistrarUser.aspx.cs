using MisOfertas.CapaDatos.JModels;
using MisOfertas.CapaDatos.Models;
using MisOfertas.CapaNegocio.Casos_de_Negocio;

using System;
using System.Web.UI;

namespace MisOfertas.WEB
{
    public partial class RegistrarUser : System.Web.UI.Page
    {
         public Usuario user { get { return (Usuario)Session["usuario"]; } set { Session["usuario"] = value; } } 
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    if (user.TipoUsuario.IdTipoUsuario != 2) //distinto a 2, solo 2 ingresa
            //    {
            //        Response.Redirect("");
            //    }
            //    Session.Abandon();
            //}
        }

        protected void BtnRegistrar_Click(object sender, EventArgs e)

        {
            //Usuario UsuarioRgstro = (Usuario)Session["usuario"];

            //Usuario NewUsuario = new Usuario();
            //var listaUser = usuario.ToList();

            //NUsuario negocio = new NUsuario();
            Usuario oUser = new Usuario(); //usando el jmodel

            oUser.Rut = txtRut.Text;
            oUser.Nombre = txtNombre.Text;
            oUser.Apellido = txtApellidos.Text;
            oUser.Telefono = int.Parse(txtTelefono.Text);
            //oUser.COMUNAA = ddlUbicacion.SelectedItem.Text.ToString(); CARGAR DDL DE COMUNAS
            oUser.Password = txtPassword.Text;
            oUser.Correo = txtCorreo.Text;
            oUser.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            oUser.Comuna=txtComuna.Text;

            NUsuario us = new NUsuario();
            var resultado = us.Create(oUser);

            if (resultado.IsSuccess)
            {
                
                LimpiarControles();

                //ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), Guid.NewGuid().ToString(), "alert('Se ha Registrado Exitosamente! Felicidades!!')", true);

                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Registro Exitoso!', 'Felicidades, Presione Ok!', 'success') </script>"); /*ésto es sweet alert llamado del script y link*/
                    //ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "redirigir");
            }


            else
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), Guid.NewGuid().ToString(), "alert('No se ha podido registrar :c')", true);
            }
        }

        private void LimpiarControles()
        {
            txtRut.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtFechaNacimiento.Text = string.Empty;
            txtComuna.Text = string.Empty;

            //ddlComuna.SelectedIndex = 1;



        }
    }
}
    



