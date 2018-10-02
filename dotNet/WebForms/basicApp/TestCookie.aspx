<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestCookie.aspx.cs" Inherits="TestCookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="bodytag" runat="server" >
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnSetCookie" runat="server" OnClick="btnSetCookie_Click" Text="SetCookie" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnGetCookie" runat="server" Text="GetCookie" OnClick="btnGetCookie_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        &nbsp;
    
    </div>
        <asp:Label ID="lblCookie" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
