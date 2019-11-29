using MisOfertas.CapaDatos;
using MisOfertas.CapaNegocio.Casos_de_Negocio_Web;
using System;
using System.Web.UI;

namespace MisOfertas.WEB
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Abandon();
            }
        }

        

        

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text != string.Empty && txtPass.Text != string.Empty)
            {
                NUsuario negocio = new NUsuario();

                UserLoginRequest request = new UserLoginRequest();

                request.Email = txtCorreo.Text;
                request.Password = txtPass.Text;

                var responseAux = negocio.Login(request);
                if (responseAux.IsSuccess)
                {

                    var objUsuario = negocio.Traer(txtCorreo.Text);
                    Session["usuario"] = objUsuario;
                    Response.Redirect("INICIO.aspx");

                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), Guid.NewGuid().ToString(), "alert('" + responseAux.Message + "')", true);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), Guid.NewGuid().ToString(), "alert('Usuario O Contraseña incorrectos')", true);
                }

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), Guid.NewGuid().ToString(), "alert('Ingrese datos,estan vacios')", true);
            }
        }

        //protected void BtnVolver_Click(object sender, ImageClickEventArgs e)
        //{
        //    Response.Redirect("OfertasHot.aspx");
        //}
    }
}
    
