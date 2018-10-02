<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContactForm.aspx.cs" Inherits="ContactForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblName" runat="server" Text="Enter Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server" Width="166px"></asp:TextBox>
        <br />
    
    </div>
        <p>
            <asp:Label ID="lblNumber" runat="server" Text="Enter Mob.No"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtNumber" runat="server"  Width="163px"></asp:TextBox>
        </p>
        <p style="margin-left: 120px">
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="Display" />
        </p>
        <p style="margin-left: 120px">
            <asp:GridView ID="GridViewContacts" runat="server" Width="332px">
            </asp:GridView>
        </p>
    </form>
</body>
</html>
