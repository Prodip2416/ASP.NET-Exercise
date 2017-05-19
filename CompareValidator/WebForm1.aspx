<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CompareValidator.WebForm1" %>

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
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Re-Type Password</td>
                    <td>
                        <asp:TextBox ID="txtRetypePassword" runat="server" TextMode="Password"></asp:TextBox>

                        <asp:CompareValidator ID="CompareValidatorPassword"
                             runat="server" ErrorMessage="Password and re-type password not match"
                            ControlToValidate="txtRetypePassword" ControlToCompare="txtPassword"
                            Operator="Equal" Type="String" ForeColor="red" ></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>Date
                    </td>
                    <td>
                        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                      <asp:CompareValidator ID="CompareValidatorDateofbirth" runat="server" 
                 ErrorMessage="Date of application must be greater than 01/01/2012"
                ControlToValidate="txtDate" ValueToCompare="01/01/2012"
                Type="Date" Operator="GreaterThan" ForeColor="Red"
                 SetFocusOnError="true"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>Age
                    </td>
                    <td>
                        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidatorAge" runat="server" 
                            ErrorMessage="Age must be a number" ForeColor="red"
                           ControlToValidate="txtAge" Type="Integer" Operator="DataTypeCheck" ></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnSave" runat="server" Width="150px" Text="Save" OnClick="btnSave_Click" /></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label></td>
                </tr>
               
            </table>
        </div>
    </form>
</body>
</html>
