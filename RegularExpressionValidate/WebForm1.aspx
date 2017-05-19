<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RegularExpressionValidate.WebForm1" %>

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
            <td>Email:</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server"
                     ErrorMessage="Invalid Email" ForeColor="red"
                   ControlToValidate="txtEmail" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                      ></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr><td colspan="2">
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" /></td></tr>
        <tr><td colspan="2">
            <asp:Label ID="lblMessage" ForeColor="green" runat="server"></asp:Label></td></tr>
    </table>
    </div>
    </form>
</body>
</html>
