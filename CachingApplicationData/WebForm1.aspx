<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CachingApplicationData.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family:Arial">
    <asp:Button ID="btnGetProducts" runat="server" Text="Get Products Data" 
        onclick="btnGetProducts_Click" />
    <br /><br />
    <asp:GridView ID="gvProducts" runat="server">
    </asp:GridView>
    <br />
    <asp:Label ID="lblMessage" Font-Bold="true" runat="server"></asp:Label>
</div>
    </form>
</body>
</html>
