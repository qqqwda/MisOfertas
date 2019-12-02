<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Categorias.aspx.cs" Inherits="MisOfertas.WEB.Categorias" %>
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

    	
  
	<div class="col-md-12">
						<div class="row">
							<div class="products-tabs">
    
    <asp:DataList ID="dlCategorias" runat="server" Height="1756px" Width="462px">
     
    
    
        <ItemTemplate>
            
      <div class="product">
			<!-- container -->
			<div class="container">
				<!-- row -->
                <div class="col-md-12">
				<div class="row">	

							<div class="products-tabs">
								<!-- tab -->
								<div id="tab1" class="tab-pane active">
									<div class="products-slick" data-nav="#slick-nav-1">
										<!-- product -->
                                     
										<div class="product">
											<div class="product-img">
												<img src='<%#Eval("Imagen")%>' alt="">
												<div class="product-label">
													<span class="sale">-VER GRANDES %%%</span>
													<span class="new">NUEVO</span>
												</div>
											</div>
											<div class="product-body">
												<p class="product-name">'<%#Eval("Descripcion")%>'</p>
												<%--<h3 class="product-category">'<%#Eval("Descripcion")%>'</h3>--%>
												<%--<h4 class="product-price">$980.00 <del class="product-old-price">$990.00</del></h4>--%>
												<div class="product-rating">
													<i class="fa fa-star"></i>
													<i class="fa fa-star"></i>
													<i class="fa fa-star"></i>
													<i class="fa fa-star"></i>
													<i class="fa fa-star"></i>
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
									

                </ItemTemplate>

    </asp:DataList>
    
  </div>
    </div>
    </div>
    
  <script src="js/jquery.min.js"></script>
		<script src="js/bootstrap.min.js"></script>
		<script src="js/slick.min.js"></script>
		<script src="js/nouislider.min.js"></script>
		<script src="js/jquery.zoom.min.js"></script>
		<script src="js/main.js"></script>
      
</asp:Content>
