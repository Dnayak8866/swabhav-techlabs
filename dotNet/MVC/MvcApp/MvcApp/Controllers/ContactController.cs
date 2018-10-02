using MvcApp.Models.Contact;
using MvcApp.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class ContactController : Controller
    {
        ContactServices contactService = new ContactServices();
        // GET: Contact
        public ActionResult Home()
        {
           
            ContactVm vm = new ContactVm();
            vm.ContactList = contactService.ContactList;
            if (TempData["contacts"]!=null)
            {
              
                vm.ContactList = TempData["contacts"] as List<contact>;
            }
            TempData["contacts"] = vm.ContactList;
            return View(vm);
        }
        public ActionResult Add()
        {
          
            AddVm vm = new AddVm() { ContactList = contactService.ContactList };
           
            return View(vm);
        }

        [HttpPost]
        public ActionResult Add(AddVm vm)
        {
            
            contactService.ContactList = TempData["contacts"] as List<contact>;
            contactService.AddContact(vm.ContactNo,vm.Fname,vm.Lname,vm.Email);

            TempData["contacts"] = contactService.ContactList;

            vm.ContactList = TempData["contacts"] as List<contact>;
            return RedirectToAction("Home",vm);
        }

        public ActionResult Display()
        {
            return RedirectToAction("Home");
        }



        
    }
}