<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ChechBoxControll.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset style="width:350px">
        <legend><b>Education</b></legend>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Graduate"/>
        <asp:CheckBox ID="CheckBox2" runat="server" Text="Post Graduate"/>
        <asp:CheckBox ID="CheckBox3" runat="server" Text="Doctrate"/>
    </fieldset>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
