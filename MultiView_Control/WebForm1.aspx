<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MultiView_Control.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="ViewPersonalDetails" runat="server">
                    <table style="border: 1px solid black">
                        <tr>
                            <td colspan="2">
                                <h2><b>Step 1 - Personal Details</b></h2>
                            </td>
                        </tr>
                        <tr>
                            <td>FirstName:</td>
                            <td>
                                <asp:TextBox ID="txtFirstName" runat="server" Width="159px" ToolTip="&quot;Please Enter Your First name&quot;"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>LastName:</td>
                            <td>
                                <asp:TextBox ID="txtLastName" runat="server" Width="159px" ToolTip="&quot;Please Enter Your Last Name&quot;"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Gender:</td>
                            <td>
                                <asp:DropDownList ID="ddlGender" runat="server">
                                    <asp:ListItem Text="Male" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="FeMale" Value="2"></asp:ListItem>
                                </asp:DropDownList></td>
                        </tr>
                        <tr>
                            <td colspan="2" style="text-align: right">
                                <asp:Button ID="btnStep1" runat="server" Text="Step 2 >>" OnClick="btnStep1_Click" />
                            </td>
                        </tr>
                    </table>
                </asp:View>
                <asp:View ID="ViewContactDetails" runat="server">
                    <table style="border: 1px solid black">
                        <tr>
                            <td colspan="2">
                                <h2><b>Step 2 - Contact Details</b></h2>
                            </td>
                        </tr>
                        <tr>
                            <td>Email:</td>
                            <td>
                                <asp:TextBox ID="txtEmail" runat="server" Width="159px" ToolTip="&quot;Please Enter Your Email&quot;"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>MobileNo:</td>
                            <td>
                                <asp:TextBox ID="txtMobileNo" runat="server" Width="159px" ToolTip="&quot;Please Enter Your Mobile No&quot;"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnBackToStep1" runat="server" Text="<< Step 1" OnClick="btnBackToStep1_Click" /></td>
                            <td colspan="2" style="text-align: right">
                                <asp:Button ID="btnGoToStep3" runat="server" Text="Step 3 >>" OnClick="btnGoToStep3_Click" />
                            </td>
                        </tr>
                    </table>
                </asp:View>
                <asp:View ID="ViewSummary" runat="server">
                    <table style="border: 1px solid black">
                        <tr>
                            <td>
                                <h2><b>Step 3 - Summary</b></h2>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <h3>Personal Details</h3>
                            </td>
                        </tr>
                        <tr>
                            <td>FirstName:</td>
                            <td>
                                <asp:Label ID="lblFirstName" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>LastName:</td>
                            <td>
                                <asp:Label ID="lblLastName" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Gender:</td>
                            <td>
                                <asp:Label ID="lblGender" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <h3>Contact Details</h3>
                            </td>
                        </tr>
                        <tr>
                            <td>Email:</td>
                            <td>
                                <asp:Label ID="lblEmail" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>MobileNo:</td>
                            <td>
                                <asp:Label ID="lblMobileNo" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnBackToStep2" runat="server" Text="<< Step 2" OnClick="btnBackToStep2_Click" /></td>
                            <td colspan="2" style="text-align: right">
                                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                            </td>
                        </tr>
                    </table>
                </asp:View>
            </asp:MultiView>
        </div>
    </form>
</body>
</html>
