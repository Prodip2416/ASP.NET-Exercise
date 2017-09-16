<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CreaterReCaptchrToRegistration.WebForm1" %>

<%@ Register TagPrefix="recaptcha" Namespace="Recaptcha" Assembly="Recaptcha, Version=1.0.5.0, Culture=neutral, PublicKeyToken=9afc4d65b28c38c2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial">
            <h3>User Registration</h3>
            <table style="border: 1px solid black">
                <tr>
                    <td>
                        <b>Name </b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" Width="230px">
                        </asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                            runat="server" ControlToValidate="txtName"
                             ForeColor="red" ErrorMessage="Name Is Required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Email </b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Width="230px">
                        </asp:TextBox>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                            runat="server" ControlToValidate="txtEmail"
                             ForeColor="red" ErrorMessage="Email Is Required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Password </b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" Width="230px"
                            TextMode="Password"></asp:TextBox>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
                            runat="server" ControlToValidate="txtPassword"
                             ForeColor="red" ErrorMessage="Password Is Required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <table>
                            <tr>
                                <td>
                                     <recaptcha:RecaptchaControl ID="recaptcha" runat="server"
                            PublicKey="6Lf8GSIUAAAAAKgoHNNgz7VCkKIpLqj7dQPbPILq"
                            PrivateKey="6Lf8GSIUAAAAAFoGXg8JkrzTP6hyS_5cKDoWATVC" />
                                </td>
                                <td>
                                    <asp:CustomValidator ID="CustomValidator1"
                                         runat="server" ForeColor="red" Text="*"
                                         OnServerValidate="RecaptchaValidator_ServerValidate"></asp:CustomValidator>
                                </td>
                            </tr>
                        </table>

                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnSubmit" runat="server" Text="Register"
                            OnClick="btnSubmit_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:ValidationSummary ID="ValidationSummary1" ForeColor="red" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblMessage" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>

    </form>
  
</body>
</html>
