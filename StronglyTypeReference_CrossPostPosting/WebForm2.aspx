<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="StronglyTypeReference_CrossPostPosting.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr><td><h1>This is WebForm 2</h1></td></tr>
        <tr>
            <td><b>Name:</b>
                <asp:Label ID="lblName" runat="server"></asp:Label>
            </td>
        </tr>
        <tr><td><b>Email:</b>
            <asp:Label ID="lblEmail" runat="server"></asp:Label>
            </td></tr>
        <tr><td>
            <asp:Label ID="lblMessage" runat="server"  Font-Bold="true"></asp:Label></td></tr>
    </table>
    </div>
    </form>
</body>
</html>
