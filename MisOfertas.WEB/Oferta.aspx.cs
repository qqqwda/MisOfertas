using MisOfertas.CapaDatos.JModels;
using MisOfertas.CapaDatos.Models;
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
    public partial class Oferta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                string id = Request.QueryString["id"];
                int idOferta = int.Parse(id);
                List<OfertaProductoModel> oferta;
                oferta = Helper.OfertasProductosSegunOferta(idOferta);
                
                dlOferta.DataSource = oferta;
                dlOferta.DataBind();

                dlComentarios.DataSource = Helper.ComentariosOferta(idOferta);
                dlComentarios.DataBind();

            }
        }

        

        private List<CapaDatos.Models.Oferta> CargarOferta(int id)
        {


            try
            {
                NOferta negocio = new NOferta();
                List<CapaDatos.Models.Oferta> oferta = negocio.ToList().Where(x => x.IdOferta == id).ToList();
                return oferta;
            }
            catch (Exception)
            {

                throw;
            }

            
        }


        public void AgregarComentario()
        {
            string id = Request.QueryString["id"];
            int idOferta = int.Parse(id);

            var sesion = (Usuario)Session["usuario"];
            NOpinionOferta negocio = new NOpinionOferta();
            OpinionOfertaModel opinion = new OpinionOfertaModel();
            opinion.Comentario = txtComentario.InnerText;
            opinion.FechaPublicacion = DateTime.Now;
            opinion.IdOferta = idOferta;
            opinion.IdUsuario = sesion.IdUsuario;
            opinion.Imagen = "";

            negocio.Create(opinion);
            
            
        }

        protected void PublicarComentario_Click(object sender, EventArgs e)
        {
            var sesion = (Usuario)Session["usuario"];
            if (sesion != null)
            {
                AgregarComentario();
                string id = Request.QueryString["id"];
                Response.Redirect("Oferta.aspx?id=" + id);
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
            
        }
    }
}