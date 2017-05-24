<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WindowOpen_Using_JavaScript.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function windowOpenFunction() {
            var Name = document.getElementById('txtName').value;
            var Email = document.getElementById('txtEmail').value;

            window.open('WebForm2.aspx?NameOfUser=' + Name + '&Email=' + Email , '_self', 'location=no,resizable=no', false);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr><td><h1><b>This is WebForm 1</b></h1></td></tr>
        <tr><td>Name:<asp:TextBox ID="txtName" runat="server"></asp:TextBox></td></tr>
        <tr><td>Email:
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td></tr>
        <tr><td>
            <input id="Button1" type="button" style="width:300px"
                 onclick="windowOpenFunction()" value="HTML - Button Window.Open" /></td></tr>
        <tr><td colspan="2">
            <asp:Button ID="Button2" runat="server" Width="300px" Text="ASP. NET Button Window.Open" OnClick="Button2_Click" /></td></tr>
    </table>
    </div>
    </form>
</body>
</html>
