<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="TodosProductos.aspx.cs" Inherits="MisOfertas.WEB.TodosProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- BREADCRUMB -->
		<div id="breadcrumb" class="section">
			<!-- container -->
			<div class="container">
				<!-- row -->
				<div class="row">
					<div class="col-md-12">
						<ul class="breadcrumb-tree">
							<li><a href="#">Inicio</a></li>
							<li><a href="#">Tipo Categoria</a></li>
							<li><a href="#">Accesorios</a></li>
							<li class="active">Audifonos (227,490 Results)</li>
						</ul>
					</div>
				</div>
				<!-- /row -->
			</div>
			<!-- /container -->
		</div>
		<!-- /BREADCRUMB -->

		<!-- SECTION -->
		<div class="section">
			<!-- container -->
			<div class="container">
				<!-- row -->
				<div class="row">
					<!-- ASIDE -->
					<div id="aside" class="col-md-3">
						<!-- aside Widget -->
						<div class="aside">
							<h3 class="aside-title">Categories</h3>
							<div class="checkbox-filter">

								<div class="input-checkbox">
									<input type="checkbox" id="category-1">
									<label for="category-1">
										<span></span>
										Computadores
										<small>(120)</small>
									</label>
								</div>

								<div class="input-checkbox">
									<input type="checkbox" id="category-2">
									<label for="category-2">
										<span></span>
										Celulares
										<small>(740)</small>
									</label>
								</div>

								<div class="input-checkbox">
									<input type="checkbox" id="category-3">
									<label for="category-3">
										<span></span>
										Camaras
										<small>(1450)</small>
									</label>
								</div>

								<div class="input-checkbox">
									<input type="checkbox" id="category-4">
									<label for="category-4">
										<span></span>
										Ropa
										<small>(578)</small>
									</label>
								</div>

								<div class="input-checkbox">
									<input type="checkbox" id="category-5">
									<label for="category-5">
										<span></span>
										Alimentos
										<small>(120)</small>
									</label>
								</div>

								<div class="input-checkbox">
									<input type="checkbox" id="category-6">
									<label for="category-6">
										<span></span>
										Mas Electronica
										<small>(740)</small>
									</label>
								</div>
							</div>
						</div>
						<!-- /aside Widget -->

						<!-- aside Widget -->
						<div class="aside">
							<h3 class="aside-title">Precio</h3>
							<div class="price-filter">
								<div id="price-slider"></div>
								<div class="input-number price-min">
									<input id="price-min" type="number">
									<span class="qty-up">+</span>
									<span class="qty-down">-</span>
								</div>
								<span>-</span>
								<div class="input-number price-max">
									<input id="price-max" type="number">
									<span class="qty-up">+</span>
									<span class="qty-down">-</span>
								</div>
							</div>
						</div>
						<!-- /aside Widget -->

						<!-- aside Widget -->
						<div class="aside">
							<h3 class="aside-title">Marcas</h3>
							<div class="checkbox-filter">
								<div class="input-checkbox">
									<input type="checkbox" id="brand-1">
									<label for="brand-1">
										<span></span>
										SAMSUNG
										<small>(578)</small>
									</label>
								</div>
								<div class="input-checkbox">
									<input type="checkbox" id="brand-2">
									<label for="brand-2">
										<span></span>
										LG
										<small>(125)</small>
									</label>
								</div>
								<div class="input-checkbox">
									<input type="checkbox" id="brand-3">
									<label for="brand-3">
										<span></span>
										SONY
										<small>(755)</small>
									</label>
								</div>
								<div class="input-checkbox">
									<input type="checkbox" id="brand-4">
									<label for="brand-4">
										<span></span>
										SAMSUNG
										<small>(578)</small>
									</label>
								</div>
								<div class="input-checkbox">
									<input type="checkbox" id="brand-5">
									<label for="brand-5">
										<span></span>
										LG
										<small>(125)</small>
									</label>
								</div>
								<div class="input-checkbox">
									<input type="checkbox" id="brand-6">
									<label for="brand-6">
										<span></span>
										SONY
										<small>(755)</small>
									</label>
								</div>
							</div>
						</div>
						<!-- /aside Widget -->

						<!-- aside Widget -->
						<div class="aside">
							<h3 class="aside-title">Las Mas Vistas</h3>
							<div class="product-widget">
								<div class="product-img">
									<img src="./img/product01.png" alt="">
								</div>
								<div class="product-body">
									<p class="product-category">Categoria</p>
									<h3 class="product-name"><a href="#">nombre producto</a></h3>
									<h4 class="product-price">$100.00 <del class="product-old-price">$1.000.00</del></h4>
								</div>
							</div>

							<div class="product-widget">
								<div class="product-img">
									<img src="./img/product02.png" alt="">
								</div>
								<div class="product-body">
									<p class="product-category">Categoria</p>
									<h3 class="product-name"><a href="#">nombre producto</a></h3>
									<h4 class="product-price">$500.00 <del class="product-old-price">$5.000.00</del></h4>
								</div>
							</div>

							<div class="product-widget">
								<div class="product-img">
									<img src="./img/product03.png" alt="">
								</div>
								<div class="product-body">
									<p class="product-category">Categoria</p>
									<h3 class="product-name"><a href="#">nombre producto</a></h3>
									<h4 class="product-price">$150.00 <del class="product-old-price">$450.00</del></h4>
								</div>
							</div>
						</div>
						<!-- /aside Widget -->
					</div>
					<!-- /ASIDE -->

					<!-- STORE -->
					<div id="store" class="col-md-9">
						<!-- tienda mejores filtro -->
						<div class="store-filter clearfix">
							<div class="store-sort">
								<label>
									Popularidad:
									<select class="input-select">
										<option value="0">Popular Alto</option>
										<option value="1">Posicion Baja</option>
                                        <option value="2">Posicion Alta</option>
									</select>
								</label>

								<label>
									Cant Productos:
									<select class="input-select">
										<option value="0">20</option>
										<option value="1">50</option>
									</select>
								</label>
							</div>
							<ul class="store-grid">
								<li class="active"><i class="fa fa-th"></i></li>
								<li><a href="#"><i class="fa fa-th-list"></i></a></li>
							</ul>
						</div>
						<!-- /tienda mejores filtro -->

						<!-- tienda productos -->
						<div class="row">
							<!-- producto -->
							<div class="col-md-4 col-xs-6">
								<div class="product">
									<div class="product-img">
										<img src="./img/product01.png" alt="">
										<div class="product-label">
											<span class="sale">-30%</span>
											<span class="new">NUEVO</span>
										</div>
									</div>
									<div class="product-body">
										<p class="product-category">Categoria</p>
										<h3 class="product-name"><a href="#">nombre producto</a></h3>
										<h4 class="product-price">$430.00 <del class="product-old-price">$892.00</del></h4>
										<div class="product-rating">
											<i class="fa fa-star"></i>
											<i class="fa fa-star"></i>
											<i class="fa fa-star"></i>
											<i class="fa fa-star"></i>
											<i class="fa fa-star"></i>
										</div>
										<div class="product-btns">
											<button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">agregar a favoritos</span></button>
											<button class="add-to-compare"><i class="fa fa-exchange"></i><span class="tooltipp">agregar para comparar</span></button>
											<button class="quick-view"><i class="fa fa-eye"></i><span class="tooltipp">vista rapida</span></button>
										</div>
									</div>
									<div class="add-to-cart">
										<button class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> Ver disponibilidad producto</button>
									</div>
								</div>
							</div>
							<!-- /producto -->

							<!-- producto -->
							<div class="col-md-4 col-xs-6">
								<div class="product">
									<div class="product-img">
										<img src="./img/product02.png" alt="">
										<div class="product-label">
											<span class="sale">-80%</span>
											<span class="new">NUEVO</span>
										</div>
									</div>
									<div class="product-body">
										<p class="product-category">Categoria</p>
										<h3 class="product-name"><a href="#">nombre producto</a></h3>
										<h4 class="product-price">$000.00 <del class="product-old-price">$000.00</del></h4>
										<div class="product-rating">
											<i class="fa fa-star"></i>
											<i class="fa fa-star"></i>
											<i class="fa fa-star"></i>
											<i class="fa fa-star"></i>
											<i class="fa fa-star-o"></i>
										</div>
										<div class="product-btns">
											<button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">agregar a favoritos</span></button>
											<button class="add-to-compare"><i class="fa fa-exchange"></i><span class="tooltipp">agregar para comparar</span></button>
											<button class="quick-view"><i class="fa fa-eye"></i><span class="tooltipp">vista rapida</span></button>
										</div>
									</div>
									<div class="add-to-cart">
										<button class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> Ver disponibilidad producto</button>
									</div>
								</div>
							</div>
							<!-- /product -->

							<div class="clearfix visible-sm visible-xs"></div>

							<!-- producto -->
							<div class="col-md-4 col-xs-6">
								<div class="product">
									<div class="product-img">
										<img src="./img/product03.png" alt="">
                                        <div class="product-label">
                                        <span class="sale">-74%</span>
										<span class="new">NUEVO</span>
									</div>
                                        </div>
									<div class="product-body">
										<p class="product-category">Categoria</p>
										<h3 class="product-name"><a href="#">nombre producto</a></h3>
										<h4 class="product-price">$20.00 <del class="product-old-price">$100.00</del></h4>
										<div class="product-rating">
										</div>
										<div class="product-btns">
											<button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">agregar a favoritos</span></button>
											<button class="add-to-compare"><i class="fa fa-exchange"></i><span class="tooltipp">agregar para comparar</span></button>
											<button class="quick-view"><i class="fa fa-eye"></i><span class="tooltipp">vista rapida</span></button>
										</div>
									</div>
									<div class="add-to-cart">
										<button class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i>Ver disponibilidad producto</button>
									</div>
								</div>
							</div>
							<!-- /producto -->

							<div class="clearfix visible-lg visible-md"></div>

							<!-- producto -->
							<div class="col-md-4 col-xs-6">
								<div class="product">
									<div class="product-img">
									<img src="./img/product04.png" alt="">
                                        <div class="product-label">
                                        <span class="sale">-74%</span>
										<span class="new">NUEVO</span>
									</div>
                                   </div>
									<div class="product-body">
										<p class="product-category">Categoria</p>
										<h3 class="product-name"><a href="#">nombre producto</a></h3>
										<h4 class="product-price">$980.00 <del class="product-old-price">$2.000.00</del></h4>
										<div class="product-rating">
										</div>
										<div class="product-btns">
											<button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">agregar a favoritos</span></button>
											<button class="add-to-compare"><i class="fa fa-exchange"></i><span class="tooltipp">aagregar para comparar</span></button>
											<button class="quick-view"><i class="fa fa-eye"></i><span class="tooltipp">vista rapida</span></button>
										</div>
									</div>
									<div class="add-to-cart">
										<button class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> Ver disponibilidad producto</button>
									</div>
								</div>
							</div>
							<!-- /producto -->

							<div class="clearfix visible-sm visible-xs"></div>

							<!-- producto -->
							<div class="col-md-4 col-xs-6">
								<div class="product">
									<div class="product-img">
									<img src="./img/product05.png" alt="">
                                        <div class="product-label">
                                        <span class="sale">-82%</span>
										<span class="new">NUEVO</span>
									</div>
                                   </div>
									<div class="product-body">
										<p class="product-category">Categoria</p>
										<h3 class="product-name"><a href="#">nombre producto</a></h3>
										<h4 class="product-price">$120.00 <del class="product-old-price">$700.00</del></h4>
										<div class="product-rating">
										</div>
										<div class="product-btns">
											<button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">agregar a favoritos</span></button>
											<button class="add-to-compare"><i class="fa fa-exchange"></i><span class="tooltipp">agregar para comparar</span></button>
											<button class="quick-view"><i class="fa fa-eye"></i><span class="tooltipp">vista rapida</span></button>
										</div>
									</div>
									<div class="add-to-cart">
										<button class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> Ver disponibilidad producto</button>
									</div>
								</div>
							</div>
							<!-- /producto -->

							<!-- producto -->
							<div class="col-md-4 col-xs-6">
								<div class="product">
									<div class="product-img">
									<img src="./img/product04.png" alt="">
                                        <div class="product-label">
                                        <span class="sale">-24%</span>
										<span class="new">NUEVO</span>
									</div>
                                   </div>
									<div class="product-body">
										<p class="product-category">Categoria</p>
										<h3 class="product-name"><a href="#">nombre producto</a></h3>
										<h4 class="product-price">$230.00 <del class="product-old-price">$520.00</del></h4>
										<div class="product-rating">
											<i class="fa fa-star"></i>
											<i class="fa fa-star"></i>
											<i class="fa fa-star"></i>
											<i class="fa fa-star"></i>
											<i class="fa fa-star-o"></i>
										</div>
										<div class="product-btns">
											<button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">agregar a favoritos</span></button>
											<button class="add-to-compare"><i class="fa fa-exchange"></i><span class="tooltipp">agregar para comparar</span></button>
											<button class="quick-view"><i class="fa fa-eye"></i><span class="tooltipp">vista rapida</span></button>
										</div>
									</div>
									<div class="add-to-cart">
										<button class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> Ver disponibilidad producto</button>
									</div>
								</div>
							</div>
							<!-- /producto -->

							<div class="clearfix visible-lg visible-md visible-sm visible-xs"></div>

							<!-- producto -->
							<div class="col-md-4 col-xs-6">
								<div class="product">
									<div class="product-img">
										<img src="./img/product07.png" alt="">
                                        <div class="product-label">
                                     <span class="sale">-64%</span>
										<span class="new">NUEVO</span>
									</div>
                                        </div>
									<div class="product-body">
										<p class="product-category">Categoria</p>
										<h3 class="product-name"><a href="#">nombre producto</a></h3>
										<h4 class="product-price">$270.00 <del class="product-old-price">$560.00</del></h4>
										<div class="product-rating">
											<i class="fa fa-star"></i>
											<i class="fa fa-star"></i>
											<i class="fa fa-star"></i>
											<i class="fa fa-star"></i>
											<i class="fa fa-star"></i>
										</div>
										<div class="product-btns">
											<button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">agregar a favoritos</span></button>
											<button class="add-to-compare"><i class="fa fa-exchange"></i><span class="tooltipp">agregar para comparar</span></button>
											<button class="quick-view"><i class="fa fa-eye"></i><span class="tooltipp">vista rapida</span></button>
										</div>
									</div>
									<div class="add-to-cart">
										<button class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> Ver disponibilidad producto</button>
									</div>
								</div>
							</div>
							<!-- /producto -->

							<!-- producto -->
							<div class="col-md-4 col-xs-6">
								<div class="product">
									<div class="product-img">
										<img src="./img/product08.png" alt="">
                                        <div class="product-label">
                                        <span class="sale">-97%</span>
										<span class="new">NUEVO</span>
									</div>
                                    </div>
									<div class="product-body">
										<p class="product-category">Categoria</p>
										<h3 class="product-name"><a href="#">nombre producto</a></h3>
										<h4 class="product-price">$580.00 <del class="product-old-price">$350.00</del></h4>
										<div class="product-rating">
										</div>
										<div class="product-btns">
											<button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">agregar a favoritos</span></button>
											<button class="add-to-compare"><i class="fa fa-exchange"></i><span class="tooltipp">agregar para comparar</span></button>
											<button class="quick-view"><i class="fa fa-eye"></i><span class="tooltipp">vista rapida</span></button>
										</div>
									</div>
									<div class="add-to-cart">
										<button class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> Ver disponibilidad producto</button>
									</div>
								</div>
							</div>
							<!-- /producto -->

							<div class="clearfix visible-sm visible-xs"></div>

							<!-- producto -->
							<div class="col-md-4 col-xs-6">
								<div class="product">
									<div class="product-img">
										<img src="./img/product09.png" alt="">
                                        <div class="product-label">
                                       <span class="sale">-33%</span>
										<span class="new">NUEVO</span>
									</div>
                                  </div>
									<div class="product-body">
										<p class="product-category">Categoria</p>
										<h3 class="product-name"><a href="#">nombre producto</a></h3>
										<h4 class="product-price">$890.000 <del class="product-old-price">$1.000.000</del></h4>
										<div class="product-rating">
										</div>
										<div class="product-btns">
											<button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">agregar a favoritos</span></button>
											<button class="add-to-compare"><i class="fa fa-exchange"></i><span class="tooltipp">agregar para comparar</span></button>
											<button class="quick-view"><i class="fa fa-eye"></i><span class="tooltipp">vista rapida</span></button>
										</div>
									</div>
									<div class="add-to-cart">
										<button class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> Ver disponibilidad producto</button>
									</div>
								</div>
							</div>
							<!-- /producto -->
						</div>
						<!-- /tienda producto -->

						<!-- store bottom filter -->
						<div class="store-filter clearfix">
							<span class="store-qty">Mostrando 20-100 Productos</span>
							<ul class="store-pagination">
								<li class="active">1</li>
								<li><a href="#">2</a></li>
								<li><a href="#">3</a></li>
								<li><a href="#">4</a></li>
								<li><a href="#"><i class="fa fa-angle-right"></i></a></li>
							</ul>
						</div>
						<!-- /tienda botones filtro -->
					</div>
					<!-- /TIENDA -->
				</div>
				<!-- /row -->
			</div>
			<!-- /container -->
		</div>
		<!-- /SECCION -->


</asp:Content>
