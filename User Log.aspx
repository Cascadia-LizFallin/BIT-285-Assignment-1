<%@ Page Language="C#" AutoEventWireup="true" CodeFile="User Log.aspx.cs" Inherits="User_Log" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblWelcome" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Welcome"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="gvUserLog" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="btnRefresh" runat="server" OnClick="btnRefresh_Click" Text="Refresh Table" />
&nbsp;&nbsp;
        <asp:Button ID="btnLogout" runat="server" OnClick="btnLogout_Click" Text="Logout" />
    &nbsp;&nbsp;
            <asp:HyperLink ID="linkLogin" runat="server" NavigateUrl="~/login.aspx" Visible="False">You have logged out. Log in again?</asp:HyperLink>
    </form>
</body>
</html>
