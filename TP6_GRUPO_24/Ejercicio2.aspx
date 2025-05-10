<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP6_GRUPO_24.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
           <h2> <asp:Label ID="Label1" runat="server" Text="INICIO"></asp:Label> </h2>
        
           <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/SeleccionarProductos.aspx">Seleccionar Productos</asp:HyperLink>
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Eliminar Productos seleccionados</asp:LinkButton>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/MostrarProductos.aspx">Mostrar Productos</asp:HyperLink>
        
           <p>
               <asp:Label ID="lblMensaje" runat="server"></asp:Label>
               
           </p>
        <br />
<br />
<br />
<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/PaginaInicio.aspx">Volver a la pagina de inicio</asp:HyperLink>
        
    </form>
</body>
</html>
