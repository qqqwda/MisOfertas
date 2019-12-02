<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPgePriv.Master" AutoEventWireup="true" CodeBehind="EditarOferta.aspx.cs" Inherits="MisOfertas.WEB.EditarOferta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,500,700" rel="stylesheet">

 		<%--<!-- Bootstrap -->
 		<link type="text/css" rel="stylesheet" href="css/bootstrap.min.css"/>--%>

 		<!-- Slick -->
 		<link type="text/css" rel="stylesheet" href="css/slick.css"/>
 		<link type="text/css" rel="stylesheet" href="css/slick-theme.css"/>

 		<!-- nouislider -->
 		<link type="text/css" rel="stylesheet" href="css/nouislider.min.css"/>

 		<!-- Font Awesome Icon -->
 		<link rel="stylesheet" href="css/font-awesome.min.css">

 		<!-- Custom stlylesheet -->
 		<link type="text/css" rel="stylesheet" href="css/style.css"/>




    <!-- SECTION -->
		<div class="section">
			<!-- container -->
			<div class="container-fluid">
				<!-- row -->
				<div class="row">

					<div class="col-md-7">
						<!-- Billing Details --><
						<div class="billing-details">
							<div class="section-title">
								<h3 class="title">ACTUALIZAR OFERTAS</h3>
							</div>
                            <div class="form-group">
                            <asp:DropDownList ID="ddlProducto" runat="server" Width="350">
                                
                            </asp:DropDownList>
                            </div>

							<div class="form-group">
							<asp:TextBox ID="txtcompraMin" runat="server" class="input" type="number" name="compraMin" placeholder="Compra Minima del producto" ></asp:TextBox>
							</div>
							<div class="form-group">
								<asp:TextBox ID="txtCompraMax" runat="server" class="input" type="number" name="CompraMax" placeholder="Compra Maxima del producto"  ></asp:TextBox>
							</div>
							<div class="form-group">
                             <asp:Label ID="lblFecha" runat="server" Text="Fecha disponibilidad del producto"></asp:Label>
							<asp:TextBox ID="txtfechaProduct" runat="server" class="input" type="date" name="fechaProduct" placeholder="Fecha disponibilidad del producto" ></asp:TextBox>
							</div>
							<div class="form-group">
								<asp:TextBox ID="txtValor" runat="server" class="input" type="number" name="Valor" placeholder="Valor del producto " ></asp:TextBox>
							</div>
							<div class="form-group">
								<asp:TextBox ID="txtDescuento" runat="server" class="input" type="number" name="Porcentaje de Descuento" placeholder="Descuento otorgado al producto" ></asp:TextBox>
							</div>
                            <div  class="form-group">
                               <%-- <input type="text" name="descripcion" />--%>
							<textarea ID="txtDescripcion" runat="server"  class="input" type="text" placeholder="Ingresar la descripcion del producto, caracteristicas,color etc.."></textarea>
						</div>
							
							
						</div>
						
						<asp:Button ID="BtnActualizarOferta" class="primary-btn order-submit" runat="server" Text="ACTUALIZAR OFERTA" Width="417px" OnClick="BtnActualizarOferta_Click" />
                        <asp:Button ID="BtnEliminarOferta" class="primary-btn order-submit" runat="server" Text="ELIMINAR OFERTA" Width="417px" OnClick="BtnEliminarOferta_Click" />
                        
					</div>
					<!-- /Order Details -->
				</div>
				<!-- /row -->
			</div>
			<!-- /container -->
		</div>
		<!-- /SECTION -->



    <!-- jQuery Plugins -->
		<script src="js/jquery.min.js"></script>
		<script src="js/bootstrap.min.js"></script>
		<script src="js/slick.min.js"></script>
		<script src="js/nouislider.min.js"></script>
		<script src="js/jquery.zoom.min.js"></script>
		<script src="js/main.js"></script>


   
</asp:Content>
