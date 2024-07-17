<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookies2.aspx.cs" Inherits="ModuloII.Cookies2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lLogin" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="btnExecutarCookie2" runat="server" Text="Apaga Cookies" OnClick="btnExecutarCookie2_Click" />
            <asp:Button ID="btnListarCookies" runat="server" OnClick="btnListarCookies_Click" Text="Listar Cookies Criados" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Session ID:"></asp:Label>
            <asp:TextBox ID="txtbSessionID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Contador:"></asp:Label>
            <asp:TextBox ID="txtbContador" runat="server"></asp:TextBox>
            <asp:Button ID="btnContador" runat="server" OnClick="btnContador_Click" Text="Add" />
            <asp:Button ID="btnRemove" runat="server" OnClick="btnRemove_Click" Text="Remover" />
        </div>
    </form>
</body>
</html>
