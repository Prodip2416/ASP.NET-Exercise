<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ReloadingRefreshingCache.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family: Arial">
    <asp:Button ID="btnLoadCountriesAndCache" runat="server" Text="Load Countries & Cache"
        OnClick="btnLoadCountriesAndCache_Click" />
    &nbsp;
    <asp:Button ID="btnGetCountriesFromCache" runat="server" Text="Get Countries from Cache"
        OnClick="btnGetCountriesFromCache_Click" />
    <br />
    <br />
    <asp:GridView ID="gvCountries" runat="server">
    </asp:GridView>
    <br />
    <asp:Button ID="btnRemoveCachedItem" runat="server" Text="Remove Cached Item" 
    OnClick="btnRemoveCachedItem_Click" />
    &nbsp;
    <asp:Button ID="btnGetCacheStatus" runat="server" Text="Get Cache Status" 
    OnClick="btnGetCacheStatus_Click" />
    <br />
    <br />
    <asp:Label ID="lblMessage" Font-Bold="true" runat="server"></asp:Label>
</div> 
    </form>
</body>
</html>
