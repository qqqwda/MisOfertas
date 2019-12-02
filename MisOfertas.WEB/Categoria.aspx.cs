using MisOfertas.CapaDatos.JModels;
using MisOfertas.CapaNegocio.Casos_de_Negocio;
using MisOfertas.CapaNegocio.Casos_de_Negocio_Web.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MisOfertas.WEB
{
    public partial class Categoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];
                TraerOfertasPorCategoria(id);
            }
        }

        

        private void TraerOfertasPorCategoria(string id)
        {
            int.Parse(id);

            
            List<OfertaProductoModel> ofertaProductos = Helper.OfertasProductos(int.Parse(id));
            dlOfertasPorCategoria.DataSource = ofertaProductos;
            dlOfertasPorCategoria.DataBind();
        }

        protected void BtnCategoria_Click(object sender, EventArgs e)
        {

        }
    }
}