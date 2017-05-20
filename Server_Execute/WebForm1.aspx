<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Server_Execute.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr><td><h1>This is Web Form 1</h1></td></tr>
        <tr>
            <td>Name: <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
        </tr>
        <tr><td>Email: <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td></tr>
        <tr><td>
            <asp:Button ID="btnServerExecute" runat="server" Text="Server.Execute Web form 2" OnClick="btnServerExecute_Click" /></td></tr>
        <tr><td>
            <asp:Button ID="btnExternalSites" runat="server" Text="Server.Execute External sites" /></td></tr>
    </table>
        <asp:Label ID="lblMessage" Font-Bold="true"  runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
