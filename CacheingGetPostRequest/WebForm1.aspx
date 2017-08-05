<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CacheingGetPostRequest.WebForm1" %>
<%@OutputCache Duration="30" VaryByParam="DroDownList1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
 <div style="font-family:Arial">
    Select Product: 
    <asp:DropDownList ID="DropDownList1" AutoPostBack="true" runat="server" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem Text="All" Value="All"></asp:ListItem>
        <asp:ListItem Text="Laptop" Value="Laptop"></asp:ListItem>
        <asp:ListItem Text="Iphone" Value="Iphone"></asp:ListItem>
        <asp:ListItem Text="LCD TV" Value="LCD TV"></asp:ListItem>
        <asp:ListItem Text="Destop" Value="Destop"></asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
    <br />
    Server Time: 
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <br />
    <br />
    Client Time:
    <script type="text/javascript">
        document.write(Date());
    </script>
</div>
    </form>
</body>
</html>
