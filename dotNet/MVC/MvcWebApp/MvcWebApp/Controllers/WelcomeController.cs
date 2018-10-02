using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebApp.Controllers
{
    public class WelcomeController : Controller
    {
        public string Index()
        {
            return "<h1>Hello World from index </h1>";
        }

        public ViewResult About()
        {

            return View();
        }
        public ViewResult Career()
        {
            ViewBag.Company = "SwabhavTechlabs";
            return View();
        }

        public ContentResult DisplayDept(int ? id)
        {
            return Content("<h1>Display dept for "+id+"</h1>");
        }

        public ContentResult DisplayEmp(int empno)
        {
            return Content("<h1>Displaying Emp no "+empno+"</h1>");
        }



    }
}