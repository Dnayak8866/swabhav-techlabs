<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            color: #66CCFF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 class="auto-style1">Login page....</h1>
    <link href="Content/bootstrap.css" rel="stylesheet" />
     <table style="width:100%;" class="table-condensed">
    <tr>
        <td class="auto-style1" style="font-family: 'Arial Black'; font-style: normal; font-variant: normal; color: #808080">Enter AccountNo</td>
        <td class="auto-style2">
            <asp:TextBox ID="txtUserId" runat="server" Width="170px" CssClass="form-control"></asp:TextBox>
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
            <asp:TextBox ID="txtPassword" runat="server" Width="170px" CssClass="form-control"></asp:TextBox>
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
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="btn btn-info" />
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

