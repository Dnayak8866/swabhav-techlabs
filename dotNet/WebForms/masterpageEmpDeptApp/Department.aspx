<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageEmpDept.master" AutoEventWireup="true" CodeFile="Department.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 197px;
        }
        .auto-style2 {
            width: 214px;
        }
        .auto-style3 {
            width: 197px;
            height: 26px;
        }
        .auto-style4 {
            width: 214px;
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Department page</h2>
    <p>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lblEnterDeptNo" runat="server" Text="Enter DeptNo:" ForeColor="#666699"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtDeptNo" runat="server" Width="202px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="deptNoValidator" runat="server" ControlToValidate="txtDeptNo" ErrorMessage="!field is required..." ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lblDeptName" runat="server" Text="Enter Dept Name:" ForeColor="#666699"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtDepName" runat="server" Width="201px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="deptNameReqValidator" runat="server" ControlToValidate="txtDepName" ErrorMessage="!field is required...." ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3" style="color: #808080">
                    Enter Location</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtDeptLocation" runat="server" Width="201px"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="deptLocationReqValidator" runat="server" ControlToValidate="txtDeptLocation" ErrorMessage="! field is required..." ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
    </p>
   <asp:Button ID="btnAddDept" runat="server" Text="Add" OnClick="btnAddDept_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnDisplayDept" runat="server" Text="Display" OnClick="btnDisplayDept_Click" />
&nbsp;<asp:GridView ID="GridViewDept" runat="server" EnableViewState="False" Width="359px">
        </asp:GridView>
    
</asp:Content>


