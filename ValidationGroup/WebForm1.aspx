<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ValidationGroup.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<table>
    <tr>
        <td style="vertical-align: top">
            <table style="border: 1px solid black">
                <tr>
                    <td colspan="2">
                        <h2>
                            Login</h2>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>User Name</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUN" runat="server" Width="100px">
                        </asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorUN" 
                            runat="server" ForeColor="Red"
                            ErrorMessage="Username is required" 
                            ControlToValidate="txtUN" Display="Dynamic"
                            Text="*" ValidationGroup="Login">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Password</b>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxPWD" runat="server" Width="100px" 
                        TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPWD" 
                            runat="server" ForeColor="Red"
                            ErrorMessage="Password is required" 
                            ControlToValidate="TextBoxPWD" Display="Dynamic"
                            Text="*" ValidationGroup="Login">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnLogin" ValidationGroup="Login" 
                        runat="server" Text="Login" 
                        onclick="btnLogin_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:ValidationSummary ValidationGroup="Login" 
                            ID="ValidationSummary2" runat="server" 
                            ForeColor="Red" HeaderText="Page Errors"
                            ShowMessageBox="True" ShowSummary="true" 
                            DisplayMode="List" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblLoginStatus" runat="server" 
                        Font-Bold="true"></asp:Label>
                    </td>
                </tr>
            </table>
        </td>
        <td>
            &nbsp;&nbsp;
        </td>
        <td>
            <table style="border: 1px solid black">
                <tr>
                    <td colspan="2">
                        <h2>
                            User Registration</h2>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Email</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Width="100px">
                        </asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" 
                            runat="server" ForeColor="Red"
                            ErrorMessage="Email is required" 
                            ControlToValidate="txtEmail" Display="Dynamic"
                            Text="*" ValidationGroup="Registration">
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator 
                            ID="RegularExpressionValidatorEmail" 
                            runat="server"
                            ErrorMessage="Invalid Email Format" 
                            ControlToValidate="txtEmail" ForeColor="Red"
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                            Text="*"
                            ValidationGroup="Registration">
                        </asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>User Name</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server" Width="100px">
                        </asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserName" 
                            runat="server" ForeColor="Red"
                            ErrorMessage="Username is required" 
                            ControlToValidate="txtUserName" Display="Dynamic"
                            Text="*" ValidationGroup="Registration">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Password</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" 
                        Width="100px" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" 
                            runat="server" ForeColor="Red"
                            ErrorMessage="Password is required" 
                            ControlToValidate="txtPassword" Display="Dynamic"
                            Text="*" ValidationGroup="Registration">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Confirm Password</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtConfirmPassword" runat="server" 
                            TextMode="Password" Width="100px"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidatorPassword" 
                            runat="server" 
                            ErrorMessage="Password and Confirm Password must match"
                            ControlToValidate="txtConfirmPassword" 
                            ControlToCompare="txtPassword" Operator="Equal"
                            Type="String" ForeColor="Red" Text="*" 
                            ValidationGroup="Registration">
                        </asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnSubmit" runat="server" Text="Register" 
                        OnClick="btnSubmit_Click" ValidationGroup="Registration"/>
                        &nbsp;
                        <asp:Button ID="btnClear" runat="server" onclick="btnClear_Click" 
                        CausesValidation="false" Text="Clear" style="height: 26px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                            ForeColor="Red" HeaderText="Page Errors" ShowMessageBox="True" 
                            ShowSummary="true" DisplayMode="List" 
                            ValidationGroup="Registration"/>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblStatus" runat="server" 
                        Font-Bold="true"></asp:Label>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
    </form>
</body>
</html>
