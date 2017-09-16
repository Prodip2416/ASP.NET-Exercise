<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SaveImageToDataBase.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br/>
        <br/>
        <asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click" />
        <br />
        <br/>
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        <br/>
        <br/>
        <asp:HyperLink ID="HyperLink1" runat="server">View Upload Image</asp:HyperLink>
    </div>
    </form>
</body>
</html>
