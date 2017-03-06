<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="ViewState.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    ASP.NET Server Control:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br/>
        <br/>
        HTML Control:
        <input id="Text1" runat="server" type ="text" />
        <asp:Button ID="Button1" runat="server" Text="Button" />
      </div>
    </form>
</body>
</html>
