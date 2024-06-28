<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForms_Course.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Primeira Pagina Web Forms</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Executar" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Mensagem de Boas Vindas!!!"></asp:Label>
        </div>
    </form>
</body>
</html>
