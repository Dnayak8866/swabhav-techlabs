<%@ Page Language="VB" AutoEventWireup="false" CodeFile="TestValidation.aspx.vb" Inherits="TestValidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            height: 23px;
            width: 144px;
        }
        .auto-style3 {
            width: 144px;
        }
        .auto-style4 {
            height: 23px;
            width: 231px;
        }
        .auto-style5 {
            width: 231px;
        }
        .auto-style6 {
            height: 21px;
            width: 144px;
        }
        .auto-style7 {
            height: 21px;
            width: 231px;
        }
        .auto-style8 {
            height: 21px;
        }
        .auto-style9 {
            height: 30px;
            width: 144px;
        }
        .auto-style10 {
            height: 30px;
            width: 231px;
        }
        .auto-style11 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1" colspan="3" style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-weight: bold; font-style: italic; color: #000000">&nbsp;Registrartion Form</td>
            </tr>
            <tr>
                <td class="auto-style2" style="font-family: 'Arial Black'; font-size: small; font-weight: bold; font-style: normal; font-variant: normal; color: #808080">Enter name</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtName" runat="server" Width="213px" style="margin-right: 0px"></asp:TextBox>
                </td>
                <td class="auto-style1">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtName" runat="server" ErrorMessage="NameFieldRequired"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-family: 'Arial Black'; font-size: small; font-weight: bold; font-style: normal; font-variant: normal; color: #808080">Enter Age</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtAge" runat="server" Width="215px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-family: 'Arial Black'; font-size: small; font-weight: bold; font-style: normal; font-variant: normal; color: #808080">Enter Email ID</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtEmail" runat="server" Width="216px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6" style="font-family: 'Arial Black'; font-size: small; font-weight: bold; font-style: normal; font-variant: normal; color: #808080">Enter Salary</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtSalary" runat="server" Width="215px"></asp:TextBox>
                </td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style9" style="font-family: 'Arial Black'; font-size: small; font-weight: bold; font-style: normal; font-variant: normal; color: #808080">&nbsp;</td>
                <td class="auto-style10">
                    <asp:Button ID="btnSubmit" runat="server" style="margin-left: 73px" Text="Submit" />
                </td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
