<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PassingDataMasterPageToContentPages.WebForm1" %>
<%@ MasterType VirtualPath="Site.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
