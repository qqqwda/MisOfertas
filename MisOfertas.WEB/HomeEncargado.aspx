<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/MasterPgePriv.Master" AutoEventWireup="true" CodeBehind="HomeEncargado.aspx.cs" Inherits="MisOfertas.WEB.HomeGerente" %>
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
             <div aria-controls="dataTable" class="sorting">
                 
                     <asp:ImageButton ID="BtnExportarExcel" runat="server" ImageUrl="~/Img/Excel.png" Height="88px" Width="94px" Style="margin-left: 301px" OnClick="BtnExportarExcel_Click" />

                     <asp:ImageButton ID="btntxt" runat="server" ImageUrl="~/Img/Note.jfif" Height="88px" Width="94px" Style="margin-left: 301px" OnClick="btntxt_Click" />
                     <br />
                     <br />

            <asp:GridView  ID="GvOfertas" runat="server" Width ="80%"  CssClass="table table-bordered"  AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="GvOfertas_PageIndexChanging" PageSize="25" OnSelectedIndexChanged="GvOfertas_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                        <asp:BoundField DataField="CompraMin" HeaderText="Compra Minima" />
                        <asp:BoundField DataField="CompraMax" HeaderText="Compra Maxima" />
                        <asp:BoundField DataField="FechaDisponibilidad" HeaderText="Fecha Disponibilidad" />
                         <asp:BoundField DataField="Valor" HeaderText="Valor $" />
                         <asp:BoundField DataField="PorcentajeDescuento" HeaderText="Porcentaje Descuento" />
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:ImageButton ID="btneditar" runat="server" ImageUrl="https://cdn.discordapp.com/attachments/647215602452135936/649830205602529280/user_edit.png" CausesValidation="False" OnCommand="btneditar_Command1" CommandArgument='<% #Eval("IdOferta")%> ' CommandName="Editar" Text="Editar" OnClientClick="return confirm('¿Esta seguro que desea Editar esta oferta?');"/>
                            </ItemTemplate>
                             <ControlStyle Height="43px" Width="60px" />
                        </asp:TemplateField>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:ImageButton ID="btnEliminar" runat="server" ImageUrl="https://cdn.discordapp.com/attachments/647215602452135936/649830202167263251/delete.png" CausesValidation="False" OnCommand="btnEliminar_Command" CommandArgument='<% #Eval("IdOferta")%> ' CommandName="Eliminar" Text="Eliminar"  OnClientClick="return confirm('¿Esta seguro que desea Eliminar esta oferta?');"/>
                            </ItemTemplate>
                             <ControlStyle Height="43px" Width="60px" />
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
        </div>
            
             </div>
  </div>
    </div>
        </div>

    




</asp:Content>
