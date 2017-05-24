<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="QueryString.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table>
        <tr><td><h1><b>This is WebForm 1</b></h1></td></tr>
        <tr><td><b>Name:</b><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td></tr>
        <tr><td><b>Email:</b><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td></tr>
        <tr><td>
            <asp:Button ID="Button1" runat="server" Text="Go To WebForm 2" Width="300px" OnClick="Button1_Click"/></td></tr>
    </table>
    </div>
    </form>
</body>
</html>
