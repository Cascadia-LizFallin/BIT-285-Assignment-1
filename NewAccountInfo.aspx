<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewAccountInfo.aspx.cs" Inherits="NewAccountInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <h1>New Account Information</h1>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="textboxFirstName" runat="server" Width="225px"></asp:TextBox>
&nbsp;<asp:Label ID="lblRequiredFirst" runat="server" Text="* required"></asp:Label>
        &nbsp;<asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="textboxFirstName" ErrorMessage="First name is required"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="textboxLastName" runat="server" Width="225px" height="22px"></asp:TextBox>
&nbsp;
        <asp:Label ID="lblRequiredLast" runat="server" Text="* required"></asp:Label>
        <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ControlToValidate="textboxLastName" ErrorMessage=" Last name is required"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email Address"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="textboxEmail" runat="server" style="margin-left: 5px" Width="225px" height="22px" CausesValidation="True" ValidateRequestMode="Enabled"></asp:TextBox>
        <br />
        <asp:Label ID="lblProgramOption" runat="server" Text="Program Option"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlistProgramOption" runat="server">
            <asp:ListItem>Web Developer Degree</asp:ListItem>
            <asp:ListItem>ETSP Degree</asp:ListItem>
            <asp:ListItem>Network Technology Degree</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <div style="margin-left: 120px">
            <asp:CheckBox ID="chkboxEmail" runat="server" Text="email me program updates" OnCheckedChanged="chkboxEmail_CheckedChanged" />
        &nbsp;&nbsp;
        <asp:RegularExpressionValidator ID="revChkboxEmailAddress" runat="server" ControlToValidate="textboxEmail" ErrorMessage="Email is incorrectly formatted" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </div>
        <br />
        <asp:Button ID="btnCreateAcct" runat="server" Text="create account" PostBackURL="~/Password Generator.aspx" OnClick="btnCreateAcct_Click"/>
&nbsp;&nbsp;
        <asp:Button ID="btnReset" runat="server" Text="reset" OnClick="btnReset_Click" OnClientClick="this.form.reset();return false;"/>
    </form>
</body>
</html>
