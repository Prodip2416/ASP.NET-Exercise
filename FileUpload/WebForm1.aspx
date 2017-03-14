<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FilrUpload.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        &nbsp;&nbsp;
        <asp:Button ID="btnUpload" runat="server" Text="Upload File" OnClick="btnUpload_Click" />
        <br/><br/>
        <asp:Label ID="lblMessage" runat="server" font-bold="true"></asp:Label>
    </div>
    </form>
</body>
</html>
