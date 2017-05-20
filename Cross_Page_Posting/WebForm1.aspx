<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Cross_Page_Posting.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr><td><h1>This is WebForm 1</h1></td></tr>
        <tr><td>Name:<asp:TextBox ID="txtName" runat="server"></asp:TextBox></td></tr>
        <tr><td>Email:<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td></tr>
        <tr><td>
            <asp:Button ID="btnCrossPostBack" runat="server" Text="CrossPagePosting WebForm2" PostBackUrl="~/WebForm2.aspx" /></td></tr>
        <tr><td>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            </td></tr>
    </table>
    </div>
    </form>
</body>
</html>
