using MvcApp.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            LoginVm vm = new LoginVm()
            {
                UserName = "root",
                UserPass = "root"

            };
            return View(vm);
        }
       
        [HttpPost]
        public ActionResult Index(LoginVm vm)
        {
            if (vm.UserName==null|| vm.UserPass==null)
            {
                return View(vm);
            }
            Session["user"] = vm.UserName;
            return RedirectToAction("Index","Home");
        }
    }
}