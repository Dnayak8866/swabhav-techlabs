using mvcBankApp.Models.PassbookModel;
using mvcBankApp.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcBankApp.Controllers
{
    public class PassbookController : Controller
    {
        private BankDbContext _dbContext = new BankDbContext();
        // GET: Passbook
        public ActionResult Index()
        {
            if (Session["acntno"]==null)
            {
                return RedirectToAction("Index","Login");
            }

            PassbookVM vm = new PassbookVM();
            BankingServices bankService = new BankingServices(_dbContext);

            vm.AccountNo = Convert.ToInt32(Session["acntno"]);
            vm.accountTransactionsList = bankService.GetSingleAccountTransaction(vm.AccountNo);
            return View(vm);
        }

        [HttpPost]

        public ActionResult Index(PassbookVM vm)
        {
            BankingServices bankService = new BankingServices(_dbContext);

            vm.AccountNo = Convert.ToInt32(Session["acntno"]);
            vm.accountTransactionsList = bankService.GetSingleAccountTransaction(vm.AccountNo);
            bankService.DownloadeStatement(vm.accountTransactionsList);
            return View(vm);
        }
    }
}