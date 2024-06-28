<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComponentesI.aspx.cs" Inherits="WebForms_Componentes.ComponentesI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Conhecendo os componentes - parte 1</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">Site</td>
                    <td class="auto-style4">Endereço</td>
                    <td>Opções</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtSite" runat="server" Height="16px" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtEndereco" runat="server" Height="16px" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="btnInserir" runat="server" OnClick="btnInserir_Click" Text="Inserir Site" />
                        <asp:Button ID="btSelecionar" runat="server" OnClick="btSelecionar_Click" Text="Selecionar Site" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:DropDownList ID="ddlSite" runat="server" Width="200px">
                            <asp:ListItem>LinkedIn</asp:ListItem>
                            <asp:ListItem>Youtube</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style4">
                        <asp:ListBox ID="lbEndereco" runat="server" Width="200px">
                            <asp:ListItem>http://youtube.com.br</asp:ListItem>
                        </asp:ListBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
