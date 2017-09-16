<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ImageGalleryCreate.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Back To Gallery" OnClick="Button1_Click" />
        <br/>
        <br/>
        <asp:Image ID="Image1" Height="400" Width="750" runat="server" />
        <br/>
        <br/>
        <asp:Button ID="Button2" runat="server" Text="Back To Gallery" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
