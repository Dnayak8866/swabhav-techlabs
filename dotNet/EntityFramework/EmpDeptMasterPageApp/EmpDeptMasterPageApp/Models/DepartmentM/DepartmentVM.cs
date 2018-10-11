using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpDeptMasterPageApp.Models.DepartmentM
{
    public class DepartmentVM
    {
        public List<Department> DeptList;

        public DepartmentVM()
        {
            DeptList = new List<Department>();
        }

        public List<Department> DepartmentList
        {
            get
            {
                return DeptList;
            }
            set
            {
                DeptList = value;
            }
        }
    }
}