<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MultipleCacheingUserControl.WebForm1" %>

<%@ Register Src="UCUserControl1.ascx" TagName="UCUserControl1" TagPrefix="uc1" %>

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
                    <td>Page content that changes</td>
                </tr>
                <tr>
                    <td>Page Server time:
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Page Client Time:
                        <script type="text/javascript">
                            document.write(Date());
                        </script>
                    </td>
                </tr>
                <tr>
                    <td>

                        <uc1:UCUserControl1 ID="UCUserControl11" runat="server" />

                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
