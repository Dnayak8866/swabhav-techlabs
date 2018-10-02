using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestSummary : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     

        lblAppValue.Text = "Application value :"+Application["count"];
        lblSession.Text = "Session VAlue :" + Session["user"];
        
        

    }
}