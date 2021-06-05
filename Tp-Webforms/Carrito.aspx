<%@ Page Title="carrito" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="presentacionWeb.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<h1>Este es tu carrito de compras</h1>

	<%if (carrito.Count != 0)
		{%>
<%foreach (Modelo.Articulo item in carrito)
	{ %>

		<div class="card mb-3" style="max-width: 620px;">
  <div class="row no-gutters">
	  <div class="col-md-4">
		  <img src="<% =item.imagenUrl %>" alt="...">
	  </div>
    <div class="col-md-6">
      <div class="card-body">
        <h1 class="card-title"><% =item.nombre %></h1>
        <h3 class="card-text"><%=item.descripcion %></h3>
      </div>
    </div>
	  <div class="col-md-2 justify-content-end">
		<asp:Button  CssClass="btn btn-danger" Text="Eliminar" ID="BotonEliminar" runat="server" />
	  </div>
  </div>
</div>
	<%} %>

	<%}
		else
		{	%>
	<h5>Tu carrito esta vacio!</h5>
	<%} %>
</asp:Content>
