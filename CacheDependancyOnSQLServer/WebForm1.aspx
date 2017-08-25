<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CacheDependancyOnSQLServer.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
  <div style="font-family: Arial">
    <asp:Button ID="btnGetData" runat="server" Text="Get Data" 
    OnClick="btnGetData_Click" />
    <br />
    <br />
    <asp:GridView ID="gvProducts" runat="server">
    </asp:GridView>
    <br />
    <asp:Label ID="lblStatus" runat="server" Font-Bold="true">
    </asp:Label>
</div>
    </form>
</body>
</html>
