﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="StronglyTypeReference_CrossPostPosting.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr><td><h1>This is WebForm 1</h1></td></tr>
        <tr><td><b>Name:</b>
            
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
        </tr>
        <tr><td><b>Email:</b>
           
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
        </tr>
        <tr><td>
            <asp:Button ID="btnStronglyType" runat="server" Text="CrossPostPosting WebForm2" OnClick="btnStronglyType_Click" PostBackUrl="~/WebForm2.aspx" /></td></tr>
    </table>
    </div>
    </form>
</body>
</html>