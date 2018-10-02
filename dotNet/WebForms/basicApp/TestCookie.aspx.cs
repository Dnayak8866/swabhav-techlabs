using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestCookie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["color"] != null)
        {
            bodytag.Style["background-color"] = Request.Cookies["color"].Value;
            lblCookie.Text = "Cookie is set...";
        }else
        {
            lblCookie.Text = "Cookie is not set....";
        }
    }

    protected void btnSetCookie_Click(object sender, EventArgs e)
    {
        HttpCookie cookie = new HttpCookie("color");
        cookie.Value = "Green";
       // cookie.Expires = DateTime.Now.AddDays(1);
        Response.SetCookie(cookie);
        lblCookie.Text = "Cookie is set...";
    }

    protected void btnGetCookie_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["color"] != null)
        {
            lblCookie.Text = "Color Cookie is "+ Request.Cookies["color"].Value;
        }
        else
        {
            lblCookie.Text = "Cookie is not set....";
        }
    }
}