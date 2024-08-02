<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMestre.Master" AutoEventWireup="true" CodeBehind="Frases.aspx.cs" Inherits="Sistema_WEB_Frases.Frases" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:Panel ID="Panel1" runat="server" GroupingText="Cadastro/Alteração de Frases">
        <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
        <br />
        <asp:TextBox ID="txtId" runat="server" Enabled="false"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Frase"></asp:Label>
        <br />
        <asp:TextBox ID="txtFrases" runat="server" Width="570px"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Autor"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlAutor" runat="server" Height="30px" Width="200px">
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Categoria"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlCategoria" runat="server" Height="30px" Width="200px">
            </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnSalvar" runat="server" Text="Inserir" OnClick="btnSalvar_Click"  />
        <asp:Button ID="btnCancelar" runat="server" CausesValidation="False" Text="Cancelar" OnClick="btnCancelar_Click" />
        <br />

    </asp:Panel>
    <br />
    <br />
    <asp:Panel ID="Panel2" runat="server" GroupingText="Lista de Categorias">
        <asp:GridView ID="gvDados" runat="server" AutoGenerateColumns="False" DataKeyNames="id" Width="575px" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleting="gvDados_RowDeleting" OnSelectedIndexChanged="gvDados_SelectedIndexChanged" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:BoundField DataField="id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="frase" HeaderText="Frase" SortExpression="frase" />
                <asp:BoundField DataField="autornome" HeaderText="Autor" />
                <asp:BoundField DataField="categorianome" HeaderText="Categoria" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </asp:Panel>
</asp:Content>
