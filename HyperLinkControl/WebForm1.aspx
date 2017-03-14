<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HyperLinkControl.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink ID="HyperLink1" 
            height ="100px"
            width="400px"
            Text="Click Here go to google.com" 
            runat="server" 
            Target="_blank"
            ImageUrl="~/Images/googlelogo_color_284x96dp.png"
             NavigateUrl="http://google.com.bd"></asp:HyperLink>
    </div>
    </form>
</body>
</html>
