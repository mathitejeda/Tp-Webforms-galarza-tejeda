<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tp_Webforms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  <main role="main" class="col-md-9 ml-sm-auto col-lg-10 px-4">
                <div class="card-deck">
                    <asp:Repeater runat="server" ID="repeater">
                        <ItemTemplate>
                            <div class="col-md-4 p-2">
                                <div class="card">
                                    <img src="<%#Eval("imagenUrl") %>" class="card-img-top" alt="...">
                                    <div class="card-body">
                                        <h5 class="card-title"><%#Eval("nombre")%></h5>
                                        <p class="card-text"><%#Eval("descripcion")%></p>
                                    </div>
                                    <a class="btn btn-primary" href="/DetalleArticulo?id=<%#Eval("id")%>">Detalle</a>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </main>

</asp:Content>
