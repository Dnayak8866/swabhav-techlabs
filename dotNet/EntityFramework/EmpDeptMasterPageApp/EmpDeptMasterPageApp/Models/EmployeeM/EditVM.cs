using EmpDeptMasterPageApp.Models.DepartmentM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpDeptMasterPageApp.Models.EmployeeM
{
    public class EditVM
    {
        public Guid Id { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
        public string EmpJob { get; set; }


        public List<Department> DeptList;
        public Guid SelectedDept { get; set; }

    }
}