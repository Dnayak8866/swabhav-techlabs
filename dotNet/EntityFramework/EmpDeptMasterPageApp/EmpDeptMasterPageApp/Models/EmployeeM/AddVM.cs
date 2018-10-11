using EmpDeptMasterPageApp.Models.DepartmentM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpDeptMasterPageApp.Models.EmployeeM
{
    public class AddVM
    {
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
        public string EmpJob { get; set; }

        public List<Department> DeptLsit;
        public Guid SelectedDept { get; set; }

        public List<Employee> EmpList { get; set; }
    }
}