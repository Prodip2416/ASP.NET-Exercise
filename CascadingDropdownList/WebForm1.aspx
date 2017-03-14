<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CascadingDropdownList.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="ddlContinent" DataTextField="ContinentName" AutoPostBack="true" DataValueField="ContinentId" width="200px" runat="server" 
            OnSelectedIndexChanged="ddlContinent_SelectedIndexChanged"></asp:DropDownList>
        <br/>
        <br/>
        <br/>
        <asp:DropDownList ID="ddlCountries" 
            DataTextField="CountryName" DataValueField="CountryId" AutoPostBack="true"
            Width="200px" runat="server" OnSelectedIndexChanged="ddlCountries_SelectedIndexChanged"></asp:DropDownList>
          <br/>
        <br/>
        <br/>
        <asp:DropDownList ID="ddlCities"
            DataTextField="CityName" DataValueField="CityId"
             Width="200px" runat="server"></asp:DropDownList>
    </div>
    </form>
</body>
</html>
