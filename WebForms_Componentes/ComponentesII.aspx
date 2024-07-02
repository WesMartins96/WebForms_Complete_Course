<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComponentesII.aspx.cs" Inherits="WebForms_Componentes.ComponentesII" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0" >
                <asp:View ID="View1" runat="server">
                    <asp:Image ID="Image1" runat="server" Height="300px" ImageUrl="~/Imagens/image01.jpg" Width="500px" AlternateText="Imagem flor do windows 11" />
                    <asp:Image ID="Image2" runat="server" Height="300px" ImageUrl="~/Imagens/image02.jpg" Width="500px" AlternateText="Imagem ondas do windows 11" />
                </asp:View>
                <asp:View ID="View2" runat="server">
                </asp:View>
                <asp:View ID="View3" runat="server">
                </asp:View>
            </asp:MultiView>
        </div>
    </form>
</body>
</html>
