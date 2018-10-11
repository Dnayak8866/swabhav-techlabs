using EmpDeptMasterPageApp.Models.DepartmentM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpDeptMasterPageApp.Models.Services
{
    public class DepartmentServices
    {
        private EmpDeptDbContext _dbContext;
        public List<Department> deptList;

        public DepartmentServices(EmpDeptDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Department> DeptList
        {
            get
            {
                return deptList;
            }
        }

        public DepartmentServices()
        {
            _dbContext = new EmpDeptDbContext();
        }

        public void AddDepartment(Department dept)
        {
            _dbContext.Departments.Add(dept);
            _dbContext.SaveChanges();
        }

        public List<Department> GetAllDepartment()
        {
            deptList = new List<Department>();

            deptList = _dbContext.Departments.Select((d) => d).ToList();
            return deptList;
        }

        public Department SeacrhDepartment(Guid id)
        {
            Department dept = _dbContext.Departments.Where((d) => d.Id == id).Select((d) => d).Single();
            return dept;
        }

        public void UpdateDepartment(Department dept)
        {
            Department department= _dbContext.Departments.Where((d) => d.Id == dept.Id).Select((d) => d).Single();
            department.DeptName = dept.DeptName;
            department.DeptLoc = dept.DeptLoc;
            _dbContext.SaveChanges();

        }


    }
}