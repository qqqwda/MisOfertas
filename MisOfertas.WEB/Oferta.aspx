<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Oferta.aspx.cs" Inherits="MisOfertas.WEB.Oferta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <!-- Google font -->
 		<link href="https://fonts.googleapis.com/css?family=Montserrat:400,500,700" rel="stylesheet">

 		<!-- Bootstrap -->
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

    <asp:DataList runat="server"  id="dlOferta">
        <ItemTemplate>

              <!-- SECTION -->
		<div class="section">
			<!-- container -->
			<div class="container">
				<!-- row -->
				<div class="row">
					<!-- Product main img -->
					<div class="col-md-5 col-md-push-2">
						<div id="product-main-img">
							<div class="product-preview">
                                <div class="product-preview">
									<img src='<%#Eval("Imagen")%>'  alt="">
							</div>
								<%--<img src='<%#Eval("Imagen")%>'  alt="">--%>
							</div>
							
						</div>
					</div>
					<!-- /Product main img -->

					<!-- Product thumb imgs -->
					<div class="col-md-2  col-md-pull-5">
						<div id="product-imgs">
							<div class="product-preview">
								<%--<img src="./img/product01.png" alt="">--%>
							</div>

							<div class="product-preview">
							<%--	<img src="./img/product03.png" alt="">--%>
							</div>

							<div class="product-preview">
								<%--<img src="./img/product06.png" alt="">--%>
							</div>

							<div class="product-preview">
								<%--<img src="./img/product08.png" alt="">--%>
							</div>
						</div>
					</div>
					<!-- /Product thumb imgs -->

					<!-- Product details -->
					<div class="col-md-5">
						<div class="product-details">
							<h2 class="product-name">'<%#Eval("DescripcionProducto")%>'</h2>
							<div>
								<div class="product-rating">
									<i class="fa fa-star"></i>
									<i class="fa fa-star"></i>
									<i class="fa fa-star"></i>
									<i class="fa fa-star"></i>
									<i class="fa fa-star-o"></i>
								</div>
								<a class="review-link" href="#">10 Persona(s) vieron este producto | Add your review</a>
							</div>
							<div>
								<h3 class="product-price">Precio Actual:<%#Eval("Valor")%><br /><del class="product-old-price">-Precio Anterior:<%#Eval("PrecioNormal")%></del></h3>
								<br /><span class="product-available">Stock Disponible -><%#Eval("Stock")%></span><span class="product-available">Porcentaje De Descuento %:<%#Eval("PorcentajeDescuento")%></span></div>
                            <label>Descripcion Del Producto:</label>
							<p><%#Eval("Descripcion")%></p>
							<%--<div class="product-options">--%>
								<label>Marca :</label>
									<p><%#Eval("Marca")%></p>
								<label>Modelo :</label>
                                <p><%#Eval("Modelo")%></p>
							<%--</div> --%>
								<%--<div class="product-options">--%>
									<label>Temporada :</label>
                                      <li><a  href="#"><%#Eval("Temporada")%></a></li>  
                                        <label>Fecha Disponiblidad:</label>
                                        <li><a href="#"><%#Eval("FechaDisponibilidad")%></a></li>
								<%--</div>--%>
                            	<div class="add-to-cart">
                                    <div class="qty-label">
								     <label>Compra Minima:</label>
                                        <li><a href="#"><%#Eval("CompraMin")%></a></li>
									<div class="input-number">
										<label>Compra Maxima:</label>
                                        <li><a href="#"><%#Eval("CompraMax")%></a></li>
									</div>
								</div>
								<button class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> Agregar Producto a Favoritos</button>
							</div>

							<%--<ul class="product-btns">
								<li><a href="#"><i class="fa fa-heart-o"></i>Agregar</a></li>
								<li><a href="#"><i class="fa fa-exchange"></i>Comparar</a></li>
							</ul>--%>

							<ul class="product-links">
								<li>Categoria:</li>
								<li><a href='#'><%#Eval("NombreCategoria")%></a></li>
                                <li>Empresa Dueña Producto:</li>
								<li><a href='#'><%#Eval("NombreEmpresa")%></a></li>
							</ul>

							<ul class="product-links">
								<li>Siguenos en Nuestras Redes Sociales:</li>
								<li><a href="#"><i class="fa fa-facebook"></i></a></li>
								<li><a href="#"><i class="fa fa-twitter"></i></a></li>
								<li><a href="#"><i class="fa fa-google-plus"></i></a></li>
								<li><a href="#"><i class="fa fa-envelope"></i></a></li>
							</ul>

						</div>
					</div>
					<!-- /Product details -->


                    <!-- /Product PANEL ABAJO NAVEGA Y COMENT -->

                    <div class="col-md-12">
						<div id="product-tab">
							<!-- product tab nav -->
							<ul class="tab-nav">
								<li class="active"><a data-toggle="tab" href="#tab1">Descripcion Oferta</a></li>
								<li><a data-toggle="tab" href="#tab2">Detalles Producto</a></li>
								<li><a data-toggle="tab" href="#tab3">Calificaciones</a></li>
							</ul>
							<!-- /product tab nav -->

							<!-- product tab content -->
							<div class="tab-content">
								<!-- tab1  -->
								<div id="tab1" class="tab-pane fade in active">
									<div class="row">
										<div class="col-md-12">
											<p><%#Eval("Descripcion")%></p>
										</div>
									</div>
								</div>
								<!-- /tab1  -->

								<!-- tab2  -->
								<div id="tab2" class="tab-pane fade in">
									<div class="row">
										<div class="col-md-12">
											<p><%#Eval("DescripcionProducto")%></p>
										</div>
									</div>
								</div>
								<!-- /tab2  -->

								<!-- tab3  -->
								<div id="tab3" class="tab-pane fade in">
									<div class="row">
										<!-- Rating -->
										<div class="col-md-3">
											<div id="rating">
												<div class="rating-avg">
													<span>Promedio 4.6</span>
													<div class="rating-stars">
														<i class="fa fa-star"></i>
														<i class="fa fa-star"></i>
														<i class="fa fa-star"></i>
														<i class="fa fa-star"></i>
														<i class="fa fa-star-o"></i>
													</div>
												</div>
												<ul class="rating">
													<li>
														<div class="rating-stars">
															<i class="fa fa-star"></i>
															<i class="fa fa-star"></i>
															<i class="fa fa-star"></i>
															<i class="fa fa-star"></i>
															<i class="fa fa-star"></i>
														</div>
														<div class="rating-progress">
															<div style="width: 80%;"></div>
														</div>
														<span class="sum">3</span>
													</li>
													<li>
														<div class="rating-stars">
															<i class="fa fa-star"></i>
															<i class="fa fa-star"></i>
															<i class="fa fa-star"></i>
															<i class="fa fa-star"></i>
															<i class="fa fa-star-o"></i>
														</div>
														<div class="rating-progress">
															<div style="width: 60%;"></div>
														</div>
														<span class="sum">2</span>
													</li>
													<li>
														<div class="rating-stars">
															<i class="fa fa-star"></i>
															<i class="fa fa-star"></i>
															<i class="fa fa-star"></i>
															<i class="fa fa-star-o"></i>
															<i class="fa fa-star-o"></i>
														</div>
														<div class="rating-progress">
															<div></div>
														</div>
														<span class="sum">4</span>
													</li>
													<li>
														<div class="rating-stars">
															<i class="fa fa-star"></i>
															<i class="fa fa-star"></i>
															<i class="fa fa-star"></i>
															<i class="fa fa-star"></i>
															<i class="fa fa-star-o"></i>
														</div>
														<div class="rating-progress">
															<div></div>
														</div>
														<span class="sum">0</span>
													</li>
													<li>
														<div class="rating-stars">
															<i class="fa fa-star"></i>
															<i class="fa fa-star-o"></i>
															<i class="fa fa-star-o"></i>
															<i class="fa fa-star-o"></i>
															<i class="fa fa-star-o"></i>
														</div>
														<div class="rating-progress">
															<div></div>
														</div>
														<span class="sum">0</span>
													</li>
												</ul>
											</div>
										</div>
										<!-- /Rating -->
                                        
        </ItemTemplate>
    </asp:DataList>
										<!-- Reviews -->
										<div class="col-md-6">
                                            <asp:DataList ID="dlComentarios" runat="server" >
                                                
                                                    <ItemTemplate>
											<div id="reviews">

                                                
                                                        <ul class="reviews">
													<li>
														<div class="review-heading">
															<h5 class="name">'<%#Eval("NombreCompleto")%>'</h5>
															<p class="date">'<%#Eval("FechaPublicacion")%>'</p>
                                                            <div class="review-rating">
