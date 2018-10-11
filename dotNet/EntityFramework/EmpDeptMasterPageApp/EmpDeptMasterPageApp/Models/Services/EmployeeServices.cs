using EmpDeptMasterPageApp.Models.EmployeeM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpDeptMasterPageApp.Models.Services
{
    public class EmployeeServices
    {
        private EmpDeptDbContext _dbContext;



        public EmployeeServices(EmpDeptDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        public void AddEmployee(Employee emp)
        {

            _dbContext.Employees.Add(emp);
            _dbContext.SaveChanges();
        }

        public Employee SearchAEmployee(Guid id)
        {
            Employee emp = _dbContext.Employees.Where((e) => e.Id == id).Single();
            return emp;
        }

        public List<Employee> GetAllEmployees()
        {

            return _dbContext.Employees.ToList();
        }

        public void UpdateEmployee(Employee emp)
        {
          Employee employee=  _dbContext.Employees.Where((e)=>e.Id==emp.Id).Single();
            employee.EmpName = emp.EmpName;
            employee.Department = emp.Department;
            employee.EmpJob = emp.EmpJob;
            employee.EmpSalary = emp.EmpSalary;

            _dbContext.SaveChanges();
        }

        public List<Employee> GetAllEmployeesByDeptId(Guid deptId)
        {

            return _dbContext.Employees.Where((e)=>e.Department.Id==deptId).ToList();
        }

    }
}