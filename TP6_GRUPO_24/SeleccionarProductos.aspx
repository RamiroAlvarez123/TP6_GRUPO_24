<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionarProductos.aspx.cs" Inherits="TP6_GRUPO_24.SeleccionarProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="gvProductos" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanging="gvProductos_SelectedIndexChanging" PageSize="14" OnPageIndexChanging="gvProductos_PageIndexChanging">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:TemplateField HeaderText="Id Producto">

            <ItemTemplate>
                <asp:Label ID="lbl_it_idProducto" runat="server" Text='<%# Bind("IdProducto") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Nombre Producto">

            <ItemTemplate>
                <asp:Label ID="lbl_it_NombreProducto" runat="server" Text='<%# Bind("NombreProducto") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Cantidad Por Unidad">

            <ItemTemplate>
                <asp:Label ID="lbl_it_CantidadPorUnidad" runat="server" Text='<%# Bind("CantidadPorUnidad") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Precio Unidad">

            <ItemTemplate>
                <asp:Label ID="lbl_it_PrecioUnidad" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
    <EditRowStyle BackColor="#2461BF" />
    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#EFF3FB" />
    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F5F7FB" />
    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
    <SortedDescendingCellStyle BackColor="#E9EBEF" />
    <SortedDescendingHeaderStyle BackColor="#4870BE" />
</asp:GridView>
        
    <asp:Label ID="lblProducto" runat="server" Text=""></asp:Label>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Ejercicio2.aspx">Volver al Inicio</asp:HyperLink>
        
    </form>
    </body>
</html>
