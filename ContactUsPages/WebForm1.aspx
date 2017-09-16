<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ContactUsPages.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset style="width: 350px">
        <legend>Contect us</legend>
        <table>
            <tr>
                <td><b>Name</b></td>
                <td>
                    <asp:TextBox ID="txtName" Width="200px" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                       ControlToValidate="txtName" Text="*" ForeColor="red"  ErrorMessage="Name is Required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td><b>Email</b></td>
                <td>
                    <asp:TextBox ID="txtEmail" Width="200px" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                       ControlToValidate="txtEmail" Display="Dynamic" Text="*" ForeColor="red" 
                         ErrorMessage="Email is Required"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ErrorMessage="Please enter a valid email" Display="Dynamic" ControlToValidate="txtEmail" ForeColor="Red"
                         ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td><b>Subject</b></td>
                <td>
                    <asp:TextBox ID="txtSubject" Width="200px" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                       ControlToValidate="txtSubject" Text="*" ForeColor="red"  ErrorMessage="Subject is Required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="vertical-align: top"><b>Comments</b></td>
                <td style="vertical-align: top">
                    <asp:TextBox ID="txtComments" Width="200px" runat="server" TextMode="MultiLine" Rows="5"></asp:TextBox></td>
                <td style="vertical-align: top">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" 
                        runat="server" Text="*" ForeColor="red" ControlToValidate="txtComments" ErrorMessage="Comments are Required"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:ValidationSummary ID="ValidationSummary1" ForeColor="red" HeaderText="Please Fis The Following errors" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label1" runat="server" ForeColor="Green" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
    </fieldset>
    </div>
    </form>
</body>
</html>
