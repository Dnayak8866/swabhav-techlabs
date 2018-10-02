<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestTimestamp.aspx.cs" Inherits="TestTimestamp" %>

<%@ Register src="Timestamp.ascx" tagname="Timestamp" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   
    <form id="form1" runat="server">
         <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <div>
        <br />
    
        <uc1:Timestamp ID="Timestamp1" runat="server" />
    
    </div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Button ID="btnPostback" runat="server" Text="Button" />
<br />
                <br />
                <uc1:Timestamp ID="Timestamp3" runat="server" />
            </ContentTemplate>
            
           
        </asp:UpdatePanel>
    <br />
    <div>
    
        <uc1:Timestamp ID="Timestamp2" runat="server" />
    
    </div>
    </form>
</body>
</html>
