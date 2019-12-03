using MisOfertas.CapaDatos.Models;
using System;
using System.Net;
using System.Net.Mail;
using System.Web.UI;

namespace MisOfertas.WEB
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        Usuario objUsuario = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if ((Usuario)Session["usuario"] != null)
                {

                    objUsuario = (Usuario)Session["usuario"];
                    CargarDefault(objUsuario);
                   
                }
            }
        }
            

        private void CargarDefault(Usuario objUsuario)
        {
            
            liCorreo.InnerHtml = "Inicio sesion con :"+" "+ objUsuario.Correo;
            //liCelular.InnerHtml = "su telefono"+objUsuario.Telefono.ToString();
            liInicioSesion.InnerText = "Bienvenido/a "+ objUsuario.Nombre + " " +  objUsuario.Apellido;
        }

        protected void btnSuscribir_Click(object sender, EventArgs e)
        {
            EnviarCorreo("Aviso De Suscripcion Pagina Mis Ofertas", "Usted Se Ha Suscrito Exitosamente a MIsOfertas", txtCorreo.Text);

            //ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), Guid.NewGuid().ToString(), "alert('Suscripcion Ha sido exitosa.Felicidades!!!')", true);

            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "mensaje", "<script> swal('Se Ha Suscrito Con Exito!', 'Felicidades, Presione Ok!', 'success') </script>");
        }



        private void EnviarCorreo(string asunto, string cuerpo, string correo)
        {
            try

            {
                MailMessage correos = new MailMessage();
                SmtpClient envios = new SmtpClient();


                correos.To.Clear();
                correos.Body = "";
                correos.Subject = "";
                correos.Body = cuerpo;
                correos.Subject = asunto;
                correos.IsBodyHtml = true;
                correos.To.Add(txtCorreo.Text); //correos que se escriban en el campo por defecto
                //correos.To.Add("cri.riverab@alumnos.duoc.cl");

                if (correo.Equals("txtCorreo") == false)
                {
                //System.Net.Mail.Attachment archivo = new Attachment("C:/Users/CRISTOPHER/Desktop/DEMRE/BUENA.pdf");
                correos.Attachments.Add(new Attachment("C:/Users/CRISTOPHER/Desktop/DEMRE/BUENA.pdf")); 
                }

                correos.From = new MailAddress("ofertas.portafolio@gmail.com");
                envios.Credentials = new NetworkCredential("ofertas.portafolio@gmail.com", "ofertas123");

                //Datos importantes no modificables para tener acceso a las cuentas

                envios.Host = "smtp.gmail.com"; //dominio
                envios.Port = 587;
                envios.EnableSsl = true;

                envios.Send(correos);

            }
            catch (Exception ex)
            {

            }
        }
    }
}