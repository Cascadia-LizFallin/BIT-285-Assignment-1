// Liz Fallin
// BIT 285
// Assignment 1
// login.aspx.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        // Future: Do a username/pwd check
        // For now, just accept any combo
        Session["username"] = textboxUserName.Text;
        Server.Transfer("User Log.aspx");
    }
}