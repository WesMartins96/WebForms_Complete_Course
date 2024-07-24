<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMestre.Master" AutoEventWireup="true" CodeBehind="Categoria.aspx.cs" Inherits="Sistema_WEB_Frases.Categoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" GroupingText="Cadastro/Alteração de Categorias">
        <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
        <br />
        <asp:TextBox ID="txtId" runat="server" Enabled="false"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Categoria"></asp:Label>
        <br />
        <asp:TextBox ID="txtCategoria" runat="server" Width="570px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSalvar" runat="server" Text="Inserir" OnClick="btnSalvar_Click" />
        <asp:Button ID="btnCancelar" runat="server" CausesValidation="False" Text="Cancelar" />
        <br />
        <br />
        <asp:GridView ID="gvDados" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Width="575px">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="categoria" HeaderText="categoria" SortExpression="categoria" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sisfrasesConnectionString %>" SelectCommand="SELECT * FROM [categorias]"></asp:SqlDataSource>
        <br />


    </asp:Panel>

</asp:Content>
