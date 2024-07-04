<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UtilizandoJavascript.aspx.cs" Inherits="WebForms_Componentes.UtilizandoJavascript" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="300px" ImageUrl="~/Imagens/image01.jpg" Width="500px" onMouseOver="exibirMensagem()"/>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Utilizar Javascript" Width="500px"/>
        </div>
        <div>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" onClick="aumentarFont()" >[+]</asp:HyperLink>
            <asp:HyperLink ID="HyperLink2" runat="server" onClick="diminuirFont()" >[-]</asp:HyperLink>
            <p id="p1">Exemplo de como alterar o tamanho da fonte utilizando javascript</p>
            <p id="p2">Visite o meu canal no youtube <a href="https://www.youtube.com/channel/UCis3hJLsYyLF3Zq0q24GKUw">Dev Wes</a></p>
        </div>
    </form>

</body>
</html>


<script type="text/javascript">
    function exibirMensagem() {
        alert('Olá Mundo!!!')
    }

    var tamanhoFont = 12;
    function aumentarFont() {
        tamanhoFont = tamanhoFont + 1;
        document.getElementById("p1").style.fontSize = tamanhoFont + "px";
        document.getElementById("p2").style.fontSize = tamanhoFont + "px";
    }

    function diminuirFont() {
        tamanhoFont = tamanhoFont - 1;
        document.getElementById("p1").style.fontSize = tamanhoFont + "px";
        document.getElementById("p2").style.fontSize = tamanhoFont + "px";
    } 
</script>
