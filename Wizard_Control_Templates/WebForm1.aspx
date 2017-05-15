<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Wizard_Control_Templates.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="0">
            <StartNavigationTemplate>
                <asp:Button ID="StartNextButton" runat="server"
                     OnClientClick="return confirm('Are you sure you want to go to next page?')" CommandName="MoveNext" Text="Next" />
            </StartNavigationTemplate>
            <WizardSteps>
                <asp:WizardStep ID="WizardStep1" runat="server" Title="Step 1">
                    <asp:TextBox ID="Step1TextBox" runat="server"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep ID="WizardStep2" runat="server" Title="Step 2">
                    <asp:TextBox ID="Step2TextBox" runat="server"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep ID="WizardStep3" runat="server" Title="Step 3">
                    <asp:TextBox ID="Step3TextBox" runat="server"></asp:TextBox>
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    </div>
    </form>
</body>
</html>
