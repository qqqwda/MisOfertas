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
    public partial class CrearOferta : System.Web.UI.Page
    {

        

        protected void Page_Load(object sender, EventArgs e)
        {
            var sesion = (Usuario)Session["usuario"];
            if (sesion.TipoUsuario.IdTipoUsuario != 3)
            {
                Response.Redirect("Inicio.aspx");
            }
            

            NProducto negocioProducto = new NProducto();
            ddlProducto.DataSource = negocioProducto.ToListModel();

            ddlProducto.Items.Add(new ListItem("Seleccione Un Producto","0"));

            foreach (var item in negocioProducto.ToListModel())
            {
                ListItem i = new ListItem(item.Nombre, item.IdProducto.ToString());
                ddlProducto.Items.Add(i);
                
            }
            

        }

        protected void BtnAgregarOferta_Click(object sender, EventArgs e)
        {
            NProducto oProducto = new NProducto();
            var sesion = (Usuario)Session["usuario"];
            OfertaModel ofertaModel = new OfertaModel();

            ofertaModel.CompraMax = int.Parse(txtCompraMax.Text);
            ofertaModel.CompraMin = int.Parse(txtcompraMin.Text);
            ofertaModel.Descripcion = txtDescripcion.InnerText;
            ofertaModel.PorcentajeDescuento = int.Parse(txtDescuento.Text);
            ofertaModel.Valor = int.Parse(txtValor.Text);
            ofertaModel.FechaDisponibilidad = DateTime.Parse(txtfechaProduct.Text);
            ofertaModel.IdProducto = int.Parse(ddlProducto.SelectedItem.Value);
            ofertaModel.IdUsuario = (sesion.IdUsuario);


            NOferta onOfertas = new NOferta();

            onOfertas.Create(ofertaModel);





        }
    }
}