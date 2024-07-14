<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormSalarioMinimo.aspx.cs" Inherits="ModuloII.FormSalarioMinimo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Informe o Salário Bruto"></asp:Label>
            <br />
            <asp:TextBox ID="txtbSalario" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Percentual de Desconto"></asp:Label>
            <br />
            <asp:TextBox ID="txtbDesconto" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnEnviarDados" runat="server" PostBackUrl="~/RespostaSalarioMinimo.aspx" Text="Enviar Dados" />
        </div>
    </form>
</body>
</html>
