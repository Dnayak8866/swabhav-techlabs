using MvcApp.Models.Color;
using MvcApp.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class ColorController : Controller
    {
        // GET: Color
        public ActionResult Index()
        {
            ColorService colorservice = new ColorService();
            ColorVm vm = new ColorVm();
           vm.ColorList = colorservice.ColorList;
           vm.ColorCount = colorservice.ColorCount;


            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(ColorVm vm ,string ColorList)
        {
            ColorService colorservice = new ColorService();
            vm.ColorCount = colorservice.ColorCount;
            vm.ColorList = colorservice.ColorList;
            
            vm.SelectedColorName= colorservice.GetColorName(vm.SelectedColorCode);

       
            return View(vm);
        }
    }
}