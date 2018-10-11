using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDeptApp
{
    class Program
    {
        static void Main(string[] args)
        {
          
             SwabhavDbContext dbContext = new SwabhavDbContext();
             AddDepartment(dbContext);
         //  UpdateDepartment(dbContext);
        //    DeleteDepartment(dbContext);
           
        }

        private static void DeleteDepartment(SwabhavDbContext dbContext)
        {
           
            Department dept = dbContext.Departments.Where((d) => d.Id == 3).Single();
            dbContext.Departments.Remove(dept);
            dbContext.SaveChanges();
            Console.WriteLine("Department deleted...");
        }

        private static void UpdateDepartment()
        {
            SwabhavDbContext dbContext = new SwabhavDbContext();
            Department dept = dbContext.Departments.Where((d) => d.Id == 3).Single();
            dept.Dname = "Operations";
            Console.WriteLine(dept.Dname);
            dbContext.SaveChanges();
            Console.WriteLine("Department updated successfully....");
        }

        private static void AddDepartment(SwabhavDbContext dbContext)
        {
            
            dbContext.Departments.Add(new Department { Dname = "IT", Location = "Andheri" });
            dbContext.Departments.Add(new Department { Dname = "Marketting", Location = "Surat" });
            dbContext.Departments.Add(new Department { Dname = "Sales", Location = "Andheri" });
            dbContext.SaveChanges();
            Console.WriteLine("Departments added successfully....");

        }
    }
}
