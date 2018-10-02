using MvcApp.Models.Dept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApp.Models.Services
{
    public class DepartmentService
    {
        List<Department> deptList = new List<Department>();
        List<Employee> empList = new List<Employee>();
        

        public DepartmentService()
        {
            deptList.Add(new Department() { DeptName = "IT", DeptNo = 10 });
            deptList.Add(new Department() { DeptName = "Sales", DeptNo = 20 });
            deptList.Add(new Department() { DeptName = "Marketing", DeptNo = 30 });
            deptList.Add(new Department() { DeptName = "Operations", DeptNo = 40 });

            empList.Add(new Employee() { EmpName = "Abhi", EmpJob = "Manager", EmpDeptNo = 40 });
            empList.Add(new Employee() { EmpName = "Suni", EmpJob = "Clerk", EmpDeptNo = 20});
            empList.Add(new Employee() { EmpName = "Dharmesh", EmpJob = "Developer", EmpDeptNo = 10 });
            empList.Add(new Employee() { EmpName = "Chandan", EmpJob = "Developer", EmpDeptNo = 10 });
        }

        public List<Employee> GetEmployees(string deptno)
        {
            List<Employee> selectedemployees = new List<Employee>();
            foreach (Employee emp in empList)
            {
                if (emp.EmpDeptNo.ToString() == deptno)
                {
                    selectedemployees.Add(emp);
                }
            }
            return selectedemployees;
        }




        public List<Department> DeptList
        {
            get
            {
                return deptList;
            }
        }
        public List<Employee> EmpList
        {
            get
            {
                return empList;
            }
        }



    }
}