<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="WebForms_Componentes.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="Menu1" runat="server" BackColor="#E3EAEB" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Overline="False" Font-Size="0.8em" ForeColor="#666666" Orientation="Horizontal" StaticSubMenuIndent="10px" Width="100%">
                <DynamicHoverStyle BackColor="#666666" ForeColor="White" />
                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <DynamicMenuStyle BackColor="#E3EAEB" />
                <DynamicSelectedStyle BackColor="#1C5E55" />
                <Items>
                    <asp:MenuItem Text="Projetos" Value="Projetos">
                        <asp:MenuItem NavigateUrl="~/Calendar.aspx" Text="Calendario" Value="Calendario"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/ImageMap.aspx" Text="Imagem" Value="Imagem"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem Text="Consutas" Value="Consutas"></asp:MenuItem>
                    <asp:MenuItem Text="Relatorios" Value="Relatorios"></asp:MenuItem>
                </Items>
                <StaticHoverStyle BackColor="#666666" ForeColor="White" />
                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <StaticSelectedStyle BackColor="#1C5E55" />
            </asp:Menu>
        </div>
    </form>
</body>
</html>
