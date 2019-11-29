using MisOfertas.CapaDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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