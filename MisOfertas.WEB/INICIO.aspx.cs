using MisOfertas.CapaDatos.Models;
using MisOfertas.CapaNegocio.Casos_de_Negocio;
using System;
using System.Collections.Generic;

namespace MisOfertas.WEB
{
    public partial class INICIO : System.Web.UI.Page
    {
        Usuario objUsuario = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {

           
            if (!IsPostBack)
            {
                List<string> lista = new List<string>() { "ola", "alo", "ole" };

                dlProductos.DataSource = lista;
                dlProductos.DataBind();
            }
        }
    }
}