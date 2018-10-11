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
            return View(vm);
        }
        public ActionResult Add()
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("Index", "Login", new { actionMethod = "Add" });
            }
            AddVm vm = new AddVm();
           
            return View(vm);
           
        }

        [HttpPost]
        public ActionResult Add(AddVm vm)
        {
           
            contactService.AddContact(vm.Id, vm.Fname,vm.Lname,vm.ContactNo,vm.Email);
            return RedirectToAction("Home");
        }

        public ActionResult Display()
        {
            return RedirectToAction("Home");
        }

        
        public ActionResult Edit(int? id)
        {
          
            if (Session["user"] == null)
            {
                return RedirectToAction("Index", "Login", new { actionMethod = "Home" });
            }
            EditVm vm = new EditVm();
            contact cont = contactService.SearchContact(Convert.ToInt32(id));
           
            
            vm.Id = cont.Id;
            vm.Fname = cont.Fname;
            vm.Lname = cont.Lname;
            vm.ContactNo = cont.contactNo;
            vm.Email = cont.email;
           
            return View(vm);
        }

        [HttpPost]
        public ActionResult Edit(EditVm vm)
        {
            contactService.UpdateContact(new contact {Id=vm.Id, Fname=vm.Fname,Lname=vm.Lname,contactNo=vm.ContactNo,email=vm.Email});
            vm.ContactList = contactService.ContactList;
            return RedirectToAction("Home");
        }
       
       

        
    }
}