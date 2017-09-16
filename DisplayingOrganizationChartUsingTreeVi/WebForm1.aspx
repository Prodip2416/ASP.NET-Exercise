<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DisplayingOrganizationChartUsingTreeVi.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
  <div style="font-family:Arial">
    <table>
        <tr>
            <td style="border:1px solid black">
                <asp:TreeView ID="TreeView1" ShowCheckBoxes="All" 
                    runat="server">
                </asp:TreeView>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text=">>" />            
            </td>
            <td>
                <asp:ListBox ID="ListBox1" runat="server" Height="145px" 
                    Width="100px">
                </asp:ListBox>
            </td>
        </tr>
    </table>
</div>
    </form>
</body>
</html>
