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
                //us oUsuario = T001_UsuarioBLL.ValidarUsuario(int.Parse(txtRut.Text), txtPass.Text);

                //if (oUsuario != null)
                //{

                //    Session["Usuario"] = oUsuario;
                //    Response.Redirect("Default.aspx");

                //}
                //else
                //{
                //    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), Guid.NewGuid().ToString(), "alert('Rut o Contraseña incorrecta')", true);
                //}
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), Guid.NewGuid().ToString(), "alert('Ingresar datos,estan vacios')", true);
            }
        }
    }
}