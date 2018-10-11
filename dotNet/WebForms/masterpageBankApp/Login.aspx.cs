using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BankTransactionLib;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["islogout"]=="yes")
        {
            Session.Abandon();
            Response.Redirect("Home.aspx");
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
      
        LoginService loginservice = new LoginService();
        int inputacntno = Convert.ToInt32(txtUserId.Text);
        string inputpass = txtPassword.Text;

        if (loginservice.AuthenticateUser(inputacntno, inputpass))
        {

            Session["account"] = loginservice.acntHolder;
            Response.Redirect("Home.aspx");
        }
        lblValidUser.Text = "!enter a valid userid and password.....";
    }
}