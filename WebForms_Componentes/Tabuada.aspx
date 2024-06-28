<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tabuada.aspx.cs" Inherits="WebForms_Componentes.Tabuada" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>    
    <form id="form1" runat="server">
        <div>
            <h1>Tabuada</h1>
            <p>
                <asp:DropDownList ID="ddlNumeros" runat="server">
                </asp:DropDownList>
                <asp:Button ID="btExecutar" runat="server" OnClick="btExecutar_Click" Text="Exibir a Tabuada" />
            </p>
            <p>
                <asp:ListBox ID="lbDados" runat="server" Height="200px" Width="140px"></asp:ListBox>
            </p>

        </div>
    </form>
</body>
</html>
