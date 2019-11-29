using MisOfertas.CapaDatos.Models;
using MisOfertas.CapaNegocio.Casos_de_Negocio;
using System;

namespace MisOfertas.WEB
{
    public partial class INICIO : System.Web.UI.Page
    {
        Usuario objUsuario = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {

           
            if (!IsPostBack)
            {
                if((Usuario)Session["usuario"] != null )
                {
                    objUsuario = (Usuario)Session["usuario"];
                    switch(objUsuario.TipoUsuario.IdTipoUsuario)
                    {
                        case 1:
                            break;
                        case 2:
                            break;  
                            //administrador
                        case 3:
                            
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}