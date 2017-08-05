<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCUserControl1.ascx.cs" Inherits="MultipleCacheingUserControl.UCUserControl1" %>
<%@OutputCache Duration="30" VaryByControl="ProductName" %>
<table style="border: 1px solid black">
    <tr>
        <td style="background-color: Gray; font-size: 12pt">
            Products User Control
        </td>
    </tr>
    <tr>
        <td>
            Select Product:
           
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