<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ButtonLinkButtonImageButton.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1"
            OnClientClick="return confirm('Are you sure You Delete this Record.')"
             runat="server" OnClick="LinkButton1_Click">Submit</asp:LinkButton>
        <br />
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1"
            OnClientClick="alert('Are You sure - You Submit this Image')"
             runat="server" ImageUrl="~/Images/submit2.png" OnClick="ImageButton1_Click1" />
    
    </div>
    </form>
</body>
</html>
