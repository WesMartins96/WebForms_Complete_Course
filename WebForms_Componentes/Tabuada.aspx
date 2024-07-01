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
                <asp:ListBox ID="lbDados" runat="server" Height="200px" Width="140px" Visible="False"></asp:ListBox>
            </p>
            <p>
                <asp:Table ID="tbDados" runat="server" BackColor="#99CCFF" BorderColor="#000066" BorderStyle="Ridge" BorderWidth="3px" CellPadding="5" CellSpacing="5" Font-Bold="True" Font-Size="Medium" Visible="False" Width="231px">
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server"></asp:TableCell>
                        <asp:TableCell runat="server">X</asp:TableCell>
                        <asp:TableCell runat="server">0</asp:TableCell>
                        <asp:TableCell runat="server">=</asp:TableCell>
                        <asp:TableCell runat="server"></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server"></asp:TableCell>
                        <asp:TableCell runat="server">X</asp:TableCell>
                        <asp:TableCell runat="server">1</asp:TableCell>
                        <asp:TableCell runat="server">=</asp:TableCell>
                        <asp:TableCell runat="server"></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server"></asp:TableCell>
                        <asp:TableCell runat="server">X</asp:TableCell>
                        <asp:TableCell runat="server">2</asp:TableCell>
                        <asp:TableCell runat="server">=</asp:TableCell>
                        <asp:TableCell runat="server"></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server"></asp:TableCell>
                        <asp:TableCell runat="server">X</asp:TableCell>
                        <asp:TableCell runat="server">3</asp:TableCell>
                        <asp:TableCell runat="server">=</asp:TableCell>
                        <asp:TableCell runat="server"></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server"></asp:TableCell>
                        <asp:TableCell runat="server">X</asp:TableCell>
                        <asp:TableCell runat="server">4</asp:TableCell>
                        <asp:TableCell runat="server">=</asp:TableCell>
                        <asp:TableCell runat="server"></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server"></asp:TableCell>
                        <asp:TableCell runat="server">X</asp:TableCell>
                        <asp:TableCell runat="server">5</asp:TableCell>
                        <asp:TableCell runat="server">=</asp:TableCell>
                        <asp:TableCell runat="server"></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server"></asp:TableCell>
                        <asp:TableCell runat="server">X</asp:TableCell>
                        <asp:TableCell runat="server">6</asp:TableCell>
                        <asp:TableCell runat="server">=</asp:TableCell>
                        <asp:TableCell runat="server"></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server"></asp:TableCell>
                        <asp:TableCell runat="server">X</asp:TableCell>
                        <asp:TableCell runat="server">7</asp:TableCell>
                        <asp:TableCell runat="server">=</asp:TableCell>
                        <asp:TableCell runat="server"></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server"></asp:TableCell>
                        <asp:TableCell runat="server">X</asp:TableCell>
                        <asp:TableCell runat="server">8</asp:TableCell>
                        <asp:TableCell runat="server">=</asp:TableCell>
                        <asp:TableCell runat="server"></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server"></asp:TableCell>
                        <asp:TableCell runat="server">X</asp:TableCell>
                        <asp:TableCell runat="server">9</asp:TableCell>
                        <asp:TableCell runat="server">=</asp:TableCell>
                        <asp:TableCell runat="server"></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server"></asp:TableCell>
                        <asp:TableCell runat="server">X</asp:TableCell>
                        <asp:TableCell runat="server">10</asp:TableCell>
                        <asp:TableCell runat="server">=</asp:TableCell>
                        <asp:TableCell runat="server"></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </p>
            <p>
                <asp:PlaceHolder ID="PlaceHolder" runat="server"></asp:PlaceHolder>
            </p>

        </div>
    </form>
</body>
</html>
