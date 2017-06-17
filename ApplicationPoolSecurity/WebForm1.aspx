<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ApplicationPoolSecurity.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="gridView" runat="server"></asp:GridView><br/>
        <asp:FileUpload ID="fileUpload" runat="server"/>
       &nbsp; <asp:Button ID="Button1" runat="server" Text="Read File" OnClick="Button1_Click" />
        <br/>
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
