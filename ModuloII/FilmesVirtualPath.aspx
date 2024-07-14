<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FilmesVirtualPath.aspx.cs" Inherits="ModuloII.FilmesVirtualPath" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Filmes"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlFilmes" runat="server" Width="350px">
            </asp:DropDownList>
            <asp:TextBox ID="txtbFilmes" runat="server" ToolTip="Digite o nome do filme" Width="350px"></asp:TextBox>
            <asp:Button ID="btnInserirFilme" runat="server" OnClick="btnInserirFilme_Click" Text="Inserir Filme" />
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" PostBackUrl="~/RespostaFilmesVirtualPath.aspx" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
