<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RadioButtonList_Property.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Text="Blue" Value="1"></asp:ListItem>
            <asp:ListItem Text="Green" Value="2"></asp:ListItem>
            <asp:ListItem Text="Red" Value="3"></asp:ListItem>
            <asp:ListItem Text="Yellow" Value="4"></asp:ListItem>
            <asp:ListItem Text="Orange" Value="5"></asp:ListItem>
            <asp:ListItem Text="Black" Value="6"></asp:ListItem>

        </asp:RadioButtonList>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Select" />
&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Clear Selected" />
    </div>
    </form>
</body>
</html>
