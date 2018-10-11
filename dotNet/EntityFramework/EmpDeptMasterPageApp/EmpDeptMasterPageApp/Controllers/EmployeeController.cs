using EmpDeptMasterPageApp.Models.EmployeeM;
using EmpDeptMasterPageApp.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpDeptMasterPageApp.Controllers
{
    public class EmployeeController : Controller
    {
        EmpDeptDbContext dbContext = new EmpDeptDbContext();
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeVM vm = new EmployeeVM();
            EmployeeServices empServices = new EmployeeServices(dbContext);
            vm.EmpList = empServices.GetAllEmployees();
            return View(vm);
        }

        public ActionResult Add()
        {
            AddVM vm = new AddVM();
            EmployeeServices empServices = new EmployeeServices(dbContext);
            DepartmentServices deptService = new DepartmentServices();
            vm.DeptLsit = deptService.GetAllDepartment();

            return View(vm);
        }

        [HttpPost]
        public ActionResult Add(AddVM vm)
        {
            EmployeeServices empServices = new EmployeeServices(dbContext);
            DepartmentServices deptService = new DepartmentServices(dbContext);

            empServices.AddEmployee(new Employee { EmpName = vm.EmpName, EmpJob = vm.EmpJob, EmpSalary = vm.EmpSalary, Department = deptService.SeacrhDepartment(vm.SelectedDept) });
            return RedirectToAction("Index");
        }

        public ActionResult Edit(Guid id)
        {
            EditVM vm = new EditVM();
            EmployeeServices empServices = new EmployeeServices(dbContext);

            DepartmentServices deptService = new DepartmentServices(dbContext);
            vm.DeptList = deptService.GetAllDepartment();
            vm.Id = id;

            Employee emp = empServices.SearchAEmployee(vm.Id);
            vm.EmpName = emp.EmpName;
            vm.EmpJob = emp.EmpJob;
            vm.EmpSalary = emp.EmpSalary;
            vm.SelectedDept = emp.Department.Id;

            return View(vm);
        }

        [HttpPost]
        public ActionResult Edit(EditVM vm)
        {
            DepartmentServices deptService = new DepartmentServices(dbContext);
            
            EmployeeServices empService = new EmployeeServices(dbContext);
            empService.UpdateEmployee(new Employee { Id = vm.Id, EmpName = vm.EmpName, EmpJob = vm.EmpJob, EmpSalary = vm.EmpSalary, Department = deptService.SeacrhDepartment(vm.SelectedDept) });

            return RedirectToAction("Index");
        }

        


    }
}