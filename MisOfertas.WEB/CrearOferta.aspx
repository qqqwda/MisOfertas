<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPgePriv.Master" AutoEventWireup="true" CodeBehind="CrearOferta.aspx.cs" Inherits="MisOfertas.WEB.CrearOferta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <!-- Google font -->
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
						<!-- Billing Details -->
						<div class="billing-details">
							<div class="section-title">
								<h3 class="title">CREACION DE OFERTAS</h3>
							</div>
                            <div class="form-group">
                            <asp:DropDownList ID="ddlProducto" runat="server" Width="350">
                                
                            </asp:DropDownList>
                            </div>

							<div class="form-group">
							<asp:TextBox ID="txtcompraMin" runat="server" class="input" type="number" name="compraMin" placeholder="Compra Minima del producto"  required=""></asp:TextBox>
							</div>
							<div class="form-group">
								<asp:TextBox ID="txtCompraMax" runat="server" class="input" type="number" name="CompraMax" placeholder="Compra Maxima del producto"  required=""></asp:TextBox>
							</div>
							<div class="form-group">
                             <asp:Label ID="lblFecha" runat="server" Text="Fecha disponibilidad del producto"></asp:Label>
							<asp:TextBox ID="txtfechaProduct" runat="server" class="input" type="date" name="fechaProduct" placeholder="Fecha disponibilidad del producto" required=""></asp:TextBox>
							</div>
							<div class="form-group">
								<asp:TextBox ID="txtValor" runat="server" class="input" type="number" name="Valor" placeholder="Valor del producto " required=""></asp:TextBox>
							</div>
							<div class="form-group">
								<asp:TextBox ID="txtDescuento" runat="server" class="input" type="number" name="Porcentaje de Descuento" placeholder="Descuento otorgado al producto" required="" ></asp:TextBox>
							</div>
                            <div  class="form-group">
                               <%-- <input type="text" name="descripcion" />--%>
							<textarea ID="txtDescripcion" runat="server"  class="input" type="text" placeholder="Ingresar la descripcion del producto, caracteristicas,color etc.."></textarea>
						</div>
							
							<div class="form-group">
								<div class="input-checkbox">
									<input type="checkbox" id="create-account" required="">
									<label for="create-account">
										<span></span>
										Esta seguro de crear esta Nueva Oferta?
									</label>
									<%--<div class="caption">
										<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt.</p>
										<input class="input" type="password" name="password" placeholder="Enter Your Password">
									</div>--%>
								</div>
							</div>
						</div>
						
						<asp:Button ID="BtnAgregarOferta" class="primary-btn order-submit" runat="server" Text="CREAR NUEVA OFERTA" Width="417px" OnClick="BtnAgregarOferta_Click"  OnClientClick="return confirm('¿Esta seguro que desea Agregar Una Nueva Oferta?');"/>
                        
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
