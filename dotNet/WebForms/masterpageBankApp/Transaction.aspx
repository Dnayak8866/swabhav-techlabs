<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Transaction.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 style="color: #66CCFF">Transaction page...</h1>
    <table style="width:100%;">
    <tr>
        <td class="auto-style1" style="font-family: 'Arial Black'; font-style: normal; font-variant: normal; color: #808080">Enter Amount</td>
        <td class="auto-style2">
            <asp:TextBox ID="txtAmt" runat="server" Width="170px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="amountRequireValidator" runat="server" ControlToValidate="txtAmt" ErrorMessage="! field is mandatory..." ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
     <tr>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td  class="auto-style1" style="font-family: 'Arial Black'; font-style: normal; font-variant: normal; color: #808080">
            <asp:Label ID="Label1" runat="server" Text="Transaction Type"></asp:Label>
        </td>
        <td class="auto-style2">
            <asp:RadioButtonList ID="btnRadioTransactionType" runat="server">
                <asp:ListItem>Deposit</asp:ListItem>
                <asp:ListItem>Withdraw</asp:ListItem>
            </asp:RadioButtonList>
        </td>
        <td>&nbsp;</td>
    </tr>
   
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

    <tr>
        <td class="auto-style1">
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"  />
        </td>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">
            &nbsp;</td>
        <td class="auto-style2">
            <asp:Label ID="lblSuccess" runat="server" ForeColor="Lime"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

