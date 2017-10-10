<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SqlCommandBuilderExercise.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family: sans-serif">
    <table border="2" >
        <tr>
            <td>Student Id</td>
            <td>
                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                &nbsp;<asp:Button ID="btnLoadStudent" runat="server" Text="Button" OnClick="btnLoadStudent_Click" />
            </td>
        </tr>
        <tr>
            <td>Name</td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Gender</td>
            <td>
                <asp:DropDownList ID="ddlGender" runat="server">
                    <asp:ListItem Text="Select Gender" Value="-1"></asp:ListItem>
                    <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr><td>Total Marks</td>
            <td>
                <asp:TextBox ID="txtMarks" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" /></td>
            <td colspan="2">
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                &nbsp;&nbsp;
                <asp:Label ID="lblStatus" runat="server" Font-Bold="True" ForeColor="Green"></asp:Label>
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
