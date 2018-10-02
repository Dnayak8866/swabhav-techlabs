using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeptLibrary;
using LoginServiceLibrary;

public partial class _Default : System.Web.UI.Page
{
    DepartmentRepository deptrepo = DepartmentRepository.GetInstance();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["user"] == null)
        {
            Response.Redirect("Login.aspx");
        }

    }

    protected void btnAddDept_Click(object sender, EventArgs e)
    {
        
        deptrepo.AddDepartment(Convert.ToInt32(txtDeptNo.Text), txtDepName.Text, txtDeptLocation.Text);
       


    }

    protected void btnDisplayDept_Click(object sender, EventArgs e)
    {
        GridViewDept.DataSource = deptrepo.GetDepartments();
        GridViewDept.DataBind();
    }
}