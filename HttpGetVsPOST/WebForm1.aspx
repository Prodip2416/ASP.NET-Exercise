<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HttpGetVsPOST.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr><td>FirstName: <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td></tr>
        <tr><td>LastName: <asp:TextBox ID="txtlastName" runat="server"></asp:TextBox></td></tr>
        <tr><td>Email: <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td></tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
