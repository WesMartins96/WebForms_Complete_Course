<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadArquivos.aspx.cs" Inherits="UploadArquivos.UploadArquivos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="[UPLOAD] de Arquivos"></asp:Label>
            <br />
            <asp:FileUpload ID="fuArquivos" runat="server" />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Nome do Arquivo"></asp:Label>
            <asp:TextBox ID="txtbNomeArquivo" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Tamanho do Arquivo"></asp:Label>
            <asp:TextBox ID="txtbTamanhoArquivo" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar Arquivo" OnClick="btnEnviar_Click" />
        </div>
    </form>
</body>
</html>
