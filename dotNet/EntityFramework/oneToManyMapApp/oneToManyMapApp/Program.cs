using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneToManyMapApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SwabhavDbContext dbContext = new SwabhavDbContext();

            /*       Department dept = new Department();
                   dept.Employees = new List<Employee>();

                  dept.DeptName = "Marketing";
                  dept.DeptLoc = "Surat";

                  dbContext.Departments.Add(dept);
                  dbContext.SaveChanges();

                   dept.Employees.Add(new Employee { EmpName = "Abhishek Singh", EmpJob = "Developer", EmpSalary = 20000 });
                   dbContext.SaveChanges(); 

                //   GetEmployDetailsFromParent(dbContext); */
           // GetDeptDetailsFromEmpID(dbContext);

          iqueryableConcept(dbContext);
         // ienummerableConcept(dbContext);
        }

        private static void iqueryableConcept(SwabhavDbContext dbContext)
        {
          var emps =  dbContext.Employees.Where((e) => e.EmpName.StartsWith("A"))
                .Select((e) => new { Firstname = e.EmpName.Split(' ')[0], EmpID = e.Id });
            foreach (var e in emps)
            {
                Console.WriteLine("Firstname :" + e.Firstname + " " + "EmpId :" + e.EmpID);
            }
         

        }

        private static void ienummerableConcept(SwabhavDbContext dbContext)
        {
            var emps = dbContext.Employees.Where((e) => e.EmpName.StartsWith("A"))
                .ToList()
                .Select((e) => new { Firstname = e.EmpName.Split(' ')[0], EmpID = e.Id });
            foreach (var e in emps)
            {
                Console.WriteLine("Firstname :" + e.Firstname + " " + "EmpId :" + e.EmpID);
            }
        }

        private static void GetDeptDetailsFromEmpID(SwabhavDbContext dbContext)
        {
           Employee emp= dbContext.Employees.Select((e) => e).Where((e) => e.Id == new Guid("E5BF0B88-4B62-4379-8EC4-D06F728F2064")).Single();
            
            Console.WriteLine("Dept name :"+emp.Department.DeptName+"\n"+
                "Dept Id :"+emp.Department.Id.ToString()
                +"\n"+"DEpt Location:"+emp.Department.DeptLoc);
           
        }

        private static void GetEmployDetailsFromParent(SwabhavDbContext dbContext)
        {
            Console.WriteLine("inside...");
            Department dept = dbContext.Departments.Where((d) => d.Id == new Guid("70297305-D32F-4F56-B9AC-7104897ADE25")).Single();
            Console.WriteLine(dept.DeptName);
            var employees = dept.Employees.Select((e) => e);

            foreach (var e in employees)
            {
                Console.WriteLine("Employee Name :" + e.EmpName);
            }

        }


    }
}
