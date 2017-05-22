<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LoginPage.WebForm1" %>

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
           <td>
               <b>Name:</b>
           </td>
            <td>
                <asp:TextBox ID="txtName" Width="200px" runat="server"></asp:TextBox>
            </td>
        </tr>
           <tr>
           <td>
               <b>Password:</b>
           </td>
            <td>
                <asp:TextBox ID="txtPassword" Width="200px" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnSubmit" runat="server" Text="Sign in" OnClick="btnSubmit_Click" /></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label></td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
