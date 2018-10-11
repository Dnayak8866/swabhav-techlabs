using mvcBankApp.Models.HomeModel;
using mvcBankApp.Models.RegistrationModel;
using mvcBankApp.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcBankApp.Controllers
{
    public class HomeController : Controller
    {
        private BankDbContext _dbcontext = new BankDbContext();
        // GET: Home
        public ActionResult Index()
        {
            HomeVM vm = new HomeVM();
            if (Session["acntno"] != null)
            {
                BankingServices bankService = new BankingServices(_dbcontext);

                int acntno = Convert.ToInt32(Session["acntno"]);
                Account acnt = bankService.GetLoggedInAccount(acntno);
                vm.currentUSer = acnt.AccountHolderName;
                return View(vm);
            }
            return View(vm);
        }
    }
}