<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TreeViewControlOnXMLfiles.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" 
    XPath="/Items/TreeViewItem" DataFile="~/XMLFile1.xml">
</asp:XmlDataSource>
        
        <asp:TreeView ID="TreeView1" DataSourceID="XmlDataSource1" runat="server">
    <DataBindings>
        <asp:TreeNodeBinding DataMember="TreeViewItem" TextField="Text"
        NavigateUrlField="NavigateUrl" Target="_blank" />
    </DataBindings>
</asp:TreeView> 
    </div>
    </form>
</body>
</html>
