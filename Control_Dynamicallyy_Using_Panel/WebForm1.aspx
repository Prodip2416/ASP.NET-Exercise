<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Control_Dynamicallyy_Using_Panel.WebForm1" %>

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
            <td> <h3><b>Control Type</b></h3></td>
            <td>
                <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Text="Label" Value="Label"></asp:ListItem>
                    <asp:ListItem Text="TextBox" Value="TextBox"></asp:ListItem>
                    <asp:ListItem Text="Button" Value="Button"></asp:ListItem>
                </asp:CheckBoxList></td>
             <td> <h3>How Many</h3></td>
            <td>
                <asp:TextBox ID="txtHowMany" runat="server"></asp:TextBox></td>
            <td>
                <asp:Button ID="btnGenerate" runat="server" Text="Generate Control" OnClick="btnGenerate_Click" /></td>
        </tr>

        <tr>
            <td colspan="5"><h3>Label Controls </h3></td></tr>
        <tr>
            <td colspan="5">
                <asp:Panel ID="pnlLabel" runat="server"></asp:Panel>
            </td>
        </tr>
        <tr>
            <td colspan="5"><h3>TextBox Controls</h3></td></tr>
        <tr>
            <td colspan="5">
                <asp:Panel ID="pnlTextbox" runat="server"></asp:Panel>
            </td>
        </tr>
        <tr>
            <td colspan="5"><h3>Button Controls</h3></td></tr>
        <tr>
            <td colspan="5">
                <asp:Panel ID="pnlButton" runat="server"></asp:Panel>
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
