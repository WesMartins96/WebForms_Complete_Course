<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookies.aspx.cs" Inherits="ModuloII.Cookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Login"></asp:Label>
                <br />
                <asp:TextBox ID="txtbLoginCookie" runat="server" Width="140px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
                <br />
                <asp:TextBox ID="txtbSenhaCookie" runat="server" TextMode="Password" Width="140px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnExecutarCookie" runat="server" OnClick="btnExecutarCookie_Click" Text="Button" Width="150px" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
