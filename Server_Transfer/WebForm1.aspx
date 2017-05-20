<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Server_Transfer.WebForm1" %>

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
            <td><h1>This is web form 1</h1></td>
        </tr>
        <tr>
            <td>Name:
                    
               &nbsp;&nbsp;<asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Email:
               &nbsp;&nbsp;<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr><td>
            <asp:Button ID="btnTransfertowebform2"
                 runat="server" Text="TransferToWebForm2" OnClick="btnTransfertowebform2_Click" /></td>

        </tr>
        <tr>
            <td>
                <asp:Button ID="btnTransferExternalWebsite" runat="server" Text="TransferToExternalWensite" /></td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
