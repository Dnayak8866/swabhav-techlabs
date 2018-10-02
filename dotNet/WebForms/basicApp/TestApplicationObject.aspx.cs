using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestApplicationObject : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Application["count"] == null)
        {
            Application["count"] = 0;

        }
        lblOld.Text = "Old value " + Application["count"];
        Application["count"] = Convert.ToInt32(Application["count"]) + 1;

        lblNew.Text = "New Value " + Application["count"];
       
    }
}