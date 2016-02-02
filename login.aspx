<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <h1>Please Login</h1>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="textboxUserName" runat="server"></asp:TextBox>
&nbsp;<p>
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="textboxPassword" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            <asp:HyperLink ID="linkNewAccount" runat="server" NavigateUrl="~/NewAccountInfo.aspx">Need a new account?</asp:HyperLink>
        </p>
        <p>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>
            <%--Go to the User Log page after testing for pwd validity<asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" PostBackUrl="~/login.aspx" />--%>
        </p>
    </form>
</body>
</html>
