using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPageEmpDept : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            Menu1.Items[2].Text = "Logout";
            Menu1.Items[2].NavigateUrl = "Login.aspx?page=index";
        }

    }
}
