﻿using MisOfertas.CapaDatos.Models;
using System;

namespace MisOfertas.WEB
{
    public partial class MasterPgePriv : System.Web.UI.MasterPage
    {
        Usuario objUsuario = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if ((Usuario)Session["usuario"] != null)
                {

                    objUsuario = (Usuario)Session["usuario"];
                    CargarDefault(objUsuario);

                }
            }
        }





        private void CargarDefault(Usuario objUsuario)
        {


            liInicioSesion.InnerText = "Bienvenido/En Sesion: " + objUsuario.Nombre + " " + objUsuario.Apellido;
            cargaNombre.InnerText = "Bienvenido/a Encargado :" + objUsuario.Nombre;
        }
    }
}