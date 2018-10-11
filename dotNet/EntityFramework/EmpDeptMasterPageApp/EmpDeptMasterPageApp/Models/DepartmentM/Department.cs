using EmpDeptMasterPageApp.Models.EmployeeM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpDeptMasterPageApp.Models.DepartmentM
{
    public class Department
    {
        public virtual List<Employee> Employees { get; set; }
        public Guid Id { get; set; }
        public string DeptName { get; set; }
        public string DeptLoc { get; set; }

        public Department()
        {
            Id = Guid.NewGuid();
        }
    }
}