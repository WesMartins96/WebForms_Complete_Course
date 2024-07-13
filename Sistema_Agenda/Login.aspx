<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Sistema_Agenda.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lEmailLogin" runat="server" Text="E-mail" Font-Bold="True"></asp:Label>
            <br />
            <asp:TextBox ID="txtbEmailLogin" runat="server" Width="250px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lSenhaLogin" runat="server" Text="Senha" Font-Bold="True"></asp:Label>
            <br />
            <asp:TextBox ID="txtbSenhaLogin" runat="server" TextMode="Password" Width="250px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" Width="260px" BackColor="#6699FF" Font-Bold="True" ForeColor="White" />
            <br />
    <asp:Label ID="lMsg" runat="server" Font-Size="Medium" ForeColor="#CC0000"></asp:Label>
        </div>
    </form>
</body>
</html>
