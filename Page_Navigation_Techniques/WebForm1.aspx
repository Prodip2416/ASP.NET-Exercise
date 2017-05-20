<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Page_Navigation_Techniques.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <h1>Web Form 1</h1>
        <asp:HyperLink ID="HyperLink1"  NavigateUrl="~/WebForm2.aspx" Text="Go to Web form 2" runat="server">

        </asp:HyperLink>
        <h3><b>There are several techniques</b></h3>
        <ul>
            <li>HyperLink</li>
             <li>Response.Redirect</li>
             <li>Server.Transfer</li>
             <li>Server.Execute</li>
             <li>Cross-Page postback</li>
             <li>Window.Open</li>

        </ul>
    </div>
    </form>
</body>
</html>
