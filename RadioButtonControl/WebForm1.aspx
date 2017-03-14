<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RadioButtonControl.WebForm1" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset>
        <legend><b>Gender</b></legend>
        <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName="GroupName" OnCheckedChanged="RadioButton1_CheckedChanged" />
        <asp:RadioButton ID="RadioButton2" runat="server" text="Female" GroupName="GroupName"/>
        <asp:RadioButton ID="RadioButton3" runat="server" Text="Unknown" GroupName="GroupName"/>
    </fieldset>

        <asp:Button ID="Button1" runat="server" Text="Button" />
    </div>
    </form>
</body>
</html>
