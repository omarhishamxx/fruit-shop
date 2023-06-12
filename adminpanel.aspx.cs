using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;

public partial class adminpanel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["isAdmin"] == null || !(bool)Session["isAdmin"])
        {
            // Redirect the user to the login page or any other appropriate page
            Response.Redirect("login.aspx");
        }
    }
    protected void Viewcust_Click(object sender, EventArgs e)
    {
        Response.Redirect("adcustomerview.aspx");
    }
    protected void Viewadmin_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminview.aspx");
    }
}