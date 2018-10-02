using DeptRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class TestDept : System.Web.UI.Page
{
   private DepartmentRepository deptrepo = new DepartmentRepository();
    protected void Page_Load(object sender, EventArgs e)
    {
       if (!IsPostBack)
        {
           

            DropDownListDeptName.DataSource = deptrepo.GetDeptDetails();
            DropDownListDeptName.DataValueField = "DeptNo";
            DropDownListDeptName.DataTextField = "DeptName";
            DropDownListDeptName.DataBind();

            DropDownSelectionChangedEvnt(sender,e);

            
            
        } 
        


    }



    protected void DropDownSelectionChangedEvnt(object sender, EventArgs e)
    {
        litHeader.Text = "Display Dept :" + DropDownListDeptName.SelectedItem.ToString() + " "+"DeptNO :" + DropDownListDeptName.SelectedItem.Value;
        GridViewEmp.DataSource = deptrepo.GetEmployees(Convert.ToInt32(DropDownListDeptName.SelectedItem.Value));
        GridViewEmp.DataBind();
    }
}