// Liz Fallin
// BIT 285
// Assignment 1
// NewAccountInfo.aspx.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

public partial class NewAccountInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCreateAcct_Click(object sender, EventArgs e)
    {
        // Store first name, last name, email, and program in Session
        Session["firstName"] = textboxFirstName.Text;
        Session["lastName"] = textboxLastName.Text;
        Session["email"] = textboxEmail.Text;
        Session["program"] = ddlistProgramOption.Text;

        // Go to the Password Generator page
        Server.Transfer("Password Generator.aspx");
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
    }
    protected void chkboxEmail_CheckedChanged(object sender, EventArgs e)
    {

    }
}