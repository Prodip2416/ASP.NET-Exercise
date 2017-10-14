<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationFrom.aspx.cs" Inherits="RegistrationWithLoginFrom.RegistrationFrom" %>
<%@ Register TagPrefix="recaptcha" Namespace="Recaptcha" Assembly="Recaptcha" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr><td colspan="2"><b>Registration From</b></td></tr>
            <tr><td colspan="2"><b></b></td></tr>
            <tr>
                <td class="auto-style1">Name</td>
                <td>
                    <asp:TextBox ID="txtName" Width="250px" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorName"
                                                runat="server" ForeColor="red"
                                                ControlToValidate="txtName" ErrorMessage="Name is Required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Password</td>
                <td>
                    <asp:TextBox ID="txtPassword" Width="250px" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server"
                                                ErrorMessage="Password is Required" ControlToValidate="txtPassword" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">ConfirmPassword</td>
                <td>
                    <asp:TextBox ID="txtConfirmPassword" Width="250px" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirm" ControlToValidate="txtConfirmPassword" runat="server"
                                                ErrorMessage="Password is Required" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidatorConfirmPassword" Display="Dynamic" ControlToCompare="txtPassword" runat="server"
                                          ControlToValidate="txtConfirmPassword" ForeColor="red" ErrorMessage="Password does not Match"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Gender</td>
                <td>
                    <asp:DropDownList ID="ddlGender" Width="250px" runat="server">
                        <asp:ListItem Text="Select Gender" Value="-1"></asp:ListItem>
                        <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                        <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorGender"
                                                runat="server" ControlToValidate="ddlGender" InitialValue="-1" ForeColor="red" ErrorMessage="Gender is Required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Department</td>
                <td>
                    <asp:TextBox ID="txtDepartment" Width="250px" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorDepartment"
                                                runat="server" ControlToValidate="txtDepartment" ForeColor="red" ErrorMessage="Department is Required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Email</td>
                <td>
                    <asp:TextBox ID="txtEmail"
                                 Width="250px" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail"
                                                runat="server" ForeColor="Red" Display="Dynamic" ControlToValidate="txtEmail" ErrorMessage="Email is Required"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail"
                                                    runat="server" Display="Dynamic" ControlToValidate="txtEmail" ForeColor="red" ErrorMessage="InValid Email"
                                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Campus</td>
                <td>
                    <asp:DropDownList ID="ddlCampus" Width="250px" runat="server">
                        <asp:ListItem Text="Select Campus" Value="-1"></asp:ListItem>
                        <asp:ListItem Text="ABC" Value="ABC"></asp:ListItem>
                        <asp:ListItem Text="ACB" Value="ACB"></asp:ListItem>
                        <asp:ListItem Text="BCA" Value="BCA"></asp:ListItem>
                        <asp:ListItem Text="CAB" Value="CAB"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorCampus"
                                                ControlToValidate="ddlCampus" ForeColor="red" InitialValue="-1" runat="server" ErrorMessage="Campus is Required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <recaptcha:RecaptchaControl ID="recaptcha" runat="server"
                                                PublicKey="6LckGyIUAAAAAGwk4fOyI6oQwlrL5SfMHhg9sBeU"
                                                PrivateKey="6LckGyIUAAAAAJLdOoTN9KTA27oIx-_zxHwLpV2q"/>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
                </td>
            </tr>
            <tr><td colspan="2">
                <asp:ValidationSummary ID="ValidationSummary1" ForeColor="red"
                                       HeaderText="Please Give True Information" runat="server"/>
            </td></tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblMessage" runat="server"></asp:Label></td>
            </tr>
        </table>

        <br/>
        <br/>
        <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Green" NavigateUrl="WebForm1.aspx" >Go To Sign In page</asp:HyperLink>
    </div>
    </form>
</body>
</html>
