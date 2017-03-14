<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BulletedList_Property.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
          <asp:BulletedList ID="BulletedList1" runat="server" BulletStyle="Numbered" DisplayMode="LinkButton" OnClick="BulletedList1_Click" Target="_blank">
            <asp:ListItem Text="Gmail" Value="http://gmail.com"></asp:ListItem>
            <asp:ListItem Text="Google" Value="http://google.com"></asp:ListItem>
            <asp:ListItem Text="Facebook" Value="http://facebook.com"></asp:ListItem>
            <asp:ListItem Text="Youtube" Value="http://youtube.com"></asp:ListItem>
        </asp:BulletedList>
    </div>
    </form>
</body>
</html>
