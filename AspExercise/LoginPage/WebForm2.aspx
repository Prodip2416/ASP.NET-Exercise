<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="LoginPage.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblMessages" runat="server" Text=""></asp:Label>
        <br/>
        <br/>
        <asp:Button ID="btnSignOut" runat="server" Text="Sign Out" OnClick="btnSignOut_Click" />
    </div>
    </form>
</body>
</html>
