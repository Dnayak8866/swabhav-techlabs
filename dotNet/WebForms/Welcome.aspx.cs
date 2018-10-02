using System;
using System.Web.UI;

public partial class Welcome:System.Web.UI.Page
    {
        public void Page_Load()
        {
            if (this.IsPostBack)
            {
                lblGetPost.Text="Method is "+"post";
             }
            else if(Request.HttpMethod=="GET")
            {
                lblGetPost.Text = "Method is "+"get";
            }
        }
        public void btnWishClickHandler(object sender,EventArgs e)
        {
         if (txtName.Text!="")
            {
                lblHello.Text = "Hello from " + txtName.Text;
            }    
        }
    }
