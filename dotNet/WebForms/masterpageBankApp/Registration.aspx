<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1 style="color: #66CCFF">Registration page....</h1>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <table style="width: 100%;" class="table-condensed">
        <tr>
            <td class="auto-style1" style="font-family: 'Arial Black'; font-style: normal; font-variant: normal; color: #808080">Enter AccountNo</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtAcntNo" runat="server" Width="170px" CssClass="form-control"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="emailRequiredValidator" runat="server" ControlToValidate="txtAcntNo" ErrorMessage="! field is mandatory..." ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" style="font-family: 'Arial Black'; font-style: normal; font-variant: normal; color: #808080">Enter Name</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtName" runat="server" Width="170px" CssClass="form-control"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="passwordValidate" runat="server" ErrorMessage="! field is mandatory...." ForeColor="Red" ControlToValidate="txtName"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" style="font-family: 'Arial Black'; font-style: normal; font-variant: normal; color: #808080">Balance</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtBalance" runat="server" Width="170px" CssClass="form-control"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="! field is mandatory...." ForeColor="Red" ControlToValidate="txtBalance"></asp:RequiredFieldValidator>
            </td>
        </tr>
          <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style1" style="font-family: 'Arial Black'; font-style: normal; font-variant: normal; color: #808080">Password</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtPassword" runat="server" Width="170px" CssClass="form-control"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="!field is mandatory.." ForeColor="Red"></asp:RequiredFieldValidator>
             </td>
        </tr>

         <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:CompareValidator ID="passwordcompareValidator" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfPass" ErrorMessage="!password and confirm-passowd did not matched.." ForeColor="Red"></asp:CompareValidator>
             </td>
        </tr>
           <tr>
            <td class="auto-style1" style="font-family: 'Arial Black'; font-style: normal; font-variant: normal; color: #808080">Confirm-Password</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtConfPass" runat="server" Width="170px" CssClass="form-control"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtConfPass" ErrorMessage="!field is mandatory....." ForeColor="Red"></asp:RequiredFieldValidator>
               </td>
        </tr>
         <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" CssClass="btn btn-info" />
            </td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="lblRegisterSuccess" runat="server" ForeColor="Lime"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

