<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TreeViewOnWenSiteMap.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SiteMapDataSource ShowStartingNode="False" ID="SiteMapDataSource1" runat="server" />
        <asp:TreeView ID="TreeView1" DataSourceID="SiteMapDataSource1" runat="server"></asp:TreeView>
    </div>
    </form>
</body>
</html>
