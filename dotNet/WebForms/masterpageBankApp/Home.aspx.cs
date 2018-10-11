using BankTransactionLib;
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
        if (Session["account"] != null)
        {
            lblNoOfUSer.Text = "No of users :" + Application["TotalOnlineUsers"].ToString();
            AccountHolder acntholder = Session["account"] as AccountHolder;
            displayUserHeader.Text = "Welcome   " + acntholder.AcntHolderName;
        }
    }
}