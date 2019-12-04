<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Categoria.aspx.cs" Inherits="MisOfertas.WEB.Categoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
    	

     <link href="https://fonts.googleapis.com/css?family=Montserrat:400,500,700" rel="stylesheet">
    <link type="text/css" rel="stylesheet" href="css/bootstrap.min.css" />
    <link type="text/css" rel="stylesheet" href="css/slick.css" />
    <link type="text/css" rel="stylesheet" href="css/slick-theme.css" />
    <link type="text/css" rel="stylesheet" href="css/nouislider.min.css" />
    <link rel="stylesheet" href="css/font-awesome.min.css">
    <link type="text/css" rel="stylesheet" href="css/style.css" />
   

   

                    <asp:DataList ID="dlOfertasPorCategoria" runat="server" Height="117px" Width="143px"  RepeatColumns="2"  CssClass="cent" ShowHeader="False" GridLines="Horizontal" HorizontalAlign="Left" RepeatDirection="Horizontal" ShowFooter="False" CellPadding="0" CellSpacing="0">
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
										<div class="product" >
											<div class="product-img">
												<img  src='<%#Eval("Imagen")%>' alt="">
												<div class="product-label">
													<span class="sale"> 85%</span>
													<span class="new">NUEVO</span>
												</div>
											</div>
											<div class="product-body">
												<p class="product-name">'<%#Eval("Descripcion")%>'</p>
                                                <h4 class="product-price"><%#Eval("Valor")%><del class="product-old-price"><%#Eval("PrecioNormal")%></del></h4>
												<%--<h3 class="product-category">'<%#Eval("Descripcion")%>'</h3>--%>
												<h4 class="product-price"></h4>
												<div class="product-rating">
													<i class="fa fa-star"></i>
													<i class="fa fa-star"></i>
													<i class="fa fa-star"></i>
													<i class="fa fa-star"></i>
													<i class="fa fa-star"></i>
												</div>
												<div class="product-btns">
													<%--<button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">añadir a favoritos</span></button>
													<button class="add-to-compare"><i class="fa fa-exchange"></i><span class="tooltipp">comparar</span></button>
													<button class="quick-view"><i class="fa fa-eye"></i><span class="tooltipp">vista rapida</span></button>--%>
												</div>
											</div>
											<div class="add-to-cart">
                                                
                                                <asp:Button ID="BtnCategoria" runat="server"  Text="Ver Producto"  class="add-to-cart-btn" OnClick="BtnCategoria_Click" OnCommand="BtnCategoria_Command" CommandArgument='<% #Eval("IdOferta")%>'></asp:Button>
                                                <%--<i class="fa fa-shopping-cart"></i>--%>
												<%--<button class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> Ver Producto--%>
                                               <%--   <asp:Button runat="server" Text="Ir a categoría" CausesValidation="False" OnCommand="Categoria_Command" CommandArgument='<% #Eval("IdCategoria")%>'  class="add-to-cart-btn" ></asp:Button>--%>
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
                    

       


     
</asp:Content>
