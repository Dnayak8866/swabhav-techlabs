<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageEmpDept.master" AutoEventWireup="true" CodeFile="Employee.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 207px;
        }
        .auto-style2 {
            width: 196px;
        }
        .auto-style3 {
            width: 207px;
            height: 26px;
        }
        .auto-style4 {
            width: 196px;
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
        }
        .auto-style6 {
            width: 207px;
            height: 23px;
        }
        .auto-style7 {
            width: 196px;
            height: 23px;
        }
        .auto-style8 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Employee page..</h2>
    <p>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Enter EmpNO:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtEmpNo" runat="server" Width="181px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Enter Employee Name:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtEmpName" runat="server" Width="181px"></asp:TextBox>
                </td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style1">Enter Job Type:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtJobType" runat="server" Width="181px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Enter MGR:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtMgr" runat="server" Width="181px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Enter HireDate:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtHiredate" runat="server" Width="181px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Enter Salary:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtSalary" runat="server" Width="181px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Enter Commision:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtCommision" runat="server" Width="181px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Enter DepartmentNo:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtDeptNo" runat="server" Width="181px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6"></td>
                <td class="auto-style7"></td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Button ID="btnAddEmp" runat="server" Text="Add" OnClick="btnAddEmp_Click" />
                </td>
                <td class="auto-style7">
                    <asp:Button ID="btnDisplayEmp" runat="server" Text="Display" OnClick="btnDisplayEmp_Click" />
                </td>
                <td class="auto-style8">&nbsp;</td>
            </tr>
        </table>
    </p>
    <asp:GridView ID="GridViewEmp" runat="server" Height="152px" Width="301px">
    </asp:GridView>
</asp:Content>

