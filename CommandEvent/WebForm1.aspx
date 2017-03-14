<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CommandEvent.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button ID="printButton" runat="server" Text="Print" OnCommand="CommandButton_Click" CommandName="Print" />
    <asp:Button ID="deleteButton" runat="server" Text="Delete" OnCommand="CommandButton_Click" CommandName="Delete" />
    <asp:Button ID="topButton" runat="server" Text="Show Top 10 Employees" OnCommand="CommandButton_Click" CommandName="Show"
        CommandArgument="Top10" />
    <asp:Button ID="bottomButton" runat="server" Text="Show Bottom 10 Employees" OnCommand="CommandButton_Click" CommandName="Show"
        CommandArgument="Bottom10" />


        <asp:Label ID="lebel" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
