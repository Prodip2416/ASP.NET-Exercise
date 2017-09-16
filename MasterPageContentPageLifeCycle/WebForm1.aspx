<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MasterPageContentPageLifeCycle.WebForm1" %>
<%@ Register src="TextUserControl.ascx" tagname="TextUserControl" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:TextBox ID="TextBox1" runat="server"  
         OnInit="TextBox1_Init"  OnLoad="TextBox1_Load"PreRender="TextBox1_PreRender">
      
    </asp:TextBox>
    <uc1:TextUserControl ID="TextUserControl1"  OnInit="TestUC1_Init"  OnLoad="TestUC1_Load"PreRender="TestUC1_Load" runat="server" />

</asp:Content>
