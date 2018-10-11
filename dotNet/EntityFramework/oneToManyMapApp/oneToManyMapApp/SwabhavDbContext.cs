using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneToManyMapApp
{
   public  class SwabhavDbContext:DbContext
    {
      public  DbSet<Employee> Employees { get; set; }
      public  DbSet<Department> Departments { get; set; }
    }
}
