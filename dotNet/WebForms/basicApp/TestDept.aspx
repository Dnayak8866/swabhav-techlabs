<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestDept.aspx.cs" Inherits="TestDept" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblSelectDept" runat="server" Text="Select Department"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownListDeptName" AutoPostBack="true" runat="server" Height="16px" Width="118px" OnSelectedIndexChanged="DropDownSelectionChangedEvnt" >
        </asp:DropDownList>
        <h1><asp:Literal ID="litHeader" runat="server" />
            <asp:Button ID="Button1" runat="server" Text="Button" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Button" />
        </h1>
    </div>
        <asp:GridView ID="GridViewEmp" runat="server" EnableViewState="False" Width="359px">
        </asp:GridView>
    </form>
   
</body>
</html>
