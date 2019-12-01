using MisOfertas.CapaNegocio.Casos_de_Negocio;
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
                CargarComentarios(id);
            }
        }

        private void CargarComentarios(string id)
        {
            int.Parse(id);
            NOferta ofertas = new NOferta();
            var listaOfertas = ofertas.ToList().Where(o => o.Producto.Categoria.IdCategoria == int.Parse(id));
            foreach (var item in listaOfertas)
            {
                //cargar comentarios con item.OpinionOferta
            }
        }

        private void TraerOfertasPorCategoria(string id)
        {
            int.Parse(id);
            NOferta ofertas = new NOferta();
            var listaOfertas = ofertas.ToList().Where(o => o.Producto.Categoria.IdCategoria == int.Parse(id)).ToList();
        }
    }
}