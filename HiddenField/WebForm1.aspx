<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HiddenField.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <table>
                <tr>
                    <td>Name:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </tr>
                <tr>
                    <td>Gender:</td>
                    <td>
                        <asp:TextBox ID="txtGender" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Department:</td>
                    <td>
                        <asp:TextBox ID="txtDept" runat="server"></asp:TextBox></td>
                </tr>
            </table>
            <asp:Button ID="Button1" runat="server" Text="Update Employee"
                OnClick="Button1_Click" />&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click"
                Text="Load Employee" />
        </div>
    </form>
</body>
</html>
