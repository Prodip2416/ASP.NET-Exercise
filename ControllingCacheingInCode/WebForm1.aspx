<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ControllingCacheingInCode.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Server Time:
        <asp:Label ID="Label" runat="server" Text=""></asp:Label>
        <br/>
        <br/>
        Client Time:
        <script type="text/javascript">
            document.write(Date());
        </script>
    </div>
    </form>
</body>
</html>
