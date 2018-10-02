using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestSession : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (Session["user"] == null)
        { 
            Session["user"] = 0;
          
        }
        
          lblOld.Text= "Old value " + Session["user"];
          Session["user"] = Convert.ToInt32(Session["user"])+1;

          lblNew.Text = "New Value " + Session["user"];
          lblSessionID.Text = "Session Id is  :" + Session.SessionID;
        

    }
}