<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Calender_Event_Property.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Calendar ID="Calendar1" runat="server" Caption="Training Calender" CaptionAlign="Top" DayNameFormat="Full" NextMonthText="&gt;&gt;" NextPrevFormat="ShortMonth" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged" PrevMonthText="&lt;&lt;" SelectionMode="DayWeek">
            <DayHeaderStyle BackColor="#CC3300" ForeColor="White" />
        </asp:Calendar>
    </div>
    </form>
</body>
</html>
