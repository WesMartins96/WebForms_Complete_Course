<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Sistema_Agenda.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="Login.css" rel="stylesheet" type="text/css" />
</head>

<body>
    <div class="container">
        <h1>Sistema Agenda</h1>
        <form id="form1" runat="server">
            <div>
                <asp:Label ID="lEmailLogin" runat="server" Text="E-mail"></asp:Label>
                <asp:TextBox ID="txtbEmailLogin" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lSenhaLogin" runat="server" Text="Senha"></asp:Label>
                <asp:TextBox ID="txtbSenhaLogin" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
            </div>
            <asp:Label ID="lMsg" runat="server"></asp:Label>
        </form>
    </div>
</body>
</html>
