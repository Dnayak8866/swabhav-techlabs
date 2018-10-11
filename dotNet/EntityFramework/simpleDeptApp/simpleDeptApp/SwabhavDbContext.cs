using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDeptApp
{
    class SwabhavDbContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }


    }
}
