<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RetrievingItemTextValueIndes_FromDDL.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Text="Select" Value="-1"></asp:ListItem>
            <asp:ListItem Text="Bangladesh" Value="1"></asp:ListItem>
             <asp:ListItem Text="India" Value="2"></asp:ListItem>
             <asp:ListItem Text="UK" Value="3"></asp:ListItem>
             <asp:ListItem Text="USA" Value="4"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
