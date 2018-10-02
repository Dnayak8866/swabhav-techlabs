using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestLoginaspx : System.Web.UI.Page
{
    private string username = "dharmesh";
    private string password = "pass@";
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if(txtUser.Text==username && txtPass.Text == password)
        {
            Server.Transfer("WelcomeUser.aspx?user="+txtUser.Text);
            
        }
    }
}