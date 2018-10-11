using mvcBankApp.Models.RegistrationModel;
using mvcBankApp.Models.Services;
using mvcBankApp.Models.TransactionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcBankApp.Controllers
{
    public class TransactionController : Controller
    {
        private BankDbContext _dbContext = new BankDbContext();
        
        // GET: Transaction
        public ActionResult Index()
        {
            TransactionVM vm = new TransactionVM();
           
            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(TransactionVM vm)
        {
            vm.LoggedInAccountNo = Convert.ToInt32(Session["acntno"]);
            BankingServices bankService = new BankingServices(_dbContext);
            AccountTransaction acntTransaction = new AccountTransaction { TransactionType = vm.SeletedTransactionType, TransactionAmount = vm.TransactionAmount, TransactionDate = DateTime.Now, acnt = bankService.GetLoggedInAccount(vm.LoggedInAccountNo) };
            bankService.DoTransaction(acntTransaction,vm.LoggedInAccountNo);

            return View(vm);
        }
    }
}