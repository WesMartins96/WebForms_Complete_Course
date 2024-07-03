<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComponentesII.aspx.cs" Inherits="WebForms_Componentes.ComponentesII" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/ArquivosGerais/Propaganda.xml" Height="300px" Target="_blank" Width="500px" />
            <br />
            <asp:Literal runat="server" Text="&lt;b&gt;Olá Mundo" ></asp:Literal>
        </div>
        <div>
            
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0" >
                <asp:View ID="View1" runat="server">
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="300px" ImageUrl="~/Imagens/image01.jpg" OnClick="ImageButton1_Click" Width="500px" />
                    <asp:ImageButton ID="ImageButton2" runat="server" Height="300px" ImageUrl="~/Imagens/image02.jpg" OnClick="ImageButton2_Click" Width="500px" />
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <asp:Label ID="Label1" runat="server" Text="Windows 11 - Blue Flower"></asp:Label>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Windows 11 - Blue Waves"></asp:Label>
                    <br />
                    <br />
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://www.youtube.com/channel/UCis3hJLsYyLF3Zq0q24GKUw" Target="_blank">Meu Canal no Youtube</asp:HyperLink>
                    <br />
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="https://github.com/WesMartins96" Target="_blank">Meu GitHub</asp:HyperLink>
                    <br />
                    <br />
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Voltar</asp:LinkButton>
                </asp:View>
                <asp:View ID="View3" runat="server">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Windows 7 - True Flower"></asp:Label>
                    <br />
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Windows 7 - Waves of Pass"></asp:Label>
                    <br />
                    <br />
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton1_Click">Voltar</asp:LinkButton>
                </asp:View>
            </asp:MultiView>
        </div>
    </form>
</body>
</html>
