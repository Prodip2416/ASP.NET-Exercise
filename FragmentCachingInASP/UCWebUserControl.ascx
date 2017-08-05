<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCWebUserControl.ascx.cs" Inherits="FragmentCachingInASP.UCWebUserControl" %>
<%@OutputCache Duration="30" VaryByParam="None" Shared="true" %>
<table border="1px" >
    <tr style="background: gray">
        <td>Product User Control</td>
    </tr>
    <tr>
        <td>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </td>
    </tr>
    <tr>
        <td>
          <b>  User Control Server Time: </b>
            <asp:Label ID="lblServer" runat="server" Text=""></asp:Label>
        </td>
    </tr>
      <tr>
        <td>
         <b>User Control Client Time:</b> 
            <script type="text/javascript">
                document.write(Date());
            </script>
        </td>
    </tr>
</table>