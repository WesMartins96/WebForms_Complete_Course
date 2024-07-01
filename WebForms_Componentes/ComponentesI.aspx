<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComponentesI.aspx.cs" Inherits="WebForms_Componentes.ComponentesI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Conhecendo os componentes - parte 1</title>
    <style type="text/css">
        .auto-style1 {
            width: 402px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">Site</td>
                    <td class="auto-style4">Endereço</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtSite" runat="server" Height="16px" Width="380px"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtEndereco" runat="server" Height="16px" Width="380px"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:ListBox ID="lbEndereco" runat="server" Width="380px" SelectionMode="Multiple">
                        </asp:ListBox>
                    </td>
                    <td class="auto-style4">
                        Opções<br />
                        <asp:Button ID="btnInserir" runat="server" OnClick="btnInserir_Click" Text="Inserir Site" Width="160px" />
                        <asp:Button ID="btSelecionar" runat="server" OnClick="btSelecionar_Click" Text="Selecionar Site" Width="160px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:DropDownList ID="ddlSite" runat="server" Width="380px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
