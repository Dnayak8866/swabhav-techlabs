using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpDeptMasterPageApp.Models.DepartmentM
{
    public class EditVM
    {
        public string DeptName { get; set; }
        public string DeptLoc { get; set; }
        public Guid Id { get; set; }
       
    }
}