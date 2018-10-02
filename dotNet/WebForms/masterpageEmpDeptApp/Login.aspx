<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageEmpDept.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        width: 170px;
    }
    .auto-style2 {
        width: 173px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
    <tr>
        <td class="auto-style1" style="font-family: 'Arial Black'; font-style: normal; font-variant: normal; color: #808080">Enter UserId</td>
        <td class="auto-style2">
            <asp:TextBox ID="txtUserId" runat="server" Width="170px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="emailRequiredValidator" runat="server" ControlToValidate="txtUserId" ErrorMessage="! field is mandatory..." ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1" style="font-family: 'Arial Black'; font-style: normal; font-variant: normal; color: #808080">Enter Password</td>
        <td class="auto-style2">
            <asp:TextBox ID="txtPassword" runat="server" Width="170px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="passwordValidate" runat="server" ErrorMessage="! field is mandatory...." ForeColor="Red" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </td>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">
            &nbsp;</td>
        <td class="auto-style2">
            <asp:Label ID="lblValidUser" runat="server" ForeColor="Red"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

