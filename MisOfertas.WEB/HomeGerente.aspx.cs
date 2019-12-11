using MisOfertas.CapaDatos.Models;
using System;

namespace MisOfertas.WEB
{
    public partial class HomeEncargado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var sesion = (Usuario)Session["usuario"];
            if (sesion.TipoUsuario.IdTipoUsuario != 3)
            {
                Response.Redirect("Inicio.aspx");
            }

        }
    }
}