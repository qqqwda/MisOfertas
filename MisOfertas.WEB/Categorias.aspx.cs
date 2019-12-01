using MisOfertas.CapaNegocio.Casos_de_Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MisOfertas.WEB
{
    public partial class Categorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCategorias();
            }
            
        }

        private void CargarCategorias()
        {
            NCategoria categorias = new NCategoria();
            dlCategorias.DataSource = categorias.ToList();
            dlCategorias.DataBind();
        }

        protected void Categoria_Command(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("Categoria.aspx?id=" + id);
        }
        
    }
}