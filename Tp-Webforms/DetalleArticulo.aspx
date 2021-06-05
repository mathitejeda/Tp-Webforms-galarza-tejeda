<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="presentacionWeb.DetalleArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="card border-dark mb-3" >
  <div class="row no-gutters">
    <div class="col-md-4">
      <img src="<%#Eval("imagenUrl") %>" style ="max-width:100%">
    </div>
    <div class="col-md-8">
      <div class="card-body">
        <h1 class="card-title">Nombre del producto</h1>
          <br />
        <h3 class="card-text" style="font-weight:normal">$precio</h3>
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
    <p class="card-text"><%#Eval("descripcion")%></p>
  </div>
</div>
</asp:Content>
