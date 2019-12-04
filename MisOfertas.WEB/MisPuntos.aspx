<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MisPuntos.aspx.cs" Inherits="MisOfertas.WEB.MisPuntos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <!-- Custom fonts for this template-->
  <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
  <link href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet">

  <!-- Custom styles for this template-->
 <%-- <link href="css/sb-admin-2.min.css" rel="stylesheet">--%>


         <div class="container-fluid">
              <div class="card shadow mb-4">
          <!-- Page Heading -->
          <h1 class="h3 mb-2 text-gray-800" id="hPuntos" runat="server">Porcentaje De Descuento/Mis Puntos :'<%#Eval("Puntos")%>'</h1>
          <%--<p class="mb-4">DataTables is a third party plugin that is used to generate the demo table below. For more information about DataTables, please visit the <a target="_blank" href="https://datatables.net">official DataTables documentation</a>.</p>--%>

          <!-- DataTales Example -->
          <div class="card shadow mb-4">
            <div class="card-header py-3">
              <h6 class="m-0 font-weight-bold text-primary">Tipos De Descuento</h6>
            </div>
            <div class="card-body">
              <div class="table-responsive">
                <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">

                  <thead>
                    <tr>
                      <th>Puntos</th>
                      <th>Descuento</th>
                      <th>Tope</th>
                      <th>Rubro</th>
                    </tr>
                  </thead>
                  
                  <tbody>
                    <tr>
                      <td>0-100</td>
                      <td>5%</td>
                      <td>$100.000</td>
                      <td>Alimentos</td>
                      
                    </tr>
                       <tr>
                      <td>101-500</td>
                      <td>10%</td>
                      <td>$150.000</td>
                      <td>Alimentos,Electronica y Linea Blanca</td>
                    </tr>
                       <tr>
                      <td>500-1000</td>
                      <td>15%</td>
                      <td>$300.000</td>
                      <td>Alimentos,Electronica,Linea Blanca y Ropa</td>
                    </tr>
                  </tbody>
                </table>
                </div>
            </div>
          </div>
             </div>
             </div>
    <br />
                <asp:Label ID="Label1" runat="server" Text="Descargar Cupon De MIS Puntos Acumulados :"></asp:Label>
                 <asp:ImageButton ID="BtnExportarMisPuntos" runat="server" ImageUrl="~/Img/Excel.png" Height="88px" Width="90px" style="margin-left: 26px" OnClick="BtnExportarMisPuntos_Click" />




    <%--CssClass="" --%>

    <!-- Bootstrap core JavaScript-->
  <script src="vendor/jquery/jquery.min.js"></script>
  <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

  <!-- Core plugin JavaScript-->
  <script src="vendor/jquery-easing/jquery.easing.min.js"></script>

  <!-- Custom scripts for all pages-->
  <script src="js/sb-admin-2.min.js"></script>

  <!-- Page level plugins -->
  <script src="vendor/datatables/jquery.dataTables.min.js"></script>
  <script src="vendor/datatables/dataTables.bootstrap4.min.js"></script>
     <!-- Custom styles for this page -->
  <link href="vendor/datatables/dataTables.bootstrap4.min.css" rel="stylesheet">
  <!-- Page level custom scripts -->
  <script src="js/demo/datatables-demo.js"></script>
        

</asp:Content>
