<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tp_Webforms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  <main role="main">
                <div class="card-group">
                    <asp:Repeater runat="server" ID="repeater">
                        <ItemTemplate>
                            <div class="col-md-4 p-2">
                                <div class="card">
                                    <rect style="width:100%; height=100%; fill:grey">
                                        <img src="<%#Eval("imagenUrl") %>" class="card-img-top" alt="..." style="width:100%; height:15rem;object-fit:scale-down">
                                        </rect>
                                    <div class="card-body">
                                        <h5 class="card-title"><%#Eval("nombre")%></h5>
                                        <p class="card-text">$<%#Eval("precio")%></p>
                                    </div>
                                    <a class="btn btn-primary" href="/DetalleArticulo?id=<%#Eval("id")%>">Detalle</a>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </main>
        </div>
    </div>
</asp:Content>
