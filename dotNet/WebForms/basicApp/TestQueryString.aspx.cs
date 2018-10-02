using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestQueryString : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["deptno"]!=null)
        {
            string deptno = Request.QueryString["deptno"];
            lblDisplayQueryString.Text = "Displaying employee of department " + deptno;
        }
        else
        {
            lblDisplayQueryString.Text = "No employee...";
        }
        

    }
}