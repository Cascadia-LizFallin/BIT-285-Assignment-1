<%@ Application Language="C#" %>
<%@ Import Namespace="System.Data"%>
<script runat="server">
/**
* Liz Fallin
* BIT 285
* Assignment 1
* global.aspx
* Creates data table with session info for this user
*
* Initialize a new DataTable variable for the application,
* define the data types in its columns
*/
    void Application_Start(object sender, EventArgs e)
    {
        // Was getting a javascript error during validation
        ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        DataTable dt = new DataTable();
    
        dt.Columns.Add(new DataColumn("session_id", System.Type.GetType("System.String")));
        dt.Columns.Add(new DataColumn("username", System.Type.GetType("System.String")));
        dt.Columns.Add(new DataColumn("login_time", System.Type.GetType("System.DateTime")));
        dt.Columns.Add(new DataColumn("ip_address", System.Type.GetType("System.String")));
    
        // store the DataTable as an Application variable
        Application["visitorTable"] = dt;
    }

    // browser's first visit to the page, (session starts)
    void Session_Start(Object s, EventArgs e)
    {
        //Nothing at this point;
    }
    
    // session ends
    void Session_End(Object s, EventArgs e)
    {   
        Session.Abandon();
    }

    
    
</script>