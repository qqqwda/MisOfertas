﻿using MisOfertas.CapaDatos.JModels;
using MisOfertas.CapaDatos.Models;
using MisOfertas.CapaNegocio.Casos_de_Negocio;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace MisOfertas.WEB
{
    public partial class EditarOferta : System.Web.UI.Page
    {


        int intId;
        protected void Page_Load(object sender, EventArgs e)
        {
            var sesion = (Usuario)Session["usuario"];
            if (sesion.TipoUsuario.IdTipoUsuario != 3)
            {
                Response.Redirect("Inicio.aspx");
            }

            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];
                intId = int.Parse(id);
                CargarDatos(id);
                NOferta noferta = new NOferta();

            }

        }

        private void CargarDatos(string id)
        {

            CargarCombo();

            NOferta noferta = new NOferta();
            var oferta = noferta.ToList().FirstOrDefault(x => x.IdOferta == intId);
            txtCompraMax.Text = oferta.CompraMax.ToString();
            txtcompraMin.Text = oferta.CompraMin.ToString();
            txtDescuento.Text = oferta.PorcentajeDescuento.ToString();
            txtDescripcion.InnerText = oferta.Descripcion.ToString();
            txtfechaProduct.Text = oferta.FechaDisponibilidad.ToString();
            txtValor.Text = oferta.Valor.ToString();

        }

        private void CargarCombo()
        {
            NProducto negocioProducto = new NProducto();
            ddlProducto.DataSource = negocioProducto.ToListModel();

            ddlProducto.Items.Add(new ListItem("Seleccione Un Producto", "0"));

            foreach (var item in negocioProducto.ToListModel())
            {
                ListItem i = new ListItem(item.Nombre, item.IdProducto.ToString());
                ddlProducto.Items.Add(i);

            }

        }

        protected void BtnActualizarOferta_Click(object sender, EventArgs e)
        {

            NOferta noferta = new NOferta();
            OfertaModel ofertaModel = new OfertaModel();
            var sesion = (Usuario)Session["usuario"];
            ofertaModel.CompraMax = (int)(decimal.Parse(txtCompraMax.Text));
            ofertaModel.CompraMin = (int)(decimal.Parse(txtcompraMin.Text));
            ofertaModel.Descripcion = txtDescripcion.InnerText;


            ofertaModel.PorcentajeDescuento = (int)(decimal.Parse(txtDescuento.Text));
            ofertaModel.Valor = int.Parse(txtValor.Text);
            ofertaModel.FechaDisponibilidad = DateTime.Parse(txtfechaProduct.Text);
            ofertaModel.IdProducto = int.Parse(ddlProducto.SelectedItem.Value);
            ofertaModel.IdUsuario = sesion.IdUsuario;

            string id = Request.QueryString["id"];
            int idProd = int.Parse(id);
            noferta.UpdateModel(idProd, ofertaModel);


            Response.Redirect("HomeEncargado.aspx");




        }

        protected void BtnEliminarOferta_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            int idProd = int.Parse(id);
            NOferta noferta = new NOferta();
            noferta.Delete(idProd);
            ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Se Ha eliminado con exito la oferta!', 'Felicidades, Presione Ok!', 'success') </script>");
            Response.Redirect("HomeEncargado.aspx");
        }
    }
}