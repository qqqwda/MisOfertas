using MisOfertas.CapaDatos.Models;
using MisOfertas.CapaNegocio.Casos_de_Negocio;
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
    public partial class HomeGerente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var sesion = (Usuario)Session["usuario"];
            if (sesion.TipoUsuario.IdTipoUsuario != 3)
            {
                Response.Redirect("Inicio.aspx");
            }

            if (!IsPostBack)
            {
                CargarGV();

            }
        }



        private void CargarGV()
        {
            NOferta oferta = new NOferta();
            var listaOfertas = oferta.ToList();

            GvOfertas.DataSource = listaOfertas;
            GvOfertas.DataBind();

            NOferta negocioOferta = new NOferta();
          
        }

        protected void BtnExportarExcel_Click(object sender, ImageClickEventArgs e)
        {
            ExportToExcel("ListaTodasOfertas.xls", GvOfertas);
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

        protected void btntxt_Click(object sender, ImageClickEventArgs e)
        {

            StringBuilder sw = new StringBuilder();
            NOferta oferta = new NOferta();
            var listaOfertas = oferta.ToList();
            int conteo = listaOfertas.Count;
            foreach (var item in listaOfertas)
            {
                if (conteo == 1)
                {
                    sw.Append(item.IdOferta);
                }
                else
                {
                    sw.Append(item.IdOferta + ";" + item.Descripcion + ";" + item.Valor + ";"); //adjuntar las cosas q quiero para archivo plano
                }


                conteo--;
            }


            Response.Clear();

            Response.ContentType = "application/octet-stream";
            Response.AddHeader("Content-Disposition", "attachment;filename=LISTAOFERTAS.txt");
            Response.Buffer = true;
            Response.Write(sw.ToString());
            Response.End();




        }

        //protected void btneditar_Click(object sender, EventArgs e)
        //{
        //    pnlEditar.Visible = true;
        //    hdfEditar.Value = "1";
        //    CargarEditar(int.Parse(hdfEditar.Value.ToString()));
        //}

        //private void CargarEditar(int IDOferta)
        //{
        //    NOferta oferta = new NOferta();
        //    var objOferta = oferta.Traer(IDOferta);
        //    txteditar.Text = objOferta.Descripcion;
        //}

        //protected void btnGuardarEditar_Click(object sender, EventArgs e)
        //{
        //    NOferta oferta = new NOferta();
        //    var objOferta = oferta.Traer(int.Parse(hdfEditar.Value.ToString()));
        //    objOferta.Descripcion = txteditar.Text;

        //    if (oferta.Update(objOferta))
        //    {
        //        string fun = "funciono";
        //        CargarGV();
        //    }
        //    else
        //    {

        //    }
        //}

        

        protected void btnEliminar_Command(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            NOferta noferta = new NOferta();
            noferta.Delete(id);
            Response.Redirect("HomeEncargado.aspx");
        }

        //protected void btneditar_Command(object sender, CommandEventArgs e)
        //{
        //    int id = int.Parse(e.CommandArgument.ToString());
        //    Response.Redirect("EditarOferta.aspx?id=" + id);
        //}


        protected void GvOfertas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void GvOfertas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btneditar_Command1(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("EditarOferta.aspx?id=" + id);
        }
    }
}