using MvcApp.Models.Login;
using MvcApp.Models.Services;
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

            string methodname=Request.QueryString["actionMethod"];
            TempData["methodname"] = methodname;
            return View(vm);
        }
       
        [HttpPost]
        public ActionResult Index(LoginVm vm)
        {
            LoginService loginservice = new LoginService();
            
            if (!(loginservice.AuthenticateUser(vm.UserName,vm.UserPass)))
            {
                return View(vm);
            }
            
            Session["user"] = vm.UserName;
            return RedirectToAction(TempData["methodname"].ToString(), "Contact");

        }
    }
}