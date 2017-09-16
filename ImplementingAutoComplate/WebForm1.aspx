<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ImplementingAutoComplate.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style/jquery-ui.structure.min.css" rel="stylesheet" />
    <script src="Script/jquery-ui.min.js"></script>
    <script src="Script/jquery-ui.js"></script>
      <script type="text/javascript" language="javascript">
        $(function () {
            $('#<%= txtStudentName.ClientID %>').autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: "StudentService.asmx/GetStudentNames",
                        data: "{ 'searchTerm': '" + request.term + "' }",
                        type: "POST",
                        dataType: "json",
                        contentType: "application/json;charset=utf-8",
                        success: function (data) {
                            response(data.d);
                        },
                        error: function (result) {
                            alert('There is a problem processing your request');
                        }
                    });
                },
                minLength: 0
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtStudentName" runat="server">
        </asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button"
            onclick="Button1_Click" />
        <br />
        <asp:GridView ID="gvStudents" runat="server">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
