using System;
using System.Net;
using System.Net.Mail;

namespace MisOfertas.WEB
{
    public partial class PruebaCorreo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtAsunto.Text != string.Empty && txtCuerpo.Text != string.Empty)
            {
                EnviarCorreo(txtAsunto.Text, txtCuerpo.Text, "cristopher.e.rivera@gmail.com");
            }

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
                correos.To.Add("cristopher.e.rivera@gmail.com");

                //if (ruta.Equals("") == false)
                //{
                //    System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment(ruta);
                //    correos.Attachments.Add(archivo);
                //}

                correos.From = new MailAddress("ofertas.portafolio@gmail.com");
                envios.Credentials = new NetworkCredential("ofertas.portafolio@gmail.com", "ofertas123");

                //Datos importantes no modificables para tener acceso a las cuentas

                envios.Host = "smtp.gmail.com";
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