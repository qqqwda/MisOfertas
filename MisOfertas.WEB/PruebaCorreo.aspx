<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PruebaCorreo.aspx.cs" Inherits="MisOfertas.WEB.PruebaCorreo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        asunto :<asp:TextBox ID="txtAsunto" runat="server"></asp:TextBox>
        <br />
         cuerpo :<asp:TextBox ID="txtCuerpo" TextMode="MultiLine" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnEnviar" runat="server" Text="enviar" OnClick="btnEnviar_Click" />
    </form>
</body>
</html>
