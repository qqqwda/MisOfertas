<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistrarUser.aspx.cs" Inherits="MisOfertas.WEB.RegistrarUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <link href="css/sweetalert.css" rel="stylesheet" />
    <script src="js/sweetalert.min.js" type="text/javascript"></script>

    <%--<script> function redirigir(valido) {
     swal('Registro Exitoso!', 'Felicidades, Presione Ok!', 'success');

    </script>--%>



    <!-- FORMULARIO REGISTRO -->
    <div class="section">
        <!-- container -->
        <div class="container">
            <!-- row -->
            <div class="row">

                <div class="col-md-7">
                    <script src="js/Comunas.js"></script>


                    <div class="billing-details">
                        <div class="section-title">
                            <h3 class="title">CREAR TU PROPIA CUENTA EN NUESTRA PAGINA</h3>
                        </div>
                        <div class="form-group">
                            <%--<input class="input" type="text" name="Rut" placeholder="Rut" maxlength="10">--%>
                            <asp:Label ID="rut" runat="server" Text="Ingrese su Rut Sin Guion Ni Puntos :"></asp:Label>
                            <asp:TextBox ID="txtRut" runat="server" Width="783px" class="input" MinLength="9" MaxLength="10" placeholder="Ingrese su Rut sin guion" type="number" required=""></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="nombre" runat="server" Text="Ingrese su Nombre :"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
								 <asp:TextBox ID="txtNombre" runat="server" Width="783px" class="input" type="text" placeholder="Ingrese aqui su Nombre" pattern="[A-Za-z0-9]+" required=""></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="apellido" runat="server" Text="Ingrese su Apellido :"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
								 <asp:TextBox ID="txtApellidos" runat="server" Width="783px" class="input" type="text" placeholder="Ingrese aqui su Apellido" pattern="[A-Za-z0-9]+" required=""></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="correo" runat="server" Text="Ingrese su Correo :"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
								 <asp:TextBox ID="txtCorreo" runat="server" Width="783px" type="email" class="input" placeholder="Ingrese aqui su Correo" required=""></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="password" runat="server" Text="Ingrese su Contraseña :"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							 <asp:TextBox ID="txtPassword" runat="server" Width="783px" type="password" required="" class="input" placeholder="Escriba su contraseña"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="telefono" runat="server" Text="Ingrese su Telefono :"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							 <asp:TextBox ID="txtTelefono" runat="server" Width="783px" type="number" MaxLength="8" class="input" placeholder="Ingrese aqui su Telefono" required=""></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="fechanacimiento" runat="server" Text="Ingrese su fecha de Nacimiento :"></asp:Label>
                            &nbsp;&nbsp;&nbsp;
							 <asp:TextBox ID="txtFechaNacimiento" runat="server" Width="783px" type="date" placeholder="Fecha Nacimiento" required=""></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="comuna" runat="server" Text="Ingrese su Comuna :"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="txtComuna" runat="server" class="input" Width="783px" type="text" required="" placeholder="Ingrese su comuna de residencia"></asp:TextBox>
                        </div>


                        <%--                                <select id="regiones"></select>
                                <select id="comunas"></select>--%>

                        <%--<asp:DropDownList ID="comuna" runat="server" SelectMethod="comuna"></asp:DropDownList>
                               <asp:DropDownList ID="DropDownList1" runat="server" SelectMethod="region"></asp:DropDownList>--%>



                        <div class="input-checkbox">
                            <input type="checkbox" required="" id="terms">
                            <label for="terms">
                                <span></span>
                                He leido todo,acepto terminos y condiciones<a href="#"></a>
                            </label>
                        </div>
                        <asp:Button ID="BtnRegistrar" runat="server" Text="Crear Cuenta" class="primary-btn order-submit" Width="189px" OnClick="BtnRegistrar_Click" />
                        <%--		<a href="#" class="primary-btn order-submit">Crear Cuenta</a> <!-- /hacer referencia aspx -->--%>
                        <a href="Login.aspx" class="primary-btn order-submit">Ya Tengo Una Cuenta</a>
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
