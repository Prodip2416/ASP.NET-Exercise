<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Wizard_Conrol_Property.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Wizard ID="Wizard1" runat="server" DisplayCancelButton="True" Font-Bold="True" Font-Italic="True" ForeColor="#339933" HeaderText="Personal Details" ActiveStepIndex="1">
            <WizardSteps>
                <asp:WizardStep ID="WizardStep1" runat="server" Title="Step 1"></asp:WizardStep>
                <asp:WizardStep ID="WizardStep2" runat="server" Title="Step 2"></asp:WizardStep>
                 <asp:WizardStep ID="WizardStep3" runat="server" Title="Step 3"></asp:WizardStep>            
            </WizardSteps>
        </asp:Wizard>
    </div>
    </form>
</body>
</html>
