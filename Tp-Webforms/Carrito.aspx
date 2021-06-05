<%@ Page Title="carrito" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="presentacionWeb.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<h1>Este es tu carrito de compras</h1>

		<div class="card mb-3" style="max-width: 620px;">
  <div class="row no-gutters">
	  <div class="col-md-4">
		  <img src="..." alt="...">
	  </div>
    <div class="col-md-6">
      <div class="card-body">
        <h5 class="card-title">Card title</h5>
        <p class="card-text">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
      </div>
    </div>
	  <div class="col-md-2 justify-content-end">
		<asp:Button  CssClass="btn btn-danger" Text="Eliminar" ID="BotonEliminar" runat="server" />
	  </div>
  </div>
</div>

</asp:Content>
