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
            <asp:RadioButtonList ID="rbDesconto" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem Selected="True" Value="10">10%</asp:ListItem>
                <asp:ListItem Value="20">20%</asp:ListItem>
                <asp:ListItem Value="30">30%</asp:ListItem>
                <asp:ListItem>Outro</asp:ListItem>
            </asp:RadioButtonList>
            <asp:TextBox ID="txtbDesconto" runat="server" Visible="False"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnEnviarDados" runat="server" PostBackUrl="~/RespostaSalarioMinimo.aspx" Text="Enviar Dados" />
        </div>
    </form>
</body>
</html>
