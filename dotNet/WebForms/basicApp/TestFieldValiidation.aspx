<%@ Page Language="VB" AutoEventWireup="false" CodeFile="TestFieldValiidation.aspx.vb" Inherits="TestFieldValiidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
                <td class="auto-style2" style="font-family: 'Arial Black'; font-size: small; font-weight: bold; font-style: normal; font-variant: normal; color: #808080">Enter Name</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtName" runat="server" Width="214px" style="margin-right: 0px"></asp:TextBox>
                </td>
                <td class="auto-style1">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtName" runat="server" ErrorMessage="! the field is mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-family: 'Arial Black'; font-size: small; font-weight: bold; font-style: normal; font-variant: normal; color: #808080">Enter Age</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtAge" runat="server" Width="214px"></asp:TextBox>
                </td>
                <td>
                    <asp:RangeValidator ID="AgeRangeValidator" runat="server" ControlToValidate="txtAge" ErrorMessage="!age must between 16 to 18" ForeColor="Red" MaximumValue="18" MinimumValue="16" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-family: 'Arial Black'; font-size: small; font-weight: bold; font-style: normal; font-variant: normal; color: #808080">Enter Email ID</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtEmail" runat="server" Width="214px"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="EmailValidator" runat="server" ControlToValidate="txtEmail" ErrorMessage="!enter correct email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6" style="font-family: 'Arial Black'; font-size: small; font-weight: bold; font-style: normal; font-variant: normal; color: #808080">Enter Salary</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtSalary" runat="server" Width="214px"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    <asp:CompareValidator ID="SalaryCompareValidator" runat="server" ControlToValidate="txtSalary" ErrorMessage="!salary should be &gt;10000" ForeColor="Red" Operator="GreaterThan" Type="Integer" ValueToCompare="10000"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6" style="font-family: 'Arial Black'; font-size: small; font-weight: bold; font-style: normal; font-variant: normal; color: #808080">Enter Password</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtPassword" runat="server" Width="214px"></asp:TextBox>
                </td>
                <td class="auto-style8">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6" style="font-family: 'Arial Black'; font-size: small; font-weight: bold; font-style: normal; font-variant: normal; color: #808080">Re-Type Password</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtRePassword" runat="server" Width="214px"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtRePassword" ErrorMessage="!both password are not matched ." ForeColor="Red"></asp:CompareValidator>
                </td>
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
