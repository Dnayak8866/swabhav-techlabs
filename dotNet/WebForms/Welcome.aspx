<%@Page Language="C#" CodeFile="Welcome.aspx.cs" Inherits="Welcome" %>
<!DOCTYPE html>
<html>
    <head>
        <title>
            WelcomePage
        </title>
    </head>
    <body>
        <h1>Welcome Page</h1>
        <asp:Label ID="lblGetPost" runat ="server"></asp:Label>
        <form runat="server">
            Enter your name:<asp:TextBox ID="txtName" runat="server" />
            <asp:Button ID="btnWish" runat="server" Text="Wish" OnClick="btnWishClickHandler" />
            <asp:Label ID="lblHello" runat="server"></asp:Label>
        </form>
    </body>
</html>