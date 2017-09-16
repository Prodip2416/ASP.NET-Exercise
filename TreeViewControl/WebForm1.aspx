<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TreeViewControl.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TreeView ID="TreeView1" runat="server">
    <Nodes> 
        <asp:TreeNode Text="Home" NavigateUrl="~/Home.aspx" Target="_blank" />
        <asp:TreeNode Text="Employee" NavigateUrl="~/Employee.aspx" Target="_blank">
            <asp:TreeNode Text="Upload Resume" NavigateUrl="~/UploadResume.aspx" Target="_blank"/>
            <asp:TreeNode Text="Edit Resume" NavigateUrl="~/EditResume.aspx" Target="_blank"/>
            <asp:TreeNode Text="View Resume" NavigateUrl="~/ViewResume.aspx" Target="_blank"/>
        </asp:TreeNode>
        <asp:TreeNode Text="Employer" NavigateUrl="~/Employer.aspx" Target="_blank">
            <asp:TreeNode Text="Upload Job" NavigateUrl="~/UploadJob.aspx" Target="_blank"/>
            <asp:TreeNode Text="Edit Job" NavigateUrl="~/EditJob.aspx" Target="_blank"/>
            <asp:TreeNode Text="View Job" NavigateUrl="~/ViewJob.aspx" Target="_blank"/>
        </asp:TreeNode>
        <asp:TreeNode Text="Admin" NavigateUrl="~/Admin.aspx" Target="_blank">
            <asp:TreeNode Text="Add User" NavigateUrl="~/AddUser.aspx" Target="_blank"/>
            <asp:TreeNode Text="Edit User" NavigateUrl="~/EditUser.aspx" Target="_blank"/>
            <asp:TreeNode Text="View User" NavigateUrl="~/ViewUser.aspx" Target="_blank"/>
        </asp:TreeNode>
    </Nodes>
</asp:TreeView>
    </div>
    </form>
</body>
</html>
