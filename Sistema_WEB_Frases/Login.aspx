<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Sistema_WEB_Frases.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="CSS/login.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" GroupingText="" CssClass="login">
                <i class="fas fa-user-circle icon"></i>
                <h2>Login</h2>
                <asp:Label ID="Label1" runat="server" Text="Login"></asp:Label>
                <asp:TextBox ID="txtbLogin" runat="server"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
                <asp:TextBox ID="txtbSenha" runat="server" TextMode="Password"></asp:TextBox>
                <asp:Button ID="btnLogar" runat="server" Text="Logar" OnClick="btnLogar_Click" CssClass="login-button" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
