using MisOfertas.CapaDatos.JModels;
using MisOfertas.CapaDatos.Models;
using MisOfertas.CapaNegocio.Casos_de_Negocio;
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
                CapaDatos.Models.Oferta oferta = new CapaDatos.Models.Oferta();
                 oferta = CargarOferta(idOferta);
                CargarComentarios(oferta);


            }
        }

        private void CargarComentarios(CapaDatos.Models.Oferta oferta)
        {

            List<OpinionOferta> listaOpinion = new List<OpinionOferta>(); 
            try
            {
                listaOpinion = oferta.OpinionOfertas.ToList();
            }
            catch (Exception)
            {

                throw;
            }


        }

        private CapaDatos.Models.Oferta CargarOferta(int id)
        {
            try
            {
                NOferta negocio = new NOferta();
                CapaDatos.Models.Oferta oferta = negocio.ToList().FirstOrDefault(x => x.IdOferta == id);
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
            opinion.Comentario = "";
            opinion.FechaPublicacion = DateTime.Now;
            opinion.IdOferta = idOferta;
            opinion.IdUsuario = sesion.IdUsuario;
            opinion.Imagen = "";

            negocio.Create(opinion);
            
            
        }


    }
}