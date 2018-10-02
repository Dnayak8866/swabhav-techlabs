using EmpLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private EmployeeRepositroy emprepo = EmployeeRepositroy.GetInstance();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("Login.aspx");
        }
    }

    protected void btnAddEmp_Click(object sender, EventArgs e)
    {
        int empNo = Convert.ToInt32(txtEmpNo.Text);
        string empName = txtEmpName.Text;
        string jobType = txtJobType.Text;
        string mgr = txtMgr.Text;
        string hiredate = txtHiredate.Text;
        int salary = Convert.ToInt32(txtSalary.Text); 
        int commisn = Convert.ToInt32(txtCommision.Text);
        int deptNo = Convert.ToInt32(txtDeptNo.Text);


       emprepo.AddEmployee(empNo,empName,jobType,mgr,hiredate,salary,commisn,deptNo);
    }

    protected void btnDisplayEmp_Click(object sender, EventArgs e)
    {
        GridViewEmp.DataSource= emprepo.GetEmployees();
        GridViewEmp.DataBind();
    }
}