<%@ Page Language="C#" Trace="true" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TracingInRealTimeExample.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <b>AllEmployee</b>:
&nbsp;<asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <br/>
        <b>EmployeeByGender:</b>
&nbsp;<asp:GridView ID="GridView2" runat="server"></asp:GridView>
        <br/>
        <b>EmployeeByDepartment</b>:
&nbsp;<asp:GridView ID="GridView3" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
