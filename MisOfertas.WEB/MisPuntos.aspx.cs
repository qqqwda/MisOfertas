using MisOfertas.CapaDatos.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MisOfertas.WEB
{
	public partial class MisPuntos : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
           
        }

        protected void BtnExportarMisPuntos_Click(object sender, ImageClickEventArgs e)
        {
            //ExportToExcel("CuponMisOfertas.xls", TraerPuntors);
        }


        private void ExportToExcel(string ListaOfertas, GridView wControl)
        {
            HttpResponse response = Response;
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            Page pageToRender = new Page();
            HtmlForm form = new HtmlForm();
            form.Controls.Add(wControl);
            pageToRender.Controls.Add(form);
            response.Clear();
            response.Buffer = true;
            response.ContentType = "application/vnd.ms-excel";
            response.AddHeader("Content-Disposition", "attachment;filename=" + ListaOfertas);
            response.Charset = "UTF-8";
            response.ContentEncoding = Encoding.Default;
            pageToRender.RenderControl(htw);
            response.Write(sw.ToString());
            response.End();
        }





        



    }
}