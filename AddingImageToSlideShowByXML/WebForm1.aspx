<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AddingImageToSlideShowByXML.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
           <ContentTemplate>
               <asp:Timer runat="server" ID="timer" Interval="1000" OnTick="timer_Tick"></asp:Timer>
            <asp:Image runat="server" ID="image" Height="250px" Width="400px"></asp:Image>
               <br/>
               <br/>
             Name:  <asp:Label ID="Label1" runat="server"> </asp:Label><br/>
             Order:  <asp:Label ID="Label2" runat="server"></asp:Label>
               
               <br/>
               <asp:Button ID="Button1" runat="server" Text="StopSlideBar" OnClick="Button1_Click" />
           </ContentTemplate> 

        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
