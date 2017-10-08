<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DisConnectedDataAccess.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnGetDataFromDB" runat="server" Text="Get Data from DataBase" OnClick="btnGetDataFromDB_Click" />
        <br />
        <br/>
        <asp:GridView ID="gvStudent" runat="server" 
            AutoGenerateColumns="False" DataKeyNames="Id" OnRowCancelingEdit="gvStudent_RowCancelingEdit" OnRowDeleting="gvStudent_RowDeleting" OnRowEditing="gvStudent_RowEditing" OnRowUpdating="gvStudent_RowUpdating">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:BoundField DataField="Marks" HeaderText="Marks" SortExpression="Marks" />
            </Columns>
        </asp:GridView>
        <br/>
        <asp:Button ID="btnUpdateData" runat="server" Text="Update DataBase Table" OnClick="btnUpdateData_Click" />
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
  
    </div>
    </form>
</body>
</html>
