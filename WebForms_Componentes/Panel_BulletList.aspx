<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Panel_BulletList.aspx.cs" Inherits="WebForms_Componentes.Panel_BulletList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:BulletedList ID="blLista" runat="server" BulletStyle="Square" Font-Bold="True" DisplayMode="LinkButton" Visible="False">
                <asp:ListItem>Par ou Impar</asp:ListItem>
                <asp:ListItem>Calcula o Fatorial</asp:ListItem>
            </asp:BulletedList>
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem>Par ou Impar</asp:ListItem>
                <asp:ListItem>Fatorial</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            <asp:Panel ID="pnParouImpar" runat="server" Visible="false">
                <asp:Label ID="Label1" runat="server" Text="Verifica se o número informado é [Par ou Impar]"></asp:Label>
                <br />
                <asp:TextBox ID="txtValorPn1" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Verificar" OnClick="Button1_Click" />
                <br />
                <asp:Label ID="lResult1" runat="server" Text=""></asp:Label>

            </asp:Panel>
            <br />
            <asp:Panel ID="pnFatorial" runat="server" Visible="false">
                <asp:Label ID="Label3" runat="server" Text="Calcula o [Fatorial] de um número"></asp:Label>
                <br />
                <asp:TextBox ID="txtValorPn2" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" Text="Calcular" />
                <br />
                <asp:Label ID="lResult2" runat="server"></asp:Label>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
