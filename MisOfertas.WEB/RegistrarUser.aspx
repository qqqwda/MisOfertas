<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistrarUser.aspx.cs" Inherits="MisOfertas.WEB.RegistrarUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- FORMULARIO REGISTRO -->
    <div class="section">
			<!-- container -->
			<div class="container">
				<!-- row -->
				<div class="row">

					<div class="col-md-7">



						<div class="billing-details">
							<div class="section-title">
								<h3 class="title">CREAR TU CUENTA</h3>
							</div>
							<div class="form-group">
								<input class="input" type="text" name="Rut" placeholder="Rut">
							</div>
                            <div class="form-group">
								<input class="input" type="text" name="Nombre" placeholder="Nombre">
							</div>
							<div class="form-group">
								<input class="input" type="text" name="Apellido" placeholder="Apellidos">
							</div>
							<div class="form-group">
								<input class="input" type="email" name="Correo" placeholder="Correo">
							</div>
							<div class="form-group">
								<input class="input" type="password" name="Password" placeholder="Password">
							</div>
							<div class="form-group">
								<input class="input" type="tel" name="Telefono" placeholder="Telefono">
							</div>
							<div class="form-group">
								<input class="input" type="date" name="FechaNacimiento" placeholder="FechaNacimiento">
							</div>
							<div class="form-group">
								<input class="input" type="text" name="Comuna" placeholder="Comuna">
							</div>
							
							<div class="input-checkbox">
							<input type="checkbox" id="terms">
							<label for="terms">
								<span></span>
								He leido todo,acepto terminos y condiciones<a href="#">T</a>
							</label>
						</div>
						<a href="#" class="primary-btn order-submit">Crear Cuenta</a>
						</div>

						<!-- /FORMULARIO REGISTRO -->


                        		</div>
					<!-- /Order Details -->
				</div>
				<!-- /row -->
			</div>
			<!-- /container -->
		</div>


</asp:Content>
