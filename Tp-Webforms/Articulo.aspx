<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Articulo.aspx.cs" Inherits="presentacionWeb.Articulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="card border-dark mb-3" >
  <div class="row no-gutters">
    <div class="col-md-4">
      <img src="https://th.bing.com/th/id/R59c122a1b8250b6158bc90f1e3970fe5?rik=DHWVS7%2bih6iH5g&pid=ImgRaw" style ="max-width:100%">
    </div>
    <div class="col-md-8">
      <div class="card-body">
        <h1 class="card-title">Nombre del producto</h1>
          <br />
        <h3 class="card-text" style="font-weight:normal">$precio</h3>
          <br />
         <asp:Button id="botonAgregar" Text="Agregar al carrito" CssClass="btn btn-success" runat="server"/>
         <br />

      </div>
    </div>
  </div>
</div>
<div class="card border-dark mb-3">
  <div class="card-body text-dark">
    <h5 class="card-title">Descripción</h5>
    <p class="card-text">Aca va la descripcion del producto</p>
  </div>
</div>
</asp:Content>
