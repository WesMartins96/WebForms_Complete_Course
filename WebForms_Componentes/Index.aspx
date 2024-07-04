<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebForms_Componentes.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Tabuada.aspx">Tabuada</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Calendar.aspx">Calendar</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Panel_BulletList.aspx">Par ou Impar</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="250px" ImageUrl="~/Imagens/image01.jpg" PostBackUrl="~/Tabuada.aspx" Width="500px" />
                    </td>
                    <td>
                        <asp:ImageButton ID="ImageButton2" runat="server" Height="250px" ImageUrl="~/Imagens/image02.jpg" PostBackUrl="~/Calendar.aspx" Width="500px" />
                    </td>
                    <td>
                        <asp:ImageButton ID="ImageButton3" runat="server" Height="250px" ImageUrl="~/Imagens/image03.jpg" PostBackUrl="~/Panel_BulletList.aspx" Width="500px" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
