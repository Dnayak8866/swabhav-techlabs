using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestListItem : System.Web.UI.Page
{ 
    static int  count=0;
    protected void Page_Load(object sender, EventArgs e)
    {
        count += 1 ;
        Response.Write("Inside page load..."+count);
        if (IsPostBack)
        {
            Response.Write("Inside page load..."+count);
        }
        else
        {
            lstBoxCompanies.Items.Add("HiTech");
            lstBoxCompanies.Items.Add("SwabhavTechlabs");
        }
        
    }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            lstBoxCompanies.Items.Add(txtCompanyName.Text);
        }
        
    }

    protected void btnDeleteCompany_Click(object sender, EventArgs e)
    {
            
       lstBoxCompanies.Items.Remove(lstBoxCompanies.SelectedItem);
      //  lstBoxCompanies.ClearSelection();
    }
}