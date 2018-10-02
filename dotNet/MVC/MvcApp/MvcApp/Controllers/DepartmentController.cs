using MvcApp.Models.Dept;
using MvcApp.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            DepartmentService deptService = new DepartmentService();
            
            DeptVm vm = new DeptVm();
            vm.SelectEmpList = deptService.EmpList;
            vm.DeptList= deptService.DeptList;
            
            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(DeptVm vm)
        {
            DepartmentService deptService = new DepartmentService();
            vm.DeptList = deptService.DeptList;
            
           
            vm.SelectEmpList = deptService.GetEmployees(vm.SelectedDeptNo);

            return View(vm);
        }


    }
}