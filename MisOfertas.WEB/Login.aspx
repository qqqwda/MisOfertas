<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MisOfertas.WEB.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title> 
    <link href="Css/Login.css" rel="stylesheet" />
</head>

<body>
    <form id="form1" runat="server">
      <div class="logo">
<img src="Img/logo.png" />
</div>
<div class="campos">
<div class="fila-login">
<asp:TextBox ID="txtCorreo" runat="server" type="text" placeholder="correo" required="" CssClass="txt-rut" Width="290px"></asp:TextBox>

</div>
<div class="fila-pass">
<asp:TextBox ID="txtPass" runat="server" type="password" placeholder="Contraseña" required="" CssClass="txt-pass"></asp:TextBox>
</div>
<div class="fila-boton">
<asp:LinkButton ID="btnEntrar" runat="server" OnClick="btnEntrar_Click" CssClass="btn-ingresar">Ingresar</asp:LinkButton>
</div>
</div>
    </form>
</body>
</html>
