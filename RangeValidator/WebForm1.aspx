<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RangeValidator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td><b>Age</b></td>
            <td>
                <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidatorAge" runat="server" 
                ErrorMessage="Age must be between 1 & 100"
                MinimumValue="1" MaximumValue="100"
                ControlToValidate="txtAge" Type="Integer" 
                ForeColor="Red" Display="Dynamic">
            </asp:RangeValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorAge" 
            runat="server" ErrorMessage="Age is required" 
            ControlToValidate="txtAge" ForeColor="Red"
            Display="Dynamic" >
            </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Date</td>
            <td>
                <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
               
            <asp:RangeValidator ID="endDateValidator" runat="server" 
                Display="Dynamic" ErrorMessage="Date must be 1/4/2012 to 1/1/2018"
                 ControlToValidate="txtDate"
                MaximumValue="1/1/2100" MinimumValue="1/4/2012" ForeColor="red" 
                 Type="Date"></asp:RangeValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorDate"
                     runat="server" Display="Dynamic" ControlToValidate="txtDate"
                     ForeColor="red" ErrorMessage="Date Must be Required"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" /></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblMessage" runat="server" Font-Bold="True" ForeColor="red"></asp:Label></td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
