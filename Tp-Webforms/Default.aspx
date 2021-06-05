<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tp_Webforms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Bienvenido</h1>
        <p class="lead">Compre por favor</p>
    </div>
<table>   
    <%foreach (Modelo.Articulo item in lista)
		{%>
        <tr>
            <td>
                <%= item.nombre %>
            </td>
        <td><%=item.descripcion %></td>
        <td>
            <%=item.precio %>
        </td>
        </tr>
    <%} %>
</table>

</asp:Content>
