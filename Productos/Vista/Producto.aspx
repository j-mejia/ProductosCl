<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="Productos.Views.Producto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-bottom: 157px">
            ID Marca:<asp:TextBox ID="tbxMarca" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ID Producto:
            <asp:TextBox ID="tbxProd" runat="server" OnTextChanged="tbxProd_TextChanged"></asp:TextBox>
            <br />
            ID Presentacion: <asp:TextBox ID="tbxPres" runat="server"></asp:TextBox>
            <br />
            ID Proveedor:
            <asp:TextBox ID="tbxProv" runat="server"></asp:TextBox>
            <br />
            ID Zona:
            <asp:TextBox ID="tbxZona" runat="server"></asp:TextBox>
            <br />
            Codigo:<asp:TextBox ID="tbxCod" runat="server"></asp:TextBox>
            <br />
            Descripcion:
            <asp:TextBox ID="txbDesc" runat="server"></asp:TextBox>
            <br />
            Precio:
            <asp:TextBox ID="tbxPrecio" runat="server"></asp:TextBox>
            <br />
            Stock:
            <asp:TextBox ID="tbxStock" runat="server"></asp:TextBox>
            <br />
            IVA:
            <asp:TextBox ID="tbxIVA" runat="server"></asp:TextBox>
            <br />
            Peso:
            <asp:TextBox ID="tbxPeso" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
            <br />
            <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar" />
            <asp:Button ID="btnBorrar" runat="server" OnClick="btnBorrar_Click" Text="Borrar" />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
