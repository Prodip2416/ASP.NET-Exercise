<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MasterPages.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="font-family:Arial">
    <tr>
        <td colspan="2" style="width:800px; height:80px; background-color:#BDBDBD; 
            text-align:center">
            <h1>
                WebSite Header
            </h1>
        </td>
    </tr>
    <tr>
        <td style="height:500px; background-color:#D8D8D8; width:150px">
            <h3>Menu</h3>
        </td>
        <td style="height:500px; background-color:#E6E6E6; width:650px">
            <h2>This section changes on a page by page basis</h2>        
        </td>
    </tr>
    <tr>
        <td colspan="2" style="background-color:#BDBDBD; text-align:center">
            <b>Website Footer</b>
        </td>
    </tr>
</table>
    </div>
    </form>
</body>
</html>
