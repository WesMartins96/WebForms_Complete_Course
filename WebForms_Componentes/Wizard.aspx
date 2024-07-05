<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Wizard.aspx.cs" Inherits="WebForms_Componentes.Wizard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Wizard ID="Wizard1" runat="server" Height="400px" Width="800px">
                <WizardSteps>
                    <asp:WizardStep runat="server" title="Dados Cadastrais">
                    </asp:WizardStep>
                    <asp:WizardStep runat="server" title="Endereço">
                    </asp:WizardStep>
                </WizardSteps>
            </asp:Wizard>
        </div>
    </form>
</body>
</html>
