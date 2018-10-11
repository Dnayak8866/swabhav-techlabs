using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpDeptMasterPageApp.Models.DepartmentM
{
    public class AddVM
    {
        public string DeptName { get; set; }
        public string DeptLoc { get; set; }

        public List<Department> DeptList { get; set; }
    }
}