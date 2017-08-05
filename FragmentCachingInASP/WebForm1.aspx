<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FragmentCachingInASP.WebForm1" %>

<%@ Register src="UCWebUserControl.ascx" tagname="UCWebUserControl" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border="1px">
        <tr>
            <td>
                Page Contant That Change
            </td>
        </tr>
         <tr>
        <td>
          <b>  Page Server Time: </b>
            <asp:Label ID="lblServer" runat="server" Text=""></asp:Label>
        </td>
    </tr>
          <tr>
        <td>
         <b>Page Client Time:</b> 
            <script type="text/javascript">
                document.write(Date());
            </script>
        </td>
    </tr>
        <tr>
            <td>
                
                <uc1:UCWebUserControl ID="UCWebUserControl1" runat="server" />
                
            </td>
        </tr>
    </table>   
    </div>
    </form>
</body>
</html>
