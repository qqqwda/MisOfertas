<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPgePriv.Master" AutoEventWireup="true" CodeBehind="HomeGerente.aspx.cs" Inherits="MisOfertas.WEB.HomeGerente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



      
    <div class="container-fluid">
     <div class="card-header py-3">
   <h1 class="h3 mb-2 text-gray-800">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Lista De Ofertas</h1>
        </div>
       <div class="card shadow mb-4">
     <div class="card-body">
         <div class="table-responsive" id="dataTable">
             <div aria-controls="dataTable" class="sorting" >

                 <asp:ImageButton ID="BtnExportarExcel" runat="server" ImageUrl="~/Img/Excel.png" Height="88px" Width="94px" style="margin-left: 301px" OnClick="BtnExportarExcel_Click" />
                  <asp:ImageButton ID="btntxt" runat="server" ImageUrl="~/Img/Note.jfif" Height="88px" Width="94px" style="margin-left: 301px" OnClick="btntxt_Click" />
            <asp:GridView ID="GvOfertas"  Width ="80%"  CssClass="table table-bordered" runat="server"  ></asp:GridView>
        </div>
             </div>
  </div>
    </div>
        </div>

    <asp:Button ID="btneditar" runat="server" Text="EDITAR PRUEBA" OnClick="btneditar_Click" />
    <asp:HiddenField ID="hdfEditar" runat="server" />
    <asp:Panel ID="pnlEditar" runat="server" Visible ="false">


        
        <asp:TextBox ID="txteditar" runat="server"></asp:TextBox>
        <asp:Button ID="btnGuardarEditar" runat="server" Text="Guardar cambios" OnClick="btnGuardarEditar_Click" />

    </asp:Panel>




</asp:Content>
