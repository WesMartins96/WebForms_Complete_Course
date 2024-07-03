<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImageMap.aspx.cs" Inherits="WebForms_Componentes.ImageMap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ImageMap ID="ImageMap1" runat="server" Height="300px" ImageUrl="~/Imagens/image03.jpg" Width="500px">
                <asp:RectangleHotSpot AlternateText="Youtube" Bottom="400" NavigateUrl="http://www.youtube.com.br" Right="250" Target="_blank" />
                <asp:RectangleHotSpot AlternateText="GitHub" Bottom="250" Left="250" NavigateUrl="http://github.com.br" Right="500" Target="_blank" />
            </asp:ImageMap>
        </div>
    </form>
</body>
</html>
