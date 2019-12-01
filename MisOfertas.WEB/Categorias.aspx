<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Categorias.aspx.cs" Inherits="MisOfertas.WEB.Categorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:DataList ID="dlCategorias" runat="server">
        <ItemTemplate>
            <div class="card" style="width: 30rem;">
              <img  class="img-thumbnail" alt="..." src='<%#Eval("Imagen")%>'>
              <div class="card-body">
                <h5 class="card-title">'<%#Eval("Descripcion")%>'</h5>
                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                
              </div>
            </div>
            <asp:Button runat="server" Text="Ir a categoría" CausesValidation="False" OnCommand="Categoria_Command" CommandArgument='<% #Eval("IdCategoria")%>'></asp:Button>
        </ItemTemplate>
        
    </asp:DataList>
    
    <br />
</asp:Content>
