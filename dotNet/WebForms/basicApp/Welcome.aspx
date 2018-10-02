<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Enter task:<asp:TextBox ID="txtTask" runat="server" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="AddTask"/>
        <div id="lblDiv" runat="server">
            <asp:BulletedList ID="lstTasks" runat="server" EnableViewState="false"></asp:BulletedList>

        </div>
    
    </div>
    </form>
</body>
</html>
