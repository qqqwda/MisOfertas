﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Categorias.aspx.cs" Inherits="MisOfertas.WEB.Categorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!-- Boo*+tstrap -->
		<link type="text/css" rel="stylesheet" href="css/bootstrap.min.css"/>

		<!-- Slick -->
		<link type="text/css" rel="stylesheet" href="css/slick.css"/>
		<link type="text/css" rel="stylesheet" href="css/slick-theme.css"/>

		<!-- nouislider -->
		<link type="text/css" rel="stylesheet" href="css/nouislider.min.css"/>

		<!-- Font Awesome Icon -->
		<link rel="stylesheet" href="css/font-awesome.min.css">

		<!-- Custom stlylesheet -->
		<link type="text/css" rel="stylesheet" href="css/style.css"/>

    	
  
	
    
    <asp:DataList ID="dlCategorias" runat="server" Height="117px" Width="143px"  RepeatColumns="2"  CssClass="cent" ShowHeader="False" GridLines="Horizontal" HorizontalAlign="Left" RepeatDirection="Horizontal" ShowFooter="False" CellPadding="0" CellSpacing="0">
     
    
    
        <ItemStyle BorderColor="#FF0066" />
     
    
    
        <ItemTemplate>
                  <div class="section-center">
            <!-- container -->
            <div class="container">
                <!-- row -->
               <div class="row">
            <div class="col-md-12">
                      	<div class="section-title text-center">
							<h3 class="title"></h3>
						</div>  <%--<div class="col-md-3 col-x-6">--%>
					</div>
                                     <div class="col-md-3 col-xs-offset-1">

										<div class="product">
											<div class="product-img">
												<img src='<%#Eval("Imagen")%>' alt="">
												<div class="product-label">
													<span class="sale">-VER GRANDES OFERTAS %</span>
													<span class="new">NUEVO</span>
												</div>
											</div>
											<div class="product-body">
												<h4 class="product-rating">'<%#Eval("Descripcion")%>'</h4>
												<%--<h3 class="product-category">'<%#Eval("Descripcion")%>'</h3>--%>
												<%--<h4 class="product-price">$980.00 <del class="product-old-price">$990.00</del></h4>--%>
												<div class="product-name">
													<p id="hPuntuacion">'<%#Eval("PromedioPuntuacion")%>'</p>
												</div>
												<%--<div class="product-btns">
													<button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">añadir a favoritos</span></button>
													<button class="add-to-compare"><i class="fa fa-exchange"></i><span class="tooltipp">comparar</span></button>
													<button class="quick-view"><i class="fa fa-eye"></i><span class="tooltipp">vista rapida</span></button>
												</div>--%>
											</div>
											<div class="add-to-cart">
												<%--<button class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> ver disponibilidad</button>--%>
                                                  <asp:Button runat="server" Text="Ir a categoría" CausesValidation="False" OnCommand="Categoria_Command" CommandArgument='<% #Eval("IdCategoria")%>'  class="add-to-cart-btn" ></asp:Button>
											</div>
										</div>
                                            
                                </div>
                               </div>	
                              </div>
                             </div>
							</div>	

                    </div>
                </div>
                </div>

                </ItemTemplate>

    </asp:DataList>
    
    
  <script src="js/jquery.min.js"></script>
		<script src="js/bootstrap.min.js"></script>
		<script src="js/slick.min.js"></script>
		<script src="js/nouislider.min.js"></script>
		<script src="js/jquery.zoom.min.js"></script>
		<script src="js/main.js"></script>
</asp:Content>
