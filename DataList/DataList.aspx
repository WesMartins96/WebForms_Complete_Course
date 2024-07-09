<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataList.aspx.cs" Inherits="DataList.DataList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
            <br />
            <asp:TextBox ID="txtNome" runat="server" Width="250px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
            <br />
            <asp:TextBox ID="txtEmail" runat="server" Width="250px"></asp:TextBox>
            <asp:Button ID="btnEnviarAoBanco" runat="server" Text="Enviar ao Banco de dados" Font-Italic="True" OnClick="btnEnviarAoBanco_Click" />
            <br />
            <hr />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Large" Text="Lista de Contatos"></asp:Label>
            <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyField="Id" DataSourceID="DataSource" GridLines="Both" Width="250px">
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <ItemStyle BackColor="White" ForeColor="#330099" />
                <ItemTemplate>
                    Id:
                    <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                    <br />
                    Nome:
                    <asp:Label ID="NomeLabel" runat="server" Text='<%# Eval("Nome") %>' />
                    <br />
                    Email:
                    <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                    <br />
                    <br />
                </ItemTemplate>
                <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            </asp:DataList>
            <asp:SqlDataSource ID="DataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Id], [Nome], [Email] FROM [Contato]"></asp:SqlDataSource>
            <br />
        </div>
    </form>
</body>
</html>
