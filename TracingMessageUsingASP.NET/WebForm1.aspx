<%@ Page Language="C#" Trace="true" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TracingMessageUsingASP.NET.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
 <div style="font-family: Arial">
    <table style="border: 1px solid black">
        <tr>
            <td>
                <b>First Number</b>
            </td>
            <td>
                <asp:TextBox ID="txtFirstNumber" runat="server">
                </asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <b>Second Number</b>
            </td>
            <td>
                <asp:TextBox ID="txtSecondNumber" runat="server">
                </asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnDivide" runat="server" Text="Divide" 
                OnClick="btnDivide_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblMessage" runat="server" Font-Bold="true">
                </asp:Label>
            </td>
        </tr>
    </table>
</div> 
    </form>
</body>
</html>
