using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLinqQueryApp
{
    class TestEmpLinq
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee(7839, "KING", "PRESIDENT", "None", "17-NOV-81", 5000, 0, 10));
            empList.Add(new Employee(7698, "BLAKE", "MANAGER", "7833", "1-MAY-81", 2850, 0, 30));
            empList.Add(new Employee(7782, "CLARK", "MANAGER", "7839", "9-JUN-81", 2450, 0, 10));
            empList.Add(new Employee(7566, "JONES", "MANAGER", "7839", "2-APR-81", 2975, 0, 20));
            empList.Add(new Employee(7654, "MARTIN", "SALESMAN", "7698", "28-SEP-81", 1250, 1400, 30));
            empList.Add(new Employee(7499, "ALLEN", "SALESMAN", "7698", "20-FEB-81", 1600, 300, 30));
            empList.Add(new Employee(7844, "TURNER", "SALESMAN", "7698", "8-SEP-81", 1500, 0, 30));
            empList.Add(new Employee(7900, "JAMES", "CLERK", "7698", "3-DEC-81", 950, 0, 30));
            empList.Add(new Employee(7521, "WARD", "SALESMAN", "7698", "22-FEB-81", 1250, 500, 30));
            empList.Add(new Employee(7902, "FORD", "ANALYST", "7566", "3-DEC-81", 3000, 0, 20));
            empList.Add(new Employee(7369, "SMITH", "CLERK", "7902", "17-DEC-80", 800, 0, 20));
            empList.Add(new Employee(7788, "SCOTT", "ANALYST", "7566", "09-DEC-82", 3000, 0, 20));
            empList.Add(new Employee(7876, "ADAMS", "CLERK", "7788", "12-JAN-83", 1100, 0, 20));
            empList.Add(new Employee(7934, "MILLER", "CLERK", "7782", "23-JAN-82", 1300, 0, 10));

            Console.WriteLine("[All employees..................................]");
            var allEmployees = empList.Select((e) => e);
            DisplayEmployess(allEmployees);

            Console.WriteLine("[All employees where DEptno=10........................................]");
            var allEmployeesWithDept10 = empList.Select((e) => e).Where((e) => (e.EmpDeptNo == 10));
            DisplayEmployess(allEmployeesWithDept10);

            Console.WriteLine("[All employees with salary descending order.............................]");
            var employeesWithSalDesc = empList.Select((e) => e).OrderByDescending((e) => e.EmpSalary);
            DisplayEmployess(employeesWithSalDesc);

            Console.WriteLine("[All employees whose name starts with A.................................]");
            var employeesNameStartsWithA = empList.Select((e) => e).Where((e) => (e.EmpName.StartsWith("A")));
            DisplayEmployess(employeesNameStartsWithA);

            Console.WriteLine("[All employees whose Commision is 0.................................]");
            var employeesWithNoCommission = empList.Select((e) => e).Where((e) => (e.EmpComisn == 0));
            DisplayEmployess(employeesWithNoCommission);

            Console.WriteLine("[All employees whose DeptNo is not 10................................]");
            var allEmployeesWithoutDept10 = empList.Select((e) => e).Where((e) => (e.EmpDeptNo != 10));
            DisplayEmployess(allEmployeesWithoutDept10);


            Console.WriteLine("[All employees With CTC................................]");
            var allEmpSalaryWithCtc = empList.Select((e) => new { empname = e.EmpName, empctc = ((e.EmpSalary + e.EmpComisn) * 12) });
            foreach (var emp in allEmpSalaryWithCtc)
            {
                Console.WriteLine("Employee Name :" + emp.empname +
                    "\nEmployee CTC :" + emp.empctc
                    + "\n-----------------------------------");
            }


            Console.WriteLine("[All employees with name and Deptno................................]");
            var employeesWithDeptAndName = empList.Select((e) => new { e.EmpName, e.EmpDeptNo });
            foreach (var emp in employeesWithDeptAndName)
            {
                Console.WriteLine("Employee Name :" + emp.EmpName +
                   "\nDept No :" + emp.EmpDeptNo
                   + "\n-----------------------------------");
            }

            Console.WriteLine("[All distinct  Deptno................................]");
            var distintDeptno = empList.Select((e) => e.EmpDeptNo).Distinct();
            foreach (var deptno in distintDeptno)
            {
                Console.WriteLine("Deptno: " + deptno);
            }

            Console.WriteLine("[Employee's hiredate and tenure.........................................]");
            var empployeewithTenure = empList.Select((e) => new { e.EmpName, e.HireDate, tenure = (DateTime.Now.Year - Convert.ToDateTime(e.HireDate).Year) });

            foreach (var emp in empployeewithTenure)
            {
                Console.WriteLine("Employee Name :" + emp.EmpName
                    + "\nEmployee Hiredate :" + emp.HireDate
                    + "\nEmployee Tenure :" + emp.tenure
                    + "\n--------------------------------------------------------------");

            }

            Console.WriteLine("[All employees who is Manager............................................]");
            var managers = empList.Select((e) => e).Where((e) => (e.EmpJob == "MANAGER"));
            DisplayEmployess(managers);

            Console.WriteLine("Top three employee with descending order salary............................................]");
            var top3EmployeeDesc = empList.Select((e) => e).OrderByDescending((e) => e.EmpSalary).Take(3);
            DisplayEmployess(top3EmployeeDesc);

            Console.WriteLine("[Employees whose name is SCOTT............................................]");
            var employeesWithNameScott = empList.Select((e) => e).Where((e) => (e.EmpName == "SCOTT"));
            DisplayEmployess(employeesWithNameScott);


            Console.WriteLine("All employees whose dept no is of scott...............");
            var scottEmployee = empList.Select((e) => e).Where((e) => e.EmpName == "SCOTT");
            var dept = scottEmployee.Select((e) => e.EmpDeptNo);
            int DepartNo = 0;
            foreach (var val in dept)
            {
                DepartNo = val;
            }
            var allEmp = empList.Select((e) => e).Where((e) => e.EmpDeptNo == DepartNo);
            DisplayEmployess(allEmp);

            Console.WriteLine("[All employees whose job is of smith...............]");
            var smith = empList.Select((e) => e).Where((e) => e.EmpName == "SMITH");
            var smithJob = smith.Select((e) => e.EmpJob);
            string job = "";
            foreach (var val in smithJob)
            {
                job = val;
            }
            var employeesHavingJobAsSmith = empList.Select((e) => e).Where((e) => e.EmpJob == job);
            DisplayEmployess(employeesHavingJobAsSmith);

            Console.WriteLine("[Maximum salaried employee...............]");
            var maxsalary = empList.Select((e) => e).Max((e) => e.EmpSalary);
            var employeeWithMaxSalary = empList.Select((e) => e).Where((e) => e.EmpSalary == maxsalary);
            DisplayEmployess(employeeWithMaxSalary);


            Console.WriteLine("[Second maximum salaried employee...............]");
            var employeesWithSalaryLessThanMaxSal = empList.Select((e) => e).Where((e) => e.EmpSalary < maxsalary);
            var secondMaxSal = employeesWithSalaryLessThanMaxSal.Max((e) => e.EmpSalary);
            var employeeWithSecondMaxSal = employeesWithSalaryLessThanMaxSal.Select((e) => e).Where((e) => e.EmpSalary == secondMaxSal);
            DisplayEmployess(employeeWithSecondMaxSal);


            Console.WriteLine("[Sum of all employees salary...............]");
            var salarySum = empList.Sum((e) => e.EmpSalary);
            Console.WriteLine("Total Salary Amount :" + salarySum);

            var noOfEmp = empList.Count();
            Console.WriteLine("Total NNo of Employees.................." + noOfEmp);

            Console.WriteLine("Group by deptno and showing HeadCount of each dept..................");
            var deptGroupingResult = empList.GroupBy((e) => e.EmpDeptNo).Select((group) => new { dept = group.Key, Count = group.Count() });

            foreach (var item in deptGroupingResult)
            {
                Console.WriteLine("{0} : {1}", item.dept, item.Count);
            }

            Console.WriteLine("Group by Job and showing Job whose HeadCount > 2 of each dept..................");
            var jobGroupingresult = empList.GroupBy((e) => e.EmpJob).Select((group) => new { job = group.Key, HeadCount = group.Count() })
                .Where((group) => group.HeadCount > 2)
                .OrderBy((group) => group.HeadCount);
            foreach (var item in jobGroupingresult)
            {
                Console.WriteLine("{0} : {1}", item.job, item.HeadCount);
            }

            Console.WriteLine("Group by Job,DeptNo and show headCount..................");
            var result = empList.GroupBy((e) => new { job = e.EmpJob, dept = e.EmpDeptNo })
                .Select((group) => new { jobtype = group.Key.job, Department = group.Key.dept, HeadCount = group.Count() })
                .OrderBy((group)=>group.Department);
            foreach (var item in result)
            {
                Console.WriteLine("{0} : {1} : {2}", item.Department, item.jobtype, item.HeadCount);
            }

            var result =from e in empList 


        }

        private static void DisplayEmployess(IEnumerable<Employee> employeesList)
        {
            foreach (var emp in employeesList)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("\n\n");
        }
    }
}
