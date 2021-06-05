<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="presentacionWeb.DetalleArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="card border-dark mb-3" >
  <div class="row no-gutters">
    <div class="col-md-4">
      <%--<img src="<asp:Label ID="lblImagenURL" runat="server" Text="Label"></asp:Label>" style ="max-width:100%">--%>
      <asp:Image ID="imgImagenArticulo" runat="server" />
    </div>
    <div class="col-md-8">
        
      <div class="card-body">
        <h1 class="card-title"><asp:Label ID="lblNombreArticulo" runat="server" Text="Label"></asp:Label></h1>
          <br />
        <h3 class="card-text" style="font-weight:normal"><asp:Label ID="lblPrecioArticulo" runat="server" Text="Label"></asp:Label></h3>
          <br />
         <a href="Carrito.aspx?id=1"><asp:Button id="botonAgregar" Text="Agregar al carrito" CssClass="btn btn-success" runat="server"/></a>
         <br />

      </div>
    </div>
  </div>
</div>
<div class="card border-dark mb-3">
  <div class="card-body text-dark">
    <h5 class="card-title">Descripción</h5>
    <p class="card-text"><asp:Label ID="lblDescripcion" runat="server" Text="Label"></asp:Label></p>
  </div>
</div>
</asp:Content>