<%--			                                         <asp:Label ID="Label1" runat="server" Text="Calificacion:"></asp:Label>--%>
                                                            <i class="fa fa-star"></i>
														    <i class="fa fa-star"></i>
                                                           </div>
																<%--<a href="#"><%#Eval("sCalificacion")%>'</a>--%>
															</div>
														
														<div class="review-body">
															<p><%#Eval("Comentario")%>'</p>
														</div>
													</li>
												</ul>
                                                    </ItemTemplate>
												</asp:DataList>
												
											</div>
										
    
										<!-- /Reviews -->

										<!-- Review Form -->
										<div class="col-md-3">
											<div id="review-form">
											


                                                    <textarea id="txtComentario" class="input" placeholder="Escribe Aqui Tu Comentario Acerca Del Producto" runat="server" cols="20" rows="2"></textarea>
													

													<div class="input-rating">
														<%--<span>Tu Calificacion: </span>--%>
														<label for="exampleFormControlSelect1">Seleccione un numero para calificar 1 MALISIMO-2 MEDIO-3 REGULAR-4 BUENO-5 EXCELENTE</label>
                                                            <select runat="server" class="form-control" id="sCalificacion">
                                                              <option>1</option>
                                                              <option>2</option>
                                                              <option>3</option>
                                                              <option>4</option>
                                                              <option>5</option>
                                                            </select>
                                                        <p>Suba Una Imagen De Su Boleta, Para Una Correcta Valoracion</p>
                                          <asp:FileUpload ID="FileUpload1"  runat="server" />
													</div>
                                                    <br />
                                                    <br />
													<asp:button OnClick="PublicarComentario_Click" Text="Publicar Comentario" id="PublicarComentario" runat="server" class="primary-btn"></asp:button>
											
											</div>
										</div>
                                          <br />
    <br />
										<!-- /Review Form -->
					




  






    

    <!-- jQuery Plugins -->
		<script src="js/jquery.min.js"></script>
		<script src="js/bootstrap.min.js"></script>
		<script src="js/slick.min.js"></script>
		<script src="js/nouislider.min.js"></script>
		<script src="js/jquery.zoom.min.js"></script>
		<script src="js/main.js"></script>


</asp:Content>
