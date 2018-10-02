<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestListItem.aspx.cs" Inherits="TestListItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblEnterCompany" runat="server" Text="Enter Comany Name"></asp:Label>
        <asp:TextBox ID="txtCompanyName" runat="server"></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server"  Text="btnAdd" OnClick="btnAdd_Click" />
    
    </div>
        <p>
            &nbsp;</p>
        <asp:ListBox ID="lstBoxCompanies"  runat="server" Width="271px">
            
        </asp:ListBox>
        <p>
            <asp:Button ID="btnDeleteCompany" SelectionMode="Single" runat="server" Text="Delete" OnClick="btnDeleteCompany_Click" />
        </p>
    </form>
</body>
</html>
