using System;

namespace MisOfertas.WEB
{
    public partial class Salir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("INICIO.aspx");
        }
    }
}