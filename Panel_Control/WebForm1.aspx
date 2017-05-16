<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Panel_Control.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Text="Select User" Value="-1"></asp:ListItem>
                <asp:ListItem Text="Admin Panel" Value="Admin"></asp:ListItem>
                <asp:ListItem Text="Non-Admin Panel" Value="Non-Admin"></asp:ListItem>
            </asp:DropDownList>
            <asp:Panel ID="AdminPanel" runat="server">

                <table>
                    <asp:Label ID="Label1" runat="server"
                        Text="You are logged in as a adminstration"
                        Font-Bold="True" Font-Size="XX-Large"></asp:Label>
                    <tr>
                        <td>Admin Name:</td>
                        <td>
                            <asp:TextBox ID="TextBox1" Text="Tom" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Admin Region:</td>
                        <td>
                            <asp:TextBox ID="TextBox2" Text="Asia" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Actions:</td>
                        <td>
                            <asp:TextBox ID="TextBox3" Text="fsdhynebvsrvibjbkj" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                    </tr>
                </table>

            </asp:Panel>
            <asp:Panel ID="NonAdminPanel" runat="server">
                <table>
                    <asp:Label ID="Label2" runat="server"
                        Text="Welcome Mike"
                        Font-Bold="True" Font-Size="XX-Large"></asp:Label>
                    <tr>
                        <td>User Name:</td>
                        <td>
                            <asp:TextBox ID="TextBox4" Text="Mike" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>User Region:</td>
                        <td>
                            <asp:TextBox ID="TextBox5" Text="Europe" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>City:</td>
                        <td>
                            <asp:TextBox ID="TextBox6" Text="London" runat="server"></asp:TextBox></td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
