using EmpDeptMasterPageApp.Models.DepartmentM;
using EmpDeptMasterPageApp.Models.EmployeeM;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmpDeptMasterPageApp.Models.Services
{
    public class EmpDeptDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}