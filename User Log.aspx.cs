// Liz Fallin
// BIT 285
// Assignment 1
// User Log.aspx.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class User_Log : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Create a grid view to display session info for all users

        if (!IsPostBack)
        {
            // Print welcome banner
            lblWelcome.Text = "Welcome, " + Session["username"] + "!";

            // Make local copy of the visitor table
            DataTable visitorTable = new DataTable();
            visitorTable = (DataTable)Application["visitorTable"];

            // Create a new row, to be filled with session data
            DataRow newRow = visitorTable.NewRow();

            newRow["session_id"] = Session.SessionID;
            newRow["username"] = Session["username"];
            newRow["login_time"] = DateTime.Now;

            // 1/29 Only getting ::1 , instead of the external IP address
            newRow["ip_address"] = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            // Add new data row to the visitor table
            visitorTable.Rows.Add(newRow);

            // Push the updated visitorTable back to the Application visitor table
            Application["visitorTable"] = visitorTable;

            // Set the Grid View's data source to the visitor table, and bind
            gvUserLog.DataSource = visitorTable.DefaultView;
            gvUserLog.DataBind();
        }
    }
    protected void gvUserLog_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnRefresh_Click(object sender, EventArgs e)
    {
        // Refresh visitor table, which will add new users, and
        // remove users who have logged out.
        // Make local copy of the visitor table

        // Pull a current copy of the visitor table
        DataTable visitorTable = new DataTable();
        visitorTable = (DataTable)Application["visitorTable"];

        // Set the Grid View's data source to the visitor table, and bind
        gvUserLog.DataSource = visitorTable.DefaultView;
        gvUserLog.DataBind();
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        // Make local copy of the visitor table
        DataTable visitorTable = new DataTable();
        visitorTable = (DataTable)Application["visitorTable"];

        //// Get username for this session
        //string localUserName = (string)Session["username"];

        //// Delete all rows where username = localusername
        //DataRow[] drr = visitorTable.Select("username='" + localUserName + "'");
        //for (int i = 0; i < drr.Length; i++)
        //    drr[i].Delete();
        //visitorTable.AcceptChanges();

        // Get session ID for this session
        string localSessionID = Session.SessionID;

        // Delete all rows where username = localusername
        DataRow[] drr = visitorTable.Select("session_id='" + localSessionID + "'");
        for (int i = 0; i < drr.Length; i++)
            drr[i].Delete();
        visitorTable.AcceptChanges();

        // Push the updated visitorTable back to the Application visitor table
        Application["visitorTable"] = visitorTable;

        // Set the Grid View's data source to the visitor table, and bind
        gvUserLog.DataSource = visitorTable.DefaultView;
        gvUserLog.DataBind();

        // Display logoff message, and allow the user to log back in
        linkLogin.Visible = true;

    }
}