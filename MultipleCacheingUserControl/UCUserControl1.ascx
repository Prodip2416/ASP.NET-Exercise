<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCUserControl1.ascx.cs" Inherits="MultipleCacheingUserControl.UCUserControl1" %>
<%@OutputCache Duration="30" VaryByControl="DropDownList1" %>
<table style="border: 1px solid black">
    <tr>
        <td style="background-color: Gray; font-size: 12pt">
            Products User Control
        </td>
    </tr>
    <tr>
        <td>
            Select Product:
            <asp:DropDownList ID="DropDownList1" AutoPostBack="true" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Text="All" Value="All"></asp:ListItem>
                <asp:ListItem Text="Laptop" Value="Laptop"></asp:ListItem>
                <asp:ListItem Text="Iphone" Value="Iphone"></asp:ListItem>
                <asp:ListItem Text="LCD TV" Value="LCD TV"></asp:ListItem>
                <asp:ListItem Text="Destop" Value="Destop"></asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td>
            <b>User Control Server Time:
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </b>
        </td>
    </tr>
    <tr>
        <td>
            <b>User Control Client Time:
                <script type="text/javascript">
                    document.write(Date());
                </script>
            </b>
        </td>
    </tr>
</table>