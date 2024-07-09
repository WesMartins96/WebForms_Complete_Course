<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridView.aspx.cs" Inherits="GridView.GridView" %>

<!DOCTYPE html>

<style>
    .centered {
        text-align: center;
        vertical-align: middle;
    }
</style>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" DataSourceID="DataSourceGridView" EnableModelValidation="True" Width="100%" AllowPaging="True" AllowSorting="True" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CssClass="centered" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            </asp:GridView>
            <asp:SqlDataSource ID="DataSourceGridView" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wesley_lopes\Desktop\Codigos_Cursos\WebForms_Course\WebForms_Course\DataList\App_Data\Agenda.mdf;Integrated Security=True" ProviderName="System.Data.SqlClient" 
                SelectCommand="SELECT [Id], [Nome], [Email] FROM [Contato]" 
                DeleteCommand="DELETE FROM [Contato] WHERE [Id] = @Id" 
                InsertCommand="INSERT INTO [Contato] ([Nome], [Email]) VALUES (@Nome, @Email)" 
                UpdateCommand="UPDATE [Contato] SET [Nome] = @Nome, [Email] = @Email WHERE [Id] = @Id">
                <DeleteParameters>
                    <asp:Parameter Name="Id" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Nome" Type="String" />
                    <asp:Parameter Name="Email" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Nome" Type="String" />
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="Id" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="Id" DataSourceID="DataSourceGridView" EnableModelValidation="True" Height="50px" Visible="False" Width="350px">
                <EditRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <Fields>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    <asp:CommandField ShowInsertButton="True" />
                </Fields>
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
            </asp:DetailsView>
        </div>
    </form>
</body>
</html>
