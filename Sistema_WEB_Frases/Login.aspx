<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Sistema_WEB_Frases.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" GroupingText="Login de usuário" CssClass="login">
                <asp:Label ID="Label1" runat="server" Text="Login"></asp:Label>
                <br />
                <asp:TextBox ID="txtbLogin" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
                <br />
                <asp:TextBox ID="txtbSenha" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnLogar" runat="server" Text="Logar" OnClick="btnLogar_Click" Width="200px" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
