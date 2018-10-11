<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Passbook.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            color: #66CCFF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 class="auto-style1">Passbook page...</h1>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <p>
        <asp:GridView ID="gvPassbook" runat="server">
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="btnDownloadPassbook" runat="server" Text="Download" OnClick="btnDownloadPassbook_Click" CssClass="btn btn-success" />
    </p>
</asp:Content>

