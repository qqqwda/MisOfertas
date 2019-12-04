using System;
using System.Web;

namespace MisOfertas.WEB
{
    public partial class Salir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Abandon();
            //Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            Response.Redirect("Login.aspx");
        }
    }
}