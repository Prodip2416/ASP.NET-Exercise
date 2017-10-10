<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CRUD.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>Name:</td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Gender:</td>
            <td>
            <asp:DropDownList ID="ddlGender" runat="server">
                <asp:ListItem Text="Selected Item" Value="-1"></asp:ListItem>
            <asp:ListItem >Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:DropDownList>
                </td>
        </tr>
        <tr>
            <td>Dept:</td>
            <td>
                <asp:TextBox ID="txtDept" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                Campus:
            </td>
            <td>
                <asp:DropDownList ID="ddlCampus" runat="server">
                     <asp:ListItem Text="Selected Item"  Value="-1"></asp:ListItem>
                     <asp:ListItem >AB</asp:ListItem>
                     <asp:ListItem >BC</asp:ListItem>
                     <asp:ListItem>CA</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Delete Id No: <asp:TextBox ID="txtDelete" runat="server"></asp:TextBox></td>
            <td>
                <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="103px" OnClick="btnDelete_Click" /></td>
        </tr>
        <tr>
            <td>Update Id No: <asp:TextBox ID="txtUpdate" runat="server"></asp:TextBox></td>
            <td>
                <asp:Button ID="btnUpdate" runat="server" Text="Update" Width="102px" OnClick="btnUpdate_Click" /></td>
        </tr>
        <tr>
            <td>ViewWith Id No:<asp:TextBox ID="txtId" runat="server"></asp:TextBox></td>
            <td>
                <asp:Button ID="btnId" runat="server" Text="ViewWithId" OnClick="btnId_OnClick" /></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnInsert" runat="server" Text="Insert" Width="100px" OnClick="btnInsert_Click" /></td>
            <td>
               <asp:Button ID="btnViewDataBase" runat="server" Text="View DataBase" OnClick="btnViewDataBase_Click" /></td>
        </tr>
        <tr><td>
            <asp:Label ID="lblMessage" runat="server"></asp:Label></td></tr>
    </table>
        <br/>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
    </div>
    </form>
</body>
</html>
