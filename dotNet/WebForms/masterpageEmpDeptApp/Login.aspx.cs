﻿using LoginServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["page"] == "index")
        {
            Session.Abandon();
            Response.Redirect("Index.aspx");
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        LoginService loginservice = new LoginService();
        string inputusername = txtUserId.Text;
        string inputpass = txtPassword.Text;

        if (loginservice.AuthenticateUser(inputusername, inputpass))
        {
            
            Session["user"] = inputusername;
            Response.Redirect("Index.aspx");
        }
        lblValidUser.Text = "!enter a valid userid and password.....";
    }
}