<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestSession.aspx.cs" Inherits="TestSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblOld" runat="server" Text="Old value"></asp:Label>
        <br />
    
    </div>
        <asp:Label ID="lblNew" runat="server" Text="New value"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblSessionID" runat="server" Font-Bold="True" ForeColor="#FF3300" Text="Session id"></asp:Label>
    </form>
</body>
</html>
