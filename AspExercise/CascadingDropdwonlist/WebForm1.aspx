<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CascadingDropdwonlist.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="ddlContinent"
            DataValueField="ContinentId" AutoPostBack="True" DataTextField="ContinentName" Width="200px" runat="server" OnSelectedIndexChanged="ddlContinent_SelectedIndexChanged"></asp:DropDownList>
        <br/>
        <br/>
        <asp:DropDownList ID="ddlCountry" 
             DataValueField="CountryId" DataTextField="CountryName"
            AutoPostBack="True" Width="200px" runat="server" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged"></asp:DropDownList>
        <br/>
        <br/>
        <asp:DropDownList ID="ddlCity" DataTextField="CityName" DataValueField="CityId" Width="200px" runat="server"></asp:DropDownList>
    </div>
    </form>
</body>
</html>
