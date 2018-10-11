using EmpDeptMasterPageApp.Models.DepartmentM;
using EmpDeptMasterPageApp.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpDeptMasterPageApp.Controllers
{
    public class DepartmentController : Controller
    {
        EmpDeptDbContext dbContext = new EmpDeptDbContext();
        // GET: Department
        public ActionResult Index()
        {
            DepartmentVM vm = new DepartmentVM();
            DepartmentServices deptService = new DepartmentServices( dbContext);
            vm.DepartmentList = deptService.GetAllDepartment();
            return View(vm);
        }



        public ActionResult Add()
        {

            AddVM vm = new AddVM();
            return View(vm);

        }
        [HttpPost]
        public ActionResult Add(AddVM vm)
        {

            DepartmentServices deptService = new DepartmentServices( dbContext);
            deptService.AddDepartment(new Department { DeptName = vm.DeptName, DeptLoc = vm.DeptLoc });
            return RedirectToAction("Index");
        }

       

        public ActionResult Edit(Guid id)
        {
            EditVM vm = new EditVM();
            vm.Id = id;
            DepartmentServices deptService = new DepartmentServices( dbContext);
            Department dept = deptService.SeacrhDepartment(vm.Id);
            vm.DeptName = dept.DeptName;
            vm.DeptLoc = dept.DeptLoc;
            return View(vm);
        }

        [HttpPost]
        public ActionResult Edit(EditVM vm)
        {
            DepartmentServices deptService = new DepartmentServices( dbContext);
            deptService.UpdateDepartment(new Department { Id=vm.Id,DeptName=vm.DeptName,DeptLoc=vm.DeptLoc});

            return RedirectToAction("Index");
        }

        public ActionResult ViewEmployees(Guid id)
        {
            EmployeeServices empServices = new EmployeeServices(dbContext);
            Models.EmployeeM.EmployeeVM empVm = new Models.EmployeeM.EmployeeVM();
            
            empVm.EmpList= empServices.GetAllEmployeesByDeptId(id);

            return View(empVm);
            
        }

    }
}