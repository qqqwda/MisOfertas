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

                var response = negocio.Login(request);
                if (response.IsSuccess)
                {
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), Guid.NewGuid().ToString(), "alert('"+response.Message+"')", true);
                }
                
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), Guid.NewGuid().ToString(), "alert('Ingresar datos,estan vacios')", true);
            }
        }
    }
}