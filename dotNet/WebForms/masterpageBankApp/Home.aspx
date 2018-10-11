<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        #displayUserHeader {
            color: #99FF66;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 style="color: #66CCFF">Home page...</h1>
    <asp:Label  style="color: #12FD07" ID="displayUserHeader" runat="server" Font-Size="X-Large" ForeColor="Lime">Please login....</asp:Label>
    <br />
    <br />
    <asp:Label ID="lblNoOfUSer" runat="server" Text=""></asp:Label>
</asp:Content>

