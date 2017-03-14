<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ListBoxControl.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Single">
           <asp:ListItem Text="Diploma" Value="1"></asp:ListItem>
           <asp:ListItem Text="Graduate" Value="2"></asp:ListItem>
           <asp:ListItem Text="Post Graduate" Value="3"></asp:ListItem>
           <asp:ListItem Text="Doctrate" Value="4"></asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </div>
    </form>
</body>
</html>
