<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestLoginaspx.aspx.cs" Inherits="TestLoginaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 797px;
        }
        .auto-style3 {
            width: 265px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="txtUserName" runat="server" Font-Bold="True" ForeColor="#666666" Text="Enter username" ValidateRequestMode="Enabled"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtUser" runat="server" Width="216px"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="usernameValidator" runat="server" ControlToValidate="txtUser" ErrorMessage="!field is required cannot be empty." ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblpass" runat="server" Font-Bold="True" ForeColor="#666666" Text="Enter Password"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtPass" runat="server" Width="214px"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="passwordValidator" runat="server" ControlToValidate="txtPass" ErrorMessage="!please enter password" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
