using EmpDeptMasterPageApp.Models.DepartmentM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpDeptMasterPageApp.Models.EmployeeM
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
        public string EmpJob { get; set; }

        public virtual Department Department { get; set; }

        public Employee()
        {
            Id = Guid.NewGuid();
        }
    }
}