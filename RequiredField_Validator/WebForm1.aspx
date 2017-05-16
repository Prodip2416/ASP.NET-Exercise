<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RequiredField_Validator.WebForm1" %>

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
            <td>Name:</td>
            <td>
                <asp:TextBox ID="txtName" Width="150px" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server"
                 ErrorMessage="Name is Required" ForeColor="red" ControlToValidate="txtName"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Gender:</td>
            <td>
                <asp:DropDownList ID="ddlGender" Width="150px" runat="server">
                    <asp:ListItem Text="Selected Item" Value="-1"></asp:ListItem>
                     <asp:ListItem Text="Male" Value="=Male"></asp:ListItem>
                     <asp:ListItem Text="FeMale" Value="=FeMale"></asp:ListItem>
                </asp:DropDownList>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidatorGender" runat="server"
                 ErrorMessage="Gender is Required" InitialValue="-1" ForeColor="red" ControlToValidate="ddlGender"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnSave" Width="100px" runat="server" Text="Save" OnClick="btnSave_Click" /></td>
        </tr>
        <tr><td colspan="2">
            <asp:Label ID="lblMessage" Font-Bold="True" runat="server"></asp:Label></td></tr>
    </table>
    </div>
    </form>
</body>
</html>
