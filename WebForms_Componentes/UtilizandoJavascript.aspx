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
    </form>
</body>
</html>


<script type="text/javascript">
    function exibirMensagem() {
        alert('Olá Mundo!!!')
    }
</script>
